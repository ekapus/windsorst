using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WindsorSt.Models
{
    public class Industry
    {
        public int Id { get; set; }
        [Display(Name = "Serving Block")]
        public Block ServingBlock { get; set; }
        public String Name { get; set; }
        public String Category { get; set; }
        public String Line { get; set; }
        public String City { get; set; }
        public String Zone { get; set; }
        public String Track { get; set; }
        public String Spot { get; set; }
        [Display(Name = "Car Count")]
        public int CarCount { get; set; }
        public String Notes { get; set; }
        [Display(Name = "General Location")]
        public String GeneralLocation { get; set; }
    }
}