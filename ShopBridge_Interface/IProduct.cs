using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopBridge_Model;

namespace ShopBridge_Interface
{
    #region IProductInterface
    public interface IProduct
    {
        //CURD Opreation
        Task Add(Product product);
        Task Update(Product product);
        Task Delete(string id);
        Task<Product> GetProduct(string id);
        Task<IEnumerable<Product>> Getproducts();
    }
    #endregion
}
