using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class ImageGameLogo : Entity
    {

        public int ImageGameLogoId { get; set; }
        [Required]
        [MaxLength(40)]
        public string ImgGameLogoName { get; set; }
        [MaxLength(256)]
        public string ImgGameLogoUrl { get; set; }
        [MaxLength(500)]
        public string ImgGameLogoDescription { get; set; }

        [Required]
        public int GameId { get; set; }
        public Game Game { get; set; }


    }
}
