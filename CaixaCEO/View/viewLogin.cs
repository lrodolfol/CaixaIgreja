using CaixaCEO.Model.Entidade;
using CaixaCEO.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CaixaCEO
{
    public partial class viewLogin : Form
    {
        private usuarios user;
        Thread trMdi;
        public viewLogin()
        {
            InitializeComponent();
        }

        private void viewLogin_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            txtUser.Focus();
        }

        private void btnAcces_Click(object sender, EventArgs e)
        {
            EntidadeLogin login = new EntidadeLogin();
            login.Usuario = txtUser.Text;
            login.Senha = txtPassword.Text;

            user = new usuarios();
            user = login.logar();

            if(user.nome != null && user.senha != null && user.ativo == true)
            {
                this.Close();
                trMdi = new Thread(abrirviewMDI);
                trMdi.SetApartmentState(ApartmentState.STA);
                trMdi.Start();
            }
            else if(user.nome != null && user.senha != null && user.ativo == false)
            {
                lblMensagem.Text = "Usuário sem permissão para acesso";
            }
            else
            {
                lblMensagem.Text = "Usuário ou senha inválidos ou Inexistente";
            }
            
        }

        private void abrirviewMDI(object obj)
        {
            Application.Run(new viewMDI(user.nome));
        }

    }
}
