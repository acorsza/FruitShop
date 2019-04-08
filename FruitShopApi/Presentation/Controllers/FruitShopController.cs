using System;
using System.Collections.Generic;
using FruitShopApi.Application.Interface;
using FruitShopApi.Domain.Entity;
using Microsoft.AspNetCore.Mvc;

namespace FruitShopApi.Presentation.Controllers
{
    [Route("fruitshop")]
    [ApiController]
    public class FruitShopController : ControllerBase
    {
        private readonly IFruitShopAppService _fruitShopService;

        public FruitShopController(IFruitShopAppService fruitShopService)
        {
            this._fruitShopService = fruitShopService;
        }

        // Default Controller for Handling the whole process described at the Exercise
        // It will read the Purchase file and generate a file with the Receipts at the Receipts folder
        // After will return the Json with the same data of the file
        [HttpGet("run")]
        public ActionResult<IEnumerable<Offer>> RunFruitShop()
        {


            return Ok(this._fruitShopService.RunFruitShop());
        }

    }
}
