using EFCore.Configurations;
using EFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    public class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder option)=>
            option.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=EFCore;Integrated Security=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new BlogEntityTypeConfiguration().Configure(modelBuilder.Entity<Blog>());
        }
        DbSet<Blog> blogs { get; set; }
    }
}
