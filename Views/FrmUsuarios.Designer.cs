namespace ProjetoAgenda.Views
{
    partial class FrmUsuarios
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
            label1 = new Label();
            dgvUsuarios = new DataGridView();
            btnExcluir = new Button();
            label2 = new Label();
            btnAlterar = new Button();
            txtBoxAlterar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(272, 9);
            label1.Name = "label1";
            label1.Size = new Size(158, 25);
            label1.TabIndex = 0;
            label1.Text = "Exclua o usuário";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(53, 151);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(387, 287);
            dgvUsuarios.TabIndex = 1;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Red;
            btnExcluir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(258, 50);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(182, 67);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 9);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 0;
            label2.Text = "Altere a senha";
            // 
            // btnAlterar
            // 
            btnAlterar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlterar.Location = new Point(13, 83);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(135, 62);
            btnAlterar.TabIndex = 3;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // txtBoxAlterar
            // 
            txtBoxAlterar.Location = new Point(12, 50);
            txtBoxAlterar.Name = "txtBoxAlterar";
            txtBoxAlterar.Size = new Size(136, 23);
            txtBoxAlterar.TabIndex = 4;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 450);
            Controls.Add(txtBoxAlterar);
            Controls.Add(btnAlterar);
            Controls.Add(btnExcluir);
            Controls.Add(dgvUsuarios);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmUsuarios";
            Text = "FrmUsuarios";
            Load += FrmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvUsuarios;
        private Button btnExcluir;
        private Label label2;
        private Button btnAlterar;
        private TextBox txtBoxAlterar;
    }
}