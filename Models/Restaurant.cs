using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace corecart.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        [Required, MaxLength(50), Display(Name = "Restaurnat Name")]
        public string Name { get; set; }
        [Display(Name = "Cousin Type")]
        public CousinType Cousin { get; set; }
    }
}
