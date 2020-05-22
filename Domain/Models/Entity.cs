using Domain.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Models
{
    public class Entity : IEntity
    {
        public string CreatedBy { get ; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedDate  { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
