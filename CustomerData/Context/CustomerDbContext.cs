using CustomerData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CustomerData.Context
{
    public class CustomerDbContext: DbContext
    {
        private readonly string _connectionString;

        public CustomerDbContext(): this("Server=8MMBQG3;Database=CustomerDb;User Id=sa;Password=Fr4g4t4cr1s")
        {
        }

        public CustomerDbContext(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public DbSet<CustomerEntity> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(this._connectionString);
            }
        }
    }
}
