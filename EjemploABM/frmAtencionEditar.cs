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
    public partial class frmAtencionEditar : MaterialSkin.Controls.MaterialForm
    {

        public Sucursal suc_pub;
        public Servicio serv_pub;
        public SucursalServicio sucserv_pub;
        public Atencion atencion_pub;
        public frmAtencionEditar()
        {
            InitializeComponent();
        }

        public frmAtencionEditar(Atencion atencion)
        {
            InitializeComponent();
            atencion_pub = atencion;
            suc_pub = atencion.sucursal_servicio_id.id_sucursal;
            sucserv_pub = atencion.sucursal_servicio_id;
            serv_pub = atencion.sucursal_servicio_id.id_servicio;
            llenadoDatos();
        }

        private void llenadoDatos() {
            cbDia.Items.Add(atencion_pub.dia_id.nombre_dia);
            cbDia.SelectedIndex = 0;
            cbDia.Enabled = false;

            cbServicio.Items.Add(serv_pub.id.ToString() + "- " + serv_pub.nombre_servicio.ToString());
            cbServicio.SelectedIndex = 0;
            cbServicio.Enabled = false;

            cmbHoraIni.Items.Clear();
            cmbHoraFin.Items.Clear();
            cmbCantPersonal.Items.Clear();
            int i = 0;
            for (i = 1; i <= 24; i++)
            {
                cmbHoraIni.Items.Add(i.ToString());
                if (i.ToString() == atencion_pub.hora_apertura.ToString())
                {
                    cmbHoraIni.SelectedIndex = i - 1;
                }
                cmbHoraFin.Items.Add(i.ToString());
                if (i.ToString() == atencion_pub.hora_cierre.ToString())
                {
                    cmbHoraFin.SelectedIndex = i - 1;
                }
            }
            for (i = 1; i <= 10; i++)
            {
                cmbCantPersonal.Items.Add(i.ToString());
                if (i.ToString() == atencion_pub.personal_servicio.ToString())
                {
                    cmbCantPersonal.SelectedIndex = i-1;
                }
            }

            txtTiempo.Text = sucserv_pub.tiempo_servicio.ToString();
        }

        private void frmAtencionEditar_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
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
            Atencion_Controller.editarAtencion(atencion_pub, hora_ini, hora_fin, cant_personal, 0);
            if (tiempo_servicio != sucserv_pub.tiempo_servicio){
                SucServ_Controller.editarSucServicio(sucserv_pub, tiempo_servicio, 0);
            }
        }
    }
}
