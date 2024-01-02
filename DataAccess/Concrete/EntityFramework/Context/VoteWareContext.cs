using System;
using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class VoteWareContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost;user=SA;password=reallyStrongPwd123;database=VoteWare;TrustServerCertificate=true;Integrated Security=false;");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Event>Events { get; set; }
        public DbSet<Date> Dates { get; set; }
        public DbSet<Vote> Votes { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}

