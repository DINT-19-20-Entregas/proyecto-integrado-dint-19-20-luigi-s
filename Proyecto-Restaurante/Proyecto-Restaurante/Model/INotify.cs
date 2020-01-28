using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Restaurante.Model
{
    public partial class Categorias : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }

    public partial class ElementosCarta : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }

    public partial class Pedidos : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
