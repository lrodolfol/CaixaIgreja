using System.Linq;

namespace CaixaCEO.Model.Entidade
{
    class EntidadeLogin
    {
        private string usuario;
        public string Usuario
        {
            get { return this.usuario;  }
            set { this.usuario = value;  }
        }

        private string senha;
        public string Senha
        {
            get { return this.senha; }
            set { this.senha = value; }
        }

        private bool ativo;
        public bool Ativo
        {
            get { return this.ativo;  }
            set { this.ativo = value; }
        }
        
        public usuarios logar()
        {
            usuarios user = new usuarios();
            using (AppDB context = new AppDB())
            {
                var n = from u in context.usuarios
                        where u.nome == this.usuario
                        && u.senha == this.senha
                        select u;

                foreach(usuarios us in n)
                {
                    user.ativo = us.ativo;
                    user.nome = us.nome;
                    user.senha = us.senha;
                }

            }
            return user;
        }

    }
}
