using BookManager.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BookManager.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
