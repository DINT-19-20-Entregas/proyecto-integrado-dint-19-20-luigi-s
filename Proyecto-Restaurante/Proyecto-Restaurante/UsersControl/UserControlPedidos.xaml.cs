using Proyecto_Restaurante.Vista_Modelo;
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

namespace Proyecto_Restaurante.UsersControls
{
    public partial class UserControlPedidos : UserControl
    {
        public UserControlPedidos()
        {
            InitializeComponent();
            this.DataContext = new PedidosVM(); 
        }
    }
}
