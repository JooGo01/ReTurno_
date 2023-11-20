using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjemploABM.Controladores;
using EjemploABM.Modelo;

namespace EjemploABM
{
    public partial class FormTurno : MaterialSkin.Controls.MaterialForm
    {

        public Cliente cli = new Cliente();
        public SucursalServicio sucursalServicio = new SucursalServicio();
        public FormTurno()
        {
            InitializeComponent();
        }

        private void FormTurno_Load(object sender, EventArgs e)
        {
            Direccion dire = new Direccion();
            List<Sucursal> listSucursal = new List<Sucursal>();
            if (Program.logueado.tipo_usuario == "S")
            {
                listSucursal = Sucursal_Controller.obtenerTodosSucCliente(Program.cli);
            }
            else {
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

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            crear();
        }

        private void crear() {
            String dni = txtDni.Text;
            String[] id_suc = cmbSucursal.Text.Split('-');
            Usuario usr = new Usuario();
            usr = Usuario_Controller.obtenerPorDni(dni);
            Sucursal sucursal = new Sucursal();
            sucursal = Sucursal_Controller.obtenerPorId(Int32.Parse(id_suc[0]));
            DateTime horaIni = dtHoraIni.Value;
            DateTime horaFin = dtHoraFin.Value;
            DateTime fechaIni = dtFecha.Value;
            DateTime fechaFin = dtFechaFin.Value;
            String fechaHoraIni = "";
            String fechaHoraFin = "";
            DateTime dtIni = new DateTime();
            DateTime dtFin = new DateTime();
            //string fechaString = "22-10-2023 15:30:45"; // Reemplaza esto con tu cadena de fecha

            // Define el formato esperado
            string formato = "dd-MM-yyyy HH:mm:ss";
            fechaHoraIni = fechaIni.ToString("dd-MM-yyyy") + " " + horaIni.ToString().Substring(horaIni.ToString().Length - 8);
            fechaHoraFin = fechaFin.ToString("dd-MM-yyyy") + " " + horaFin.ToString().Substring(horaFin.ToString().Length - 8);
            // Intenta convertir la cadena a un objeto DateTime
            DateTime.TryParseExact(fechaHoraIni, formato, CultureInfo.InvariantCulture, DateTimeStyles.None, out dtIni);
            DateTime.TryParseExact(fechaHoraFin, formato, CultureInfo.InvariantCulture, DateTimeStyles.None, out dtFin);
            //String dtIni = "";
            //String dtFin = "";
            //Formato Fecha 20231018 17:00:00
            Boolean boolSobreTurno = Calendario_Controller.obtenerPorFecha(dtIni, dtFin, sucursal);
            if (boolSobreTurno)
            {
                DialogResult dialogResult = MessageBox.Show("Ya hay un turno creado dentro de este rango horario en esta fecha ¿Desea crear el turno?", "Crear Turno", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //do something
                    Calendario_Controller.crearTurno(usr, sucursal, dtIni, dtFin);
                    MessageBox.Show("Turno Creado", "ReTurno");
                }
            }else {
                Calendario_Controller.crearTurno(usr, sucursal, dtIni, dtFin);
                MessageBox.Show("Turno Creado", "ReTurno");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void llenadoHora(Atencion atencion)
        {
            int hora_inicio = atencion.hora_apertura;
            int hora_fin = atencion.hora_cierre;
            int intervalo = sucursalServicio.tiempo_servicio;
            int indHora = 0;
            int indMin = 0;
            String horaFormateada = "";
            cbHoraIni.Items.Clear();
            for (indHora = hora_inicio; indHora <= hora_fin; indHora++) {
                for (indMin = 0; indMin < 60; indMin += intervalo) {
                    horaFormateada = $"{indHora:D2}:{indMin:D2}:00";
                    cbHoraIni.Items.Add(horaFormateada);
                }
            }
            cbHoraIni.SelectedIndex = 0;
        }

        private void cbHoraIni_SelectedIndexChanged(object sender, EventArgs e)
        {
            int intervalo = sucursalServicio.tiempo_servicio;
        }
    }
}
