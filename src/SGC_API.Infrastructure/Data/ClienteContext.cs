using Microsoft.EntityFrameworkCore;
using SGC_API.Core.Entity;
using SGC_API.Infrastructure.EntitiyConfig;

namespace SGC_API.Infrastructure.Data
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }        
        public DbSet<UsuarioContato> UsuarioContatos { get; set; }
        public DbSet<UsuarioEmail> UsuarioEmails { get; set; }
        public DbSet<UsuarioEndereco> UsuarioEnderecos { get; set; }
        
        public DbSet<App> Apps { get; set; }
        public DbSet<AppUsuario> AppsUsuarios { get; set; }
       
        public DbSet<Cliente> Clientes { get; set; }
        
        public DbSet<Terceiro> Terceiros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Tabelas
            modelBuilder.Entity<Usuario>().ToTable("TBL_USUARIO");
            modelBuilder.Entity<UsuarioContato>().ToTable("TBL_USUARIO_CONTATO");
            modelBuilder.Entity<UsuarioEmail>().ToTable("TBL_USUARIO_EMAIL");
            modelBuilder.Entity<UsuarioEndereco>().ToTable("TBL_USUARIO_ENDERECO");
            modelBuilder.Entity<App>().ToTable("TBL_APP");
            modelBuilder.Entity<AppUsuario>().ToTable("TBL_APP_USUARIO");
            modelBuilder.Entity<Cliente>().ToTable("TBL_CLIENTE");
            modelBuilder.Entity<Terceiro>().ToTable("TBL_TERCEIRO");
            #endregion

            #region Mapeamentos e Configurações
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new AppMap());
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new TerceiroMap());

            modelBuilder.ApplyConfiguration(new AppUsuarioMap());
            #endregion
        }
    }
}
