using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PTemplate.Controllers
{
    [Route("api/[controller]")]
    public class product : Controller
    {




        [Produces("application/json")]
        [HttpGet("search")]
        public async Task<IActionResult> Search()
        {
            //try
            //{
            //    string term = HttpContext.Request.Query["term"].ToString();
            //    var names = db.Products.Where(p => p.Name.Contains(term)).Select(p => p.Name).ToList();
            //    return Ok(names);
            //}
            //catch
            //{
                return BadRequest();
            //}
        }


        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
