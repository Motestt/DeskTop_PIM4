using FazendaUrbana.Entities.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FazendaUrbana.Entities.Forms
{
    public partial class AdicionarRelatoriocs : Form
    {
        public AdicionarRelatoriocs()
        {
            InitializeComponent();


            Producao.VerProducao(comboBox1);
            comboBox1.DisplayMember = "nome_item";
            comboBox1.ValueMember = "Id";


        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdicionarRelatoriocs_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Producao producao = (Producao)comboBox1.SelectedItem;   
            int id_producao = producao.Id;
            Relatorios.GerarCSV(id_producao);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se algum item está selecionado
            if (comboBox1.SelectedItem is Producao produtoSelecionado)
            {

                label6.Text = produtoSelecionado.date_plantio.ToString();

                int valor = produtoSelecionado.status;
                label7.Text = valor.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
