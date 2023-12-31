﻿using Microsoft.EntityFrameworkCore;

namespace RabbitMQWeb.Watermark.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt):base (opt)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
