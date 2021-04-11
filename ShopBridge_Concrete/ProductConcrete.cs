using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopBridge_Model;
using ShopBridge_Interface;
using System.Data.Entity;

namespace ShopBridge_Concrete
{
    #region ProductInterfaceImplimentation
    public class ProductConcrete : IProduct
    {
        private readonly DatabaseContext _dbcontext = new DatabaseContext();
        async Task IProduct.Add(Product product)
        {
           //  product.Id = Guid.NewGuid().ToString();
            try
            {
                _dbcontext.Products.Add(product);
                await _dbcontext.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }

        async Task IProduct.Delete(string id)
        {
            try
            {
                Product products = await _dbcontext.Products.FindAsync(id);
                _dbcontext.Products.Remove(products);
                await _dbcontext.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }

        async Task<Product> IProduct.GetProduct(string id)
        {
            try
            {
                Product products = await _dbcontext.Products.FindAsync(id);
                if (products == null)
                {
                    return null;
                }
                return products;
            }
            catch
            {
                throw;
            }
        }

        async Task<IEnumerable<Product>> IProduct.Getproducts()
        {
            try
            {
                var employees = await _dbcontext.Products.ToListAsync();
                return employees.AsQueryable();
            }
            catch
            {
                throw;
            }
        }

        async Task IProduct.Update(Product product)
        {
            try
            {
                _dbcontext.Entry(product).State = EntityState.Modified;
                await _dbcontext.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }
    }
    #endregion
}
