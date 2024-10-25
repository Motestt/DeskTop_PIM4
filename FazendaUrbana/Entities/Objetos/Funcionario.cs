using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FazendaUrbana.Entities.Objetos
{
    internal class Funcionario
    {

        public string Nome_func;
        public string email_func;
        public int cd_func;
        public bool status_func = true;
        public string username;
        public string password;
        public Cargo Cargo;

        public Funcionario(string nome_func, string email_func, bool status_func, Cargo cargo)
        {
            Nome_func = nome_func;
            this.email_func = email_func;
            this.status_func = status_func;
            Cargo = cargo;
        }

        public Funcionario(string nome_func, string email_func, Cargo cargo, string username, string password)
        {
            Nome_func = nome_func;
            this.email_func = email_func;
            this.Cargo = cargo;
            this.username = username;
            this.password = password;
        }




        public static int InserirFuncionario(Funcionario funcionario)
        {
            // Definir o comando SQL de inserção
            string query = @"
            INSERT INTO tb_Funcionario (nm_Func, email_Func, cd_Cargo, status_Func)
            VALUES (@Nome, @Email, @Cargo, @Status);
            SELECT SCOPE_IDENTITY();";

            int funcionarioId = -1;

            using (SqlConnection connection = ConnectionDB.OpenConnection())
            {
                try
                {
                    // Criar o comando SQL
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@Nome", funcionario.Nome_func);
                        command.Parameters.AddWithValue("@Email", funcionario.email_func);
                        command.Parameters.AddWithValue("@Cargo", funcionario.Cargo.Id);
                        command.Parameters.AddWithValue("@Status", 1);


                        funcionarioId = Convert.ToInt32(command.ExecuteScalar());

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

            return funcionarioId;
        }

        public static void InserirLogin(Funcionario funcionario, int id_funcionario)
        {
            // Definir o comando SQL de inserção
            string query = @"
            INSERT INTO tb_Login (cd_Func, ds_Login, ds_Senha)
            VALUES (@CdFunc, @Login, @Senha);";

            // Abrir a conexão
            using (SqlConnection connection = ConnectionDB.OpenConnection())
            {
                try
                {
                    // Criar o comando SQL
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Adicionar parâmetros ao comando SQL
                        command.Parameters.AddWithValue("@CdFunc", id_funcionario); // Assumindo que você tenha uma propriedade `Codigo` no objeto `Funcionario`
                        command.Parameters.AddWithValue("@Login", funcionario.username);
                        command.Parameters.AddWithValue("@Senha", funcionario.password);

                        // Executar o comando
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0){MessageBox.Show("Funcionario Cadastrado!");} else { MessageBox.Show("Algo deu errado, não foi possivel realizar o cadastro");}

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
        }


        public static int ValidarLogin(string username, string password)
        {
            // Definir o comando SQL para validar o login
            string query = @"
            SELECT cd_Func
            FROM tb_Login
            WHERE ds_Login = @Login AND ds_Senha = @Senha;";

            int funcionarioId = -1;

            // Abrir a conexão
            using (SqlConnection connection = ConnectionDB.OpenConnection())
            {
                try
                {
                    // Criar o comando SQL
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Adicionar parâmetros ao comando SQL
                        command.Parameters.AddWithValue("@Login", username);
                        command.Parameters.AddWithValue("@Senha", password);

                        // Executar o comando e obter o ID do funcionário
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            funcionarioId = Convert.ToInt32(result);
                            Identidade.ID = funcionarioId;
                            Identidade.InfoFuncionario();
                        }
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

            return funcionarioId;
        }


        public override string ToString() 
        {

            return "Nome: " + Nome_func + " - Cargo: " + Cargo.Name;
        
        }



    }
}

