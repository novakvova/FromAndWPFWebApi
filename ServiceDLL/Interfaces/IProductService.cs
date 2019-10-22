using ServiceDLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDLL.Interfaces
{
    public interface IProductService
    {
        List<ProductModel> GetProducts();
        Task<List<ProductModel>> GetProductsAsync();
        int Create(ProductAddModel product);
    }
}
