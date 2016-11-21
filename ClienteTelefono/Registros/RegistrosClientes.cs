using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using BLL;

namespace ClienteTelefono
{
    public partial class RegistrosClientes : Form
    {
        public RegistrosClientes()
        {
            InitializeComponent();
        }

        Utilidades u = new Utilidades();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Idbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void LlenarCliente(Clientes cl)
        {
            var es = ClienteBll.Buscar(u.StringToInt(IdtextBox.Text));
            IdtextBox.Text = cl.ClienteId.ToString();
            NombretextBox.Text = cl.Nombres;
            cl.FechaNacimiento = FechaNacimientodateTimePicker.Value;
            TiposTelefonosdataGridView.DataSource = null;
            TiposTelefonosdataGridView.DataSource = cl.TipoTelefono;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            IdtextBox.Clear();
            NombretextBox.Clear();
            TiposTelefonosdataGridView.DataSource = null;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Clientes clie = new Clientes();
            LlenarCliente(clie);
            ClienteBll.Guardar(clie);
            MessageBox.Show("Guardado con exito!!!");
        }

        private void LlenarClase(Clientes cliente)
        {
            cliente.Nombres = NombretextBox.Text;
            cliente.LimiteCredito = Convert.ToInt32(LimiteCreditotextBox.Text);
            cliente.FechaNacimiento = FechaNacimientodateTimePicker.Value;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            ClienteBll.Eliminar(u.StringToInt(IdtextBox.Text));
            MessageBox.Show("Eliminado con exito!!!");
        }
    }
}
