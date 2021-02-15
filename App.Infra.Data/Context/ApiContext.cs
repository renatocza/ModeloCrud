using App.Domain.Entities;
using App.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Infra.Data.Context
{
    public class ApiContext: DbContext
    {

        public ApiContext(DbContextOptions<ApiContext> options)
        : base(options)
        { }

        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>(new UsuarioMap().Configure);
        }
    }
}
