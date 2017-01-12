using Quotes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
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
        public Quote Get(int id)
        {
            //TODO Get data of page
            string q_str = new FunctionsController().GetQuoteExternal(id);
            Quote q = new Quote() { QuoteID = id, QuoteString = q_str};

            return q;
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
