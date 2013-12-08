using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WindsorSt.Models
{
    public class LayoutLocation
    {
        public int Id { get; set; }
        public String Name { get; set; }
        [Display(Name = "Off Layout Destination")]
        public OfflayoutDestination OfflayoutDestination { get; set; }
        public Industry Industry { get; set; }
    }
}