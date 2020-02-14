using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Clientes.Model
{
    public partial class Pedidos : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
    public partial class elementosCarta : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
    public partial class Categorias : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
