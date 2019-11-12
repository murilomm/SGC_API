using System.Collections.Generic;

namespace SGC_API.Core.Entity
{
    public class Cliente : Generica
    {
        public string Cpf { get; set; }
        public string Senha { get; set; }
        public string Token { get; set; }
        public string Nome { get; set; }        

        public ICollection<ClienteUsuario> ClientesUsuarios { get; set; }
        public ICollection<ClienteTerceiro> ClientesTerceiros { get; set; }
    }
}
