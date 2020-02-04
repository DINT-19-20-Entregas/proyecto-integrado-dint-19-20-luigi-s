using Proyecto_Restaurante.Servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Proyecto_Restaurante.Vista_Modelo
{
    class CategoriaVM : INotifyPropertyChanged
    {
        public ObservableCollection<Categorias> ListaCategorias { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Categorias> Categorias { get; set; }


        public CategoriaVM()
        {
            Categorias = BBDDService.GetCategorias();
        }

    }
}
