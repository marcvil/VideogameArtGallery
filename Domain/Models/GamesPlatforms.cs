using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Models
{
    public class GamesPlatforms : Entity
    {

        
        [Required]
  
        public int GameId { get; set; }
        public Game Game { get; set; }


        [Required]

        public int PlatformId { get; set; }
        public Platform Platform { get; set; }


    }
}