﻿namespace apiMap.Models
{
    public class Logger
    {
        public string Error { get; set; }
        public bool Ok { get; set; }
        public string MensajeInfo { get; set; }
        public int StatusCode { get; set; }
        public Guid IdUsuario { get; set; }
        public string Token { get; set; }
        public string EmailUsuario { get; set; }
        public string UrlImagen { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int IdRol { get; set; }
        public string RolName { get; set; }
    }
}
