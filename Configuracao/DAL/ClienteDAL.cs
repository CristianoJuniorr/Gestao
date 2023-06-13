
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClienteDAL
    {
        public void Inserir(Cliente _cliente)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"INSERT INTO Cliente(Nome, CPF, RG, Email, Telefone)
                                  VALUES (@Nome, @CPF, @RG, @Email, @Telefone)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _cliente.Nome);
                cmd.Parameters.AddWithValue("@CPF", _cliente.CPF);
                cmd.Parameters.AddWithValue("@RG", _cliente.RG);
                cmd.Parameters.AddWithValue("@Email", _cliente.Email);
                cmd.Parameters.AddWithValue("@Telefone", _cliente.Telefone);
             

                cn.Open();
                cmd.ExecuteScalar();


            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um cliente no banco de dados. " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    
        public List<Cliente> BuscarTodos()
        {
            
                List<Cliente> clienteList = new List<Cliente>();
                Cliente cliente;
                SqlConnection cn = new SqlConnection();
                SqlCommand cmd = new SqlCommand();

                try

                {
                    cn.ConnectionString = Conexao.StringDeConexao;
                    cmd.Connection = cn;
                    cmd.CommandText = @"SELECT Id, Nome, CPF, RG, Email, Telefone FROM Cliente";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cn.Open();

                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            cliente = new Cliente();
                            cliente.Id = Convert.ToInt32(rd["Id"]);
                            cliente.Nome = rd["Nome"].ToString();
                            cliente.CPF = rd["CPF"].ToString();
                            cliente.RG = rd["RG"].ToString();
                            cliente.Email = rd["Email"].ToString();
                            cliente.Telefone = rd["Email"].ToString();

                            clienteList.Add(cliente);
                        }
                    }
                    return clienteList;

                }
                catch (Exception ex)
                {

                    throw new Exception("Ocorreu um erro ao tentar buscar todos os clientes no banco de dados. " + ex.Message);
                }
                finally
                {
                    cn.Close();
                }


            
        }
        public List<Cliente> BuscarPorNome(string _nomeCliente)
        {
            List<Cliente> clienteList = new List<Cliente>();
            Cliente cliente;
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, CPF, RG, Email, Telefone FROM Cliente WHERE Nome like @Nome";
                cmd.Parameters.AddWithValue("@NomeUsuario", "%"+_nomeCliente+"%");
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        cliente = new Cliente();
                        cliente.Id = Convert.ToInt32(rd["Id"]);
                        cliente.Nome = rd["Nome"].ToString();
                        cliente.CPF = rd["CPF"].ToString();
                        cliente.RG = rd["RG"].ToString();
                        cliente.Email = rd["Email"].ToString();
                        cliente.Telefone = rd["Telfone"].ToString();
                    }

                }
            }
            catch (Exception ex)
            {

                throw; new Exception("Ocoreu um erro ao tentar fazer busca por nome de clientes no banco de dados. ");
            }

            return clienteList;

        }
        public Cliente BuscarPorId(int _id)
        {

            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            Cliente cliente = new Cliente();

            try

            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, CPF, RG, Email, Telefone FROM Cliente WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Id", _id);
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        cliente = new Cliente();
                        cliente.Id = Convert.ToInt32(rd["Id"]);
                        cliente.Nome = rd["Nome"].ToString();
                        cliente.CPF = rd["CPF"].ToString();
                        cliente.RG = rd["RG"].ToString();
                        cliente.Email = rd["Email"].ToString();
                        cliente.Telefone = rd["Telefone"].ToString();


                      

                    }
                }
                return cliente;

            }
            catch (Exception ex)
            {
                // Console.WriteLine(String.Format("Ocorreu o seguinte erro: {0} ao tentar buscar no banco "));

                throw new Exception("Ocorreu um erro ao tentar buscar um usuário: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public Cliente BuscarPorCPF(string _CPF)
        {
            return null ;
        }
        public void Alterar(Cliente _cliente)
        {
            
        }
        public void Excluir(int _id)
        {

        }
        
    }
}
