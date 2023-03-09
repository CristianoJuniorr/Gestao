
using DAL;
using Models;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class UsuarioBLL
    {
        public void Inserir(Usuario _usuario)
        {
            if (_usuario.NomeUsuario.Length <= 3 || _usuario.NomeUsuario.Length >= 50)
                throw new Exception("O nome de usuário deve ter mais de três caracteres.");

            if (_usuario.NomeUsuario.Contains(" "))
                throw new Exception("O nome de usuário não pode conter espaço em branco.");

            if (_usuario.Senha.Contains("1234567"))
                throw new Exception("Não é permitido um número sequencial.");

            if (_usuario.Senha.Length < 7 || _usuario.Senha.Length > 11)
                throw new Exception("A senha deve ter entre 7 e 11 caracteres.");

            //TODO: Validar se já existe um usuário com nome existente.

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Inserir(_usuario);
        }
       
        public Usuario BuscarPorNomeUsuario(string _nomeUsuario)
        {
            if (String.IsNullOrEmpty(_nomeUsuario))
                throw new Exception("Informe o nome do usuário.");
           
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarPorNomeUsuario(_nomeUsuario);
           
        }
        public void Alterar(Usuario _alterar)
        {
            if (_alterar.Senha.Length <= 3 || _alterar.Senha.Length >= 50)
                throw new Exception("Ocorreu um erro ao tentar alterar um usuário.");


            //TODO: Validar se o nome é menor ou igual a 3

            UsuarioDAL usuarioDal = new UsuarioDAL();
            usuarioDal.Alterar(_alterar);
        }
        public void Excluir(Usuario _excluir)
        {

            UsuarioDAL usuarioDal = new UsuarioDAL();
            usuarioDal.Excluir(_excluir);
        }
        public List<Usuario> BuscarTodos()
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarTodos();
        }
    }
}