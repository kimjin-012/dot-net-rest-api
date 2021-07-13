using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Restapi.Models;
using Restapi.Repositories;

namespace Restapi.Controllers
{
    [ApiController]
    [Route("[controller]")] // this should be "items"
    public class ItemsController : ControllerBase
    {
        private readonly IItemsRepository repository; // Just for the test

        public ItemsController(IItemsRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IEnumerable<Item> GetItmes()
        {
            var items = repository.GetItems();
            return items;
        }

        /* 
        Now the route here will be
        GET /items/{id}
        */
        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(Guid id)
        {
            var item = repository.GetItem(id);

            if(item is null)
            {
                return NotFound();
            }
            return item;
        }
    }
}