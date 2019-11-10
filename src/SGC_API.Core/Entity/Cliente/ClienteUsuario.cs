namespace SGC_API.Core.Entity
{
    public class ClienteUsuario : Generica
    {
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
