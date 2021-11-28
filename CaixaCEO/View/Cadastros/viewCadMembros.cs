using CaixaCEO.Controller;
using CaixaCEO.Funcoes;
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
    public partial class viewCadMembros : Form
    {
        public viewCadMembros()
        {
            InitializeComponent();
        }

        private void viewCadMembros_Load(object sender, EventArgs e)
        {
            MembrosController membrosController = new MembrosController();
            txtIdMembro.Text = membrosController.buscar().ToString();

            CargosController cargosController = new CargosController();
            cmbCargos.DataSource = cargosController.retornaCargos();
            cmbCargos.DisplayMember = "nome";
            cmbCargos.ValueMember = "id";

            this.carregaComboMembros();
        }

        private void carregaComboMembros()
        {
            MembrosController membrosController = new MembrosController();

            List<membros> listMembros = new List<membros>();
            listMembros = membrosController.retornaMembros();

            cmbMembros.DataSource = listMembros;
            cmbMembros.DisplayMember = "nome";
            cmbMembros.ValueMember = "id";
        }

        private void cmbMembros_SelectedIndexChanged(object sender, EventArgs e)
        {
            MembrosController membrosController = new MembrosController();

            if (cmbMembros.SelectedIndex >= 1)
            {
                List<membros> membro = new List<membros>();
                membro = membrosController.retornaMembros(cmbMembros.SelectedValue);

                txtNomeMembro.Text = membro[0].nome;
                txtDataNascimento.Text = membro[0].data_nascimento.ToString("dd/MM/yyyy");
                txtIdMembro.Text = membro[0].id.ToString();

                TimeSpan date = Convert.ToDateTime(DateTime.Now) - Convert.ToDateTime(membro[0].data_nascimento.ToString("dd/MM/yyyy"));
                int totalDias = date.Days;
                int idade = totalDias / 365;

                lblIdade.Text = idade.ToString();
                cmbCargos.SelectedValue = membro[0].cargos.id;

            }
            else
            {
                Funcoes.Funcoes.limpaCampos(grpMembros);
                txtIdMembro.Text = membrosController.buscar().ToString();
            }
        }

        private void btnSalvarMembro_Click(object sender, EventArgs e)
        {
            MembrosController membrosController = new MembrosController();

            cargos cargo = new cargos();
            cargo.id = (int)cmbCargos.SelectedValue;
            cargo.nome = cmbCargos.SelectedText;

            membros membro = new membros();
            membro.nome = txtNomeMembro.Text;
            membro.data_nascimento = Convert.ToDateTime(txtDataNascimento.Text);
            membro.id_cargo = cargo.id;
            membro.cargos = cargo;

            Funcoes.Funcoes.limpaCampos(grpMembros);

            if (membrosController.salvar(membro))
            {
                lblMensagem.ForeColor = Color.Green;
                lblMensagem.Text = "Salvo com sucesso";
            }
            else
            {
                lblMensagem.ForeColor = Color.Red;
                lblMensagem.Text = "Erro ao salvar";
            }

            txtIdMembro.Text = membrosController.buscar().ToString();
            this.carregaComboMembros();
        }
    }
}
