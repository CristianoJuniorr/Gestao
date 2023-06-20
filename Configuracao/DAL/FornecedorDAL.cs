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
                cmd.CommandText = @"INSERT INTO Fonecedor(Nome, Telefone, Email, Sites)
                                  VALUES (@Nome, @Telefone, @Email, @Sites)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _fornecedor.Nome);
                cmd.Parameters.AddWithValue("@Telefone", _fornecedor.Telefone);
                cmd.Parameters.AddWithValue("@Email", _fornecedor.Email);
                cmd.Parameters.AddWithValue("@Site", _fornecedor.Site);
                

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
                        fornecedor.Site = rd["Site"].ToString();
                        

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
    }
}
