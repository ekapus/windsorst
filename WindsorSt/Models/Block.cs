using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WindsorSt.Models
{
    public class Block
    {
        public int Id { get; set; }
        [Display(Name = "Handling Train")]
        public Train HandlingTrain { get; set; }
        public string Name { get; set; }
    }
}