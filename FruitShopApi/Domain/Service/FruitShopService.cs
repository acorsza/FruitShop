using System;
using System.Collections.Generic;
using FruitShopApi.Domain.Entity;
using FruitShopApi.Domain.Interface;
using FruitShopApi.Infrastructure.Data.Repository;

namespace FruitShopApi.Domain.Service
{
    public class FruitShopService : IFruitShopService
    {
        private readonly IOfferRepository _offerRepo;
        private readonly IProductRepository _productRepo;
        private readonly IPurchaseRepository _purchaseRepo;

        public FruitShopService(IOfferRepository offerRepo, IProductRepository productRepo, IPurchaseRepository purchaseRepo)
        {
            _offerRepo = offerRepo;
            _productRepo = productRepo;
            _purchaseRepo = purchaseRepo;

        }

        public Offer GetOfferByProduct(string id)
        {
            return _offerRepo.GetByProduct(id);
        }

        public IEnumerable<Offer> GetAllOffers()
        {
            return _offerRepo.GetAll();
        }

        public Product GetProductById(string id)
        {
            return _productRepo.GetById(id);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepo.GetAll();
        }

        public Purchase GetPurchaseById(int id)
        {
            return _purchaseRepo.GetById(id);
        }

        public IEnumerable<Purchase> GetAllPurchases()
        {
            return _purchaseRepo.GetAll();
        }
    }
}
