﻿using ECommerce.ProductCatalog.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce.ProductCatalog
{
    interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProducts();

        Task AddProduct(Product product);

        Task<Product> GetProduct(Guid productId);
    }
}
