using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form2 : Form
    {
        public List<Estudiantes> listEstudents = new List<Estudiantes>();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dgvDatos.DataSource = listEstudents;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            txtID.Text = dgvDatos.CurrentRow.Cells[0].Value.ToString();
            txtNombres.Text = dgvDatos.CurrentRow.Cells[1].Value.ToString();
            txtApellidos.Text = dgvDatos.CurrentRow.Cells[2].Value.ToString();

        }
    }
}
