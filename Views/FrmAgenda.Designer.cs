namespace ProjetoAgenda.Views
{
    partial class FrmAgenda
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
            txtBoxContato = new TextBox();
            txtBoxTelefone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            btnAlterar = new Button();
            btnExcluir = new Button();
            btnCadastrar = new Button();
            comboBoxCategorias = new ComboBox();
            dgvContatos = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContatos).BeginInit();
            SuspendLayout();
            // 
            // txtBoxContato
            // 
            txtBoxContato.Location = new Point(15, 55);
            txtBoxContato.Name = "txtBoxContato";
            txtBoxContato.Size = new Size(180, 23);
            txtBoxContato.TabIndex = 0;
            // 
            // txtBoxTelefone
            // 
            txtBoxTelefone.Location = new Point(15, 116);
            txtBoxTelefone.Name = "txtBoxTelefone";
            txtBoxTelefone.Size = new Size(180, 23);
            txtBoxTelefone.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 28);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 3;
            label1.Text = "Contato";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 90);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 3;
            label2.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 152);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 3;
            label3.Text = "Categoria";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAlterar);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(btnCadastrar);
            groupBox1.Controls.Add(comboBoxCategorias);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtBoxContato);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtBoxTelefone);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 316);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agenda";
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.FromArgb(255, 128, 0);
            btnAlterar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlterar.ForeColor = Color.White;
            btnAlterar.Location = new Point(15, 254);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(205, 50);
            btnAlterar.TabIndex = 5;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Red;
            btnExcluir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(120, 208);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(100, 40);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Lime;
            btnCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(14, 208);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(100, 40);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // comboBoxCategorias
            // 
            comboBoxCategorias.FormattingEnabled = true;
            comboBoxCategorias.Location = new Point(15, 179);
            comboBoxCategorias.Name = "comboBoxCategorias";
            comboBoxCategorias.Size = new Size(180, 23);
            comboBoxCategorias.TabIndex = 5;
            comboBoxCategorias.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dgvContatos
            // 
            dgvContatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContatos.Location = new Point(275, 21);
            dgvContatos.Name = "dgvContatos";
            dgvContatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContatos.Size = new Size(327, 307);
            dgvContatos.TabIndex = 5;
            // 
            // FrmAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 341);
            Controls.Add(dgvContatos);
            Controls.Add(groupBox1);
            Name = "FrmAgenda";
            Text = "FrmAgenda";
            Load += FrmAgenda_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtBoxContato;
        private TextBox txtBoxTelefone;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private ComboBox comboBoxCategorias;
        private Button btnAlterar;
        private Button btnExcluir;
        private Button btnCadastrar;
        private DataGridView dgvContatos;
    }
}