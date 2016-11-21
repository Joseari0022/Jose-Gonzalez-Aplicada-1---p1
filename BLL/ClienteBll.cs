using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;

namespace BLL
{
    public class ClienteBll
    {
        public static void Guardar(Clientes cl)
        {
            try
            {
                Parcial1Db db = new Parcial1Db();

                db.Clientes.Add(cl);
                db.SaveChanges();
                db.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Clientes Buscar(int id)
        {
            Clientes cliente = new Clientes();
            var db = new Parcial1Db();
            return cliente = db.Clientes.Find(id);
        }

        public static void Eliminar(int id)
        {
            var db = new Parcial1Db();
            Clientes cliente = db.Clientes.Find(id);
            db.Clientes.Remove(cliente);
            db.SaveChanges();
        }

        public static List<Clientes> GetLista()
        {
            var lista = new List<Clientes>();
            var db = new Parcial1Db();
            lista = db.Clientes.ToList();
            return lista;
        }
    }
}
