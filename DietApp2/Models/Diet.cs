using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DietApp2.Models
{
    public class Diet
    {
        public string meal { get; set; }
        public string comment { get; set; }
        public DateTime date { get; set; }
        public bool İsCompleted { get; set; }
    }
}