using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UiuCanteen.Domain.Abstract;
using UiuCanteen.Domain.Entities;

namespace UiuCanteen.Domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        private  readonly EFDbContext context = new EFDbContext();
        public IEnumerable<Entities.Product> Products
        {
            get { return context.Products; }
        }


        public void SaveProduct(Entities.Product product)
        {
            if (product.ProductId == 0)
            {
                context.Products.Add(product);
            }
            else
            {
                Product dbEntery = context.Products.Find(product.ProductId);
                if (dbEntery != null)
                {
                    dbEntery.Name = product.Name;
                    dbEntery.Description = product.Description;
                    dbEntery.Price = product.Price;
                    dbEntery.Category = product.Category;


                }
            }
            context.SaveChanges();

        }


        public Product DeleteProduct(int productId)
        {
            Product dbEntry = context.Products.Find(productId);
            if (dbEntry != null)
            {
                context.Products.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
