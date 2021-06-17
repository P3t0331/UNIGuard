﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace UniGuardClassLibrary
{
    public class UniGuardDbContext : DbContext
    {
        private readonly string ConnectionString = System.IO.File.ReadAllText(@"ConnectionString.txt");

        public DbSet<SemesterData> SemesterData { get; set; }
        public DbSet<SubjectData> SubjectData { get; set; }
        public DbSet<AssigmentData> AssigmentData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }

    }

}
