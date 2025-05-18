using IhsanWeb.ViewModel;

namespace IhsanWeb.Repository
{
    public interface IProductRepository
    {
        void Create(CreateProductViewModel viewModel);
        List<ProductViewModel>? GetAll();
        ProductViewModel? GetById(int id);
        ProductViewModel? GetByName(string name);
        ProductViewModel? Update(ProductViewModel viewModel);
    }
}
