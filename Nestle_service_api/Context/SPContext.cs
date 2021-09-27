using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nestle_service_api.Model;
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
            modelBuilder.Entity<OutboundCallViewModel>().HasNoKey().ToView(null);
            modelBuilder.Entity<tb_segment>().HasNoKey().ToView(null);
        }

    }
}
