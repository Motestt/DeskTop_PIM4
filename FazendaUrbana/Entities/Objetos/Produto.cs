using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FazendaUrbana.Entities.Objetos
{
    internal class Produto
    {
        public int id_produto { get; set; }
        public string nome_produto { get; set; }

        public double valor_produto { get; set; }

        public Categoria Categoria { get; set; }

        public int quantidade_prod { get; set; }

        public Produto() { }

        public Produto(int id_produto, string nome_produto, double valor_produto, Categoria categoria, int quantidade_prod)
        {
            this.id_produto = id_produto;
            this.nome_produto = nome_produto;
            this.valor_produto = valor_produto;
            this.Categoria = categoria;
            this.quantidade_prod = quantidade_prod;
        }

        public Produto(int id_produto, string nome_produto, double valor_produto, int quantidade_prod)
        {
            this.id_produto = id_produto;
            this.nome_produto = nome_produto;
            this.valor_produto = valor_produto;
            this.quantidade_prod = quantidade_prod;
        }

        public void VerProdutos(ComboBox comboBox)
        {
            comboBox.Items.Clear();

            using (SqlConnection connection = ConnectionDB.OpenConnection())
            {
                try
                {
                    string query = @"
                SELECT p.cd_Produto, p.nm_Produto, p.vl_Produto, p.cd_Categoria, p.qt_Produto, c.nm_Categoria
                FROM tb_Produto p
                JOIN tb_Categoria c ON p.cd_Categoria = c.cd_Categoria";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Acessando os dados corretamente
                                int id_produto = Convert.ToInt32(reader.GetValue(0));
                                string nome = reader.GetString(1);
                                double valor = Convert.ToDouble(reader.GetValue(2));
                                int codigo = Convert.ToInt32(reader.GetValue(3));
                                int quantidade = Convert.ToInt32(reader.GetValue(4));
                                string nome_categoria = reader.GetString(5);

                                // Crie a categoria sem um Id real

                                Categoria categoria = new Categoria(codigo, nome_categoria);
                                Produto produto = new Produto(id_produto, nome, valor, categoria, quantidade);
                                comboBox.Items.Add(produto);
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


        public void RemoverProduto(Produto produto)
        {

            using (SqlConnection conn = ConnectionDB.OpenConnection())
            {
                try
                {
                    string query = "DELETE FROM tb_Produto WHERE cd_Produto = @cod_prod";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("cod_prod", produto.id_produto);

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
                catch (Exception ex){ MessageBox.Show(ex.Message);}

            }

        }

        public void AdicionarProduto(Produto produto)
        {
            using (SqlConnection conn = ConnectionDB.OpenConnection())
            {

                try
                {
                    string query = "INSERT INTO tb_Produto(nm_Produto, vl_Produto, cd_Categoria, qt_Produto) values(@nome, @valor, @categoria, @quant)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", produto.nome_produto);
                        cmd.Parameters.AddWithValue("@valor", produto.valor_produto);
                        cmd.Parameters.AddWithValue("@categoria", produto.Categoria.Id);
                        cmd.Parameters.AddWithValue("@quant", produto.quantidade_prod);
                        
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Produto adicionado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Produto não foi adicionado!");
                        }




                    }




                }catch(Exception ex) { MessageBox.Show(ex.Message);}






            }

        }

        public static void VerProdutos_2(ComboBox comboBox)
        {
            comboBox.Items.Clear();

            using (SqlConnection connection = ConnectionDB.OpenConnection())
            {
                try
                {
                    string query = "select cd_Produto, nm_Produto, vl_Produto, qt_Produto from tb_Produto";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Acessando os dados corretamente
                                int id_produto = Convert.ToInt32(reader.GetValue(0));
                                string nome = reader.GetString(1);
                                double valor = Convert.ToDouble(reader.GetValue(2));
                                int quantidade = Convert.ToInt32(reader.GetValue(3));
                                
                                // Crie a categoria sem um Id real

                                Produto produto = new Produto(id_produto, nome, valor, quantidade);
                                comboBox.Items.Add(produto);

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

    }


}
