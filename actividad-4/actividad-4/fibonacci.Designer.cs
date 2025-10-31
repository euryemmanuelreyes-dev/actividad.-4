namespace actividad_4
{
    partial class fibonacci
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
            btnGenerar = new Button();
            txtlimite = new TextBox();
            txtresultado = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(283, 9);
            label1.Name = "label1";
            label1.Size = new Size(151, 25);
            label1.TabIndex = 0;
            label1.Text = "Serie de fibonacci";
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(424, 248);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(112, 34);
            btnGenerar.TabIndex = 1;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // txtlimite
            // 
            txtlimite.Location = new Point(140, 106);
            txtlimite.Name = "txtlimite";
            txtlimite.Size = new Size(150, 31);
            txtlimite.TabIndex = 2;
            // 
            // txtresultado
            // 
            txtresultado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtresultado.Location = new Point(140, 178);
            txtresultado.Name = "txtresultado";
            txtresultado.Size = new Size(285, 31);
            txtresultado.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 112);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 4;
            label2.Text = "Limite";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 184);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 5;
            label3.Text = "Resultado";
            // 
            // fibonacci
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtresultado);
            Controls.Add(txtlimite);
            Controls.Add(btnGenerar);
            Controls.Add(label1);
            Name = "fibonacci";
            Text = "fibonacci";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGenerar;
        private TextBox txtlimite;
        private TextBox txtresultado;
        private Label label2;
        private Label label3;
    }
}