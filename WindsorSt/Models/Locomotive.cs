using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WindsorSt.Models
{
    public class Locomotive
    {
        public int Id { get; set; }
        public string Owner { get; set; }
        public string ReportingMark { get; set; }
        public string RoadNumber { get; set; }
        public string Class { get; set; }
        public Train AssignedTrain { get; set; }
        public LocomotiveStatus Status { get; set; }

    }
}