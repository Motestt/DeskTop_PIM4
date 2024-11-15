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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();

            MessageBox.Show(Identidade.FuncionarioAtual.Cargo.Id.ToString());



            label1.Text = Identidade.FuncionarioAtual.ToString();

            if (Identidade.FuncionarioAtual.Cargo.Id == 1 ||
                Identidade.FuncionarioAtual.Cargo.Id == 2 ||
                Identidade.FuncionarioAtual.Cargo.Id == 6)
            {

                adiministrativoToolStripMenuItem.Visible = true;

            }
            else { adiministrativoToolStripMenuItem.Visible = false; }











        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CadastrarProduto cadastrarProduto = new CadastrarProduto();
            cadastrarProduto.ShowDialog();

        }

        private void opçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Estoque estoque = new Estoque();
            estoque.ShowDialog();

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void adiministrativoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarFornecedor cadastrar = new CadastrarFornecedor();
            cadastrar.ShowDialog();

        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adicionarDadosProduçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarDadosProdução adicionardadosprodução = new AdicionarDadosProdução();

            adicionardadosprodução.ShowDialog();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarClientes cadastrarclientes = new CadastrarClientes();
            
            cadastrarclientes.ShowDialog();
        }

        private void relatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarRelatoriocs adicionarrelatorio = new AdicionarRelatoriocs();

            adicionarrelatorio.ShowDialog();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void carrinhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaDeVendas2 telaDeVendas2 = new TelaDeVendas2();
            telaDeVendas2.ShowDialog();
        }
    }
}
