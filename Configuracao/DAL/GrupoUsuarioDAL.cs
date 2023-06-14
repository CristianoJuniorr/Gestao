using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GrupoUsuarioDal
    {
        public void Inserir(GrupoUsuario grupoUsuario)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"INSERT INTO GrupoUsuario(GrupoUsuario)
                                  VALUES (@GrupoUsuario)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@GrupoUsuario", grupoUsuario.NomeGrupo);


                cn.Open();
                cmd.ExecuteScalar();


            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um novo Grupo no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }

        }

        public void Alterar(GrupoUsuario _alterar)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"UPDATE GrupoUsuario set GrupoUsuario = @GrupoUsuario where id = @id;";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@GrupoUsuario", _alterar.NomeGrupo);
                cmd.Parameters.AddWithValue("@id", _alterar.Id);


                cn.Open();
                cmd.ExecuteScalar();


            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar um Grupo no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(int _idGrupoUsuario, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {

                using (SqlCommand cmd = new SqlCommand("Delete From GrupoUsuario where Id = @Id"))
                {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _idGrupoUsuario);
            try
            {
                        if(_transaction == null)
                        {
                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }

                cmd.Transaction= transaction;
                cmd.Connection = transaction.Connection;

                RemoverTodasPermissoes(_idGrupoUsuario, _transaction);
                RemoverTodosUsuarios(_idGrupoUsuario, _transaction);

                cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();


            }
            catch (Exception ex)
            {
                        transaction.Rollback();
                throw new Exception("Ocorreu um erro ao tentar excluir um Grupo no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();                   
                }
            }
            }
        }
        public void RemoverTodosUsuarios(int _idGrupoUsuario, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {

                using (SqlCommand cmd = new SqlCommand("DELETE FROM UsuarioGrupoUsuario Where Id_GrupoUsuario = @Id "))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Id", _idGrupoUsuario);
                    try
                    {
                        if (_transaction == null)
                        {
                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }

                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;

                        
                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();


                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar excluir um Usuario do Grupo no banco: " + ex.Message);
                    }
                    finally
                    {
                        cn.Close();
                    }
                }
            }
        }
        public void RemoverTodasPermissoes(int _idGrupoUsuario, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {

                using (SqlCommand cmd = new SqlCommand("DELETE FROM PermissaoGrupoUsuario Where Id_GrupoUsuario = @Id "))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Id", _idGrupoUsuario);
                        if (_transaction == null)
                        {
                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }

                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;

                    try
                    {
                       
                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();


                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar excluir uma Permissao do Grupo no banco: " + ex.Message);
                    }
                    finally
                    {
                        cn.Close();
                    }
                }
            }
        }

        public GrupoUsuario BuscarPorId(int _id)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            GrupoUsuario grupoUsuario = new GrupoUsuario();

            try

            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, GrupoUsuario FROM GrupoUsuario WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Id", _id);
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        grupoUsuario = new GrupoUsuario();
                        grupoUsuario.Id = Convert.ToInt32(rd["Id"]);
                        grupoUsuario.NomeGrupo = rd["GrupoUsuario"].ToString();

                    }
                }
                return grupoUsuario;

            }
            catch (Exception ex)
            {
                // Console.WriteLine(String.Format("Ocorreu o seguinte erro: {0} ao tentar buscar no banco "));

                throw new Exception("Ocorreu um erro ao tentar buscar um Grupo: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
            public List <GrupoUsuario> BuscarPorIdUsuario(int _idUsuario)
        {  
            List<GrupoUsuario> grupoUsuarios = new List<GrupoUsuario>();
            GrupoUsuario grupoUsuario = new GrupoUsuario();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT GrupoUsuario.Id, GrupoUsuario.GrupoUsuario From GrupoUsuario INNER JOIN UsuarioGrupoUsuario ON GrupoUsuario.Id = UsuarioGrupoUsuario.Id_GrupoUsuario WHERE Id_Usuario = @Id_usuario;";
                cmd.Parameters.AddWithValue("@Id_usuario", _idUsuario);
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        grupoUsuario = new GrupoUsuario();
                        grupoUsuario.Id = Convert.ToInt32(rd["Id"]);
                        grupoUsuario.NomeGrupo = rd["GrupoUsuario"].ToString();
                        grupoUsuarios.Add(grupoUsuario);
                    }

                }
                return grupoUsuarios;
            }
            catch (Exception )
            {

                throw new Exception("Ocorreu um erro ao tentar fazer à busca de um grupo.  ");
            }

           
        }

        public GrupoUsuario BuscarPorNomeGrupoUsuario(string _nomeGrupoUsuario)
        {
            GrupoUsuario grupoUsuario = new GrupoUsuario();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
           

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, GrupoUsuario FROM GrupoUsuario WHERE GrupoUsuario like @GrupoUsuario";
                cmd.Parameters.AddWithValue("@GrupoUsuario", "%" + _nomeGrupoUsuario + "%");
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        grupoUsuario = new GrupoUsuario();
                        grupoUsuario.Id = Convert.ToInt32(rd["Id"]);
                        grupoUsuario.NomeGrupo = rd["GrupoUsuario"].ToString();

                    }
                    else
                    {
                        throw new Exception("Grupo não encontrado. ");
                    }
                }
            }
            catch (Exception )
            {

                throw new Exception("Ocorreu um erro ao tentar fazer busca de Descrição. ");
            }

            return grupoUsuario;

        }
       

        public List<GrupoUsuario> BuscarTodos()
        {
            List<GrupoUsuario> grupoUsuarios = new List<GrupoUsuario>();
            GrupoUsuario grupoUsuario;
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, GrupoUsuario FROM GrupoUsuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        grupoUsuario = new GrupoUsuario();
                        grupoUsuario = new GrupoUsuario();
                        grupoUsuario.Id = Convert.ToInt32(rd["Id"]);
                        grupoUsuario.NomeGrupo = rd["GrupoUsuario"].ToString();
                        grupoUsuario.Permissoes = new PermissaoDal().BuscarPorIdGrupoUsuario(grupoUsuario.Id);
                        grupoUsuarios.Add(grupoUsuario);
                    }
                }
                return grupoUsuarios;

            }
            catch (Exception )
            {
                // Console.WriteLine(String.Format("Ocorreu o seguinte erro: {0} ao tentar buscar no banco "));

                throw new Exception("Ocorreu um erro ao tentar buscar todos os Grupos. ");
            }
            finally
            {
                cn.Close();
            }
            
        }

        public void RemoverPermisao(int idGrupoUsuario, int idPermissao)
        {


            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"Delete from PermissaoGrupoUsuario Where Id_GrupoUsuario = @idGrupoUsuario AND Id_Permissao = @IdPermissao";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdGrupoUsuario", idGrupoUsuario);
                cmd.Parameters.AddWithValue("@IdPermissao", idPermissao);


                cn.Open();
                cmd.ExecuteScalar();


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
    }


    }

