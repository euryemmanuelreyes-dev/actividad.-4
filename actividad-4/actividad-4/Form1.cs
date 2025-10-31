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

        private void divisasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            divisas formdivisas = new divisas();
            formdivisas.MdiParent = this;
            formdivisas.Show();
        }

        private void fibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fibonacci formfibonacci = new fibonacci();
            formfibonacci.MdiParent = this;
            formfibonacci.Show();
        }
    }
}
