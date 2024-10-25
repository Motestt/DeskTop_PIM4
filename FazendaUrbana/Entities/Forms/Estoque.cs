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
using System.Globalization;

namespace FazendaUrbana.Entities.Forms
{
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();

            Categoria categoria = new Categoria();
            categoria.VerCategoria(comboBox1);

     
            comboBox1.DisplayMember = "Name"; 
            comboBox1.ValueMember = "Id";


            Produto produto = new Produto();
            produto.VerProdutos(comboBox2);


            comboBox2.DisplayMember = "nome_produto";
            comboBox2.ValueMember = "id_produto";

            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se algum item está selecionado
            if (comboBox2.SelectedItem is Produto produtoSelecionado)
            {
                // Define o texto da Label com o valor do produto
                label_valor.Text = produtoSelecionado.valor_produto.ToString();
                label6.Text = produtoSelecionado.quantidade_prod.ToString();
            }
        }


        private void Estoque_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = 1;
            string nome_prod = textBox1.Text;
            double valor_prod = double.Parse(textBox2.Text, CultureInfo.InvariantCulture);

            Categoria categoria = (Categoria)comboBox1.SelectedItem;

            int quantidade_prod = int.Parse(textBox4.Text);

            Produto produto = new Produto(id, nome_prod, valor_prod, categoria, quantidade_prod);

            produto.AdicionarProduto(produto);

            produto.VerProdutos(comboBox2);



           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto = (Produto)comboBox2.SelectedItem;

            produto.RemoverProduto(produto);

            produto.VerProdutos(comboBox2);
           








        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
