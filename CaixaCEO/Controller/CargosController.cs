using CaixaCEO.Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaCEO.Controller
{
    class CargosController
    {
        private CargosDAO cargosDao;
        public string mensagem { get; set; }

        public bool salvar(string nome, string descricao, int id)
        {
            if(string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(descricao))
            {
                this.mensagem = "Campos em branco";
                return false;
            }

            cargosDao = new CargosDAO();
            cargos cargo = new cargos();
            cargo.nome = nome;
            cargo.descricao = descricao;
            cargo.id = id;
            
            return (cargosDao.salvar(cargo)) ? true : false;
        }

        public int buscar()
        {
            this.cargosDao = new CargosDAO();
            int idCargo = cargosDao.buscar();

            return idCargo + 1;
        }

        public List<cargos> retornaCargos(object idCargo = null)
        {
            cargosDao = new CargosDAO();
            return cargosDao.retornaCargos(idCargo);
        }

        public bool excluirCargo(cargos cargo)
        {
            cargosDao = new CargosDAO();
            return cargosDao.excluirCargos(cargo);
        }
    }
}
