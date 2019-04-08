using System;
namespace FruitShopApi.Domain.Entity
{
    public class Offer
    {
        public int OfferId { get; set; }
        public string Product { get; set; }
        public string Category { get; set; }
        public int MinQuantity { get; set; }
        public int OfferDiscount { get; set; }
    }
}
