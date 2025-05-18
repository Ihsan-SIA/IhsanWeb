using System.ComponentModel.DataAnnotations;

namespace IhsanWeb.ViewModel
{
    public class UpdateProductViewModel
    {
        [Required(ErrorMessage = "Enter product name pls")]
        public string Name { get; set; } = default!;
        public string? Description {  get; set; }
        public decimal? Price {  get; set; }
    }
}