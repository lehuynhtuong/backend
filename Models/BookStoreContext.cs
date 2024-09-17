﻿using Microsoft.EntityFrameworkCore;
namespace BackEnd.Models
{
    public class BookStoreContext : DbContext
    {
        public DbSet<Collection> Collections { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<User> user { get; set; }

        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options)
        {
        }
    }
}
