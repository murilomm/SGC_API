using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGC_API.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGC_API.Infrastructure.EntitiyConfig
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder
                .HasKey(u => u.Id);

            builder
                .HasMany(u => u.Enderecos)
                .WithOne(u => u.Usuario)
                .HasForeignKey(u => u.UsuarioId)
                .HasPrincipalKey(u => u.Id);

            builder
                .HasMany(u => u.Contatos)
                .WithOne(u => u.Usuario)
                .HasForeignKey(u => u.UsuarioId)
                .HasPrincipalKey(u => u.Id);

            builder
                .HasMany(u => u.Emails)
                .WithOne(u => u.Usuario)
                .HasForeignKey(u => u.UsuarioId)
                .HasPrincipalKey(u => u.Id);

            builder
                .HasOne(_ => _.Cliente)
                .WithMany(_ => _.Usuarios);


            builder.Property(u => u.Nome).HasColumnType("VARCHAR(50)").HasMaxLength(50);
            builder.Property(u => u.Sobrenome).HasColumnType("VARCHAR(100)").HasMaxLength(100);
            builder.Property(u => u.Sobrenome).HasColumnType("VARCHAR(100)").HasMaxLength(100);
            builder.Property(u => u.Documento).HasColumnType("VARCHAR(20)").HasMaxLength(20);
            builder.Property(u => u.TipoDocumento).HasColumnType("VARCHAR(20)").HasMaxLength(20);
            builder.Property(u => u.Filiacao).HasColumnType("VARCHAR(50)").HasMaxLength(50);
            builder.Property(u => u.Genero).HasColumnType("VARCHAR(1)").HasMaxLength(1);
        }
    }
}
