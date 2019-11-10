using System.Collections.Generic;

namespace SGC_API.Core.Entity
{
    public class App : Generica
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }

        public ICollection<AppUsuario> AppsUsuarios { get; set; }
    }
}
