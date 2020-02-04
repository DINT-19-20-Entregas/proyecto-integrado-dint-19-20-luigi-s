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
        private static readonly Project_SQLEntities _contexto = new Project_SQLEntities();

        static BBDDService()
        {
            _contexto.Categorias.Load();
            _contexto.elementosCarta.Load();
            _contexto.Pedidos.Load();
        }

        public static ObservableCollection<Categorias> GetCategorias()
        {
            return _contexto.Categorias.Local;
        }

        public static ObservableCollection<elementosCarta> GetElementos()
        {
            return _contexto.elementosCarta.Local;
        }

        public static ObservableCollection<Pedidos> GetPedidos()
        {
            return _contexto.Pedidos.Local;
        }

        public static ObservableCollection<elementosCarta> GetElementosCarta()
        {
            return _contexto.elementosCarta.Local;
        }

        public static ObservableCollection<Categorias> GetElementosCategorias()
        {
            return _contexto.Categorias.Local;
        }

        public static int AddPedido(Pedidos p)
        {
            _contexto.Pedidos.Add(p);
            return _contexto.SaveChanges();
        }

        public static int AddElementoCarta(elementosCarta e)
        {
            _contexto.elementosCarta.Add(e);
            return _contexto.SaveChanges();
        }

        public static int AddCategoria(Categorias c)
        {
            _contexto.Categorias.Add(c);
            return _contexto.SaveChanges();
        }

        public static int DeletePedido(Pedidos p)
        {
            _contexto.Pedidos.Remove(p);
            return _contexto.SaveChanges();
        }

        public static int DeleteElementosCarta(elementosCarta e)
        {
            _contexto.elementosCarta.Remove(e);
            return _contexto.SaveChanges();
        }

        public static int DeleteCategoria(Categorias c)
        {
            _contexto.Categorias.Remove(c);
            return _contexto.SaveChanges();
        }

        public static int UpdateDB()
        {
            return _contexto.SaveChanges();
        }
    }
}
