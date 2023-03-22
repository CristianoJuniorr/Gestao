using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public  class PermissaoBLL
    {
       
        public void Alterar(Permissao _alterar)
        {
            if (_alterar.Descricao.Length <= 3 || _alterar.Descricao.Length >= 50)
                throw new Exception("A descrição deve ter mais de três caracteres. ");


            //TODO: Validar se o nome é menor ou igual a 3

            PermissaoDal permissaoDal = new PermissaoDal();
            permissaoDal.Alterar(_alterar);
        }

        public void Excluir(Permissao _excluir)
        {

            PermissaoDal permissaoDal = new PermissaoDal();
            permissaoDal.Excluir(_excluir);
        }

        public Permissao BuscarPorNomeDescricao(string _nomeDescricao)
        {
            if (String.IsNullOrEmpty(_nomeDescricao))
                throw new Exception("Informe uma descrição válida. ");

            PermissaoDal permissaoDAL = new PermissaoDal();
            return permissaoDAL.BuscarPorNomeDescricao(_nomeDescricao);

        }

        public List<Permissao> BuscarTodos()
        {
            PermissaoDal permissaoDAL = new PermissaoDal();
            return permissaoDAL.BuscarTodos();
        }

        public void AdicionarPermissao(int _idPermissao, int _idGrupoUsuario)
        {
            if (new PermissaoDal().ExisteRelacioamento(_idPermissao, _idGrupoUsuario))
                return;
            PermissaoDal permissaoDAL = new PermissaoDal();
            permissaoDAL.AdicionarPermissao(_idPermissao, _idGrupoUsuario);
        }
    }
}
