using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using BoVoyageWeb.Models;

namespace BoVoyageWeb.Data
{
    public class BoVoyageDbContext : DbContext
    {
        public BoVoyageDbContext() : base("BoVoyageConnectionString")
        {
        }

        public DbSet<Agence> Agences { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Destination> Destinations { get; set; }

        public DbSet<Reservation> Reservations { get; set; }
    }
}