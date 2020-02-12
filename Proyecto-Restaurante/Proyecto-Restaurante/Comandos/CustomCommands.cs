using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Proyecto_Restaurante.UsersControls
{
    class CustomCommands
    {
        public static readonly RoutedUICommand Limpiar = new RoutedUICommand(
         "Limpiar",
         "Limpiar",
         typeof(CustomCommands),
         new InputGestureCollection()
         {
                new KeyGesture(Key.L, ModifierKeys.Control)
         }
       );

        public static readonly RoutedUICommand Modificar = new RoutedUICommand(
            "Modificar",
            "Modificar",
            typeof(CustomCommands),
            new InputGestureCollection()
            {
                new KeyGesture(Key.M, ModifierKeys.Control)
            }
        );
    }
}
