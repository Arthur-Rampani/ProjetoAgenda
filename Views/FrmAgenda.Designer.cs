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
            comboBoxCategorias = new ComboBox();
            btnCadastrar = new Button();
            btnExcluir = new Button();
            btnAlterar = new Button();
            groupBox1.SuspendLayout();
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
            label1.Location = new Point(15, 28);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 3;
            label1.Text = "Contato";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 90);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 152);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
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
            groupBox1.Location = new Point(21, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 316);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agenda";
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
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(14, 208);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(100, 40);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(120, 208);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(100, 40);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(15, 254);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(205, 50);
            btnAlterar.TabIndex = 5;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // FrmAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "FrmAgenda";
            Text = "FrmAgenda";
            Load += FrmAgenda_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
    }
}