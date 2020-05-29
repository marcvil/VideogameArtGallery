using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Models
{
    public class Platform : Entity
    {
        public int PlatformId { get; set; }

        [Required]
        [MaxLength(40)]
        public string PlatformName { get; set; }


        // Many-to-Many with GamesPlatform
        public ICollection<GamesPlatforms> GamesPlatforms { get; set; }



        // One-to-Many with Image

        public ICollection<Image> Images { get; set; }
    }
}
