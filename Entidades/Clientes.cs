using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Clientes
    {
        private int selectedValue;
        private string text;

        [Key]
        public int ClienteId { get; set; }
        public string  Nombres { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int LimiteCredito { get; set; }

        public virtual List<TiposTelefonos> TipoTelefono { get; set; }
        public Clientes()
        {
            this.TipoTelefono = new List<TiposTelefonos>();
        }
        public Clientes(int clienteid, string nombres, int limitecredito, DateTime fechanacimiento)
        {
            this.ClienteId = clienteid;
            this.Nombres = nombres;
            this.FechaNacimiento = fechanacimiento;
            this.LimiteCredito = limitecredito;
            this.TipoTelefono = new List<TiposTelefonos>();
        }

        public Clientes(int selectedValue, string text)
        {
            this.selectedValue = selectedValue;
            this.text = text;
        }
    }
}
