using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using FruitShopApi.Domain.Entity;
using FruitShopApi.Domain.Interface;

namespace FruitShopApi.Infrastructure.Data.Repository
{
    public class OfferRepository : IOfferRepository
    {
        static readonly string FullPath = @"../FruitShopApi/Resources/";
        static readonly string FileName = "Offer.txt";

        public Offer GetByProduct(string id)
        {
            return File.ReadAllLines(FullPath + FileName)
                   .Skip(1)
                   .Select(x => x.Split(';'))
                   .Select(x => new Offer()
                   {
                       OfferId = int.Parse(x[0]),
                       Product = x[1],
                       Category = x[2],
                       MinQuantity = int.Parse(x[2]),
                       OfferDiscount = int.Parse(x[3])
                   }).Single(x => x.Product == id);
        }

        public IEnumerable<Offer> GetAll()
        {
            return File.ReadAllLines(FullPath + FileName)
                   .Skip(1)
                   .Select(x => x.Split(';'))
                   .Select(x => new Offer()
                   {
                       OfferId = int.Parse(x[0]),
                       Product = x[1],
                       Category = x[2],
                       MinQuantity = int.Parse(x[2]),
                       OfferDiscount = int.Parse(x[3])
                   }).ToList();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
