using Proyecto_Clientes.Model;
using Proyecto_Clientes.Service;
using Proyecto_Clientes.VistaModelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Lógica de interacción para UserControlPrecio.xaml
    /// </summary>
    public partial class UserControlPrecio : UserControl
    {
        int iva;

        ObservableCollection<elementosCarta> elementosLista;
        public UserControlPrecio()
        {
            InitializeComponent();
            elementosLista = VMCarta.ListaElementosPedidos;
            iva = PrecioVM.GetIva();
            ElementosPedidosListBox.DataContext = elementosLista;

            PrecioConIvaTextBlock.Text += Math.Round(PrecioVM.CalculaPrecioConIva(elementosLista), 2).ToString();
            PrecioSinIvaTextBlock.Text += Math.Round(PrecioVM.CalculaPrecioSinIva(elementosLista), 2).ToString();
        }

        private void AceptarButton_Click(object sender, RoutedEventArgs e)
        {
            Pedidos p = new Pedidos();
            MessageBox.Show("Un camarero le atenderá en un momento", "Pedido realizado correctamente", MessageBoxButton.OK, MessageBoxImage.Information);
            p.elementosCarta = elementosLista;
            p.idPedido = 0;
            p.fecha = DateTime.Now;
            p.servido = false;
            BBDDService.AddPedido(p);
            PrecioVM.PedidoAceptado = true;
        }
    }
}
