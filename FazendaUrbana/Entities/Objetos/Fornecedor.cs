using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FazendaUrbana.Entities.Objetos
{
    internal class Fornecedor
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string cnpj { get; set; }
        public string email { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }

        public Fornecedor() { }
        public Fornecedor(int id, string name, string cnpj, string email, string endereco, string telefone)
        {
            Id = id;
            Name = name;
            this.cnpj = cnpj;
            this.email = email;
            this.endereco = endereco;
            this.telefone = telefone;
        }

        public Fornecedor(string name, string cnpj, string email, string endereco, string telefone)
        {
            Name = name;
            this.cnpj = cnpj;
            this.email = email;
            this.endereco = endereco;
            this.telefone = telefone;
        }

        public static int InserirFornecedor(Fornecedor fornecedor)
        {
            // Definir o comando SQL de inserção
            string query = @"
INSERT INTO tb_Fornecedor (nm_Forn, num_CNPJ, email_Forn, end_Forn, tel_Forn)
VALUES (@Nome, @CNPJ, @Email, @Endereco, @Telefone);
SELECT SCOPE_IDENTITY();";

            int fornecedorId = -1;

            using (SqlConnection connection = ConnectionDB.OpenConnection())
            {
                try
                {
                    // Criar o comando SQL
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Adicionar os parâmetros ao comando SQL
                        command.Parameters.AddWithValue("@Nome", fornecedor.Name);
                        command.Parameters.AddWithValue("@CNPJ", fornecedor.cnpj);
                        command.Parameters.AddWithValue("@Email", fornecedor.email);
                        command.Parameters.AddWithValue("@Endereco", fornecedor.endereco);
                        command.Parameters.AddWithValue("@Telefone", fornecedor.telefone);

                        // Executar o comando e pegar o ID do fornecedor inserido
                        fornecedorId = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro ao executar comando: " + ex.Message);
                }
                finally
                {
                    // Fechar a conexão
                    ConnectionDB.CloseConnection(connection);
                }
            }

            return fornecedorId;
        }

        public static void VerFornecedores(ComboBox comboBox)
        {
            comboBox.Items.Clear();

            using (SqlConnection connection = ConnectionDB.OpenConnection())
            {
                try
                {
                    // Definir a consulta SQL para buscar os fornecedores
                    string query = @"
                           SELECT cd_Forn, nm_Forn, num_CNPJ, email_Forn, end_Forn, tel_Forn
                           FROM tb_Fornecedor";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Ler os dados retornados pela consulta
                            while (reader.Read())
                            {
                                // Acessar os dados da linha
                                int id_forn = Convert.ToInt32(reader.GetValue(0));
                                string nome = reader.GetString(1);
                                string cnpj = reader.GetString(2);
                                string email = reader.GetString(3);
                                string endereco = reader.GetString(4);
                                string telefone = reader.GetString(5);

                                // Criar um objeto Fornecedor
                                Fornecedor fornecedor = new Fornecedor(id_forn, nome, cnpj, email, endereco, telefone);

                                // Adicionar o fornecedor ao ComboBox
                                comboBox.Items.Add(fornecedor);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Exibir erro caso haja algum problema
                    MessageBox.Show("Erro ao carregar fornecedores: " + ex.Message);
                }
            }
        }

        public static void RemoverFornecedor(Fornecedor fornecedor)
        {

            using (SqlConnection conn = ConnectionDB.OpenConnection())
            {
                try
                {
                    string query = "DELETE FROM tb_Fornecedor WHERE cd_Forn = @cod_prod";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("cod_prod", fornecedor.Id);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Fornecedor removido com sucesso.");
                        }
                        else
                        {
                            MessageBox.Show("Fornecedor não encontrado.");
                        }

                    }

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

            }

        }
    }

}
