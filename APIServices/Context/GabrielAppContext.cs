using APIServices.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace APIServices.Context
{
    class GabrielAppContext : DbContext
    {
        //static DbContextOptions<GabrielAppContext> options =
        //    new DbContextOptionsBuilder<GabrielAppContext>()
        //                 .UseInMemoryDatabase("TheDB")
        //                 .Options;

        //Options That we want in Memory
        //public InMemoryContext() : base(options)
        //{

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = tcp:gabrielsql.database.windows.net, 1433; Initial Catalog = Gabriel_DB; Persist Security Info = False; User ID = gabrieladmin; Password =SwjTu2BWe7FJKh8; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");

            }

        }
        public DbSet<Model> Model_Catalog { get; set; }
    }
}
