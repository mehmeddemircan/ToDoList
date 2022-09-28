﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=ToDoListBusra;User Id=postgres;Password=Sd635241;");
        }

        // database ekleme işlemi yapar 
        public DbSet<Mission> Missions { get; set; }

        public DbSet<Group> Groups { get; set; }

    }
}