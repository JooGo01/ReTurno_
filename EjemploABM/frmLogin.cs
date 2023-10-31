using EjemploABM.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploABM
{
    public partial class frmLogin : MaterialSkin.Controls.MaterialForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            FormCliente frmCliente = new FormCliente();
            DialogResult dr = frmCliente.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String usuario=txtEmail.Text;
            String pass = txtContrasenia.Text;
            if (usuario != "" && pass != "")
            {
                inicioSesion(usuario, pass);
            }
            else {
                MessageBox.Show("Por favor complete los campos para poder iniciar sesion", "ReTurno");
            }
        }

        private void inicioSesion(String usr, String pass) {
            bool autenticado=false;
            autenticado=Usuario_Controller.autenticar(usr, pass, true);
            if (autenticado)
            {
                FormCalendario frmCalendario = new FormCalendario();
                DialogResult dr = frmCalendario.ShowDialog();
            }
            else {
                MessageBox.Show("No se pudo iniciar sesion, vuelva a intentar", "ReTurno");
            }
        }

    }
}
