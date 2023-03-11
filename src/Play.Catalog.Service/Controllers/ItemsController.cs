using Microsoft.AspNetCore.Mvc;
using Play.Catalog.Service.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Play.Catalog.Service.Controllers
{
    [ApiController]
    [Route("items")]
    public class ItemsController : ControllerBase
    {
        private static readonly List<ItemDto> items = new()
         {
             new ItemDto(Guid.NewGuid(),"Potion", "Restores some health", 5 ,DateTimeOffset.UtcNow),
             new ItemDto(Guid.NewGuid(),"Antidote", "Cures Poison", 7 ,DateTimeOffset.UtcNow),
             new ItemDto(Guid.NewGuid(),"Bronze Sword", "Deals a small of damage", 20,DateTimeOffset.UtcNow)
         };
        [HttpGet]
        public IEnumerable<ItemDto> Get()
        {
            return items;
        }

        [HttpGet("{id}")]
        public ItemDto GetById(Guid id)
        {
            var item = items.Where(x => x.Id == id).FirstOrDefault();
            return item;
        }

    }
}
