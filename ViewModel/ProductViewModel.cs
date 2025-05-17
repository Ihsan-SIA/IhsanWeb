namespace IhsanWeb.ViewModel
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Price { get; set; } = default!;
        public string? Description { get; set; }
    }
}
