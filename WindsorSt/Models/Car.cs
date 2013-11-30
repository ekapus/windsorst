using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WindsorSt.Models
{
    

    public class Car
    {
        public int Id { get; set; }
        public String Owner { get; set; }
        public String ReportingMarks { get; set; }
        public String Color { get; set; }
        public String PaintSchemeNotes { get; set; }
        public String RoadNumber { get; set; }
        public String CTD { get; set; }
        public String Blt { get; set; }
        public String Srvc { get; set; }
        public String Length { get; set; }
        public String GeneralCarType { get; set; }
        public String SpecificCarType { get; set; }
        public String Service { get; set; }
        public String Manufacturer { get; set; }
        public String Item { get; set; }
        public String Weight { get; set; }
        public String Wheels { get; set; }
        public String Trucks { get; set; }
        public String Couplers { get; set; }
        public String Weathered { get; set; }
        public String AcquisitionDate { get; set; }
        public String PricePaid { get; set; }
        public String RepairsNeeded { get; set; }
        public Industry OnLayoutDestination { get; set; }
        public OfflayoutDestination OffLayoutDestination { get; set; }
 
    }
}