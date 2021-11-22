using CaixaCEO.View.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CaixaCEO.View
{
    public partial class viewMDI : Form
    {
        protected string usuario;

        public viewMDI(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario.ToUpper();
            string tituloMdi = String.Format( "{0} - Bem vindo(a) {1}", this.Text, this.usuario);
            this.Text = tituloMdi;
        }

        private void membrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewCadCargo cadCargo = new viewCadCargo();
            cadCargo.Show();
        }
    }
}
