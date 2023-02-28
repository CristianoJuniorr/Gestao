using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;


namespace BLL
{
    public class GrupoUsuarioBLL
    {
        public void Inserir(GrupoUsuario grupoUsuario)
        {
            if (grupoUsuario.NomeGrupo.Length <= 3 || grupoUsuario.NomeGrupo.Length >= 50)
                throw new Exception("O nome deve ter mais de três caracteres.");


            //TODO: Validar se já existe um usuário com nome existente.

            GrupoUsuarioDal grupoUsuarioDal = new GrupoUsuarioDal();
            grupoUsuarioDal.Inserir(grupoUsuario);
        }
        
        public void Alterar(GrupoUsuario _alterar)
        {
            if (_alterar.NomeGrupo.Length <= 3 || _alterar.NomeGrupo.Length >= 50)
                throw new Exception("O nome deve ter mais de três caracteres.");


            //TODO: Validar se já existe um usuário com nome existente.

            GrupoUsuarioDal grupoUsuarioDal = new GrupoUsuarioDal();
            grupoUsuarioDal.Alterar(_alterar);
        }

        public void Excluir(GrupoUsuario _excluir)
        {
            GrupoUsuarioDal grupoUsuarioDal = new GrupoUsuarioDal();
            grupoUsuarioDal.Excluir(_excluir);
        }

        public List<GrupoUsuario> BuscarTodos()
        {
            GrupoUsuarioDal grupoUsuarioDAL = new GrupoUsuarioDal();
            return grupoUsuarioDAL.BuscarTodos();
        }


    }

}
