using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Models
{
    public  class Game : Entity
    {
        public int GameId { get; set; }

        [Required]
        public string GameName { get; set; }
        
        public string GameDescription { get; set; }

        public ICollection<Genre> GameGenres { get; set; }
        public ICollection<Platform> GamePlatforms { get; set; }
    }
}
