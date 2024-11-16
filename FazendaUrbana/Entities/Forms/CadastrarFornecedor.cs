using FazendaUrbana.Entities.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FazendaUrbana.Entities.Forms
{
    public partial class CadastrarFornecedor : Form
    {
        public CadastrarFornecedor()
        {
            InitializeComponent();

            Fornecedor.VerFornecedores(comboBox1);

            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";


            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;









        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CadastrarFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Coletando dados
            string Nome = textBox1.Text;
            string CNPJ = textBox2.Text;
            string email = textBox3.Text;
            string endereco = textBox4.Text;
            string telefone = textBox5.Text;

            //Criando e instaciando objeto Fornecedor
            Fornecedor fornecedor = new Fornecedor(Nome, CNPJ, email, endereco, telefone);

            int ID = Fornecedor.InserirFornecedor(fornecedor);

            if (ID != -1)
            {
                MessageBox.Show("Fornecedor Cadastrado com sucesso!");
            }
            else {MessageBox.Show("Algo deu errado!");}


            Fornecedor.VerFornecedores(comboBox1);










        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {






        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = comboBox1.SelectedItem as Fornecedor;

            Fornecedor.RemoverFornecedor(fornecedor);

            Fornecedor.VerFornecedores(comboBox1);


        }
    }
}
