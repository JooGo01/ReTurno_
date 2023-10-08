using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjemploABM.ControlesDeUsuario;

namespace EjemploABM
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();


            Productos_UC prodsUC = new Productos_UC();
            addUserControl(prodsUC);

            if(Program.logueado.Id_tipo != 1)
            {
                btn_users.Hide();
            }


        }

        private void btn_prods_Click(object sender, EventArgs e)
        {
            Productos_UC prodsUC = new Productos_UC();
            addUserControl(prodsUC);
        }

        private void btn_cats_Click(object sender, EventArgs e)
        {
            Categorias_UC catsUC = new Categorias_UC();
            addUserControl(catsUC);
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            Usuarios_UC userUC = new Usuarios_UC();
            addUserControl(userUC);
        }

        private void addUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            uc.BringToFront();
        }


    }
}
