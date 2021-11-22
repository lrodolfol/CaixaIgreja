using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaCEO.Model.DAO
{
    class CargosDAO
    {
        public int buscar()
        {
            using (AppDB context = new AppDB())
            {
                var n = (from u in context.cargos orderby u.id descending select u).Take(1);
                foreach (var u in n)
                {
                    try
                    {
                        return u.id;
                    }
                    catch (Exception)
                    {
                        return 0;
                    }
                }

            }

            return 0;
        }

        public bool salvar(cargos cargo)
        {
            using (AppDB context = new AppDB())
            {
                try
                {
                    //TENTA ENCONTRAR UM CARGO COM O ID PASSADO PARA ATUALIZAR
                    //SENÃO, SERÁ CRIADO UM NOVO.
                    cargos carg = context.cargos.Find(cargo.id);
                    if (carg != null)
                    {
                        carg.nome = cargo.nome;
                        carg.descricao = cargo.descricao;
                    }
                    else
                    {
                        carg = context.cargos.Create();
                        carg.nome = cargo.nome;
                        carg.descricao = cargo.descricao;
                        context.cargos.Add(carg);
                    }

                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public List<cargos> retornaCargos(object idCargo = null)
        {
            using (AppDB context = new AppDB())
            {
                List<cargos> listCargos = new List<cargos>();
                cargos cargo = new cargos();

                //PODE BUSCAR O CARGO PELO ID DO PARAMETRO, OU RETORNA TODOS OS CARGOS
                if (idCargo != null)
                {
                    cargo = context.cargos.Find(idCargo);
                    listCargos.Add(cargo);
                }
                else
                {
                    //ADICIONO O 1º ITEM DE CARGO VAZIO PARA RETORNAR PARA VIEW
                    //E PREENCHER NO COMBOBOX DE FORMA VAZIA
                    listCargos.Add(cargo);

                    var n = from u in context.cargos
                            select u;
                    foreach (var u in n)
                    {
                        cargo = new cargos();
                        cargo.nome = u.nome;
                        cargo.descricao = u.descricao;
                        cargo.id = u.id;
                        listCargos.Add(cargo);
                    }
                }
                return listCargos;
            }
        }
    }
}
