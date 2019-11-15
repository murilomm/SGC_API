using System.Collections.Generic;

namespace SGC_API.Core.Entity
{
    public class Terceiro : Generica
    {
        public string Nome { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
