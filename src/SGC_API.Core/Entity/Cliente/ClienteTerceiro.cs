namespace SGC_API.Core.Entity
{
    public class ClienteTerceiro : Generica
    {
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        
        public int TerceiroId { get; set; }
        public Terceiro Terceiro { get; set; }
    }
}
