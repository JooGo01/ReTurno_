using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjemploABM.Modelo;
using EjemploABM.Controladores;
using System.Net;

namespace EjemploABM
{
    public partial class frmAtencion : MaterialSkin.Controls.MaterialForm
    {
        public frmAtencion()
        {
            InitializeComponent();
        }

        private void frmAtencion_Load(object sender, EventArgs e)
        {
            llenadoCombo();
            agregarCheckBox(Sucursal_Controller.obtenerTodosSucCliente(Program.cli));
            agregarCheckBoxDia();
        }

        private void llenadoCombo() {
            List<Servicio> listServicio = new List<Servicio>();
            listServicio = Servicio_Controller.obtenerTodosServiciosCliente(Program.cli);
            cbServicio.Items.Clear();
            if (listServicio != null)
            {
                foreach (Servicio ser in listServicio)
                {
                    String textoServicio = ser.id + "- " + ser.nombre_servicio;
                    if (!cbServicio.Items.Contains(textoServicio)) {
                        cbServicio.Items.Add(textoServicio);
                    }
                }
            }
            else { 
                btnAgregar.Enabled = false;
            }

            cmbHoraIni.Items.Clear();
            cmbHoraFin.Items.Clear();
            cmbCantPersonal.Items.Clear();
            int i = 0;
            for (i = 1; i <= 24; i++)
            {
                cmbHoraIni.Items.Add(i.ToString());
                cmbHoraFin.Items.Add(i.ToString());
            }
            for (i = 1; i <= 10; i++)
            {
                cmbCantPersonal.Items.Add(i.ToString());
            }
        }

        private void agregarCheckBox(List<Sucursal> sucursales)
        {
            // Altura de cada CheckBox
            int checkBoxHeight = 25;

            for (int i = 0; i < sucursales.Count; i++)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = "Sucursal " + sucursales[i].id;
                checkBox.Height = checkBoxHeight;
                checkBox.Tag = sucursales[i].id;

                // Configura la posición del CheckBox dentro del Panel
                checkBox.Top = i * checkBoxHeight;

                // Agrega el CheckBox al Panel
                pnl_contenedor_suc.Controls.Add(checkBox);
            }
        }

        private void agregarCheckBoxDia()
        {
            int checkBoxHeight = 25;
            Dia dia = new Dia();
            for (int i = 1; i <= 7; i++)
            {
                CheckBox checkBox = new CheckBox();
                dia = Dia_Contoller.obtenerPorId(i);
                checkBox.Text = dia.nombre_dia;
                checkBox.Height = checkBoxHeight;
                checkBox.Tag = (int)i;
                checkBox.Top = checkBoxHeight;
                checkBox.Left = (i - 1) * checkBox.Width;
                pnl_contenedor_dia.Controls.Add(checkBox);
            }
        }

        private Boolean validarCheckbox(List<Sucursal> listado_sucursal, List<Dia> listado_dia)
        {
            bool validado;
            validado = false;
            if (listado_sucursal.Count > 0 && listado_dia.Count > 0)
            {
                validado = true;
            }
            return validado;
        }

        private Boolean validarExistencia(Sucursal suc, Dia dia, SubServicio ser, int hora_ini, int hora_fin) {
            bool validado;
            List<Atencion> listAtencion = new List<Atencion>();
            validado = false;
            listAtencion= Atencion_Controller.obtenerPorDatos(suc, dia, ser, hora_ini, hora_fin);
            if (listAtencion.Count == 0) {
                validado = true;
            }
            return validado;
        }

        private Boolean validacion(List<Sucursal> listado_sucursal, List<Dia> listado_dia, SubServicio ser, int hora_ini, int hora_fin) {
            bool validado;
            bool blnExistencia;
            bool valExistencia;
            bool blnCheck;
            validado = false;
            blnExistencia = true;
            blnCheck = validarCheckbox(listado_sucursal, listado_dia);
            if (blnCheck)
            {
                foreach (Sucursal suc in listado_sucursal)
                {
                    foreach (Dia dia in listado_dia)
                    {
                        valExistencia = validarExistencia(suc, dia, ser, hora_ini, hora_fin);
                        if (!valExistencia)
                        {
                            blnExistencia = false;
                        }
                    }
                }
                if (blnExistencia)
                {
                    validado = true;
                }
                else
                {
                    MessageBox.Show("Ya hay una atencion creada con los datos ingresado, reviselo", "ReTurno");
                }
            }
            else {
                MessageBox.Show("Falta seleccionar alguna sucursal y/o dia", "ReTurno");
            }
            
            return validado;
        }

        private List<Sucursal> listSucursalMarca()
        {
            Sucursal suc = new Sucursal();
            List<Sucursal> listado_sucursal = new List<Sucursal>();
            string checkBoxID = "";
            foreach (Control control in pnl_contenedor_suc.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;

                    // Accede al valor de identificación (ID) del CheckBox
                    checkBoxID = checkBox.Tag.ToString();

                    // Verifica si el CheckBox está marcado o no
                    if (checkBox.Checked)
                    {
                        suc = Sucursal_Controller.obtenerPorId(Int32.Parse(checkBoxID));
                        listado_sucursal.Add(suc);
                    }
                }
            }
            return listado_sucursal;
        }

        private List<Dia> listDiaMarca()
        {
            Dia dia = new Dia();
            List<Dia> listado_dia = new List<Dia>();
            string checkBoxID = "";
            foreach (Control control in pnl_contenedor_dia.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;

                    // Accede al valor de identificación (ID) del CheckBox
                    checkBoxID = checkBox.Tag.ToString();

                    // Verifica si el CheckBox está marcado o no
                    if (checkBox.Checked)
                    {
                        dia = Dia_Contoller.obtenerPorId(Int32.Parse(checkBoxID));
                        listado_dia.Add(dia);
                    }
                }
            }
            return listado_dia;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String servicio = cbServicio.Text;
            SubServicio serv = new SubServicio();
            List<Sucursal> listSucursal = new List<Sucursal>();
            List<Dia> listDia = new List<Dia>();
            listDia = listDiaMarca();
            listSucursal = listSucursalMarca();
            String[] id_ser = cbServicio.Text.Split('-');
            int tiempo_servicio = Int32.Parse(txtTiempo.Text);
            int hora_ini = 0;
            int hora_fin = 0;
            int cant_personal = 0;
            String hora_texto_ini = cmbHoraIni.GetItemText(cmbHoraIni.SelectedItem);
            String hora_texto_fin = cmbHoraFin.GetItemText(cmbHoraFin.SelectedItem);
            String cant_personal_texto = cmbCantPersonal.GetItemText(cmbCantPersonal.SelectedItem);
            hora_ini = Int32.Parse(hora_texto_ini);
            hora_fin = Int32.Parse(hora_texto_fin);
            cant_personal = Int32.Parse(cant_personal_texto);
            serv = SubServicio_Controller.obtenerPorId(Int32.Parse(id_ser[0]));

            Boolean validar = validacion(listSucursal, listDia, serv, hora_ini, hora_fin);
            if (validar)
            {
                Atencion atencion = new Atencion();
                SucursalServicio sucServ = new SucursalServicio();
                int id_max = 0;
                foreach (Sucursal sucursal in listSucursal)
                {
                    id_max = SucServ_Controller.obtenerMaxId() + 1;
                    sucServ = new SucursalServicio(id_max, sucursal, serv, tiempo_servicio, 0);
                    SucServ_Controller.crearServicio(sucServ);
                    foreach (Dia dias in listDia)
                    {
                        atencion = new Atencion(Atencion_Controller.obtenerMaxId() + 1, dias, sucServ, hora_ini, hora_fin, cant_personal, 0);
                        Atencion_Controller.crearAtencion(atencion);
                    }
                }
                MessageBox.Show("Atencion Creado", "ReTurno");
            }
        }
    }
}
