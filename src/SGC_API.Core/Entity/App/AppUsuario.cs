﻿namespace SGC_API.Core.Entity
{
    public class AppUsuario : Generica
    {
        public int AppId { get; set; }
        public virtual App App { get; set; }
        
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
