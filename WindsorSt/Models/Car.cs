using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace WindsorSt.Models
{
    

    public class Car
    {
        public int Id { get; set; }
        public String Owner { get; set; }
        [Display(Name = "Reporting Marks")]
        public String ReportingMarks { get; set; }
        public String Color { get; set; }
        [Display(Name = "Paint Scheme Notes")]
        public String PaintSchemeNotes { get; set; }
        [Display(Name = "Road Number")]
        public String RoadNumber { get; set; }
        public String CTD { get; set; }
        public String Blt { get; set; }
        public String Srvc { get; set; }
        public String Length { get; set; }
        [Display(Name = "General Car Type")]
        public String GeneralCarType { get; set; }
        [Display(Name = "Specific Car Type (Class)")]
        public String SpecificCarType { get; set; }
        public String Service { get; set; }
        public String Manufacturer { get; set; }
        public String Item { get; set; }
        public String Weight { get; set; }
        public String Wheels { get; set; }
        public String Trucks { get; set; }
        public String Couplers { get; set; }
        public String Weathered { get; set; }
        [Display(Name = "Acquisition Date")]
        public String AcquisitionDate { get; set; }
        [Display(Name = "Price Paid")]
        public String PricePaid { get; set; }
        [Display(Name = "Repairs Needed")]
        public String RepairsNeeded { get; set; }
        [Display(Name = "On Layout Destination")]
        public Industry OnLayoutDestination { get; set; }
        [Display(Name = "Off Layout Destination")]
        public OfflayoutDestination OffLayoutDestination { get; set; }
        [Display(Name = "Layout Location")]
        public LayoutLocation LayoutLocation { get; set; }
    }
}