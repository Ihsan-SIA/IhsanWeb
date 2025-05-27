using IhsanWeb.Models;
using IhsanWeb.ViewModel;

namespace IhsanWeb.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products = [];

        public void Create(CreateProductViewModel viewModel)
        {
            var productCount = _products.Count != 0 ? _products.Count + 1 : 1;
            var product = new Product()
            {
                ID = productCount,
                Name = viewModel.Name,
                Price = viewModel.Price,
                Description = viewModel.Description ?? "Not available"
            };
            _products.Add(product);
        }

        public void Update(UpdateProductViewModel viewModel)
         
            var product = _products.FirstOrDefault(x => x.Name == viewModel.Name);
            if (product is null)
            {
                return;
            }
            product.Name = viewModel.Name;
            product.Price = viewModel.Price ?? product.Price;
            product.Description = viewModel.Description ?? product.Description;
        }
        public List<ProductViewModel>? GetAll()
        {
            return _products
                .Select(x => new ProductViewModel{
                    Id = x.ID,
                    Name = x.Name,
                    Price = $"${x.Price:F2}",
                    Description = x.Description ?? "Not available"
                })
                .ToList();
        }

        public ProductViewModel? GetById(int id)
        {
            Product? product = _products.FirstOrDefault(x => x.ID == id);
            
            if (product is null)
            {
                return null;
            }

            var model = new ProductViewModel
            {
                Id = product.ID,
                Name = product.Name,
                Price = $"${product.Price:F2}",
                Description = product.Description ?? "Not available"
            };

            return model;

        }

        public ProductViewModel? GetByName(string name)
        {
            Product? product = _products.FirstOrDefault(x => x.Name == name);
            
            if (product is null)
            {
                return null;
            }

            var model = new ProductViewModel
            {
                Id = product.ID,
                Name = product.Name,
                Price = $"${product.Price}",
                Description = product.Description ?? "Not available"
            };
            return model;
        }
    }
}
