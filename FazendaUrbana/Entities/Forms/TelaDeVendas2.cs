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

namespace FazendaUrbana.Entities.Forms
{
    public partial class TelaDeVendas2 : Form
    {
        public TelaDeVendas2()
        {
            InitializeComponent();


            //Combobox cliente 
           
            Cliente.VerCliente(comboBox1);
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";

            //combobox PRODUTO

            Produto.VerProdutos_2(comboBox2);
            comboBox2.DisplayMember = "nome_produto";
            comboBox2.ValueMember = "id_produto";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;

            //Combobox pagamento

            Pagamento.VerPagamentos(comboBox3);
            comboBox3.DisplayMember = "tipo_Pagamento";
            comboBox3.ValueMember = "cd_Pagamento";





        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se algum item está selecionado
            if (comboBox2.SelectedItem is Produto produtoSelecionado)
            {
                
                label5.Text = produtoSelecionado.quantidade_prod.ToString();

                double valor = produtoSelecionado.valor_produto;
                label8.Text = valor.ToString();
            }
        }
        private void TelaDeVendas2_Load(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

             
            //ID do produto e objeto produto
            Produto produto = new Produto();
            produto = comboBox2.SelectedItem as Produto;

            //ID do cliente e objeto cliente
            Cliente cliente = new Cliente();
            cliente = comboBox1.SelectedItem as Cliente;

            //Quantidade
            int quantidade = int.Parse(textBox1.Text);

            //Pagamento

            Pagamento pagamento = new Pagamento();
            pagamento = comboBox3.SelectedItem as Pagamento;


            //dados de compra e pagamento
            int cd_cliente = cliente.Id;

            int cd_produto = produto.id_produto;

            int qt_pedido = quantidade;

            int cd_pagamento = pagamento.cd_Pagamento;


            if(quantidade <= produto.quantidade_prod) 
            { Pagamento.CadastrarVenda(cd_cliente, cd_produto, qt_pedido, cd_pagamento); 
            }else{ MessageBox.Show("Quantidade não disponivel");}
                 
            


            AtualizarFormularioVendas();


        }

        public void AtualizarFormularioVendas()
        {

            this.Close();
            TelaDeVendas2 novoFormulario = new TelaDeVendas2();
            novoFormulario.ShowDialog(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
