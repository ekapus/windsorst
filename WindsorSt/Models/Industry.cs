using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WindsorSt.Models
{
    public class Industry
    {
        public int Id { get; set; }
        public String ServingTrain { get; set; }
        public String Name { get; set; }
        public String Category { get; set; }
        public String Line { get; set; }
        public String City { get; set; }
        public String Zone { get; set; }
        public String Track { get; set; }
        public String Spot { get; set; }
        public String CarCount { get; set; }
        public String Notes { get; set; }
        public String GeneralLocation { get; set; }
    }
}