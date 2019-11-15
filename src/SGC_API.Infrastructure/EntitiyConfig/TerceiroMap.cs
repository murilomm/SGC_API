using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGC_API.Core.Entity;

namespace SGC_API.Infrastructure.EntitiyConfig
{
    public class TerceiroMap : IEntityTypeConfiguration<Terceiro>
    {
        public void Configure(EntityTypeBuilder<Terceiro> builder)
        {
            builder
                .HasKey(u => u.Id);

            builder
                .HasOne(_ => _.Cliente)
                .WithMany(_ => _.Terceiros);

            builder.Property(u => u.Nome).HasColumnType("VARCHAR(50)").HasMaxLength(50);
        }
    }
}
