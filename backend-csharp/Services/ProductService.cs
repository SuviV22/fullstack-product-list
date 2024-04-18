using backend_csharp.Database;
using backend_csharp.Models;

namespace backend_csharp.Services
{
    public interface IProductService
    {
        Task<Result<List<Product>>> GetProductListAsync();
    }

    public class ProductService : IProductService
    {
        private readonly IStoreProduct _storeProduct;

        public ProductService(IStoreProduct storeProduct)
        {
            _storeProduct = storeProduct;
        }

        public async Task<Result<List<Product>>> GetProductListAsync()
        {
            var result = await _storeProduct.GetProductListAsync();
            foreach (var item in result.Data)
            {
                item.Price = Math.Round(item.BasePrice * 1.2, 2);
            }
            return result;
        }
    }
}
