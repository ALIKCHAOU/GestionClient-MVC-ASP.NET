using Gestion_des_clients.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Gestion_des_clients.Context
{
    public class GestiondesclientsContext : DbContext
    {
        public DbSet<Client> clients { get; set; }
        public DbSet<Consultant> consultants { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<GestiondesclientsContext>(null);
            base.OnModelCreating(modelBuilder);
        }


    }

}