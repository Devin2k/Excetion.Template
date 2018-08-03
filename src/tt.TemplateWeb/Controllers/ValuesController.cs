using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using tt.Template.Core.Exceptions;

namespace tt.TemplateWeb.Controllers
{
    [Route("api")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("Demo1")]
        public IEnumerable<string> Get()
        {
            throw new Demo1ErrorException();
        }

        [HttpGet("Demo2")]
        public IEnumerable<string> GetDemo2()
        {
            throw new Demo2ErrorException();
        }

        [HttpGet("Demo3")]
        public IEnumerable<string> GetDemo3()
        {
            throw new UserAuthorityErrorException();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
