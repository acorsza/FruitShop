using System;
using System.Collections.Generic;

namespace FruitShopApi.Domain.Entity
{
    public class Receipt
    {
        public int ReceiptId { get; set; }
        public List<Purchase> Purchase { get; set; }
        public decimal Total;
    }
}
