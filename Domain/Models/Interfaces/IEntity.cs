using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Models.Interfaces
{
    public interface IEntity
    {
        [Required]
        [MaxLength(60)]
        string CreatedBy { get; set; }
        string UpdatedBy { get; set; }
        [Required]
        [MaxLength(60)]
        DateTime CreatedDate { get; set; }
        DateTime UpdatedDate { get; set; }

    }
}
