using FazendaUrbana.Entities.Forms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FazendaUrbana.Entities.Objetos
{
    internal class Relatorios
    {

        public static void GerarCSV(int idProducao)
        {
            // Definir o caminho onde o arquivo será salvo (Exemplo: pasta Downloads do usuário)
            string caminhoArquivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", "Producao_" + idProducao + ".csv");

            // Consulta SQL
            string query = @"SELECT nm_Item, dt_Plantio, dt_Colheita, cd_Status, num_Lote, vl_Lote 
                         FROM tb_Producao WHERE cd_Producao = @idProducao";

            try
            {
                // Usando sua classe ConnectionDB para abrir a conexão com o banco de dados
                using (SqlConnection connection = ConnectionDB.OpenConnection())
                {
                    // Criar comando SQL
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Adiciona o parâmetro para a consulta
                        command.Parameters.AddWithValue("@idProducao", idProducao);

                        // Executar a consulta
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())  // Verificar se algum dado foi retornado
                            {
                                // Criar o arquivo CSV e escrever os dados
                                using (StreamWriter writer = new StreamWriter(caminhoArquivo))
                                {
                                    // Escrever cabeçalho do CSV
                                    writer.WriteLine("nm_Item;dt_Plantio;dt_Colheita;cd_Status;num_Lote;vl_Lote");

                                    // Obter os dados do SQL DataReader
                                    string nm_Item = reader["nm_Item"].ToString();
                                    DateTime dt_Plantio = Convert.ToDateTime(reader["dt_Plantio"]);
                                    DateTime dt_Colheita = Convert.ToDateTime(reader["dt_Colheita"]);
                                    int cd_Status = Convert.ToInt32(reader["cd_Status"]);
                                    int num_Lote = Convert.ToInt32(reader["num_Lote"]);
                                    double vl_Lote = Convert.ToDouble(reader["vl_Lote"]);

                                    // Escrever os dados no CSV
                                    string linha = $"{nm_Item};{dt_Plantio:yyyy-MM-dd};{dt_Colheita:yyyy-MM-dd};{cd_Status};{num_Lote};{vl_Lote:F2}";
                                    writer.WriteLine(linha);
                                }

                                // Mensagem de sucesso
                                MessageBox.Show("Arquivo CSV gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                // Caso não tenha encontrado o ID
                                MessageBox.Show("Nenhuma produção encontrada com o ID fornecido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Exceção em caso de erro
                MessageBox.Show("Erro ao gerar o arquivo CSV: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }










    }


}

    

