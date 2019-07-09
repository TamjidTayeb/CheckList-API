using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("v1/")]
    [ApiController]
    public class APIController : ControllerBase
    {
        private readonly ItemService _service;
        public APIController(ItemService service)
        {
            _service = service;
        }
        [HttpPost]
        [Route("AddItem")]
        public ActionResult<Item> addItem(Item item)
        {
            var items = _service.AddItem(item);

            if (items == null)
            {
                return NotFound();
            }
            return items;
        }

        [HttpGet]
        [Route("GetItems")]
        public ActionResult<Dictionary<int,Item>> GetItems()
        {
            var items = _service.GetItems();
            if (items.Count()==0)
            {
                return NotFound();
            }
            return items;
        }
    }
}