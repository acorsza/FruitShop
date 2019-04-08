using System;
namespace FruitShopApi.Domain.Entity
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public Offer Offer { get; set; }

    }
}
