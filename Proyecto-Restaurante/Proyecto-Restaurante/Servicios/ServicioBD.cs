using Proyecto_Restaurante.Vista_Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Collections.ObjectModel;

namespace Proyecto_Restaurante.Servicios
{
    public static class ServicioBD
    {
        private static readonly Project_SQLEntities _contexto;

        static ServicioBD()
        {
            _contexto = new Project_SQLEntities();
            _contexto.elementosCarta.Load();
            _contexto.Categorias.Load();
            _contexto.Pedidos.Load();
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
