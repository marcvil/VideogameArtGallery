using Domain.Models;
using Domain.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DAL
{
    public class ApplicationDbContext : DbContext
    {
        public string CurrentUserId { get; set; }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<GamesPlatforms> GamesPlatforms { get; set; }
        public DbSet<GamesGenres> GamesGenres { get; set; }
        public DbSet<ImageCover> ImageCovers { get; set; }
        public DbSet<ImageGameLogo> ImageGameLogos { get; set; }
        public DbSet<Author> Authors { get; set; }




        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<GamesPlatforms>().HasKey(cs => new { cs.GameId,cs.PlatformId});

            builder.Entity<GamesGenres>().HasKey(cs => new { cs.GameId, cs.GenreId });
            builder.Entity<ImageCover>().HasKey(i => i.ImageCoverId);
            builder.Entity<ImageGameLogo>().HasKey(i => i.ImageGameLogoId);

            builder.Entity<Game>()
                .HasOne<ImageCover>(s => s.ImageCover)
                .WithOne(ad => ad.Game)
                .HasForeignKey<Game>(ad => ad.GameId);

            builder.Entity<Game>()
              .HasOne<ImageGameLogo>(s => s.ImageGameLogo)
              .WithOne(ad => ad.Game)
              .HasForeignKey<Game>(ad => ad.GameId);



        }

        public override int SaveChanges()
        {
            UpdateAuditEntities();
            return base.SaveChanges();
        }


        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            UpdateAuditEntities();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }


        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            UpdateAuditEntities();
            return base.SaveChangesAsync(cancellationToken);
        }


        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            UpdateAuditEntities();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }


        private void UpdateAuditEntities()
        {
            var modifiedEntries = ChangeTracker.Entries()
                .Where(x => x.Entity is IEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));


            foreach (var entry in modifiedEntries)
            {
                var entity = (IEntity)entry.Entity;
                DateTime now = DateTime.UtcNow;

                if (entry.State == EntityState.Added)
                {
                    entity.CreatedDate = now;
                    entity.CreatedBy = CurrentUserId;
                }
                else
                {
                    base.Entry(entity).Property(x => x.CreatedBy).IsModified = false;
                    base.Entry(entity).Property(x => x.CreatedDate).IsModified = false;
                }

                entity.UpdatedDate = now;
                entity.UpdatedBy = CurrentUserId;
            }
        }
    }
}


