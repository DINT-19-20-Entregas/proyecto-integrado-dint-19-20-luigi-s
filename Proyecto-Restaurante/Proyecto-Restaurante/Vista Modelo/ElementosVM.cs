using Proyecto_Restaurante.Servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace Proyecto_Restaurante.Vista_Modelo
{
    class ElementosVM : INotifyPropertyChanged
    {
        private bool limpiarCampos = false;

        public event PropertyChangedEventHandler PropertyChanged;

        public ElementosVM()
        {
            ListaElementos = BBDDService.GetElementos();
        }

        public ObservableCollection<elementosCarta> ListaElementos { get; set; }

        public static void limpiaCampos(List<TextBox> listaTextBoxs)
        {
            foreach (var item in listaTextBoxs)
                item.Text = "";
        }
    }
}
