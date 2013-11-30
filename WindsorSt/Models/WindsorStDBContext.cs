using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WindsorSt.Models
{
    public class WindsorStDBContext : DbContext
    {
        public DbSet<Block> Blocks {get;set;}
        public DbSet<Car> Cars { get; set; }
        public DbSet<Industry> Industries { get; set; }
        public DbSet<OfflayoutDestination> OffLayoutDestinations { get; set; }
        public DbSet<Train> Trains { get; set; }
        public DbSet<TrainType> TrainTypes { get; set; }
    }
}