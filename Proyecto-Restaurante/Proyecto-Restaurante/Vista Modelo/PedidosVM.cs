using Proyecto_Restaurante.Servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Restaurante.Vista_Modelo
{
    class PedidosVM : INotifyPropertyChanged
    {
        public ObservableCollection<Pedidos> Pedidos { get; set; }

        public PedidosVM()
        {            
            //Pedidos = BBDDService.GetPedidos(); 
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
