using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Models
{
    public class Author : Entity
    {
        public int AuthorId { get; set; }

        [Required]
        public string AuthorName { get; set; }


        // One-to-Many with GamesPlatform
        public ICollection<Image> Image { get; set; }

    }
}
