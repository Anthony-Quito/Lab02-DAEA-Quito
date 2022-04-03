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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
                if (txtPassword.TextLength >= 8)
                {
                    string usuario = textUsuario.Text;
                    string password = txtPassword.Text;

                    List<string> neoLista = new List<string>();

                    neoLista.Add( usuario + " || " + password);
                    Console.WriteLine();
                    foreach (string usuarioList in neoLista)
                    {                     
                        Console.WriteLine(usuarioList);                    
                    }
                    PrincipalMDI principal = new PrincipalMDI();
                    principal.Show();
                    this.Hide();
                }
                else Console.WriteLine("Error en el usuario");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
