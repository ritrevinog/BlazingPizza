﻿using BlazingPizza.Server.Models;
using BlazingPizza.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingPizza.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToppingsController : ControllerBase
    {
        private readonly PizzaStoreContext Context;

        public ToppingsController(PizzaStoreContext context)
        {
            Context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Topping>>> Get()
        {
            return await Context.Toppings.OrderBy(t => t.Name).ToListAsync();
        }
    }
}
