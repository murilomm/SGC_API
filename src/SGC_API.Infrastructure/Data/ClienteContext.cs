﻿using Microsoft.EntityFrameworkCore;
using SGC_API.Core.Entity;

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
        public DbSet<ClienteUsuario> ClientesUsuarios { get; set; }
        
        public DbSet<Terceiro> Terceiros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("TBL_USUARIO");
            modelBuilder.Entity<UsuarioContato>().ToTable("TBL_USUARIO_CONTATO");
            modelBuilder.Entity<UsuarioEmail>().ToTable("TBL_USUARIO_EMAIL");
            modelBuilder.Entity<UsuarioEndereco>().ToTable("TBL_USUARIO_ENDERECO");
            
            modelBuilder.Entity<App>().ToTable("TBL_APP");
            modelBuilder.Entity<AppUsuario>().ToTable("TBL_APP_USUARIO");
            
            modelBuilder.Entity<Cliente>().ToTable("TBL_CLIENTE");
            modelBuilder.Entity<ClienteUsuario>().ToTable("TBL_CLIENTE_USUARIO");
            
            modelBuilder.Entity<Terceiro>().ToTable("TBL_TERCEIRO");
        }
    }
}
