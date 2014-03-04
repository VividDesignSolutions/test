using System;
using System.Data.Entity;

namespace vdsDemo.Models
{
    public class Create_DR
    {
        public int ID { get; set; }
        public int JSO_ID { get; set; }
        public DateTime DateOfIncident { get; set; }
        public string officerFirst { get; set; }
        public string officerLast { get; set; }
        public string violation { get; set; }
        public string inmateFirst { get; set; }
        public string inmateLast { get; set; }

    }

    public class Create_DRDBContext : DbContext
    {
        public DbSet<Create_DR> DR { get; set; }
    }
}