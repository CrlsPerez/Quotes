using AngleSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Quotes.Controllers
{
    public class FunctionsController : Controller
    {
        int id_external = 0;
        string quote_external = "";

        public int RandomID()
        {
            int max = GetMaxUsed();
            int random_id = new Random().Next(1, max);

            return random_id;
        }

        public int GetMaxUsed()
        {
            //TODO Get from DB
            int max = 15000;

            return max;
        }

        public string GetQuoteExternal(int id)
        {
            id_external = id;
            Task t = new Task(ProcessData);
            t.Start();
            t.Wait();

            return quote_external;
        }

        public void ProcessData()
        {
            Task<string> task = GetQuoteExternalData(id_external);
            quote_external = task.Result;
        }

        public async Task<string> GetQuoteExternalData(int id)
        {
            var configuration = AngleSharp.Configuration.Default.WithDefaultLoader();
            var context = BrowsingContext.New(configuration);

            var link = String.Format("http://www.buenosenlaces.com/frase.php?q={0}", id);
            await context.OpenAsync(link);

            var quote = context.Active.GetElementsByTagName("h1");
            string q_str = quote[0].ChildNodes[0].TextContent;

            return q_str;
        }
    }
}