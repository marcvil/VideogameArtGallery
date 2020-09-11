using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Models
{
    public class GamesGenres : Entity
    {


        //Bridge Relation between Many to Many with Game
        [Required]
        public int GameId { get; set; }
        public Game Game { get; set; }

        //Bridge Relation between Many to Many with Platform
        [Required]
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
