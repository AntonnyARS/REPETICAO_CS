namespace Estruturas
{
    partial class frmCadastro
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
            btnFechar = new Button();
            lblBemVindo = new Label();
            SuspendLayout();
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(1028, 14);
            btnFechar.Margin = new Padding(4, 5, 4, 5);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(102, 34);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "Sair";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // lblBemVindo
            // 
            lblBemVindo.AutoSize = true;
            lblBemVindo.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBemVindo.ForeColor = SystemColors.Desktop;
            lblBemVindo.Location = new Point(42, 39);
            lblBemVindo.Name = "lblBemVindo";
            lblBemVindo.Size = new Size(143, 30);
            lblBemVindo.TabIndex = 2;
            lblBemVindo.Text = "BEM VINDO";
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(lblBemVindo);
            Controls.Add(btnFechar);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmCadastro";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnFechar;
        private Label lblBemVindo;
    }
}