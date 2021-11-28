using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaCEO.Model.DAO
{
    class MembrosDAO
    {
        private bool condicao;

        public int buscar()
        {
            int idMembro = 0;
            using (AppDB context = new AppDB())
            {
                var n = (from u in context.membros orderby u.id descending select u).Take(1);
                foreach (var u in n)
                {
                    try
                    {
                        idMembro = u.id;
                    }
                    catch (Exception)
                    {
                        idMembro = 0;
                    }
                }
            }

            return idMembro;
        }

        public List<membros> retornaMembros(object idMembro = null)
        {
            List<membros> listMembros = new List<membros>();
            using (AppDB context = new AppDB())
            {
                membros membro = new membros();
                cargos cargo = new cargos();

                //PODE BUSCAR O MEMBRO PELO ID DO PARAMETRO, OU RETORNA TODOS OS MEMBROS
                if (idMembro != null)
                {
                    var nInner = from m in context.membros
                                 join c in context.cargos on m.id_cargo equals c.id
                                 where m.id == (int)idMembro
                                 select new
                                 {
                                     idCargo = c.id,
                                     nomeCargo = c.nome,
                                     descricaoCargo = c.descricao,

                                     IdMemb = m.id,
                                     nomeMembro = m.nome,
                                     dataNasc = m.data_nascimento
                                 };

                    foreach (var mc in nInner)
                    {
                        cargo = new cargos();
                        cargo.nome = mc.nomeCargo;
                        cargo.descricao = mc.descricaoCargo;
                        cargo.id = mc.idCargo;

                        membro = new membros();
                        membro.nome = mc.nomeMembro;
                        membro.data_nascimento = mc.dataNasc;
                        membro.id = mc.IdMemb;
                        membro.cargos = cargo;

                        listMembros.Add(membro);
                    }
                }
                else
                {
                    //ADICIONO O 1º ITEM DE CARGO VAZIO PARA RETORNAR PARA VIEW
                    //E PREENCHER NO COMBOBOX DE FORMA VAZIA
                    listMembros.Add(membro);

                    var nInner = from m in context.membros
                                 join c in context.cargos on m.id_cargo equals c.id
                                 select new
                                 {
                                     idCargo = c.id,
                                     nomeCargo = c.nome,
                                     descricaoCargo = c.descricao,

                                     IdMemb = m.id,
                                     nomeMembro = m.nome,
                                     dataNasc = m.data_nascimento
                                 };

                    foreach (var mc in nInner)
                    {
                        cargo = new cargos();
                        cargo.nome = mc.nomeCargo;
                        cargo.descricao = mc.descricaoCargo;
                        cargo.id = mc.idCargo;

                        membro = new membros();
                        membro.nome = mc.nomeMembro;
                        membro.data_nascimento = mc.dataNasc;
                        membro.id = mc.IdMemb;
                        membro.cargos = cargo;

                        listMembros.Add(membro);
                    }
                }
            }

            return listMembros;
        }


        public bool salvar(membros membro)
        {
            using (AppDB context = new AppDB())
            {
                try
                {
                    //TENTA ENCONTRAR UM MEMBRO COM O ID PASSADO PARA ATUALIZAR
                    //SENÃO, SERÁ CRIADO UM NOVO.
                    membros memb = context.membros.Find(membro.id);
                    if (memb != null)
                    {
                        memb.nome = membro.nome;
                        memb.data_nascimento = membro.data_nascimento;
                        memb.cargos = membro.cargos;
                    }
                    else
                    {
                        memb = context.membros.Create();
                        memb.nome = membro.nome;
                        memb.data_nascimento = membro.data_nascimento;
                        memb.cargos = membro.cargos;
                        context.membros.Add(memb);
                    }

                    context.SaveChanges();
                    this.condicao = true;
                }
                catch (Exception)
                {
                    this.condicao = false;
                }
            }

            return condicao;
        }
    }
}

