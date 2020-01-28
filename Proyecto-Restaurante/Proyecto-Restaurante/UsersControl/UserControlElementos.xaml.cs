﻿using Proyecto_Restaurante.Vista_Modelo;
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
    /// <summary>
    /// Lógica de interacción para UserControlElementos.xaml
    /// </summary>
    public partial class UserControlElementos : UserControl
    {
        public UserControlElementos()
        {
            InitializeComponent();
            this.DataContext = new ElementosVM();
        }
    }
}
