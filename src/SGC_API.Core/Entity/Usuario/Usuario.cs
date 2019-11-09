using System;
using System.Collections.Generic;
using System.Text;

namespace SGC_API.Core.Entity.Usuario
{
    public class Usuario : Generica
    {
        public string NomeCompleto { get; set; }
        public int Idade { get; set; }
        public string Documento { get; set; }
        public string TipoDocumento { get; set; }
        public List<Endereco> Enderecos { get; set; }
        public List<Contato> Contatos { get; set; }
        public List<Email> Emails { get; set; }
        public string Filiacao { get; set; }
        public string Genero { get; set; }
    }   
}
