using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class ImageCover : Entity
    {
        public int ImageCoverId { get; set; }
        [Required]
        [MaxLength(40)]
        public string ImgCoverName { get; set; }
        [MaxLength(256)]
        public string ImgCoverUrl { get; set; }
        [MaxLength(500)]
        public string ImgCoverDescription { get; set; }

        [Required]
        public int GameId { get; set; }
        public Game Game { get; set; }

        
    }
}
