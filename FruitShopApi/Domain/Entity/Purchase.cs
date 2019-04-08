using System;
namespace FruitShopApi.Domain.Entity
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
    }
}
