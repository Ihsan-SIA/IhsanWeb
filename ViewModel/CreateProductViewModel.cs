using System.ComponentModel.DataAnnotations;

namespace IhsanWeb.ViewModel
{
    public class CreateProductViewModel
    {
        [Required (ErrorMessage = "Awfar relax o! At least add product name na.... ")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Awfar relax o! Write product name joor")]
        public string Name { get; set; } = string.Empty;
        [StringLength(200)]
        public string Description { get; set; } = string.Empty;
        [Required(ErrorMessage = "Boss even if na free you want sell am, add 0 to the price. No dey act like say... make I no talk sha.")]
        public decimal Price { get; set; }
    }
}