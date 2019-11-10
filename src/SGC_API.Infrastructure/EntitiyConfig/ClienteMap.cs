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

            builder.Property(u => u.Nome).HasColumnType("VARCHAR(50)").HasMaxLength(50);
            builder.Property(u => u.CpfCnpj).HasColumnType("VARCHAR(14)").HasMaxLength(100);
        }
    }
}
