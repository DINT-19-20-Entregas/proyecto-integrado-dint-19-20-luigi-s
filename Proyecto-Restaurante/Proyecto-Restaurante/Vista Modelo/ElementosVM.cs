using Proyecto_Restaurante.Servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
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

        public static bool puedoEliminar(bool tieneFocus)
        {
            return tieneFocus ? true : false;
        }

        public static void eliminaRegistro(elementosCarta e)
        {
            BBDDService.DeleteElementosCarta(e);
            BBDDService.UpdateDB();
            MessageBox.Show("Se eliminó el registro satisfactoriamente", "Correcto", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }

        public static void limpiaCampos(List<TextBox> lista)
        {
            foreach(var item in lista)
                item.Text = "";
        }

        public static bool puedoLimpiarCampos(List<TextBox> lista)
        {
            bool puedo = false;
            foreach (var item in lista)
            {
                if (item.Text.Trim() != "")
                    puedo = true;
                else
                {
                    puedo = false;
                    break;
                }
            }
            return puedo;
        }

        public static void añadeElemento(elementosCarta elemento)
        {
            BBDDService.AddElementoCarta(elemento);
        }
    }
}