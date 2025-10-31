namespace actividad_4
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            menuDeUsuariosToolStripMenuItem = new ToolStripMenuItem();
            usariosToolStripMenuItem = new ToolStripMenuItem();
            divisasToolStripMenuItem = new ToolStripMenuItem();
            fibonacciToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuDeUsuariosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuDeUsuariosToolStripMenuItem
            // 
            menuDeUsuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usariosToolStripMenuItem, divisasToolStripMenuItem, fibonacciToolStripMenuItem });
            menuDeUsuariosToolStripMenuItem.Name = "menuDeUsuariosToolStripMenuItem";
            menuDeUsuariosToolStripMenuItem.Size = new Size(108, 29);
            menuDeUsuariosToolStripMenuItem.Text = "opcciones";
            // 
            // usariosToolStripMenuItem
            // 
            usariosToolStripMenuItem.Name = "usariosToolStripMenuItem";
            usariosToolStripMenuItem.Size = new Size(270, 34);
            usariosToolStripMenuItem.Text = "usarios";
            usariosToolStripMenuItem.Click += usariosToolStripMenuItem_Click;
            // 
            // divisasToolStripMenuItem
            // 
            divisasToolStripMenuItem.Name = "divisasToolStripMenuItem";
            divisasToolStripMenuItem.Size = new Size(270, 34);
            divisasToolStripMenuItem.Text = "divisas";
            divisasToolStripMenuItem.Click += divisasToolStripMenuItem_Click;
            // 
            // fibonacciToolStripMenuItem
            // 
            fibonacciToolStripMenuItem.Name = "fibonacciToolStripMenuItem";
            fibonacciToolStripMenuItem.Size = new Size(270, 34);
            fibonacciToolStripMenuItem.Text = "fibonacci";
            fibonacciToolStripMenuItem.Click += fibonacciToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "}";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuDeUsuariosToolStripMenuItem;
        private ToolStripMenuItem usariosToolStripMenuItem;
        private ToolStripMenuItem divisasToolStripMenuItem;
        private ToolStripMenuItem fibonacciToolStripMenuItem;
    }
}
