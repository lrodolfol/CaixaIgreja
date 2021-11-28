using CaixaCEO.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaCEO.View.Cadastros
{
    public partial class viewCadCargo : Form
    {
        public viewCadCargo()
        {
            InitializeComponent();
        }

        private void btnSalvarCargo_Click(object sender, EventArgs e)
        {
            CargosController cargosController = new CargosController();
            if (cargosController.salvar(txtNomeCargo.Text, txtDerscricaoCargo.Text, int.Parse(txtIdCargo.Text)))
            {
                limpaCampos();

                string msg = string.Format("Cargo de {0} salvo com sucesso", txtNomeCargo.Text);
                lblMensagemCargos.ForeColor = Color.Green;
                lblMensagemCargos.Text = msg;
                
                txtIdCargo.Text = cargosController.buscar().ToString();
                carregaComboCargos();
            }
            else
            {
                lblMensagemCargos.ForeColor = Color.Red;
                string msg = string.Format("Erro ao salvar novo cargo. {0}", cargosController.mensagem);
                lblMensagemCargos.Text = msg;
            }
        }

        private void viewCadCargo_Load(object sender, EventArgs e)
        {
            CargosController cargosController = new CargosController();
            txtIdCargo.Text = cargosController.buscar().ToString();

            carregaComboCargos();
        }

        private void carregaComboCargos()
        {
            CargosController cargosController = new CargosController();

            List<cargos> listCargos = new List<cargos>();
            listCargos = cargosController.retornaCargos();

            cmbCargos.DataSource = listCargos;
            cmbCargos.DisplayMember = "nome";
            cmbCargos.ValueMember = "id";
        }

        private void cmbCargos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargosController cargosController = new CargosController();
            if (cmbCargos.SelectedIndex >= 1)
            {
                List<cargos> cargo = new List<cargos>();
                cargo = cargosController.retornaCargos(cmbCargos.SelectedValue);

                txtNomeCargo.Text = cargo[0].nome;
                txtDerscricaoCargo.Text = cargo[0].descricao;
                txtIdCargo.Text = cargo[0].id.ToString();
            }
            else
            {
                limpaCampos();
                txtIdCargo.Text = cargosController.buscar().ToString();
            }
        }

        private void limpaCampos()
        {
            foreach (Control c in groupBoxCargos.Controls)
            {
                if (c is TextBox || c is RichTextBox || c is Label) { c.Text = ""; } //LIMPA TEXTBOX E RICHTEXTBOX
                if (c is ComboBox) { (c as ComboBox).SelectedIndex = 0; } //ZERA COMBOBOX
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(cmbCargos.SelectedIndex <= 0) { return;  }
            DialogResult res = MessageBox.Show("Excluir cargo selecionado?", "Confirma", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                CargosController cargosController = new CargosController();
                cargos cargo = new cargos();
                cargo.id = (int)cmbCargos.SelectedValue;
                cargosController.excluirCargo(cargo);

                this.limpaCampos();
                this.carregaComboCargos();

                lblMensagemCargos.ForeColor = Color.Green;
                lblMensagemCargos.Text = "Cargo excluido com sucesso";
            }
            else
            {
                lblMensagemCargos.ForeColor = Color.Red;
                lblMensagemCargos.Text = "Erro ao excluir o cargo. Tente novamente";
            }

        }
    }
}
