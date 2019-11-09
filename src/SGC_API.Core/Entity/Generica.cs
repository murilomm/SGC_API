using System;
using System.Collections.Generic;
using System.Text;

namespace SGC_API.Core.Entity
{
    public class Generica
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public int UsuarioCadastro { get; set; }
        public int? UsuarioAlteracao { get; set; }
    }
}
