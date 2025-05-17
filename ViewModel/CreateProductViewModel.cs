using System.ComponentModel.DataAnnotations;

namespace IhsanWeb.ViewModel
{
    public class CreateProductViewModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Awfar relax o! Write name joor")]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        [StringLength(200)]
        public decimal Price { get; set; }
    }
}
