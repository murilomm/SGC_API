using System.Collections.Generic;

namespace SGC_API.Core.Entity
{
    public class App : Generica
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<AppUsuario> AppsUsuarios { get; set; }
    }
}
