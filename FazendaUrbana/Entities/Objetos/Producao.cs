using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FazendaUrbana.Entities.Objetos
{
    internal class Producao
    {
        public int Id { get; set; }
        public string nome_item { get; set; }
        public DateTime date_plantio { get; set; }
        public DateTime date_colheita { get; set; }

        public int status { get; set; }

        public int num_lote { get; set; }

        public double valor_lote { get; set; }

        public Producao() { }

        public Producao(string nome_item, DateTime date_plantio, DateTime date_colheita, int status, int num_lote, double valor_lote)
        {
            this.nome_item = nome_item;
            this.date_plantio = date_plantio;
            this.date_colheita = date_colheita;
            this.status = status;
            this.num_lote = num_lote;
            this.valor_lote = valor_lote;
        }

        public Producao(int iD, string nome_item, DateTime date_plantio, DateTime date_colheita, int status, int num_lote, double valor_lote)
        {
            Id = iD;
            this.nome_item = nome_item;
            this.date_plantio = date_plantio;
            this.date_colheita = date_colheita;
            this.status = status;
            this.num_lote = num_lote;
            this.valor_lote = valor_lote;
        }

        public static void VerProducao(ComboBox comboBox)
        {
            comboBox.Items.Clear(); // Limpa o ComboBox antes de adicionar novos itens

            using (SqlConnection connection = ConnectionDB.OpenConnection())
            {
                try
                {
                    string query = "select cd_Producao, nm_Item, dt_Plantio, dt_Colheita, cd_Status, num_Lote, vl_Lote from tb_Producao;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Acessando os dados corretamente
                                int id = Convert.ToInt32(reader["cd_Producao"]);
                                string nm_Item = reader["nm_Item"].ToString();
                                DateTime dt_Plantio = Convert.ToDateTime(reader["dt_Plantio"]);
                                DateTime dt_Colheita = Convert.ToDateTime(reader["dt_Colheita"]);
                                int cd_Status = Convert.ToInt32(reader["cd_Status"]);
                                int num_Lote = Convert.ToInt32(reader["num_Lote"]);
                                double vl_Lote = Convert.ToDouble(reader["vl_Lote"]);

                                // Criação do objeto Cliente
                                Producao producao = new Producao(id, nm_Item, dt_Plantio, dt_Colheita, cd_Status, num_Lote, vl_Lote);

                                // Adiciona o cliente ao ComboBox
                                comboBox.Items.Add(producao);
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
