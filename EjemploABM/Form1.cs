using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjemploABM.Controladores;

namespace EjemploABM
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (Usuario_Controller.autenticar(textBox1.Text, textBox2.Text, true))
            {
                /*if (MantenerSesion.Checked)
                {
                    Usuario_Controlador.persistirUsuario(Program.logueado);
                }*/

                Index index = new Index();
                index.Show();
                this.Hide();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
