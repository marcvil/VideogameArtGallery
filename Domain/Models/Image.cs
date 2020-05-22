using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Models
{
    public class Image : Entity
    {
        public int ImageId { get; set; }
        [Required]
        [MaxLength(40)]
        public string ImgName { get; set; }
        [MaxLength(500)]
        public string ImgDescription { get; set; }

        [Required]
        [ForeignKey("GameId")]
        public string GameId { get; set; }


        [Required]
        [ForeignKey("PlatformId")]
        public string PlatformId { get; set; }

    }
}
