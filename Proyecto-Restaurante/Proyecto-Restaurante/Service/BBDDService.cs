using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Restaurante.Model;

namespace Proyecto_Restaurante.Servicios
{
    public static class BBDDService
    {
        private static readonly Project_SQLEntities _contexto;

        static BBDDService()
        {
            _contexto = new Project_SQLEntities();
            _contexto.Categorias.Load();
            _contexto.elementosCarta.Load();
            _contexto.Pedidos.Load();
        }

        private static ObservableCollection<Categorias> GetCategorias()
        {
            return _contexto.Categorias.Local;
        }

        public static ObservableCollection<elementosCarta> GetElementos()
        {
            return _contexto.elementosCarta.Local;
        }

        private static ObservableCollection<Pedidos> getPedidos()
        {
            return _contexto.Pedidos.Local;
        }


    }
}
