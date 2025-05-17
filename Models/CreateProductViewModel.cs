using System.ComponentModel.DataAnnotations;

namespace IhsanWeb.Models
{
    public class CreateProductViewModel
    {
        [Required]
        public string Name {  get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        [Required]
        public decimal Price {  get; set; }
    }
}
