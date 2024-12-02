namespace ProjetoAgenda.Views
{
    partial class FrmCategorias
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
            btnRegistrar = new Button();
            dgvCategorias = new DataGridView();
            btnExcluir = new Button();
            label2 = new Label();
            txtBoxRegistrarCategoria = new TextBox();
            label3 = new Label();
            btnAlterar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 9);
            label1.Name = "label1";
            label1.Size = new Size(207, 25);
            label1.TabIndex = 1;
            label1.Text = "Registre sua categoria";
            label1.Click += label1_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Lime;
            btnRegistrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.Black;
            btnRegistrar.Location = new Point(8, 72);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(207, 44);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(238, 12);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(241, 252);
            dgvCategorias.TabIndex = 3;
            dgvCategorias.CellContentClick += dgvCategorias_CellContentClick;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Red;
            btnExcluir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(12, 147);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(207, 44);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 119);
            label2.Name = "label2";
            label2.Size = new Size(192, 25);
            label2.TabIndex = 5;
            label2.Text = "Exclua sua categoria";
            // 
            // txtBoxRegistrarCategoria
            // 
            txtBoxRegistrarCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBoxRegistrarCategoria.Location = new Point(8, 37);
            txtBoxRegistrarCategoria.Name = "txtBoxRegistrarCategoria";
            txtBoxRegistrarCategoria.Size = new Size(207, 29);
            txtBoxRegistrarCategoria.TabIndex = 0;
            txtBoxRegistrarCategoria.TextAlign = HorizontalAlignment.Center;
            txtBoxRegistrarCategoria.TextChanged += txtBoxRegistrarCategoria_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 194);
            label3.Name = "label3";
            label3.Size = new Size(188, 25);
            label3.TabIndex = 5;
            label3.Text = "Altere sua categoria";
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.FromArgb(255, 128, 0);
            btnAlterar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlterar.ForeColor = Color.White;
            btnAlterar.Location = new Point(12, 222);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(207, 44);
            btnAlterar.TabIndex = 6;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 276);
            Controls.Add(btnAlterar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnExcluir);
            Controls.Add(dgvCategorias);
            Controls.Add(btnRegistrar);
            Controls.Add(label1);
            Controls.Add(txtBoxRegistrarCategoria);
            Name = "FrmCategorias";
            Text = "FrmCategorias";
            Load += FrmCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnRegistrar;
        private DataGridView dgvCategorias;
        private Button btnExcluir;
        private Label label2;
        private TextBox txtBoxRegistrarCategoria;
        private Label label3;
        private Button btnAlterar;
    }
}