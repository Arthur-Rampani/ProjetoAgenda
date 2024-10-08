namespace ProjetoAgenda
{
    partial class FrmCadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBoxNome = new TextBox();
            txtBoxUsuario = new TextBox();
            txtBoxSenha = new TextBox();
            btnCadastrar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtBoxRepetirSenha = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            btnCancelar = new Button();
            label5 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            txtBoxSenhaoficial = new TextBox();
            label7 = new Label();
            txtBoxTelefone = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtBoxNome
            // 
            txtBoxNome.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxNome.Location = new Point(32, 33);
            txtBoxNome.Name = "txtBoxNome";
            txtBoxNome.Size = new Size(301, 39);
            txtBoxNome.TabIndex = 0;
            txtBoxNome.TextChanged += txtBoxNome_TextChanged;
            // 
            // txtBoxUsuario
            // 
            txtBoxUsuario.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxUsuario.Location = new Point(32, 108);
            txtBoxUsuario.Name = "txtBoxUsuario";
            txtBoxUsuario.Size = new Size(301, 39);
            txtBoxUsuario.TabIndex = 0;
            txtBoxUsuario.TextChanged += txtBoxUsuario_TextChanged;
            // 
            // txtBoxSenha
            // 
            txtBoxSenha.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSenha.Location = new Point(31, 268);
            txtBoxSenha.Name = "txtBoxSenha";
            txtBoxSenha.Size = new Size(301, 39);
            txtBoxSenha.TabIndex = 0;
            txtBoxSenha.TextChanged += txtBoxSenha_TextChanged;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Purple;
            btnCadastrar.Enabled = false;
            btnCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = SystemColors.ButtonHighlight;
            btnCadastrar.Location = new Point(31, 389);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(134, 76);
            btnCadastrar.TabIndex = 1;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(32, 9);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(32, 84);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 2;
            label2.Text = "Usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(32, 244);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 2;
            label3.Text = "Senha";
            // 
            // txtBoxRepetirSenha
            // 
            txtBoxRepetirSenha.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxRepetirSenha.Location = new Point(31, 344);
            txtBoxRepetirSenha.Name = "txtBoxRepetirSenha";
            txtBoxRepetirSenha.Size = new Size(301, 39);
            txtBoxRepetirSenha.TabIndex = 0;
            txtBoxRepetirSenha.TextChanged += txtBoxSenha_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(32, 320);
            label4.Name = "label4";
            label4.Size = new Size(123, 21);
            label4.TabIndex = 2;
            label4.Text = "Repita a Senha";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.parede_de_gradiente_roxo_sala_de_estudio_em_branco_fundo_de_estudio_simples_570543_7224;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(345, 476);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(199, 389);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(134, 76);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(32, 164);
            label5.Name = "label5";
            label5.Size = new Size(57, 21);
            label5.TabIndex = 2;
            label5.Text = "Senha";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(30, 268);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(301, 39);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += txtBoxSenha_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(31, 164);
            label6.Name = "label6";
            label6.Size = new Size(57, 21);
            label6.TabIndex = 2;
            label6.Text = "Senha";
            // 
            // txtBoxSenhaoficial
            // 
            txtBoxSenhaoficial.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSenhaoficial.Location = new Point(30, 268);
            txtBoxSenhaoficial.Name = "txtBoxSenhaoficial";
            txtBoxSenhaoficial.Size = new Size(301, 39);
            txtBoxSenhaoficial.TabIndex = 0;
            txtBoxSenhaoficial.TextChanged += txtBoxSenha_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(31, 164);
            label7.Name = "label7";
            label7.Size = new Size(76, 21);
            label7.TabIndex = 2;
            label7.Text = "Telefone";
            // 
            // txtBoxTelefone
            // 
            txtBoxTelefone.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxTelefone.Location = new Point(32, 188);
            txtBoxTelefone.Name = "txtBoxTelefone";
            txtBoxTelefone.Size = new Size(301, 39);
            txtBoxTelefone.TabIndex = 0;
            txtBoxTelefone.TextChanged += txtBoxUsuario_TextChanged;
            // 
            // FrmCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(345, 477);
            Controls.Add(btnCancelar);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCadastrar);
            Controls.Add(txtBoxSenhaoficial);
            Controls.Add(textBox1);
            Controls.Add(txtBoxRepetirSenha);
            Controls.Add(txtBoxSenha);
            Controls.Add(txtBoxTelefone);
            Controls.Add(txtBoxUsuario);
            Controls.Add(txtBoxNome);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxNome;
        private TextBox txtBoxUsuario;
        private TextBox txtBoxSenha;
        private Button btnCadastrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBoxRepetirSenha;
        private Label label4;
        private PictureBox pictureBox1;
        private Button btnCancelar;
        private Label label5;
        private TextBox textBox1;
        private Label label6;
        private TextBox txtBoxSenhaoficial;
        private Label label7;
        private TextBox txtBoxTelefone;
    }
}
