using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TiposTelefonos
    {
        [Key]
        public int TipoId { get; set; }
        public string Descripcion { get; set; }
        public string ClientesTelefonos { get; set; }
        public string Telefono { get; set; }

        public virtual List<Clientes> Clientes { get; set; }
        public TiposTelefonos()
        {
            this.Clientes = new List<Clientes>();
        }
        public TiposTelefonos(int tipoid, string Descripcion, string clientestelefonos)
        {
            this.TipoId = tipoid;
            this.Descripcion = Descripcion;
            this.ClientesTelefonos = clientestelefonos;
            this.Clientes = new List<Clientes>();
        }
    }
}
