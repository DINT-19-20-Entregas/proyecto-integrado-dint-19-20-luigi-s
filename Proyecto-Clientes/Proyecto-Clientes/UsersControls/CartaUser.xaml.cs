using Proyecto_Clientes.Model;
using Proyecto_Clientes.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Proyecto_Clientes.UsersControls
{
    /// <summary>
    /// Lógica de interacción para CartaUser.xaml
    /// </summary>
    public partial class CartaUser : UserControl
    {
        public CartaUser()
        {
            InitializeComponent();
            this.DataContext = new VMCarta();
        }

        private void FinalizarClick(object sender, RoutedEventArgs e)
        {
            inicializaVentanaPrecios();
        }
        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (CategoriasListBox.SelectedItem != null)
            {
                (DataContext as VMCarta).AsignarCategoriaSeleccionada(CategoriasListBox);
            }
        }

        private void Grid_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            (DataContext as VMCarta).AñadirElementoAPedido((elementosCarta)ElementosListBox.SelectedItem);
        }

        private void Grid_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            (DataContext as VMCarta).QuitarElementoPedido((elementosCarta)ElementosPedidosListBox.SelectedItem);
        }

        public void inicializaVentanaPrecios()
        {
            VentanaConfirmar vc = new VentanaConfirmar();
            vc.ShowDialog();
            if (PrecioVM.PedidoAceptado)
            {
                VMCarta.ListaElementosPedidos.Clear();
                PrecioVM.PedidoAceptado = false; //Para que otros clientes puedan pedir
            }
            vc.FinalizarVentana();
        }
    }
}
