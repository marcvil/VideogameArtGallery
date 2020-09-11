using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Image : Entity
    {
        
        public int ImageId { get; set; }
        [Required]
        [MaxLength(40)]
        public string ImgName { get; set; }
        [MaxLength(256)]
        public string ImgUrl { get; set; }

        [MaxLength(500)]
        public string ImgDescription { get; set; }


        [Required]
        public int GameId { get; set; }
        public Game Game { get; set; }


        [Required]
        public int PlatformId { get; set; }
        public Platform Platform { get; set; }



        //One to Many Authors
        [Required]
        public int AuthorId { get; set; }
        public Author Author { get; set; }


    }
}
