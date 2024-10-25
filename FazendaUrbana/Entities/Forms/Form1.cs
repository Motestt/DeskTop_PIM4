using FazendaUrbana.Entities;
using FazendaUrbana.Entities.Forms;
using FazendaUrbana.Entities.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FazendaUrbana
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
         
            ShowLoginPanel();


        }
        private void ShowLoginPanel()
        {
            panel3.Visible = true;
            panel1.Visible = false;
        }

        private void ShowRegistroPanel()
        {
            panel3.Visible = false;
            panel1.Visible = true;
        }



        private void button1_Click(object sender, EventArgs e)
        {

            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.ShowDialog();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrarLogin registrarLogin= new RegistrarLogin();
            registrarLogin.ShowDialog();
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowLoginPanel();
            button4.BackColor = Color.DarkSeaGreen;
            button3.BackColor = Color.DarkOliveGreen;

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowRegistroPanel();
            button3.BackColor = Color.DarkSeaGreen;
            button4.BackColor = Color.DarkOliveGreen;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MenuPrincipal Menu = new MenuPrincipal();
            Menu.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                string local = "271; 120";
                string nome = textBoxNome.Text;
                string email = textBoxEmail.Text;
                string username = textBoxUsuario.Text;
                string password = textBoxSenha.Text;

                

                string name = "indefinido";
                int id = int.Parse(textBoxCargo.Text);

                Cargo cargo = new Cargo(Name, Id);





                //objeto


                Funcionario funcionario = new Funcionario(nome, email, cargo, username, password);

                   //abrindo conexão
                   ConnectionDB.OpenConnection();

                   //pegando o id
                   int id_func = Funcionario.InserirFuncionario(funcionario);


                   Funcionario.InserirLogin(funcionario);
               
            }
            else
            {
                string username = textBoxUsuario2.Text;
                string password = textBoxSenha2.Text;

                int funcionarioID = Funcionario.ValidarLogin(username, password);

              
                if (funcionarioID != -1)
                {
                    
      
                    MenuPrincipal menuPrincipal = new MenuPrincipal();
                    menuPrincipal.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Login ou senha inválidos.");
                }


            }










            








        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
