using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FaceMeetRazor.Models
{
    public class Records
    {
        public string Artist { get; set; }
        public string Albums { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Price { get; set; }
    }
}