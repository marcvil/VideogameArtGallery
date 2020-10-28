using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Game : Entity
    {
        public int GameId { get; set; }

        [Required]
        public string GameName { get; set; }

        public string GameDescription { get; set; }


        //One to One Image Cover
        [Required]

        public int ImageCoverId { get; set; }
        public ImageCover ImageCover { get; set; }

        //One to One ImageGameLogo
        [Required]
        public int ImageGameLogoId { get; set; }
        public ImageGameLogo ImageGameLogo { get; set; }


        // Many-to-Many with Genre

        public ICollection<GamesGenres> Genre { get; set; }


        // Many-to-Many with GamesPlatform
        public ICollection<GamesPlatforms> GamesPlatforms { get; set; }


        // One-to-Many with Image

        public ICollection<Image> Images { get; set; }



    }
}
