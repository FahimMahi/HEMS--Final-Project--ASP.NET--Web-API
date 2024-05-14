﻿using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class HEMSContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Management> Managements { get; set; }
        public DbSet<Landlord> Landlords { get; set; }
        public DbSet<Bidding> Biddings { get; set; }
        public DbSet<Property> Properties { get; set; }
   
    }
}
