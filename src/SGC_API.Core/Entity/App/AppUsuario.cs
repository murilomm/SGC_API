namespace SGC_API.Core.Entity
{
    public class AppUsuario : Generica
    {
        public int AppId { get; set; }
        public App App { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
