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

        public void Añadir(Categorias c)
        {
            BBDDService.AddCategoria(c);
            MessageBox.Show("Categoria añadida", "Confirmation", MessageBoxButton.OK , MessageBoxImage.Information);
        }

        public void Eliminar(Categorias c)
        {
            BBDDService.DeleteCategoria(c);
            MessageBox.Show("Categoria eliminada", "Confirmation", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public bool Existe(Categorias c)
        {
            bool existe = false;
            foreach (Categorias cLista in ListaCategorias)
            {
                if (cLista.nombreCategoria.Equals(c.nombreCategoria))
                    existe = true;
            }

            return existe;
        }

        public void Guardar()
        {
            BBDDService.UpdateDB();
        }

    }
}
