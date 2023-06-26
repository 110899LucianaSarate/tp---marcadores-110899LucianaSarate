using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using apiMap.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using static apiMap.Models.MarMap;

namespace apiMap.Services
{
    public class MarcService
    {
        private readonly HttpClient httpClient;

        public MarcService()
        {
            httpClient = new HttpClient();
        }

        public async Task<Marcador> listaMarca()
        {
            string token = await loggin();

            return await peticion(token) ;
        }
        public async Task<Marcador> peticion(string token)
        {
            string urlMicroservicio = "https://prog3.nhorenstein.com/api/marcador/GetMarcadores";


            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            HttpResponseMessage response = await httpClient.GetAsync(urlMicroservicio);

            if (response.IsSuccessStatusCode)
            {
                var contenido = await response.Content.ReadAsAsync<Marcador>();

                return contenido;
            }
            else
            {
                // Manejar el caso de respuesta no exitosa
                Console.WriteLine("Error en la peticion. Código de error:" + response.StatusCode);
                return null;
            }
        }
        public async Task<String> loggin()
        {

            string urlLoggin = "https://prog3.nhorenstein.com/api/usuario/LoginUsuarioWeb";

            SimpLogger user= new SimpLogger("110899","110899");
            string jsonPayload = JsonSerializer.Serialize(user);
            StringContent content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync(urlLoggin, content);


            if (response.IsSuccessStatusCode)
            {
                var contenido = await response.Content.ReadAsAsync<Logger>();

                return contenido.Token;
            }
            else
            {
                Console.WriteLine("Error en la peticion. Código de error: " + response.StatusCode);
                return null;
            }
        }
    }
}

