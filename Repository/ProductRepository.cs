using AspNetCoreGeneratedDocument;
using IhsanWeb.Models;
using IhsanWeb.ViewModel;

namespace IhsanWeb.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products = [];

        public void Create(CreateProductViewModel createModel)
        {
            var productCount = _products.Count != 0 ? _products.Count + 1 : 1;
            var product = new Product()
            {
                ID = productCount,
                Name = createModel.Name,
                Description = createModel.Description ?? "No description",
                Price = createModel.Price,
            };
            _products.Add(product);
        }

        public void Update(UpdateProductViewModel updateModel)
        {
            var existingProduct = _products.FirstOrDefault(x => x.Name == updateModel.Name);
            if (existingProduct is null)
            {
                return;
            }
            existingProduct.Name = updateModel.Name;
            existingProduct.Description = updateModel.Description ?? existingProduct.Description;
            existingProduct.Price = updateModel.Price ?? existingProduct.Price;
        }

        public List<ProductViewModel>? GetAll()
        {
            return _products
                .Select(x => new ProductViewModel()
                {
                    Id = x.ID,
                    Name = x.Name,
                    Description = x.Description,
                    Price = $"${x.Price:F2}"
                }).ToList();
        }

        public ProductViewModel? GetById(int id)
        
            var product = _products.FirstOrDefault(x => x.ID == id);
            if (product is null)
            {
                return null;
            }
            var model = new ProductViewModel()
            {
                Id = product.ID,
                Name = product.Name,
                Description = product.Description,
                Price = $"${product.Price:F2}"
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
