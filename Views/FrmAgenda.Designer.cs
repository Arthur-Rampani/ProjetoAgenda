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
            txtBoxCategoria = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtBoxContato
            // 
            txtBoxContato.Location = new Point(12, 73);
            txtBoxContato.Name = "txtBoxContato";
            txtBoxContato.Size = new Size(171, 23);
            txtBoxContato.TabIndex = 0;
            // 
            // txtBoxTelefone
            // 
            txtBoxTelefone.Location = new Point(12, 117);
            txtBoxTelefone.Name = "txtBoxTelefone";
            txtBoxTelefone.Size = new Size(171, 23);
            txtBoxTelefone.TabIndex = 1;
            // 
            // txtBoxCategoria
            // 
            txtBoxCategoria.Location = new Point(12, 184);
            txtBoxCategoria.Name = "txtBoxCategoria";
            txtBoxCategoria.Size = new Size(171, 23);
            txtBoxCategoria.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 43);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 3;
            label1.Text = "Contato";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 99);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 159);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 3;
            label3.Text = "Categoria";
            // 
            // FrmAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBoxCategoria);
            Controls.Add(txtBoxTelefone);
            Controls.Add(txtBoxContato);
            Name = "FrmAgenda";
            Text = "FrmAgenda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxContato;
        private TextBox txtBoxTelefone;
        private TextBox txtBoxCategoria;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}