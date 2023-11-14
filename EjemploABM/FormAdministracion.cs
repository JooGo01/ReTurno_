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
using EjemploABM.Modelo;

namespace EjemploABM
{
    public partial class FormAdministracion : MaterialSkin.Controls.MaterialForm
    {
        public Cliente cli = new Cliente();
        public FormAdministracion()
        {
            InitializeComponent();
        }

        private void FormAdministracion_Load(object sender, EventArgs e)
        {
            Direccion dire = new Direccion();
            List<Sucursal> listSucursal = new List<Sucursal>();
            if (Program.logueado.tipo_usuario=="S") {
                cli = Cliente_Controller.obtenerPorId(Program.cli.id);
                listSucursal = Sucursal_Controller.obtenerTodosSucCliente(cli);
            }
            else if(Program.logueado.tipo_usuario == "A") {
                listSucursal = Sucursal_Controller.obtenerTodosSucClienteAdm(Program.logueado);
            }
            foreach (Sucursal suc in listSucursal)
            {
                dire = Direccion_Controller.obtenerPorId(suc.direccion.id);
                String textoSucursal = suc.id.ToString() + "- " + dire.calle + " " + dire.altura;
                cmbSucursal.Items.Add(textoSucursal);
            }
            cmbSucursal.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregar();
            MessageBox.Show("Administracion Creado", "ReTurno");
        }

        private void agregar() {
            String email = txtEmail.Text;
            String[] id_suc = cmbSucursal.Text.Split('-');
            Usuario usr = new Usuario();
            usr = Usuario_Controller.obtenerPorMail(email);
            Sucursal sucursal = new Sucursal();
            sucursal = Sucursal_Controller.obtenerPorId(Int32.Parse(id_suc[0]));
            Administracion_Controller.crearAdministracion(sucursal, usr);
        }
    }
}
