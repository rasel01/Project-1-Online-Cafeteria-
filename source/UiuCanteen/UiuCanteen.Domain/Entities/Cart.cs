using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UiuCanteen.Domain.Entities
{
    public class Cart
    {
        private List<CartLine> LineCollections = new List<CartLine>();

        public void AddItem(Product product, int quantity)
        {
            CartLine line = LineCollections.Where(p => p.Product.ProductId == product.ProductId)
                .FirstOrDefault();
            if (line == null)
            {
                LineCollections.Add(new CartLine {Product = product, Quantity = quantity});
            }
            else
            {
                line.Quantity += quantity;
            }

        }

        public void RemoveLine(Product product)
        {
            LineCollections.RemoveAll(p => p.Product.ProductId == product.ProductId);
        }

        public decimal ComputeTotalValue()
        {
            return LineCollections.Sum(p => p.Product.Price*p.Quantity);
        }

        public IEnumerable<CartLine> Lines
        {
            get
            {
                return LineCollections;
            }
        }

        public void Clear()
        {
            LineCollections.Clear();
        }
    
}
}
