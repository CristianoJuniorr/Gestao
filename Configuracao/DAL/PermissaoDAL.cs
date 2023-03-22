using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class PermissaoDal
    {
        public void AdicionarPermissao(int _idPermissao, int _idGrupoUsuario)
        {

            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"INSERT INTO PermissaoGrupoUsuario(Id_Permissao, Id_GrupoUsuario)
                                  VALUES (@Id_Permissao, @Id_GrupoUsuario)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id_Permissao", _idPermissao);
                cmd.Parameters.AddWithValue("@Id_GrupoUsuario", _idGrupoUsuario);


                cn.Open();
                cmd.ExecuteScalar();


            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um grupo a esse usuário. " + ex.Message);
            }
            finally
            {
                cn.Close();
            }


        }




        public void Alterar(Permissao _alterar)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"UPDATE Permissao set Descricao = @Descricao where id = @id;";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Descricao", _alterar.Descricao);
                cmd.Parameters.AddWithValue("@id", _alterar.Id);


                cn.Open();
                cmd.ExecuteScalar();


            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar uma descrição no banco. " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(Permissao _excluir)
        {

            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = cn;
                cmd.CommandText = @"Delete From Permissao where id = @id;";

                cmd.CommandType = System.Data.CommandType.Text;
                //  cmd.Parameters.AddWithValue("@Descricao", _excluir.Descricao);
                cmd.Parameters.AddWithValue("@id", _excluir.Id);


                cn.Open();
                cmd.ExecuteScalar();


            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir uma descrição no banco. " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public Permissao BuscarPorNomeDescricao(string _nomeDescricao)
        {
            Permissao permissao = new Permissao();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Descricao FROM Permissao WHERE Descricao like @Descricao";
                cmd.Parameters.AddWithValue("@Descricao", "%" + _nomeDescricao + "%");
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        permissao = new Permissao();
                        permissao.Id = Convert.ToInt32(rd["Id"]);
                        permissao.Descricao = rd["Descricao"].ToString();

                    }
                    else
                    {
                        throw new Exception("Permissão não encontrada. ");
                    }
                }
            }
            catch (Exception ex)
            {

                throw; new Exception("Ocorreu um erro ao tentar buscar uma permissão. ");
            }

            return permissao;

        }
        public bool ExisteRelacioamento(int _idPermissao, int _idGrupoUsuario)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"Select 1 AS Retorno from PermissaoGrupoUsuario Where Id_Permissao = @Id_Permissao AND Id_GrupoUsuario = @Id_GrupoUsuario";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id_Permissao", _idPermissao);
                cmd.Parameters.AddWithValue("@Id_GrupoUsuario", _idGrupoUsuario);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        return true;
                    }
                }
                return false;
                //cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir um Usuario no banco. " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Permissao> BuscarPorIdGrupoUsuario(int _idUsuario )
        {
            List<Permissao> permissaos = new List<Permissao>();
            Permissao permissao = new Permissao();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Permissao.Id, Permissao.Descricao FROM Permissao
                INNER JOIN	PermissaoGrupoUsuario ON Permissao.Id = PermissaoGrupoUsuario.Id_Permissao
                WHERE Id_GrupoUsuario = @IdGrupo;";

                cmd.Parameters.AddWithValue("@IdGrupo", _idUsuario);
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        permissao = new Permissao();
                        permissao.Id = Convert.ToInt32(rd["Id"]);
                        permissao.Descricao = rd["Descricao"].ToString();
                        permissaos.Add(permissao);
                    }

                }
                return permissaos;
            }
            catch (Exception ex)
            {

                throw; new Exception("Ocorreu um erro ao tentar fazer à busca de uma permissão.  ");
            }


        }

        public List<Permissao> BuscarTodos()
        {
            List<Permissao> permissaos = new List<Permissao>();
            Permissao permissao;
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Descricao FROM Permissao";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        permissao = new Permissao();
                        permissao.Id = Convert.ToInt32(rd["Id"]);
                        permissao.Descricao = rd["Descricao"].ToString();
                        permissaos.Add(permissao);
                    }
                }

            }
            catch (Exception ex)
            {
                // Console.WriteLine(String.Format("Ocorreu o seguinte erro: {0} ao tentar buscar no banco "));

                throw new Exception("Ocorreu um erro ao tentar buscar todas as descrições: ");
            }
            finally
            {
                cn.Close();
            }
            return permissaos;
        }

    }
}
