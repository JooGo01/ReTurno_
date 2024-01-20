using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
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
        public Direccion dire = new Direccion();
        public Sucursal suc = new Sucursal();
        public SubServicio ser = new SubServicio();
        public SucursalServicio sucursalServicio = new SucursalServicio();
        public DateTime dt_sel;
        public int intervalo_tiempo;
        public FormTurno()
        {
            InitializeComponent();
        }

        public FormTurno(Sucursal p_sucursal, SubServicio p_servicio, DateTime p_dt)
        {
            InitializeComponent();
            sucursalServicio = SucServ_Controller.obtenerPorSucServ(p_sucursal, p_servicio);
            dt_sel = p_dt;
            suc = p_sucursal;
            ser = p_servicio;
            intervalo_tiempo = sucursalServicio.tiempo_servicio;
        }

        private void FormTurno_Load(object sender, EventArgs e) { 
            dire = sucursalServicio.id_sucursal.direccion;
            suc = sucursalServicio.id_sucursal;
            ser = sucursalServicio.id_subservicio;
            String textoSucursal = suc.id.ToString() + "- " + dire.calle + " " + dire.altura;
            cmbSucursal.Items.Add(textoSucursal);
            cmbSucursal.Enabled = false;
            cmbSucursal.SelectedIndex = 0;
            String textoServicio = ser.id.ToString() + "- " + ser.nombre_servicio.ToString();
            cbServicio.Items.Add(textoServicio);
            cbServicio.Enabled = false;
            cbServicio.SelectedIndex = 0;
            String hora_ini = dt_sel.ToString("HH:mm:ss");
            DateTime dt_fin = dt_sel.AddMinutes(intervalo_tiempo);
            String hora_fin=dt_fin.ToString("HH:mm:ss");
            dtFecha.Value = dt_sel;
            cbHoraIni.Items.Add(hora_ini);
            cbHoraIni.Enabled = false;
            cbHoraIni.SelectedIndex = (cbHoraIni.Items.Count-1);
            lblHoraFin.Text = hora_fin;
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
            Usuario usr = new Usuario();
            usr = Usuario_Controller.obtenerPorDni(dni);
            if (usr.id > 0)
            {
                DateTime fecha = new DateTime();
                fecha = dtFecha.Value;
                String fechaIni = fecha.ToString("dd-MM-yyyy");
                String fechaFin = fecha.ToString("dd-MM-yyyy");
                String horaIni = cbHoraIni.Text;
                String horaFin = lblHoraFin.Text.ToString();
                String fechaHoraIni = fechaIni + " " + horaIni;
                String fechaHoraFin = fechaFin + " " + horaFin;
                DateTime dtIni = new DateTime();
                DateTime dtFin = new DateTime();
                //string fechaString = "22-10-2023 15:30:45"; // Reemplaza esto con tu cadena de fecha

                // Define el formato esperado
                string formato = "dd-MM-yyyy HH:mm:ss";
                // Intenta convertir la cadena a un objeto DateTime
                DateTime.TryParseExact(fechaHoraIni, formato, CultureInfo.InvariantCulture, DateTimeStyles.None, out dtIni);
                DateTime.TryParseExact(fechaHoraFin, formato, CultureInfo.InvariantCulture, DateTimeStyles.None, out dtFin);
                //Formato Fecha 20231018 17:00:00
                Boolean boolSobreTurno = Calendario_Controller.obtenerPorFecha(dtIni, dtFin, suc);
                if (boolSobreTurno)
                {
                    DialogResult dialogResult = MessageBox.Show("Ya hay un turno creado dentro de este rango horario en esta fecha ¿Desea crear el turno?", "Crear Turno", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //do something
                        Calendario_Controller.crearTurno(usr, suc, dtIni, dtFin, ser);
                        MessageBox.Show("Turno Creado", "ReTurno");
                    }
                }
                else
                {
                    Calendario_Controller.crearTurno(usr, suc, dtIni, dtFin, ser);
                    MessageBox.Show("Turno Creado", "ReTurno");
                }
            }
            else {
                MessageBox.Show("Usuario no encontrado", "ReTurno");
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
            String horaFormateada = "";
            DateTime fecha = new DateTime();
            fecha = dtFecha.Value;
            String fechaIni = fecha.ToString("dd-MM-yyyy");
            horaFormateada = cbHoraIni.Text;
            String fechahora = fechaIni + " " + horaFormateada;
            DateTime fechaInicial = new DateTime();
            string formato = "dd-MM-yyyy HH:mm:ss";
            DateTime.TryParseExact(fechahora, formato, CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaInicial);
            DateTime horaFinal = new DateTime();
            horaFinal = fechaInicial.AddMinutes(intervalo_tiempo);
            String hora_final = horaFinal.ToString().Substring(horaFinal.ToString().Length - 8);
            lblHoraFin.Text = hora_final;
        }

        private void cmbSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<SucursalServicio> listSucServ = new List<SucursalServicio> ();
            String[] id_suc = cmbSucursal.Text.Split('-');
            Sucursal sucursal = new Sucursal();
            sucursal = Sucursal_Controller.obtenerPorId(Int32.Parse(id_suc[0]));
            listSucServ = SucServ_Controller.obtenerTodosActivosSucursal(sucursal);
            cbServicio.Items.Clear();
            foreach (SucursalServicio sucServ in listSucServ)
            {
                String textoTipoTurno = sucServ.id_subservicio.id.ToString() + "- " + sucServ.id_subservicio.nombre_servicio;
                cbServicio.Items.Add(textoTipoTurno);
            }
            cbServicio.SelectedIndex = 0;
        }

        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dtFecha.Value;
            DayOfWeek diaDeLaSemana = fechaSeleccionada.DayOfWeek;
            String[] id_suc = cmbSucursal.Text.Split('-');
            String[] id_ser = cbServicio.Text.Split('-');
            SubServicio ser = new SubServicio();
            ser = SubServicio_Controller.obtenerPorId(Int32.Parse(id_ser[0]));
            Sucursal sucursal = new Sucursal();
            sucursal = Sucursal_Controller.obtenerPorId(Int32.Parse(id_suc[0]));
            int valorDia = 0;
            valorDia = (int)diaDeLaSemana;
            if (valorDia == 0) {
                valorDia = 7;
            }
            validacionDia(valorDia, sucursal, ser);
        }

        private void validacionDia(int dia, Sucursal suc, SubServicio ser) {
            Dia obj_dia = new Dia();
            obj_dia = Dia_Contoller.obtenerPorId(dia);
            List<Atencion> listAtencion = new List<Atencion>();
            listAtencion=Atencion_Controller.obtenerTodosSucSer(suc,ser,obj_dia);
            if (listAtencion.Count > 0)
            {
                btnAgregar.Enabled = true;
                foreach (Atencion atencion in listAtencion)
                {
                    llenadoHora(atencion);
                    intervalo_tiempo = atencion.sucursal_servicio_id.tiempo_servicio;
                }
            }
            else {
                btnAgregar.Enabled = false;
            }
        }
    }
}
