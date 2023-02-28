using Microsoft.VisualBasic;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DAL
{
    public class PermissaoDal
    {
        public void Inserir(Permissao _descricao)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"INSERT INTO Permissao(Descricao)
                                  VALUES (@Descricao)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Descricao", _descricao.Descricao);


                cn.Open();
                cmd.ExecuteScalar();


            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir uma descrição no banco: " + ex.Message);
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
                throw new Exception("Ocorreu um erro ao tentar alterar uma descrição no banco: " + ex.Message);
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
                throw new Exception("Ocorreu um erro ao tentar excluir uma descrição no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
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
