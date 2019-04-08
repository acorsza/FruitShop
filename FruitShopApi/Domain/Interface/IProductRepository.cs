using System;
using System.Collections.Generic;
using FruitShopApi.Domain.Entity;

namespace FruitShopApi.Domain.Interface
{
    public interface IProductRepository : IDisposable
    {
        Product GetById(string id);
        IEnumerable<Product> GetAll();
    }
}
