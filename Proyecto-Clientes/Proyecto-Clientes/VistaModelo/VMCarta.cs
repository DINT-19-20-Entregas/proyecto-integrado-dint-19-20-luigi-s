 using Proyecto_Clientes.Model;
using Proyecto_Clientes.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Proyecto_Clientes.VistaModelo
{
    class VMCarta : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<elementosCarta> ListaElementos { get; set; }
        public ObservableCollection<Categorias> ListaCategorias { get; set; }

        public static ObservableCollection<elementosCarta> ListaElementosPedidos { get; set; }

        Categorias categoriaSeleccionada;

        public VMCarta()
        {
            ListaElementos = BBDDService.GetElementos();
            ListaCategorias = BBDDService.GetCategorias();
            ListaElementosPedidos = new ObservableCollection<elementosCarta>();
            categoriaSeleccionada = new Categorias();
        }

        public void AsignarCategoriaSeleccionada(ListBox listaCategorias)
        {
            categoriaSeleccionada = (Categorias)listaCategorias.SelectedItem;
            ListaElementos = this.Convert<elementosCarta>(categoriaSeleccionada.elementosCarta);
        }

        public ObservableCollection<elementosCarta> Convert<elementosCarta>(IEnumerable<elementosCarta> original)
        {
            return new ObservableCollection<elementosCarta>(original);
        }

        public void AñadirElementoAPedido(elementosCarta elemento)
        {
            ListaElementosPedidos.Add(elemento);
        }

        public void QuitarElementoPedido(elementosCarta elementos)
        {
            if (ListaElementosPedidos.Count > 1)
                ListaElementosPedidos.Remove(elementos);
            else
                ListaElementosPedidos.Clear();
        }
    }
}
