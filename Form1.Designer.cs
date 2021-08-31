
namespace CadastroSimples
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conexãoBancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirConexãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarTabelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_Status = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Nome
            // 
            this.txt_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.Location = new System.Drawing.Point(12, 129);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(839, 38);
            this.txt_Nome.TabIndex = 0;
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(12, 190);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(839, 38);
            this.txt_Email.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email:";
            // 
            // lista
            // 
            this.lista.AllowUserToAddRows = false;
            this.lista.AllowUserToDeleteRows = false;
            this.lista.BackgroundColor = System.Drawing.SystemColors.Control;
            this.lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.email});
            this.lista.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lista.DefaultCellStyle = dataGridViewCellStyle3;
            this.lista.Location = new System.Drawing.Point(12, 235);
            this.lista.Name = "lista";
            this.lista.ReadOnly = true;
            this.lista.RowHeadersWidth = 51;
            this.lista.RowTemplate.Height = 24;
            this.lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lista.Size = new System.Drawing.Size(839, 259);
            this.lista.TabIndex = 4;
            this.lista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lista_CellDoubleClick);
            this.lista.SelectionChanged += new System.EventHandler(this.lista_SelectionChanged);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 80;
            // 
            // nome
            // 
            this.nome.HeaderText = "NOME";
            this.nome.MinimumWidth = 6;
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 350;
            // 
            // email
            // 
            this.email.HeaderText = "EMAIL";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 380;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.conexãoBancoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(863, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoRegistroToolStripMenuItem,
            this.buscarRegistroToolStripMenuItem,
            this.editarRegistroToolStripMenuItem,
            this.excluirRegistroToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoRegistroToolStripMenuItem
            // 
            this.novoRegistroToolStripMenuItem.Name = "novoRegistroToolStripMenuItem";
            this.novoRegistroToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.novoRegistroToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.novoRegistroToolStripMenuItem.Text = "Novo Registro";
            this.novoRegistroToolStripMenuItem.Click += new System.EventHandler(this.novoRegistroToolStripMenuItem_Click);
            // 
            // buscarRegistroToolStripMenuItem
            // 
            this.buscarRegistroToolStripMenuItem.Name = "buscarRegistroToolStripMenuItem";
            this.buscarRegistroToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.buscarRegistroToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.buscarRegistroToolStripMenuItem.Text = "Buscar Registro";
            this.buscarRegistroToolStripMenuItem.Click += new System.EventHandler(this.buscarRegistroToolStripMenuItem_Click);
            // 
            // editarRegistroToolStripMenuItem
            // 
            this.editarRegistroToolStripMenuItem.Name = "editarRegistroToolStripMenuItem";
            this.editarRegistroToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editarRegistroToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.editarRegistroToolStripMenuItem.Text = "Editar Registro";
            this.editarRegistroToolStripMenuItem.Click += new System.EventHandler(this.editarRegistroToolStripMenuItem_Click);
            // 
            // excluirRegistroToolStripMenuItem
            // 
            this.excluirRegistroToolStripMenuItem.Name = "excluirRegistroToolStripMenuItem";
            this.excluirRegistroToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Delete)));
            this.excluirRegistroToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.excluirRegistroToolStripMenuItem.Text = "Excluir Registro";
            this.excluirRegistroToolStripMenuItem.Click += new System.EventHandler(this.excluirRegistroToolStripMenuItem_Click);
            // 
            // conexãoBancoToolStripMenuItem
            // 
            this.conexãoBancoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirConexãoToolStripMenuItem,
            this.criarTabelaToolStripMenuItem});
            this.conexãoBancoToolStripMenuItem.Name = "conexãoBancoToolStripMenuItem";
            this.conexãoBancoToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.conexãoBancoToolStripMenuItem.Text = "Conexão Banco";
            // 
            // abrirConexãoToolStripMenuItem
            // 
            this.abrirConexãoToolStripMenuItem.Name = "abrirConexãoToolStripMenuItem";
            this.abrirConexãoToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.abrirConexãoToolStripMenuItem.Text = "Abrir Conexão";
            this.abrirConexãoToolStripMenuItem.Click += new System.EventHandler(this.abrirConexãoToolStripMenuItem_Click);
            // 
            // criarTabelaToolStripMenuItem
            // 
            this.criarTabelaToolStripMenuItem.Name = "criarTabelaToolStripMenuItem";
            this.criarTabelaToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.criarTabelaToolStripMenuItem.Text = "Criar Tabela";
            this.criarTabelaToolStripMenuItem.Click += new System.EventHandler(this.criarTabelaToolStripMenuItem_Click);
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Inserir.Location = new System.Drawing.Point(12, 511);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(131, 58);
            this.btn_Inserir.TabIndex = 6;
            this.btn_Inserir.Text = "Inserir";
            this.btn_Inserir.UseVisualStyleBackColor = true;
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Buscar.Location = new System.Drawing.Point(149, 511);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(131, 58);
            this.btn_Buscar.TabIndex = 7;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Editar.Location = new System.Drawing.Point(286, 511);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(131, 58);
            this.btn_Editar.TabIndex = 8;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Excluir.Location = new System.Drawing.Point(423, 511);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(131, 58);
            this.btn_Excluir.TabIndex = 9;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(692, 618);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Status:";
            // 
            // lb_Status
            // 
            this.lb_Status.AutoSize = true;
            this.lb_Status.ForeColor = System.Drawing.Color.Red;
            this.lb_Status.Location = new System.Drawing.Point(747, 618);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(99, 17);
            this.lb_Status.TabIndex = 11;
            this.lb_Status.Text = "Desconectado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(256, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(351, 46);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cadastro Simples";
            // 
            // txt_ID
            // 
            this.txt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.Location = new System.Drawing.Point(750, 85);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(101, 38);
            this.txt_ID.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(719, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 644);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_Status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.btn_Inserir);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Simples";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conexãoBancoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirConexãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarTabelaToolStripMenuItem;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_Status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label5;
    }
}

