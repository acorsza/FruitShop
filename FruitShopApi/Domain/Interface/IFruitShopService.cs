using System;
using System.Collections.Generic;
using FruitShopApi.Domain.Entity;

namespace FruitShopApi.Domain.Interface
{
    public interface IFruitShopService
    {
        Offer GetOfferByProduct(string id);
        IEnumerable<Offer> GetAllOffers();
        Product GetProductById(string id);
        IEnumerable<Product> GetAllProducts();
        Purchase GetPurchaseById(int id);
        IEnumerable<Purchase> GetAllPurchases();
    }
}
