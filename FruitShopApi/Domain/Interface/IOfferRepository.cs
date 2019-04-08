using System;
using System.Collections.Generic;
using FruitShopApi.Domain.Entity;

namespace FruitShopApi.Domain.Interface
{
    public interface IOfferRepository : IDisposable
    {
        Offer GetByProduct(string id);
        IEnumerable<Offer> GetAll();
    }
}
