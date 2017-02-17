using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AuctionWebsite.Services;
using AuctionWebsite.ViewModels;
using AuctionWebsite.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AuctionWebsite.Controllers
{
    [Route("api/[controller]")]
    public class AuctionItemsController : Controller
    {
        private AuctionItemsService _service;

        public AuctionItemsController(AuctionItemsService service)
        {
            _service = service;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<AuctionItemDTO> Get()
        {
            return _service.GetItems();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]AuctionItemDTO dto)
        {
            _service.PostItem(dto);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
