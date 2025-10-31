namespace actividad_4
{
    partial class divisas
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
            btnconvertir = new Button();
            lblcantidad = new Label();
            cmbDE = new ComboBox();
            cmbA = new ComboBox();
            lbldivisas = new Label();
            label1 = new Label();
            label2 = new Label();
            txtcantidad = new TextBox();
            txtresultado = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnconvertir
            // 
            btnconvertir.Location = new Point(340, 209);
            btnconvertir.Name = "btnconvertir";
            btnconvertir.Size = new Size(112, 34);
            btnconvertir.TabIndex = 0;
            btnconvertir.Text = "convertir";
            btnconvertir.UseVisualStyleBackColor = true;
            btnconvertir.Click += btnconvertir_Click;
            // 
            // lblcantidad
            // 
            lblcantidad.AutoSize = true;
            lblcantidad.Location = new Point(461, 41);
            lblcantidad.Name = "lblcantidad";
            lblcantidad.Size = new Size(83, 25);
            lblcantidad.TabIndex = 7;
            lblcantidad.Text = "Cantidad";
            // 
            // cmbDE
            // 
            cmbDE.FormattingEnabled = true;
            cmbDE.Location = new Point(190, 25);
            cmbDE.Name = "cmbDE";
            cmbDE.Size = new Size(182, 33);
            cmbDE.TabIndex = 8;
            // 
            // cmbA
            // 
            cmbA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbA.FormattingEnabled = true;
            cmbA.Location = new Point(190, 100);
            cmbA.Name = "cmbA";
            cmbA.Size = new Size(182, 33);
            cmbA.TabIndex = 9;
            // 
            // lbldivisas
            // 
            lbldivisas.AutoSize = true;
            lbldivisas.Location = new Point(38, 33);
            lbldivisas.Name = "lbldivisas";
            lbldivisas.Size = new Size(0, 25);
            lbldivisas.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 33);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 11;
            label1.Text = "tasa de cambio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 108);
            label2.Name = "label2";
            label2.Size = new Size(150, 25);
            label2.TabIndex = 12;
            label2.Text = "peso dominicano";
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(550, 35);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(150, 31);
            txtcantidad.TabIndex = 13;
            // 
            // txtresultado
            // 
            txtresultado.BackColor = SystemColors.Control;
            txtresultado.Location = new Point(552, 165);
            txtresultado.Name = "txtresultado";
            txtresultado.Size = new Size(215, 78);
            txtresultado.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(547, 129);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 15;
            label3.Text = "valor";
            // 
            // divisas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(779, 310);
            Controls.Add(label3);
            Controls.Add(txtresultado);
            Controls.Add(txtcantidad);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbldivisas);
            Controls.Add(cmbA);
            Controls.Add(cmbDE);
            Controls.Add(lblcantidad);
            Controls.Add(btnconvertir);
            Name = "divisas";
            Text = "divisas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnconvertir;
        private Label lblcantidad;
        private ComboBox cmbDE;
        private ComboBox cmbA;
        private Label lbldivisas;
        private Label label1;
        private Label label2;
        private TextBox txtcantidad;
        private Label txtresultado;
        private Label label3;
    }
}