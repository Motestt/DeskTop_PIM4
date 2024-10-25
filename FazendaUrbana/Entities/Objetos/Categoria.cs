using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FazendaUrbana.Entities.Objetos
{
    internal class Categoria
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public Categoria()
        {
        }

        public Categoria(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }

        public void VerCategoria(ComboBox comboBox)
        {
            comboBox.Items.Clear();

            using (SqlConnection connection = ConnectionDB.OpenConnection())
            {
                try
                {
                    string query = "SELECT ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS RowNum, nm_Categoria FROM tb_Categoria";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Acessando os dados corretamente
                                int rowNum = Convert.ToInt32(reader.GetValue(0)); 
                                string nome = reader.GetString(1); 
                                
                                // Crie a categoria sem um Id real
                                Categoria categoria = new Categoria(rowNum, nome);
                                comboBox.Items.Add(categoria);
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
