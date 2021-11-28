using CaixaCEO.Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaCEO.Controller
{
    class MembrosController
    {
        MembrosDAO membroDao; 

        public int buscar()
        {
            this.membroDao = new MembrosDAO();
            int idMembro = membroDao.buscar();

            return idMembro + 1;
        }

        public List<membros> retornaMembros(object idMembro = null)
        {
            this.membroDao = new MembrosDAO();
            return membroDao.retornaMembros(idMembro);
        }

        public bool salvar(membros membro)
        {
            membroDao = new MembrosDAO();
            return membroDao.salvar(membro);    
        }

    }
}
