namespace apiMap.Models
{
    public class SimpLogger
    {
        public string nombreUsuario { get; set; }
        public string password { get; set; }

        public SimpLogger(string nombreUsuario , string password) {

            this.nombreUsuario = nombreUsuario;
            this.password = password;   

          
        }
    }

    
}
