﻿namespace SGC_API.Core.Entity
{
    public class UsuarioEmail : Generica
    {
        public string Endereco { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
