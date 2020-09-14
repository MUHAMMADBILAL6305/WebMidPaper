using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BilalAshna.Models
{
    public class Resturant
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }
    }

    public class ResturantDBContext : DbContext
    {
        public DbSet<Resturant> Resturants { get; set; }
    }
}