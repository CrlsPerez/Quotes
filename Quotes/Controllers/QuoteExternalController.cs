using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Quotes.Controllers
{
    public class QuoteExternalController : ApiController
    {
        // GET: api/QuoteExternal
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/QuoteExternal/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/QuoteExternal
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/QuoteExternal/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/QuoteExternal/5
        public void Delete(int id)
        {
        }
    }
}
