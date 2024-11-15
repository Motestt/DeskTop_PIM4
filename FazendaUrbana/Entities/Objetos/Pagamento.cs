using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FazendaUrbana.Entities.Objetos
{
    internal class Pagamento
    {
        public int cd_Pagamento {  get; set; }
        public string tipo_Pagamento { get; set; }

        public Pagamento() { }


        public Pagamento(int cd_Pagamento, string tipo_pagamento)
        {
            this.cd_Pagamento = cd_Pagamento;
            this.tipo_Pagamento = tipo_pagamento;
        }

        public static void VerPagamentos(ComboBox comboBox)
        {
            comboBox.Items.Clear();

            using (SqlConnection connection = ConnectionDB.OpenConnection())
            {
                try
                {
                    string query = "select cd_Pag, ds_Pag from tb_Pagamento";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Acessando os dados corretamente
                                int id_pagamentro = Convert.ToInt32(reader.GetValue(0));
                                string tipo_pagamento = reader.GetString(1);
                                

                                // Crie a categoria sem um Id real

                                Pagamento pagamento = new Pagamento(id_pagamentro, tipo_pagamento);
                                comboBox.Items.Add(pagamento);

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar categorias: " + ex.Message);
                }
            }
        }

        public static void CadastrarVenda(int cdCliente, int cdProduto, int qtPedido, int dsPagamento)
        {
          

            using (SqlConnection connection = ConnectionDB.OpenConnection())
            {
                try
                {
                    // Definir o comando SQL para chamar a procedure
                    using (SqlCommand command = new SqlCommand("cadastraVenda", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure; // Especifica que estamos chamando uma stored procedure

                        // Adicionar parâmetros para a procedure
                        command.Parameters.AddWithValue("@Cd_Cliente", cdCliente);
                        command.Parameters.AddWithValue("@Cd_Produto", cdProduto);
                        command.Parameters.AddWithValue("@Qt_Pedido", qtPedido);
                        command.Parameters.AddWithValue("@Ds_Pagamento", dsPagamento);

                        
                        

                        // Executar a stored procedure (ExecuteNonQuery é adequado para operações que não retornam dados)
                        command.ExecuteNonQuery();

                        // Se você precisar, pode fazer algo após a execução (ex: exibir mensagem de sucesso)
                        MessageBox.Show("Venda cadastrada com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    // Tratar erros, exibir a mensagem de erro
                    MessageBox.Show("Erro ao cadastrar venda: " + ex.Message);
                    
                }
            }
        }

    }


}


 
