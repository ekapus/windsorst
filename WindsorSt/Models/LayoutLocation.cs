using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WindsorSt.Models
{
    public class LayoutLocation
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public OfflayoutDestination OfflayoutDestination { get; set; }
        public Industry Industry { get; set; }
    }
}