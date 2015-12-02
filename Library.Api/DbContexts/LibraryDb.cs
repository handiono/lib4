using Library.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Library.Api.DbContexts
{
    public class LibraryDb : DbContext
    {

        public LibraryDb() : base("DefaultConnection")
        {
                
        }

        public DbSet<Book> Books { get; set; }


    }
}