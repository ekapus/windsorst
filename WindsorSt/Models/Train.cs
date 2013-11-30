using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WindsorSt.Models
{
    public class Train
    {
        public int Id { get; set; }
        public String Symbol {get; set;}
        public String TrainType {get; set;}
        public String Description { get; set; }
    }
}