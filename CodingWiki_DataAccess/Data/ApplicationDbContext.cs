using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_DataAccess.Data
{
    public class ApplicationDbContext:DbContext  //DbCotext class is responsible for create,update,delete,table creation..
    {
        //one of the main things we create are DbSet , these are kind of tables in database...
        public DbSet<Book> Books { get; set; } //name of dbset will be same of table created in db..
        //public DbSet<Genre> Genres { get; set; }     //to remove the table from db we just need to comment out and create migration and update db
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=laptop-mfmb1qub\\akashssmsql;Initial Catalog=BooksManagement;Integrated Security=True;Pooling=False;TrustServerCertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book { IdBook=1,Title="Spider without Duty",ISBN="1234",Price=24.12M},
                new Book { IdBook = 2, Title = "Fortune of time", ISBN = "1394", Price = 240.12M }
                );
        }
    }
}
