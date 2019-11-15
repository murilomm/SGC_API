using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGC_API.Core.Entity;

namespace SGC_API.Infrastructure.EntitiyConfig
{
    public class AppUsuarioMap : IEntityTypeConfiguration<AppUsuario>
    {
        public void Configure(EntityTypeBuilder<AppUsuario> builder)
        {
            builder
                .HasKey(u => u.Id);

            builder
                .HasKey(bc => new { bc.AppId, bc.UsuarioId });
            builder
                .HasOne(bc => bc.App)
                .WithMany(b => b.AppsUsuarios)
                .HasForeignKey(bc => bc.AppId);
            builder
                .HasOne(bc => bc.Usuario)
                .WithMany(c => c.AppsUsuarios)
                .HasForeignKey(bc => bc.UsuarioId);
        }
    }
}
