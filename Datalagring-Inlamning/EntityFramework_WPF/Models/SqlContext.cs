using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_WPF.Models {
    internal class SqlContext : DbContext {

        public SqlContext() {

        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options) {

        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\WIN21\inlamning-datalagring\Datalagring-Inlamning\EntityFramework_WPF\Data\efc_database.mdf;Integrated Security=True;Connect Timeout=30");

        }
    }
}
