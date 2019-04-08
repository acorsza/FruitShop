using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FruitShopApi.Domain.Entity;
using FruitShopApi.Domain.Interface;

namespace FruitShopApi.Infrastructure.Data.Repository
{
    public class PurchaseRepository : IPurchaseRepository
    {
        static readonly string FullPath = @"../FruitShopApi/Resources/";
        static readonly string FileName = "Purchase.txt";

        public Purchase GetById(int id)
        {
            return File.ReadAllLines(FullPath + FileName)
                   .Skip(1)
                   .Select(x => x.Split(';'))
                   .Select(x => new Purchase()
                   {
                       PurchaseId = int.Parse(x[0]),
                       Product = x[1],
                       Quantity = int.Parse(x[2])

                   }).FirstOrDefault(x => x.PurchaseId == id);
        }

        public IEnumerable<Purchase> GetAll()
        {
            return File.ReadAllLines(FullPath + FileName)
                   .Skip(1)
                   .Select(x => x.Split(';'))
                   .Select(x => new Purchase()
                   {
                       PurchaseId = int.Parse(x[0]),
                       Product = x[1],
                       Quantity = int.Parse(x[2])
                   }).ToList();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
