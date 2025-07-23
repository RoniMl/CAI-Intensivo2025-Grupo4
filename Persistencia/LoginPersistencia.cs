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
        public LoginResponse login(String username, String password)
        {

            LoginRequest datos = new LoginRequest();
            datos.User = username;
            datos.Password = password;

            // Convert the data to a JSON string
            var jsonData = JsonSerializer.Serialize(datos);

            HttpResponseMessage response = WebHelper.Post("tpIntensivo/login", jsonData);

            LoginResponse loginResponse = null;

            if (response.IsSuccessStatusCode)
            {
                var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                loginResponse = JsonSerializer.Deserialize<LoginResponse>(reader.ReadToEnd());
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                if (response.StatusCode.Equals(401))
                {
                    throw new Exception("Usuario bloqueado");
                }

                throw new Exception("Error al momento del Login");
            }

            return loginResponse;
        }
    }
}
