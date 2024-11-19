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
            button1 = new Button();
            label2 = new Label();
            txtBoxRegistrarCategoria = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 16);
            label1.Name = "label1";
            label1.Size = new Size(267, 32);
            label1.TabIndex = 1;
            label1.Text = "Registre sua categoria";
            label1.Click += label1_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.White;
            btnRegistrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.Black;
            btnRegistrar.Location = new Point(9, 120);
            btnRegistrar.Margin = new Padding(3, 4, 3, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(237, 89);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(272, 16);
            dgvCategorias.Margin = new Padding(3, 4, 3, 4);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(275, 336);
            dgvCategorias.TabIndex = 3;
            dgvCategorias.CellContentClick += dgvCategorias_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(14, 267);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(232, 89);
            button1.TabIndex = 4;
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 229);
            label2.Name = "label2";
            label2.Size = new Size(247, 32);
            label2.TabIndex = 5;
            label2.Text = "Exclua sua categoria";
            // 
            // txtBoxRegistrarCategoria
            // 
            txtBoxRegistrarCategoria.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBoxRegistrarCategoria.Location = new Point(9, 65);
            txtBoxRegistrarCategoria.Margin = new Padding(3, 4, 3, 4);
            txtBoxRegistrarCategoria.Name = "txtBoxRegistrarCategoria";
            txtBoxRegistrarCategoria.Size = new Size(236, 42);
            txtBoxRegistrarCategoria.TabIndex = 0;
            txtBoxRegistrarCategoria.TextAlign = HorizontalAlignment.Center;
            txtBoxRegistrarCategoria.TextChanged += txtBoxRegistrarCategoria_TextChanged;
            // 
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 368);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(dgvCategorias);
            Controls.Add(btnRegistrar);
            Controls.Add(label1);
            Controls.Add(txtBoxRegistrarCategoria);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button button1;
        private Label label2;
        private TextBox txtBoxRegistrarCategoria;
    }
}