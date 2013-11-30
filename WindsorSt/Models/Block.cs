using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WindsorSt.Models
{
    public class Block
    {
        public int Id { get; set; }
        public Train HandlingTrain { get; set; }
        public string Name { get; set; }
    }
}