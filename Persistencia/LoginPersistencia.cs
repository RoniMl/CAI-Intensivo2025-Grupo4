using Datos;
using Persistencia.utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Persistencia
{
    public class LoginPersistencia
    {
        public string? errorMensaje;

       

        public LoginResponse login(String username, String password)
        {
            
            LoginRequest datos = new LoginRequest();
            datos.user = username;
            datos.password = password;

            // Convert the data to a JSON string
            var jsonData = JsonSerializer.Serialize(datos);

            HttpResponseMessage response = WebHelper.Post("tpIntensivo/login", jsonData);           
            LoginResponse loginResponse = null;
            //string errorDeAPI = response.Content.ReadAsStringAsync().Result; 


            if (response.IsSuccessStatusCode)
            {
                 // Reset failed attempts on successful login
                var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                loginResponse = JsonSerializer.Deserialize<LoginResponse>(reader.ReadToEnd());
            }
            else 
            {
                string body = response.Content.ReadAsStringAsync().Result;
                var error = JsonSerializer.Deserialize<ResponseError>(body);
                errorMensaje = error.message;
              //  error = errorDeAPI;
            } 

            return loginResponse;
        }
    }
}
