using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entidades;

namespace ClienteTelefono.Registros
{
    public partial class RegistrosTiposTelefonos : Form
    {
        public RegistrosTiposTelefonos()
        {
            InitializeComponent();
        }

        Utilidades u = new Utilidades();
        TiposTelefonos tpt = new TiposTelefonos();
        private void Idbutton_Click(object sender, EventArgs e)
        {
            Pasar(TipoTelefonoBll.Buscar(u.StringToInt(IdtextBox.Text)));
        }

        private void Pasar(TiposTelefonos tp)
        {
            var tpt = TipoTelefonoBll.Buscar(u.StringToInt(IdtextBox.Text));
            IdtextBox.Text = tp.TipoId.ToString();
            DescripciontextBox.Text = tp.Descripcion;
            ClientedataGridView.DataSource = null;
            ClientedataGridView.DataSource = tp.Clientes;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            IdtextBox.Clear();
            DescripciontextBox.Clear();
            ClientedataGridView.DataSource = null;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            TiposTelefonos tipotele = new TiposTelefonos();
            LlenarClase(tipotele);
            TipoTelefonoBll.Guardar(tipotele);
            MessageBox.Show("Guardado con exito!!!");
        }

        private void LlenarClase(TiposTelefonos tpt)
        {
            tpt.Descripcion = DescripciontextBox.Text;
            tpt.Telefono = TelefonotextBox.Text;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            TipoTelefonoBll.Eliminar(u.StringToInt(IdtextBox.Text));
            MessageBox.Show("Eliminado con exito!!!");
        }

       private void LlenarCombo()
        {
            ClientecomboBox.DataSource = ClienteBll.GetLista();
            ClientecomboBox.ValueMember = "EstudianteId";
            ClientecomboBox.DisplayMember = "Nombres";
        }

        private void RegistrosTiposTelefonos_Load(object sender, EventArgs e)
        {
            LlenarCombo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tpt.Clientes.Add(new Clientes((int)ClientecomboBox.SelectedValue, ClientecomboBox.Text));
            ClientedataGridView.DataSource = null;
            ClientedataGridView.DataSource = tpt.Clientes;
        }
    }
}

