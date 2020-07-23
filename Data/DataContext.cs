using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;

using Microsoft.Extensions.Configuration;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Data
{
    public class DataContext : DbContext, IDbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public IModel GetModel()
        {
            return Model;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entities.Account>().ToTable("tbl_Account");
            modelBuilder.Entity<Entities.MeterReading>().ToTable("tbl_MeterReading");
        }
    }
}
