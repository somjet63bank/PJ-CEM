using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nestle_service_api.ViewModel;

namespace Nestle_service_api.Context
{
    public class SPContext : DbContext
    {
        public SPContext(DbContextOptions<SPContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StoreViewModel>().HasNoKey().ToView(null);
        }

    }
}
