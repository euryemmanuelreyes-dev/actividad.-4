namespace actividad_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void usariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formusuarios formusuarios = new Formusuarios();
            formusuarios.MdiParent = this;
            formusuarios.Show();
        }
    }
}
