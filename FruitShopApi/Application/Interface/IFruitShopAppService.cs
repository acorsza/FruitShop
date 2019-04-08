using System;
using System.Collections.Generic;
using FruitShopApi.Domain.Entity;

namespace FruitShopApi.Application.Interface
{
    public interface IFruitShopAppService
    {
        Receipt RunFruitShop();
    }
}
