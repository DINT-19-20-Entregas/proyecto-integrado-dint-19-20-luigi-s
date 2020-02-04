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
        private int id { get; set; }
        private int categoria { get; set; }
        private string imagen { get; set; }

        public CategoriaVM(int id, int categoria, string imagen)
        {
            this.id = id;
            this.categoria = categoria;
            this.imagen = imagen;
        }

        public override string ToString()
        {
            return "id = "+id+", categoria = "+categoria+", imagen = "+imagen;
        }
    }
}
