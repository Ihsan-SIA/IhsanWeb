namespace IhsanWeb.Models
{
    public class Product
    {
        public int ID {  get; set; }
        public string Name { get; set; } = default!;
        public decimal Price {  get; set; }
        public string? Description { get; set; }
    }
}
