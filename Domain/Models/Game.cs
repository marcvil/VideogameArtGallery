using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Models
{
    public  class Game : Entity
    {
        public int GameId { get; set; }

        [Required]
        public string GameName { get; set; }
        
        public string GameDescription { get; set; }


        // One-to-Many with Genre
        [Required]
        public int GenreId { get; set; }
        public Genre Genre{ get; set; }


        // Many-to-Many with GamesPlatform
        public ICollection<GamesPlatforms> GamesPlatforms { get; set; }


        // One-to-Many with Image

        public ICollection<Image> Images { get; set; }



    }
}
