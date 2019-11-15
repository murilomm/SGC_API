using System.Collections.Generic;

namespace SGC_API.Core.Entity
{
    public class Cliente : Generica
    {
        public string Cpf { get; set; }
        public string Senha { get; set; }
        public string Token { get; set; }
        public string Nome { get; set; }        

        public virtual ICollection<App> Apps { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
        public virtual ICollection<Terceiro> Terceiros { get; set; }
    }
}
