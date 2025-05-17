using System.ComponentModel.DataAnnotations;

namespace IhsanWeb.Models
{
    public class CreateProductViewModel
    {
        [Required]
        public string Name {  get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Price {  get; set; }
    }
}
