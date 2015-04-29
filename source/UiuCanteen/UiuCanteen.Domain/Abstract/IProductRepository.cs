﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UiuCanteen.Domain.Entities;

namespace UiuCanteen.Domain.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }


        void SaveProduct(Product product);

        Product DeleteProduct(int productId);
    }
}
