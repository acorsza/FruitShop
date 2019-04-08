using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FruitShopApi.Domain.Entity;
using FruitShopApi.Domain.Interface;

namespace FruitShopApi.Infrastructure.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        static readonly string FullPath = @"../FruitShopApi/Resources/";
        static readonly string FileName = "Product.txt";

        public Product GetById(string id)
        {
            return File.ReadAllLines(FullPath + FileName)
                   .Skip(1)
                   .Select(x => x.Split(';'))
                   .Select(x => new Product()
                   {
                       ProductId = int.Parse(x[0]),
                       ProductName = x[1],
                       Price = decimal.Parse(x[2])

                   }).Single(x => x.ProductName == id);
        }

        public IEnumerable<Product> GetAll()
        {
            return File.ReadAllLines(FullPath + FileName)
                   .Skip(1)
                   .Select(x => x.Split(';'))
                   .Select(x => new Product()
                   {
                       ProductId = int.Parse(x[0]),
                       ProductName = x[1],
                       Price = decimal.Parse(x[2])
                   }).ToList();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
