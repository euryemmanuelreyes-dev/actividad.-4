using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace actividad_4
{
    public partial class Formusuarios : Form
    {
        public Formusuarios()
        {
            InitializeComponent();

        }
        private void Formusuarios_Load(object sender, EventArgs e)
        {
            dgvAlmacenar.Columns.Add(txtNombre.Text, " ");
            dgvAlmacenar.Columns.Add(txtApellido.Text, " ");
            dgvAlmacenar.Columns.Add(txtDni.Text, " ");
            dgvAlmacenar.Columns.Add(dtpFechaDN.Text, Text = " ");
            dgvAlmacenar.Columns.Add(txtSexo.Text, " ");
            dgvAlmacenar.Columns.Add(txtFirma.Text, " ");
            dgvAlmacenar.Columns.Add(txtNacionalidad.Text, " ");
            dgvAlmacenar.Columns.Add(txtTDSangre.Text, " ");
            dgvAlmacenar.Columns.Add(txtPFE.Text, " ");
            dgvAlmacenar.Columns.Add(dtpFechaDV.Text, " ");
            dgvAlmacenar.Columns.Add(txtEC.Text, " ");
            dgvAlmacenar.Columns.Add(txtDirecc.Text, " ");
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
               string.IsNullOrWhiteSpace(txtApellido.Text) ||
               string.IsNullOrWhiteSpace(txtDni.Text) ||
               string.IsNullOrWhiteSpace(txtDirecc.Text) ||
               string.IsNullOrWhiteSpace(txtSexo.Text) ||
               string.IsNullOrWhiteSpace(txtFirma.Text) ||
               string.IsNullOrWhiteSpace(txtNacionalidad.Text) ||
               string.IsNullOrWhiteSpace(txtPFE.Text) ||
               string.IsNullOrWhiteSpace(txtTDSangre.Text) ||
               string.IsNullOrWhiteSpace(txtEC.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Agregar los datos como una nueva fila en el DataGridView
            dgvAlmacenar.Rows.Add(
                txtNombre.Text,
                txtApellido.Text,
                txtDni.Text,
                dtpFechaDN.Value.ToShortDateString(),
                txtSexo.Text,
                txtFirma.Text,
                txtNacionalidad.Text,
                txtTDSangre.Text,
                txtPFE.Text,
                dtpFechaDV.Value.ToShortDateString(),
                txtEC.Text,
                txtDirecc.Text
            );


            LimpiartexBox();
        }
        private void LimpiartexBox()
        {
            // Limpiar los TextBox
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtSexo.Clear();
            txtFirma.Clear();
            txtNacionalidad.Clear();
            txtTDSangre.Clear();
            txtPFE.Clear();
            txtEC.Clear();
            txtDirecc.Clear();
            dtpFechaDN.Value = DateTime.Now;
            dtpFechaDV.Value = DateTime.Now;

            MessageBox.Show("Datos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Validacion que halla una fila seleccionada 
            if (dgvAlmacenar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor seleccion la fila que quera eliminar.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Comfirmar fila seleccionada 
            DialogResult result = MessageBox.Show("estas seguro de eliminar esta fila.", "comfirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                dgvAlmacenar.Rows.RemoveAt(dgvAlmacenar.SelectedRows[0].Index);
                MessageBox.Show("FILA ELIMINADA CORRECTAMENTE");
            }
        }
    }
}

