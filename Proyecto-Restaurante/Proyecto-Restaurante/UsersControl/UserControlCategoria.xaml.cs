
﻿using Proyecto_Restaurante.Servicios;

﻿using Proyecto_Restaurante.Vista_Modelo;

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

namespace Proyecto_Restaurante.UsersControls
{
    /// <summary>
    /// Lógica de interacción para UserControlCategoria.xaml
    /// </summary>
    public partial class UserControlCategoria : UserControl
    {
        private ObservableCollection<Categorias> ListaCategorias { get; set; }
        private Categorias c;

        public UserControlCategoria()
        {
            InitializeComponent();
            this.DataContext = new CategoriaVM();
            c = new Categorias();
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            (this.DataContext as CategoriaVM).Añadir(c);
            (this.DataContext as CategoriaVM).Guardar();
        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            c.nombreCategoria = nombreCategoriaTextBox.Text;
            c.imagen = ImagenTextBox.Text;
            if (!(this.DataContext as CategoriaVM).Existe(c) || c.imagen != null)
                e.CanExecute = true;
            else
                e.CanExecute = false;
        }

        private void CommandBinding_Executed_1(object sender, ExecutedRoutedEventArgs e)
        {
            (this.DataContext as CategoriaVM).Eliminar(c);
            (this.DataContext as CategoriaVM).Guardar();
        }

        private void CommandBinding_CanExecute_1(object sender, CanExecuteRoutedEventArgs e)
        {
            c = (Categorias)CategoriasDataGrid.SelectedItem;
            if (c.elementosCarta.Count != 0)
                e.CanExecute = false;
            else
                e.CanExecute = true;
        }
    }
}
