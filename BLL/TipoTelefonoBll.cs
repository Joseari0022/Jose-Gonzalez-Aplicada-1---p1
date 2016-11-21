using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;

namespace BLL
{
    public class TipoTelefonoBll
    {
        public static void  Guardar(TiposTelefonos tpt)
        {
            try
            {
                var db = new Parcial1Db();

                db.TipoTelefonos.Add(tpt);
                var gp = db.TipoTelefonos.Add(tpt);
                foreach (var clie in tpt.Clientes)
                {
                    db.Entry(clie).State = EntityState.Unchanged;
                }
                db.SaveChanges();
                db.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static TiposTelefonos Buscar(int id)
        {
            TiposTelefonos tpt = new TiposTelefonos();
            var db = new Parcial1Db();
            return tpt = db.TipoTelefonos.Find(id);
        }

        public static void Eliminar(int id)
        {
            var db = new Parcial1Db();
            TiposTelefonos tpt = db.TipoTelefonos.Find(id);

            db.TipoTelefonos.Remove(tpt);
            db.SaveChanges();
        }
    }
}
