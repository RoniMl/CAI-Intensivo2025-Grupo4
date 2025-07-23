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
        public int contadorIntentosFallidos = 0;
        public int maxIntentosFallidos = 3;
        public string? errorMessage;
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
                var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                loginResponse = JsonSerializer.Deserialize<LoginResponse>(reader.ReadToEnd());
            }
            else
            {                
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                if (response.StatusCode.Equals(401))
                {
                    contadorIntentosFallidos++;
                    if (contadorIntentosFallidos >= maxIntentosFallidos)
                    {
                        errorMessage = "Has superado el número máximo de intentos fallidos. Tu cuenta ha sido bloqueada por seguridad.";
                    }
                    else
                    {
                        errorMessage = "Usuario y/o contraseña incorrectos. Por favor, inténtalo de nuevo.";
                    }
                }
            }

            return loginResponse;
        }
    }
}
