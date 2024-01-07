using EjemploABM.Controladores;
using EjemploABM.Modelo;
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
    public partial class frmServicio : MaterialSkin.Controls.MaterialForm
    {
        public frmServicio()
        {
            InitializeComponent();
        }

        private void frmServicio_Load(object sender, EventArgs e)
        {
            llenadoCombo();
            agregarCheckBox(Sucursal_Controller.obtenerTodosSucCliente(Program.cli));
            agregarCheckBoxDia();
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

        private void agregarCheckBoxDia() {
            int checkBoxHeight = 25;
            Dia dia = new Dia();
            for (int i = 1; i <= 7; i++) {
                CheckBox checkBox = new CheckBox();
                dia = Dia_Contoller.obtenerPorId(i);
                checkBox.Text = dia.nombre_dia;
                checkBox.Height = checkBoxHeight;
                checkBox.Tag =(int)i;
                checkBox.Top=checkBoxHeight;
                checkBox.Left = (i-1)* checkBox.Width;
                pnl_contenedor_dia.Controls.Add(checkBox);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String subservicio_nombre = txtSubServicio.Text;
            String servicio_nombre = txtServicio.Text;
            SubServicio sbserv = new SubServicio();
            Servicio serv = new Servicio();
            List<Sucursal> listSucursal = new List<Sucursal>();
            List<Dia> listDia = new List<Dia>();
            listDia = listDiaMarca();
            listSucursal = listSucursalMarca();

            Boolean boolValidar = validarCheckbox(listSucursal, listDia);
            if (boolValidar)
            {
                serv = Servicio_Controller.obtenerPorNombre(subservicio_nombre.ToLower());
                if (serv == null)
                {
                    serv = new Servicio(Servicio_Controller.obtenerMaxId() + 1, subservicio_nombre);
                    Servicio_Controller.crearServicio(serv);
                }

                sbserv = SubServicio_Controller.obtenerPorNombre(subservicio_nombre.ToLower());
                if (sbserv == null)
                {
                    sbserv = new SubServicio(SubServicio_Controller.obtenerMaxId() + 1, subservicio_nombre, serv);
                    SubServicio_Controller.crearServicio(sbserv);
                }
                Atencion atencion = new Atencion();
                SucursalServicio sucServ = new SucursalServicio();
                int id_max = 0;
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
                foreach (Sucursal sucursal in listSucursal)
                {
                    id_max = SucServ_Controller.obtenerMaxId() + 1;
                    sucServ = new SucursalServicio(id_max, sucursal, sbserv, tiempo_servicio, 0);
                    SucServ_Controller.crearServicio(sucServ);
                    foreach (Dia dias in listDia)
                    {
                        atencion = new Atencion(Atencion_Controller.obtenerMaxId() + 1, dias, sucServ, hora_ini, hora_fin, cant_personal, 0);
                        Atencion_Controller.crearAtencion(atencion);
                    }
                }
                MessageBox.Show("Servicio Creado", "ReTurno");
            }
            else {
                MessageBox.Show("Falta seleccionar alguna sucursal y/o dia", "ReTurno");
            }
        }

        private Boolean validarCheckbox(List<Sucursal> listado_sucursal, List<Dia> listado_dia) {
            bool validado;
            validado = false;
            if (listado_sucursal.Count > 0 && listado_dia.Count > 0) {
                validado = true;
            }
            return validado;
        }

        private void llenadoCombo() {
            cmbHoraIni.Items.Clear();
            cmbHoraFin.Items.Clear();
            cmbCantPersonal.Items.Clear();
            int i = 0;
            for (i = 1; i <= 24; i++) {
                cmbHoraIni.Items.Add(i.ToString());
                cmbHoraFin.Items.Add(i.ToString());
            }
            for (i = 1; i <= 10; i++) {
                cmbCantPersonal.Items.Add(i.ToString());
            }
        }

        private List<Sucursal> listSucursalMarca() {
            Sucursal suc = new Sucursal();
            List<Sucursal> listado_sucursal = new List<Sucursal>();
            string checkBoxID = "";
            foreach (Control control in pnl_contenedor_suc.Controls) {
                if (control is CheckBox) {
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

        private List<Dia> listDiaMarca() {
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
    }
}
