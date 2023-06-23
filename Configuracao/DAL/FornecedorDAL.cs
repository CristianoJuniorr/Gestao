using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FornecedorDAL
    {
        public void Inserir(Fornecedor _fornecedor)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"INSERT INTO Fornecedor(Nome, Telefone, Email, Sites)
                                  VALUES (@Nome, @Telefone, @Email, @Sites)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _fornecedor.Nome);
                cmd.Parameters.AddWithValue("@Telefone", _fornecedor.Telefone);
                cmd.Parameters.AddWithValue("@Email", _fornecedor.Email);
                cmd.Parameters.AddWithValue("@Sites", _fornecedor.Site);


                cn.Open();
                cmd.ExecuteScalar();


            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um Fonecedor no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Fornecedor> BuscarTodos()
        {

            List<Fornecedor> fornecedorList = new List<Fornecedor>();
            Fornecedor fornecedor;
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try

            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Telefone, Email, Sites FROM Fornecedor";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        fornecedor = new Fornecedor();
                        fornecedor.Id = Convert.ToInt32(rd["Id"]);
                        fornecedor.Nome = rd["Nome"].ToString();
                        fornecedor.Telefone = rd["Telefone"].ToString();
                        fornecedor.Email = rd["Email"].ToString();
                        fornecedor.Site = rd["Sites"].ToString();


                        fornecedorList.Add(fornecedor);
                    }
                }
                return fornecedorList;

            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar todos os fornecedores no banco de dados. " + ex.Message);
            }
            finally
            {
                cn.Close();
            }



        }
        public Fornecedor BuscarPorId(int _id)
        {

            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            Fornecedor fornecedor = new Fornecedor();

            try

            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Email, Telefone, Sites FROM Fornecedor WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Id", _id);
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        fornecedor = new Fornecedor();
                        fornecedor.Id = Convert.ToInt32(rd["Id"]);
                        fornecedor.Nome = rd["Nome"].ToString();
                        fornecedor.Telefone = rd["Telefone"].ToString();
                        fornecedor.Email = rd["Email"].ToString();
                        fornecedor.Site = rd["Sites"].ToString();




                    }
                }
                return fornecedor;

            }
            catch (Exception ex)
            {
               

                throw new Exception("Ocorreu um erro ao tentar buscar um fornecedor: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Fornecedor> BuscarPorNome(string _nomeFornecedor)
        {
            List<Fornecedor> fornecedorList = new List<Fornecedor>();
            Fornecedor fornecedor = new Fornecedor();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);


            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Telefone, Email, Sites FROM Fornecedor WHERE Nome like @Nome";
                cmd.Parameters.AddWithValue("@Nome", "%" + _nomeFornecedor + "%");
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        fornecedor = new Fornecedor();
                        fornecedor.Id = (int)rd["Id"];
                        fornecedor.Nome = rd["Nome"].ToString();
                        fornecedor.Telefone = rd["Telefone"].ToString();
                        fornecedor.Email = rd["Email"].ToString();
                        fornecedor.Site = rd["Email"].ToString();

                        fornecedorList.Add(fornecedor);
                    }
                    return fornecedorList;
                }
            }
            catch (Exception)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar por um nome de Fonecedor no banco de dados. ");
            }
            finally
            {
                cn.Close();
            }



        }
        public List<Fornecedor> BuscarPorSite(string _nomeSites)
        {
            List<Fornecedor> siteList = new List<Fornecedor>();
            Fornecedor site = new Fornecedor();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);


            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Telefone, Email, Sites FROM Fornecedor WHERE Sites like @Sites";
                cmd.Parameters.AddWithValue("@Sites", "%" + _nomeSites + "%");
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        site = new Fornecedor();
                        site.Id = (int)rd["Id"];
                        site.Nome = rd["Nome"].ToString();
                        site.Telefone = rd["Telefone"].ToString();
                        site.Email = rd["Email"].ToString();
                        site.Site = rd["Sites"].ToString();

                        siteList.Add(site);
                    }
                    return siteList;
                }
            }
            catch (Exception)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar por um Site de Fonecedor no banco de dados. ");
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Fornecedor _fornecedor)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Fornecedor SET Nome = @Nome, Email = @Email, Telefone = @Telefone, Sites = @Sites Where Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _fornecedor.Id);
                cmd.Parameters.AddWithValue("@Nome", _fornecedor.Nome);
                cmd.Parameters.AddWithValue("Telefone", _fornecedor.Telefone);
                cmd.Parameters.AddWithValue("@Email", _fornecedor.Email);
                cmd.Parameters.AddWithValue("@Sites", _fornecedor.Site);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar Alterar um Fornecedor do banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROM Fornecedor WHERE id = @id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@id", _id);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar apagar um Fornecedor no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
