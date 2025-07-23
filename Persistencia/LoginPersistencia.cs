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
        public string error = "0";

        public LoginResponse login(String username, String password)
        {
            
            LoginRequest datos = new LoginRequest();
            datos.user = username;
            datos.password = password;

            // Convert the data to a JSON string
            var jsonData = JsonSerializer.Serialize(datos);

            HttpResponseMessage response = WebHelper.Post("tpIntensivo/login", jsonData);
            
            LoginResponse loginResponse = null;
            

            if (response.IsSuccessStatusCode)
            {
                 // Reset failed attempts on successful login
                var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                loginResponse = JsonSerializer.Deserialize<LoginResponse>(reader.ReadToEnd());
            }
            else if(response.StatusCode.Equals(401))
            {
                error = "401";
            } 

            return loginResponse;
        }
    }
}
