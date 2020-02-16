using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;
using Proyecto_Clientes.Model;

namespace Proyecto_Clientes.VistaModelo
{
    public class PrecioVM
    {
        public static bool PedidoAceptado { get; set; }
        public static bool CierroVentana { get; set; }

        public PrecioVM()
        {
            PedidoAceptado = false;
            CierroVentana = false;
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

        public static double CalculaPrecioConIva(ObservableCollection<elementosCarta> listaPedidos)
        {
            double precio = 0;
            foreach (var item in listaPedidos)
                precio += item.precio;
            return precio+(precio*GetIva()/100);
        }

        public static double CalculaPrecioSinIva(ObservableCollection<elementosCarta> listaPedidos)
        {
            double precio = 0;
            foreach (var item in listaPedidos)
                precio += item.precio;
            return precio;
        }
    }
}
