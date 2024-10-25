using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FazendaUrbana.Entities.Objetos
{
    internal class Identidade
    {


        public static int ID { get; set; }

        public static Funcionario FuncionarioAtual { get; set; }


        public static void InfoFuncionario()
        {
            SqlConnection conn = ConnectionDB.OpenConnection();

            string query = @"
        SELECT f.*, c.nm_Cargo 
        FROM tb_Funcionario f
        JOIN tb_Cargo c ON f.cd_Cargo = c.cd_Cargo
        WHERE f.cd_Func = @cod";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("cod", ID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    
                    
                     while (reader.Read())
                      {
                           
                            int id_funcionario = Convert.ToInt32(reader.GetValue(0));
                            string nome = reader.GetString(1);
                            string email = reader.GetString(2);
                            int codigo = Convert.ToInt32(reader.GetValue(3));
                            bool status = Convert.ToBoolean(reader.GetValue(4));
                            string nm_cargo = reader.GetString(5);

                            Cargo cargo = new Cargo(codigo, nm_cargo);

                            Funcionario funcionario = new Funcionario(nome, email, status, cargo);

                            FuncionarioAtual = funcionario;
  
                       }
                    




                }




            }
        }

        
      





    }
}
