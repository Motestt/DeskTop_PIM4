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
    }

}
