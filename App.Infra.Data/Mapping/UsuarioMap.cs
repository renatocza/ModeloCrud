using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Infra.Data.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Cpf)
                .IsRequired()
                .HasColumnName("Cpf");

            builder.Property(c => c.DtNasc)
                .IsRequired()
                .HasColumnName("BirthDate");

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnName("Name");
        }
    }
}
