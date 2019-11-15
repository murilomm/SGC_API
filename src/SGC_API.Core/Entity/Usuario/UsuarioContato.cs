namespace SGC_API.Core.Entity
{
    public class UsuarioContato : Generica
    {
        public string Ddi { get; set; }
        public string Ddd { get; set; }
        public string Telefone { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
