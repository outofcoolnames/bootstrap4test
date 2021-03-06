﻿using Bootstrap4Test.DomainModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace Bootstrap4Test.Data
{
    public class UserContext : DbContext, IUserContext
    {
        private string _connectionString;
        public UserContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(_connectionString);
        }
    }
}
