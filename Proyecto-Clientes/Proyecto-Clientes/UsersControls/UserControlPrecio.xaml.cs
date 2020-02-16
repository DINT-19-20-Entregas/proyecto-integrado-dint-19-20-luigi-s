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
    /// Lógica de interacción para UserControlPrecio.xaml
    /// </summary>
    public partial class UserControlPrecio : UserControl
    {
        public UserControlPrecio()
        {
            InitializeComponent();
            MessageBox.Show(PrecioVM.GetIva().ToString());
        }
    }
}
