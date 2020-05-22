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
        public string SystemName { get; set; }
    }
}
