namespace FazendaUrbana.Entities.Forms
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarDadosProduçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adiministrativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFuncionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem,
            this.fornecedoresToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.produçãoToolStripMenuItem,
            this.adiministrativoToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 50);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.opçõesToolStripMenuItem.Checked = true;
            this.opçõesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estoqueToolStripMenuItem});
            this.opçõesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opçõesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(99, 46);
            this.opçõesToolStripMenuItem.Text = "Estoque";
            this.opçõesToolStripMenuItem.Click += new System.EventHandler(this.opçõesToolStripMenuItem_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.estoqueToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(271, 32);
            this.estoqueToolStripMenuItem.Text = "Cadastrar Produtos";
            this.estoqueToolStripMenuItem.Click += new System.EventHandler(this.estoqueToolStripMenuItem_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.fornecedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarFornecedoresToolStripMenuItem});
            this.fornecedoresToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.fornecedoresToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(149, 46);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // cadastrarFornecedoresToolStripMenuItem
            // 
            this.cadastrarFornecedoresToolStripMenuItem.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.cadastrarFornecedoresToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cadastrarFornecedoresToolStripMenuItem.Name = "cadastrarFornecedoresToolStripMenuItem";
            this.cadastrarFornecedoresToolStripMenuItem.Size = new System.Drawing.Size(311, 32);
            this.cadastrarFornecedoresToolStripMenuItem.Text = "Cadastrar Fornecedores";
            this.cadastrarFornecedoresToolStripMenuItem.Click += new System.EventHandler(this.cadastrarFornecedoresToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.clientesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(98, 46);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // cadastrarClientesToolStripMenuItem
            // 
            this.cadastrarClientesToolStripMenuItem.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.cadastrarClientesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cadastrarClientesToolStripMenuItem.Name = "cadastrarClientesToolStripMenuItem";
            this.cadastrarClientesToolStripMenuItem.Size = new System.Drawing.Size(257, 32);
            this.cadastrarClientesToolStripMenuItem.Text = "Cadastrar clientes";
            this.cadastrarClientesToolStripMenuItem.Click += new System.EventHandler(this.cadastrarClientesToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.vendasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.vendasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(92, 46);
            this.vendasToolStripMenuItem.Text = "Vendas";
            this.vendasToolStripMenuItem.Click += new System.EventHandler(this.vendasToolStripMenuItem_Click);
            // 
            // produçãoToolStripMenuItem
            // 
            this.produçãoToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.produçãoToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.produçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarDadosProduçãoToolStripMenuItem});
            this.produçãoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.produçãoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.produçãoToolStripMenuItem.Name = "produçãoToolStripMenuItem";
            this.produçãoToolStripMenuItem.Size = new System.Drawing.Size(112, 46);
            this.produçãoToolStripMenuItem.Text = "Produção";
            // 
            // adicionarDadosProduçãoToolStripMenuItem
            // 
            this.adicionarDadosProduçãoToolStripMenuItem.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.adicionarDadosProduçãoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.adicionarDadosProduçãoToolStripMenuItem.Name = "adicionarDadosProduçãoToolStripMenuItem";
            this.adicionarDadosProduçãoToolStripMenuItem.Size = new System.Drawing.Size(364, 32);
            this.adicionarDadosProduçãoToolStripMenuItem.Text = "Adicionar dados da Produção";
            this.adicionarDadosProduçãoToolStripMenuItem.Click += new System.EventHandler(this.adicionarDadosProduçãoToolStripMenuItem_Click);
            // 
            // adiministrativoToolStripMenuItem
            // 
            this.adiministrativoToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.adiministrativoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarFuncionariosToolStripMenuItem,
            this.relatoriosToolStripMenuItem});
            this.adiministrativoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.adiministrativoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.adiministrativoToolStripMenuItem.Name = "adiministrativoToolStripMenuItem";
            this.adiministrativoToolStripMenuItem.Size = new System.Drawing.Size(158, 46);
            this.adiministrativoToolStripMenuItem.Text = "Administrativo";
            this.adiministrativoToolStripMenuItem.Click += new System.EventHandler(this.adiministrativoToolStripMenuItem_Click);
            // 
            // cadastrarFuncionariosToolStripMenuItem
            // 
            this.cadastrarFuncionariosToolStripMenuItem.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.cadastrarFuncionariosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cadastrarFuncionariosToolStripMenuItem.Name = "cadastrarFuncionariosToolStripMenuItem";
            this.cadastrarFuncionariosToolStripMenuItem.Size = new System.Drawing.Size(303, 32);
            this.cadastrarFuncionariosToolStripMenuItem.Text = "Cadastrar Funcionarios";
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.relatoriosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(303, 32);
            this.relatoriosToolStripMenuItem.Text = "Relatorios";
            this.relatoriosToolStripMenuItem.Click += new System.EventHandler(this.relatoriosToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(939, 497);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 511);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(738, 271);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seja Bem vindo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(738, 258);
            this.label3.TabIndex = 5;
            this.label3.Text = "a Fazenda Barbosa";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adiministrativoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFuncionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem adicionarDadosProduçãoToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}