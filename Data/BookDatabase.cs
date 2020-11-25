using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookProject_ASP_MVC.Models;

namespace BookProject_ASP_MVC.Data
{
    public class BookDatabase : DbContext
    {
        public BookDatabase (DbContextOptions<BookDatabase> options)
            : base(options)
        {
        }

        public DbSet<BookProject_ASP_MVC.Models.Book> Book { get; set; }

        public DbSet<BookProject_ASP_MVC.Models.Customer> Customer { get; set; }

        public DbSet<BookProject_ASP_MVC.Models.Rental> Rental { get; set; }
    }
}
