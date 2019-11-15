using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGC_API.Core.Entity;

namespace SGC_API.Infrastructure.EntitiyConfig
{
    public class AppMap : IEntityTypeConfiguration<App>
    {
        public void Configure(EntityTypeBuilder<App> builder)
        {
            builder
                .HasKey(u => u.Id);

            builder
                .HasOne(_ => _.Cliente)
                .WithMany(_ => _.Apps);

            builder.Property(u => u.Nome).HasColumnType("VARCHAR(50)").HasMaxLength(50);
            builder.Property(u => u.Tipo).HasColumnType("VARCHAR(20)").HasMaxLength(100);
            builder.Property(u => u.Descricao).HasColumnType("VARCHAR(100)").HasMaxLength(100);
        }
    }
}
