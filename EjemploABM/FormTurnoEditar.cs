using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using EjemploABM.Controladores;
using EjemploABM.Modelo;

namespace EjemploABM
{
    public partial class FormTurnoEditar : MaterialSkin.Controls.MaterialForm
    {

        public Cliente cli = new Cliente();
        public FormTurnoEditar()
        {
            InitializeComponent();
        }

        private void FormTurnoEditar_Load(object sender, EventArgs e)
        {
            
        }

        public void cargarTurno(int id_turno) {
            Turno turno = Calendario_Controller.obtenerPorId(id_turno);
            txtDni.Text = turno.usuario.dni.ToString();
            cli = Cliente_Controller.obtenerPorId(1);
            Direccion dire = new Direccion();
            List<Sucursal> listSucursal = Sucursal_Controller.obtenerTodosSucCliente(cli);
            foreach (Sucursal suc in listSucursal)
            {
                dire = Direccion_Controller.obtenerPorId(suc.direccion.id);
                String textoSucursal = suc.id.ToString() + "- " + dire.calle + " " + dire.altura;
                cmbSucursal.Items.Add(textoSucursal);
            }
            cmbSucursal.SelectedIndex=cmbSucursal.FindStringExact(turno.sucursal.id.ToString() + "- ");
            dtFechaIni.Value=turno.fecha_ini;
            dtHoraIni.Value= turno.fecha_ini;
            dtFechaFin.Value = turno.fecha_fin;
            dtHoraFin.Value=turno.fecha_fin;
        }
    }
}
