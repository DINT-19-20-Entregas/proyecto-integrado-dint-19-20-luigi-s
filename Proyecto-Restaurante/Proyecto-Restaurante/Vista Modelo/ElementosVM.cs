using Proyecto_Restaurante.Servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Proyecto_Restaurante.Vista_Modelo
{
    class ElementosVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ElementosVM()
        {
            ListaElementos = BBDDService.GetElementos();
        }

        public ObservableCollection<elementosCarta> ListaElementos { get; set; }

        
    }
}
