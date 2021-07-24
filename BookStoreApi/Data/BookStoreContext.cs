using BookStoreApi.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApi.Data
{
    public class BookStoreContext : IdentityDbContext<ApplicationUser>
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options)
        {

        }
        public DbSet<Book> Book { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Below code can be used for database connection
            //optionsBuilder.UseSqlServer("data source = BNGLOG-L-99028; database = Concepts; Integrated Security = SSPI; persist security info = True; MultipleActiveResultSets = true");
            //base.OnConfiguring(optionsBuilder);
        }
    }
}
