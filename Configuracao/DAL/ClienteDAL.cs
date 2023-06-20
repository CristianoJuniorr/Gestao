using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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
            Cliente cliente = new Cliente();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, CPF, RG, Email, Telefone FROM Cliente WHERE Nome like @Nome";
                cmd.Parameters.AddWithValue("@Nome", "%"+_nomeCliente+"%");
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        cliente = new Cliente();
                        cliente.Id = (int)rd["Id"];
                        cliente.Nome = rd["Nome"].ToString();
                        cliente.CPF = rd["CPF"].ToString();
                        cliente.RG = rd["RG"].ToString();
                        cliente.Email = rd["Email"].ToString();
                        cliente.Telefone = rd["Telefone"].ToString();

                        clienteList.Add(cliente);
                    }
                    return clienteList;
                }
            }
            catch (Exception )
            {

                throw new Exception("Ocoreu um erro ao tentar fazer busca por nome de clientes no banco de dados. ");
            }
            finally
            {
                cn.Close();
            }

            

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

            SqlConnection cn = new SqlConnection();
            
            Cliente cliente = new Cliente();

            try

            {
                SqlCommand cmd = new SqlCommand();
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, CPF, RG, Email, Telefone FROM Cliente WHERE CPF = @CPF";
                cmd.Parameters.AddWithValue("@CPF", _CPF);
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        cliente = new Cliente();
                        cliente.Id = (int)rd["Id"];
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

                throw new Exception("Ocorreu um erro ao tentar buscar um usuário: ", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Cliente _cliente)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Cliente SET Nome = @Nome, CPF = @CPF, RG = @RG, Email = @Email, Telefone = @Telefone Where Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _cliente.Id);
                cmd.Parameters.AddWithValue("@Nome", _cliente.Nome);
                cmd.Parameters.AddWithValue("@CPF", _cliente.CPF);
                cmd.Parameters.AddWithValue("@RG", _cliente.RG);
                cmd.Parameters.AddWithValue("@Email", _cliente.Email);
                cmd.Parameters.AddWithValue("@Telefone", _cliente.Telefone);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception )
            {

                
            }
        }
        public void Excluir(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROM Cliente WHERE id = @id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@id", _id);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar apagar um Cliente do banco de dados.",ex);
            }
            finally
            {
                cn.Close();
            }
                }
        
    }
}
