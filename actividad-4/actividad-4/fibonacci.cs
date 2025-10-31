using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace actividad_4
{
    public partial class fibonacci : Form
    {
        public fibonacci()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtlimite.Text, out int limite) || limite <= 0)
            {
                MessageBox.Show("ingrse un limite", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear un StringBuilder para construir la serie
            StringBuilder serie = new StringBuilder();
            int a = 0, b = 1;

            serie.Append($"{a}");

            while (b <= limite)

            {
                serie.Append($", {b}");
                int temp = a + b;
                a = b;
                b = temp;
            }
                    txtresultado.Text = serie.ToString();
                }
            }
        }
    
            