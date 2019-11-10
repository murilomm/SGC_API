using System.Collections.Generic;

namespace SGC_API.Core.Entity
{
    public class Cliente : Generica
    {
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }

        public ICollection<ClienteUsuario> ClientesUsuarios { get; set; }
    }
}
