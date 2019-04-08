using System;
using FruitShopApi.Application.Interface;
using FruitShopApi.Application.Service;
using FruitShopApi.Domain.Entity;
using FruitShopApi.Domain.Interface;
using FruitShopApi.Domain.Service;
using FruitShopApi.Infrastructure.Data.Repository;
using Xunit;

namespace FruitShopApiTests
{
    public class FruitShopUnitTest
    {
        [Fact]
        public void TestTotal()
        {
            IOfferRepository r1 = new OfferRepository();
            IProductRepository r2 = new ProductRepository();
            IPurchaseRepository r3 = new PurchaseRepository();
            IFruitShopService f = new FruitShopService(r1, r2, r3);
            IFruitShopAppService fApp = new FruitShopAppService(f);
            Receipt r = fApp.RunFruitShop();
            Assert.Equal(5.4M, Convert.ToDecimal(r.Total));
        }
    }
}
