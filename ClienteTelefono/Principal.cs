using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClienteTelefono;

namespace ClienteTelefono
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrosClientes rc = new RegistrosClientes();
            rc.MdiParent = this.MdiParent;
            rc.Show();
        }

        private void tipoTelefonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.RegistrosTiposTelefonos rt = new Registros.RegistrosTiposTelefonos();
            rt.MdiParent = this.MdiParent;
            rt.Show();
        }
    }
}
