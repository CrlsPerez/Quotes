using Quotes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quotes.Controllers
{
    public class PageController : Controller
    {
        // GET: Page
        public ActionResult Index()
        {
            int id = new FunctionsController().RandomID();
            Quote q = new QuoteExternalController().Get(id);

            return View(q);
        }
    }
}