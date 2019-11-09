using System.Collections.Generic;

namespace SGC_API.Core.Entity
{
    public class Usuario : Generica
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
        public string Documento { get; set; }
        public string TipoDocumento { get; set; }
        public List<UsuarioEndereco> Enderecos { get; set; }
        public List<UsuarioContato> Contatos { get; set; }
        public List<UsuarioEmail> Emails { get; set; }
        public string Filiacao { get; set; }
        public string Genero { get; set; }
        public bool Administrador { get; set; }
    }   
}
