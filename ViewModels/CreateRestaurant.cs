using corecart.Models;
using System.ComponentModel.DataAnnotations;

namespace corecart.ViewModels
{
    public class CreateRestaurant
    {
        [Required,MaxLength(50), Display(Name ="Restaurnat Name")]
        public string Name { get; set; }
        public CousinType Cousin { get; set; }
    }
}
