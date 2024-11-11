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
            txtBoxRegistrarCategoria = new TextBox();
            label1 = new Label();
            btnRegistrar = new Button();
            dgvCategorias = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // txtBoxRegistrarCategoria
            // 
            txtBoxRegistrarCategoria.Location = new Point(12, 63);
            txtBoxRegistrarCategoria.Name = "txtBoxRegistrarCategoria";
            txtBoxRegistrarCategoria.Size = new Size(207, 23);
            txtBoxRegistrarCategoria.TabIndex = 0;
            txtBoxRegistrarCategoria.TextChanged += txtBoxRegistrarCategoria_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(207, 25);
            label1.TabIndex = 1;
            label1.Text = "Registre sua categoria";
            label1.Click += label1_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(48, 92);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(133, 32);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(239, 105);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.Size = new Size(240, 150);
            dgvCategorias.TabIndex = 3;
            // 
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 276);
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

        private TextBox txtBoxRegistrarCategoria;
        private Label label1;
        private Button btnRegistrar;
        private DataGridView dgvCategorias;
    }
}