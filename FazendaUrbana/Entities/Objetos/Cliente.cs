using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FazendaUrbana.Entities.Objetos
{
    internal class Cliente
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }
        public string cpf { get; set; }
        public string cnpj { get; set; }        

        public Cliente(string name, string email, string endereco, string telefone)
        {
            Name = name;
            Email = email;
            this.endereco = endereco;
            this.telefone = telefone;
        }

        public Cliente(int id, string name, string telefone)
        {
            Id = id;
            Name = name;
            this.telefone = telefone;
        }

        public Cliente()
        {
        }

        public static void VerCliente(ComboBox comboBox)
        {
            comboBox.Items.Clear(); // Limpa o ComboBox antes de adicionar novos itens

            using (SqlConnection connection = ConnectionDB.OpenConnection())
            {
                try
                {
                    string query = "SELECT cd_Cli, nm_Cli, tel_Cli FROM tb_Cliente;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Acessando os dados corretamente
                                int id = Convert.ToInt32(reader["cd_Cli"]);
                                string nome = reader["nm_Cli"].ToString();
                                string telefone = reader["tel_Cli"].ToString();

                                // Criação do objeto Cliente
                                Cliente cliente = new Cliente(id, nome, telefone);

                                // Adiciona o cliente ao ComboBox
                                comboBox.Items.Add(cliente);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
                }
            }





        }

        public static int InserirCliente(Cliente cliente)
        {
            // Definir o comando SQL de inserção para o cliente
            string queryCliente = @"
    INSERT INTO tb_Cliente (nm_Cli, email_Cli, end_Cli, tel_Cli)
    VALUES (@Nome, @Email, @Endereco, @Telefone);
    SELECT SCOPE_IDENTITY();";  // Retorna o ID do cliente recém-inserido

            int clienteId = -1;

            using (SqlConnection connection = ConnectionDB.OpenConnection())
            {
                try
                {
                    // Criar o comando SQL para inserir o cliente
                    using (SqlCommand command = new SqlCommand(queryCliente, connection))
                    {
                        // Adicionar os parâmetros do cliente
                        command.Parameters.AddWithValue("@Nome", cliente.Name);
                        command.Parameters.AddWithValue("@Email", cliente.Email);
                        command.Parameters.AddWithValue("@Endereco", cliente.endereco);
                        command.Parameters.AddWithValue("@Telefone", cliente.telefone);

                        // Executar o comando e pegar o ID do cliente inserido
                        clienteId = Convert.ToInt32(command.ExecuteScalar());
                    }

                    if (clienteId > 0)
                    {
                        // Agora que temos o ID do cliente, inserimos o CPF ou CNPJ
                        if (!string.IsNullOrEmpty(cliente.cpf))
                        {
                            // Inserir o CPF na tabela tb_Clif
                            string queryCPF = @"
                    INSERT INTO tb_Clif (cd_Cli, numCPF)
                    VALUES (@ClienteId, @CPF);";

                            using (SqlCommand commandCPF = new SqlCommand(queryCPF, connection))
                            {
                                commandCPF.Parameters.AddWithValue("@ClienteId", clienteId);
                                commandCPF.Parameters.AddWithValue("@CPF", cliente.cpf);

                                commandCPF.ExecuteNonQuery();
                            }
                        }
                        else if (!string.IsNullOrEmpty(cliente.cnpj))
                        {
                            // Inserir o CNPJ na tabela tb_Clij
                            string queryCNPJ = @"
                    INSERT INTO tb_Clij (cd_Cli, numCNPJ)
                    VALUES (@ClienteId, @CNPJ);";

                            using (SqlCommand commandCNPJ = new SqlCommand(queryCNPJ, connection))
                            {
                                commandCNPJ.Parameters.AddWithValue("@ClienteId", clienteId);
                                commandCNPJ.Parameters.AddWithValue("@CNPJ", cliente.cnpj);

                                commandCNPJ.ExecuteNonQuery();
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro ao executar comando: " + ex.Message);
                    return -1;  // Retorna -1 em caso de erro
                }
                finally
                {
                    // Fechar a conexão
                    ConnectionDB.CloseConnection(connection);
                }
            }

            return clienteId;
        }


        public void RemoverCliente(Cliente cliente)
        {

            using (SqlConnection conn = ConnectionDB.OpenConnection())
            {
                try
                {
                    string query = "DELETE FROM tb_Produto WHERE cd_c = @cod_prod";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("cod_prod", cliente.Id);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Produto removido com sucesso.");
                        }
                        else
                        {
                            MessageBox.Show("Produto não encontrado.");
                        }

                    }

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

            }

        }


    }

}
