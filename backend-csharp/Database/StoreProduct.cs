using backend_csharp.Models;
using Newtonsoft.Json;

namespace backend_csharp.Database
{
    public interface IStoreProduct
    {
        Task<Result<List<Product>>> GetProductListAsync();
    }

    public class StoreProduct : IStoreProduct
    {
        private const string FilePath = "Database/product-list.json";

        public async Task<Result<List<Product>>> GetProductListAsync()
        {
            Result<List<Product>> result = new();
            result.Data = new List<Product>();

            if(!File.Exists(FilePath))
            {
                return result;
            }

            string json = File.ReadAllText(FilePath);
            result.Data = JsonConvert.DeserializeObject<List<Product>>(json);

            return result;
        }
    }
}
