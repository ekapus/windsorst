using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WindsorSt.Models
{
    public class Locomotive
    {
        public int Id { get; set; }
        public string Owner { get; set; }
        [Display(Name = "Reporting Mark")]
        public string ReportingMark { get; set; }
        [Display(Name = "Road Number")]
        public string RoadNumber { get; set; }
        public string Class { get; set; }
        [Display(Name = "Current Assignment")]
        public Train AssignedTrain { get; set; }
        public LocomotiveStatus Status { get; set; }

    }
}