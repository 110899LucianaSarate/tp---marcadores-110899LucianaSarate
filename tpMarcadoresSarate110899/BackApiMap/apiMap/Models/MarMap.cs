namespace apiMap.Models
{
    public class MarMap
    {
        public class Marcador
        {
            //public string error { get; set; }
            //public bool ok { get; set; }
            //public string mensajeInfo { get; set; }
            //public int statusCode { get; set; }
            public List<MarcadorModelo> litadoMarcadores { get; set; }
        }

        public class MarcadorModelo
        {
            public string latitud { get; set; }
            public string longitud { get; set; }
            public string info { get; set; }
        }
    }
}
