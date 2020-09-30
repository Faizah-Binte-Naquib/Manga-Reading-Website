using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mango.Models
{
    public class Manga
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Summary { get; set; }
        public int Rating { get; set; }
    }
}