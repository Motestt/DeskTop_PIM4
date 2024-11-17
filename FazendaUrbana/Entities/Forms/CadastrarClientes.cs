using FazendaUrbana.Entities.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FazendaUrbana.Entities.Forms
{
    public partial class CadastrarClientes : Form
    {
        public CadastrarClientes()
        {
            InitializeComponent();
            atualizarCombo();
  
        }
        public void atualizarCombo()
        {
            Cliente.VerCliente(comboBox1);
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string Nome = textBox1.Text;
                string email = textBox2.Text;
                string endereco = textBox3.Text;
                string telefone = textBox4.Text;
                string cpf = textBox5.Text;   // Pode estar vazio
                string cnpj = textBox6.Text;  // Pode estar vazio

                // Verificar qual documento foi preenchido (CPF ou CNPJ)
                Cliente cliente = null;

                if (!string.IsNullOrEmpty(cpf))
                {
                    // Se o CPF foi preenchido, cria um cliente com CPF
                    cliente = new Cliente
                    {
                        Name = Nome,
                        Email = email,
                        endereco = endereco,
                        telefone = telefone,
                        cpf = cpf
                    };
                }
                else if (!string.IsNullOrEmpty(cnpj))
                {
                    // Se o CNPJ foi preenchido, cria um cliente com CNPJ
                    cliente = new Cliente
                    {
                        Name = Nome,
                        Email = email,
                        endereco = endereco,
                        telefone = telefone,
                        cnpj = cnpj
                    };
                }
                else
                {
                    // Se nenhum CPF ou CNPJ for preenchido, pode exibir uma mensagem de erro
                    MessageBox.Show("Por favor, informe o CPF ou CNPJ do cliente.");
                    return;
                }

                // Agora você pode chamar a função InserirCliente para salvar no banco
                int clienteId = Cliente.InserirCliente(cliente);
                if (clienteId > 0)
                {
                    MessageBox.Show("Cliente inserido com sucesso!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex); // Em caso de erro
                MessageBox.Show("Ocorreu um erro ao processar os dados.");
            }

            atualizarCombo();





        }

        private void CadastrarClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
