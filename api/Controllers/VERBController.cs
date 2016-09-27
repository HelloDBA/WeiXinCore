using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeiXinCore.Data;
using WeiXinCore.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WeiXinCore.api.Controllers
{
    [Route("api/[controller]")]
    public class VERBController : Controller
    {
        private AppDbContext _context;
        public VERBController(AppDbContext context)
        {
            _context = context;
        }
        // GET: api/values
        [HttpGet]
        public string Get()
        {
            VERB verb = new Models.VERB()
            {
                memberID = "test"+DateTime.Now.ToString(),
                Token = "SMBlog Test"
            };

            _context.VERB.Add(verb);
           _context.SaveChanges();
            return _context.VERB.Count().ToString();
            //return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
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
