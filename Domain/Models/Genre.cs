using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;

namespace Domain.Models
{
    public class Genre : Entity
    {
        public int GenreId { get; set; }

        [Required]
        [MaxLength(40)]
        public string GenreName { get; set; }



        // Many-to-Many with Game

        public ICollection<GamesGenres> Games { get; set; }

    }
}
