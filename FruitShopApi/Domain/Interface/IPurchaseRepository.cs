using System;
using System.Collections.Generic;
using FruitShopApi.Domain.Entity;

namespace FruitShopApi.Domain.Interface
{
    public interface IPurchaseRepository : IDisposable
    {
        Purchase GetById(int id);
        IEnumerable<Purchase> GetAll();
    }
}
