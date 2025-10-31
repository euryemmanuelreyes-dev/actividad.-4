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
    public partial class divisas : Form
    {
        public divisas()
        {
            InitializeComponent();
            //LLENAR LOS COMBOBOX DE LAS DIVISAS

            cmbDE.Items.AddRange(new string[]
            {
                "Dólar (USD)",
                "Euro (EUR)",
                "Esterlina (GBP)",
                "Peso Dominicano (DOP)"
            });

            cmbA.Items.AddRange(new string[]
            {
                "Dólar (USD)",
                "Euro (EUR)",
                "Esterlina (GBP)",
                "Peso Dominicano (DOP)"
            });
            cmbDE.SelectedIndex = 0;
            cmbA.SelectedIndex = 1;
        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtcantidad.Text, out double cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Por favor ingrse una cantidad valida.", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string de = cmbDE.SelectedItem.ToString();
            string a = cmbA.SelectedItem.ToString();

            double resultado = ConvertirDivisa(cantidad, de, a);
            txtresultado.Text = $"{cantidad} {de} = {resultado:F2} {a}";
        }

        private double ConvertirDivisa(double cantidad, string de, string a)
        {
            //tasa de combios fijas 
            double usdToDop = 64.32;
            double usdToEur = 0.94;
            double usdToEster = 0.79;

            //Convertie en USD
            double enUSD = cantidad;
            if (de.Contains("Euro")) enUSD = cantidad / usdToEur;
            else if (de.Contains("Esterlina")) enUSD = cantidad / usdToEster;
            else if (de.Contains("Peso")) enUSD = cantidad / usdToDop;

            // Luego convertir de USD a la moneda destino
            if (a.Contains("Euro")) return enUSD * usdToEur;
            else if (a.Contains("Esterlina")) return enUSD * usdToEster;
            else if (a.Contains("Peso")) return enUSD * usdToDop;
            else return enUSD; // USD a USD
        }
    }
    }
