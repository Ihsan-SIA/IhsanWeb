using IhsanWeb.ViewModel;

namespace IhsanWeb.Repository
{
    public interface IProductRepository
    {
        void Create(CreateProductViewModel viewModel);
        List<ProductViewModel>? GetAll();
        ProductViewModel? GetById(int id);
        ProductViewModel? GetByName(string name);
        void Update(UpdateProductViewModel viewModel, string name);
    }
}
