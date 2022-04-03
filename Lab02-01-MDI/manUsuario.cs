using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_01_MDI
{
    public partial class manUsuario : Form
    {
        public manUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string DNI = txtDNI.Text;
            string NAME = txtNombre.Text;
            string L_NAME = txtApellido.Text;
            string CELL = txtTelefono.Text;
            string MAIL = txtEmail.Text;
            string DATE = txtFecNac.Text;
            string ADDRESS = txtDireccion.Text;

            dataGridView1.Rows.Add(DNI, DATE, NAME, L_NAME, CELL, MAIL, ADDRESS);
        }
    }
}
