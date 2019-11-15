using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGC_API.Core.Entity;

namespace SGC_API.Infrastructure.EntitiyConfig
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder
                .HasKey(u => u.Id);

            builder
               .HasMany(_ => _.Apps)
               .WithOne(_ => _.Cliente);

            builder
               .HasMany(_ => _.Usuarios)
               .WithOne(_ => _.Cliente);

            builder
               .HasMany(_ => _.Terceiros)
               .WithOne(_ => _.Cliente);

            builder.Property(u => u.Cpf).HasColumnType("VARCHAR(14)").HasMaxLength(100);
            builder.Property(u => u.Senha).HasColumnType("VARCHAR(20)").HasMaxLength(50);
            builder.Property(u => u.Token).HasColumnType("VARCHAR(200)").HasMaxLength(200);
            builder.Property(u => u.Nome).HasColumnType("VARCHAR(50)").HasMaxLength(50);
        }
    }
}
