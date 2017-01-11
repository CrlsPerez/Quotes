using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Quotes.Models
{
    public class Quote
    {
        public int QuoteID { get; set; }
        public string QuoteString  { get; set; }
    }

    public class QuoteExternal
    {
        [Key]
        public int QuoteID_External { get; set; }
        public string QuoteString_External { get; set; }
        public string URL_External { get; set; }
    }
}