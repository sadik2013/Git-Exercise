using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace HelloMVC.DatabaseContext
{
    public class TrainingDbContext:DbContext
    {
        public DbSet<Trainee> Trainees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=DESKTOP-PHFRTLE\\SQLEXPRESS;Database=TrainingDb;Integrated Security=true ");
        }
    }
}
