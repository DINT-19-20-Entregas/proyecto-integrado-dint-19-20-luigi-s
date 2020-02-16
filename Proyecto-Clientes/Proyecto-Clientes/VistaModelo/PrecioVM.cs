using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;

namespace Proyecto_Clientes.VistaModelo
{
    public class PrecioVM
    {
        public PrecioVM()
        {
            
        }

        public static int GetIva()
        {
            string iva = "";
            string URL = "https://apidint1920.azurewebsites.net/api/iva";
            var json = new WebClient().DownloadString(URL);
            dynamic m = JsonConvert.DeserializeObject(json);
            iva = m.iva; // Aqui asigo a iva el valor que encuentre en el JSON con el nombre "iva", en este caso 10
            return Int32.Parse(iva);
        }
    }
}
