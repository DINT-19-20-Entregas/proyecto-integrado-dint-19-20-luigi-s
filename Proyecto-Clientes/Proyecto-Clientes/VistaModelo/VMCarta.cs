using Proyecto_Clientes.Model;
using Proyecto_Clientes.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Clientes.VistaModelo
{
    class VMCarta : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<elementosCarta> ListaElementos { get; set; }
        public ObservableCollection<Categorias> ListaCategorias { get; set; }

        public VMCarta()
        {
            ListaElementos = BBDDService.GetElementosCarta();
            ListaCategorias = BBDDService.GetCategorias();
        }
    }
}
