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
using System.Windows.Forms.VisualStyles;
using EjemploABM.Controladores;
using EjemploABM.Modelo;

namespace EjemploABM
{
    public partial class FormTurnoEditar : MaterialSkin.Controls.MaterialForm
    {

        public Cliente cli = new Cliente();
        public int idTurnoEditar;
        public SucursalServicio sucursalServicio = new SucursalServicio();
        public int intervalo_tiempo;
        public FormTurnoEditar()
        {
            InitializeComponent();
        }

        private void FormTurnoEditar_Load(object sender, EventArgs e)
        {
            
        }

        public void cargarTurno(int id_turno) {
            Turno turno = Calendario_Controller.obtenerPorId(id_turno);
            idTurnoEditar = id_turno;
            txtDni.Text = turno.usuario.dni.ToString();
            Direccion dire = new Direccion();
            List<Sucursal> listSucursal = new List<Sucursal>();
            int index = 0;
            if (Program.logueado.tipo_usuario == "S")
            {
                listSucursal = Sucursal_Controller.obtenerTodosSucCliente(Program.cli);
            }
            else
            {
                listSucursal = Sucursal_Controller.obtenerTodosSucClienteAdm(Program.logueado);
            }
            foreach (Sucursal suc in listSucursal)
            {
                dire = Direccion_Controller.obtenerPorId(suc.direccion.id);
                String textoSucursal = suc.id.ToString() + "- " + dire.calle + " " + dire.altura;
                cmbSucursal.Items.Add(textoSucursal);
                if (turno.sucursal.id == suc.id) {
                    cmbSucursal.SelectedIndex = index;
                }
                index = index + 1;
            }
            //cmbSucursal.SelectedIndex=cmbSucursal.FindStringExact(turno.sucursal.id.ToString() + "- ");
            /*dtFechaIni.Value=turno.fecha_ini;
            dtHoraIni.Value= turno.fecha_ini;
            dtFechaFin.Value = turno.fecha_fin;
            dtHoraFin.Value=turno.fecha_fin;*/
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar();
        }

        private void editar()
        {
            String dni = txtDni.Text;
            String[] id_suc = cmbSucursal.Text.Split('-');
            String[] id_ser = cbServicio.Text.Split('-');
            Usuario usr = new Usuario();
            Servicio ser = new Servicio();
            usr = Usuario_Controller.obtenerPorDni(dni);
            ser = Servicio_Controller.obtenerPorId(Int32.Parse(id_ser[0]));
            Sucursal sucursal = new Sucursal();
            sucursal = Sucursal_Controller.obtenerPorId(Int32.Parse(id_suc[0]));
            DateTime fecha = new DateTime();
            fecha = dtFecha.Value;
            String fechaIni = fecha.ToString("dd-MM-yyyy");
            String fechaFin = fecha.ToString("dd-MM-yyyy");
            String horaIni = cbHoraIni.ToString();
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

            Turno turno = Calendario_Controller.obtenerPorId(idTurnoEditar);
            //string fechaString = "22-10-2023 15:30:45"; // Reemplaza esto con tu cadena de fecha
            //String dtIni = "";
            //String dtFin = "";
            //Formato Fecha 20231018 17:00:00
            Boolean boolSobreTurno = Calendario_Controller.obtenerPorFechaCambio(dtIni, dtFin, sucursal);
            if (boolSobreTurno)
            {
                DialogResult dialogResult = MessageBox.Show("Ya hay un turno creado dentro de este rango horario en esta fecha ¿Desea crear el turno?", "Crear Turno", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //do something
                    Calendario_Controller.editarTurno(turno, usr, sucursal, dtIni, dtFin,0);
                    MessageBox.Show("Turno Editado", "ReTurno");

                }
            }
            else
            {
                Calendario_Controller.editarTurno(turno, usr, sucursal, dtIni, dtFin, 0);
                MessageBox.Show("Turno Editado", "ReTurno");

            }
        }

        private void llenadoHora(Atencion atencion, SucursalServicio sucursalServicio)
        {
            int hora_inicio = atencion.hora_apertura;
            int hora_fin = atencion.hora_cierre;
            int intervalo = sucursalServicio.tiempo_servicio;
            int indHora = 0;
            int indMin = 0;
            String horaFormateada = "";
            cbHoraIni.Items.Clear();
            for (indHora = hora_inicio; indHora <= hora_fin; indHora++)
            {
                for (indMin = 0; indMin < 60; indMin += intervalo)
                {
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

        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dtFecha.Value;
            DayOfWeek diaDeLaSemana = fechaSeleccionada.DayOfWeek;
            String[] id_suc = cmbSucursal.Text.Split('-');
            String[] id_ser = cbServicio.Text.Split('-');
            Servicio ser = new Servicio();
            ser = Servicio_Controller.obtenerPorId(Int32.Parse(id_ser[0]));
            Sucursal sucursal = new Sucursal();
            sucursal = Sucursal_Controller.obtenerPorId(Int32.Parse(id_suc[0]));
            int valorDia = 0;
            valorDia = (int)diaDeLaSemana;
            if (valorDia == 0)
            {
                valorDia = 7;
            }
            validacionDia(valorDia, sucursal, ser);
        }

        private void validacionDia(int dia, Sucursal suc, Servicio ser)
        {
            Dia obj_dia = new Dia();
            obj_dia = Dia_Contoller.obtenerPorId(dia);
            List<Atencion> listAtencion = new List<Atencion>();
            listAtencion = Atencion_Controller.obtenerTodosSucSer(suc, ser, obj_dia);
            if (listAtencion.Count > 0)
            {
                btnEditar.Enabled = true;
                foreach (Atencion atencion in listAtencion)
                {
                    llenadoHora(atencion);
                    intervalo_tiempo = atencion.sucursal_servicio_id.tiempo_servicio;
                }
            }
            else
            {
                btnEditar.Enabled = false;
            }
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
            for (indHora = hora_inicio; indHora <= hora_fin; indHora++)
            {
                for (indMin = 0; indMin < 60; indMin += intervalo)
                {
                    horaFormateada = $"{indHora:D2}:{indMin:D2}:00";
                    cbHoraIni.Items.Add(horaFormateada);
                }
            }
            cbHoraIni.SelectedIndex = 0;
        }
    }
}
