using Proyecto_Restaurante.Servicios;
using System;
using System.Collections.Generic;
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
            ListaElementos = new CollectionViewSource
            {
                Source = BBDDService.GetElementos()
            };
        }

        public CollectionViewSource ListaElementos { get; set; }

        
    }
}
