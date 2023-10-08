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

namespace EjemploABM
{
    public partial class FormCalendario : MaterialSkin.Controls.MaterialForm
    {
        private InfoMesCalendario _infoCalendario;
        public FormCalendario()
        {
            InitializeComponent();
        }

        private void FormCalendario_Load(object sender, EventArgs e)
        {
            crearDias();
            diasSemana();
            ajustePanel();
            _infoCalendario = new InfoMesCalendario(9,2023);
            llenarCalendario();
        }

        private void crearDias() {
            Panel diaPanel = new Panel();
            Label diaMes = new Label();
            int indexFila = 0;
            int indexCol = 0;

            for (indexFila = 0; indexFila < 6; indexFila++) { 
                for(indexCol=0; indexCol < 7; indexCol++)
                {
                    diaPanel = new Panel();
                    diaPanel.Name = String.Format("pnlDia{0}{1}", indexFila, indexCol);
                    diaMes = new Label();
                    diaMes.Name = String.Format("lblDiaMes{0}{1}", indexFila, indexCol);
                    diaMes.Text = diaMes.Name;
                    diaPanel.Controls.Add(diaMes);
                    diaPanel.BorderStyle = BorderStyle.FixedSingle;

                    switch (indexFila) { 
                        case 0:
                            panel_semana0.Controls.Add(diaPanel);
                            break;
                        case 1:
                            panel_semana1.Controls.Add(diaPanel);
                            break;
                        case 2:
                            panel_semana2.Controls.Add(diaPanel);
                            break;
                        case 3:
                            panel_semana3.Controls.Add(diaPanel);
                            break;
                        case 4:
                            panel_semana4.Controls.Add(diaPanel);
                            break;
                        case 5:
                            panel_semana5.Controls.Add(diaPanel);
                            break;
                    }
                }
            }
        }

        private void ajustePanel()
        {
            Panel[] arrPanel = new Panel[] {
                panel_dia_semana,
                panel_semana5,
                panel_semana4,
                panel_semana3,
                panel_semana2,
                panel_semana1,
                panel_semana0,
            };

            foreach (Panel pnl in arrPanel)
            {
                ajustarTamanio(pnl);
            }
        }
        private void ajustarTamanio(Control c) {
            int ancho = 0;
            int x = 0;
            int cantidadItems = 0;
            foreach (Control ctl in c.Controls)
            {
                cantidadItems++;
            }
            if (cantidadItems == 0) {
                return;
            }

            ancho = c.Width / cantidadItems;

            foreach (Control ctl in c.Controls)
            {
                ctl.Height = c.Height;
                ctl.Width = ancho;
                ctl.Location = new Point(x, 0);
                x += ancho;
            }
        }

        private void diasSemana() {
            Panel diaPanel = new Panel();
            Label diaSemana = new Label();
            int indexCol = 0;

            for (indexCol = 0; indexCol < 7; indexCol++)
            {
                diaPanel = new Panel();
                diaPanel.Name = String.Format("pnlDia{0}{1}", 0, indexCol);
                diaSemana = new Label();
                switch (indexCol)
                {
                    case 0:
                        diaSemana.Name = "Domingo";
                        break;
                    case 1:
                        diaSemana.Name = "Lunes";
                        break;
                    case 2:
                        diaSemana.Name = "Martes";
                        break;
                    case 3:
                        diaSemana.Name = "Miercoles";
                        break;
                    case 4:
                        diaSemana.Name = "Jueves";
                        break;
                    case 5:
                        diaSemana.Name = "Viernes";
                        break;
                    case 6:
                        diaSemana.Name = "Sabado";
                        break;
                }
                diaSemana.Text = diaSemana.Name;
                diaSemana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                diaSemana.AutoSize = true;
                diaSemana.Font = new Font("Calibri", 14);
                diaSemana.ForeColor = Color.Black;
                diaPanel.Controls.Add(diaSemana);
                diaPanel.BorderStyle = BorderStyle.FixedSingle;
                panel_dia_semana.Controls.Add(diaPanel);
            }
        }

        private void llenarCalendario() {
            Label lbl = new Label();
            Control lblControl = new Control();
            String lblNombre;
            int indexFila = 0;
            int indexCol = 0;

            lbl.Text = String.Format("{0}, {1}", nombreMes(_infoCalendario.getMes()), _infoCalendario.getAnio());
            panel_control.Controls.Add(lbl);

            for (indexFila = 0; indexFila < 6; indexFila++)
            {
                for (indexCol = 0; indexCol < 7; indexCol++)
                {
                    lblNombre = String.Format("lblDiaMes{0}{1}", indexFila, indexCol);
                    lblControl = Controls.Find(lblNombre, true).First();
                    lblControl.Text = _infoCalendario.diaDeMes(indexFila,indexCol).ToString();
                    lblControl.AutoSize = true;
                    lblControl.Font = new Font("Calibri", 16);

                    if (_infoCalendario.esMesActivo(indexFila, indexCol))
                    {
                        lblControl.ForeColor = Color.Black;
                    }
                    else {
                        lblControl.ForeColor = Color.Gray;
                    }

                    if (_infoCalendario.esHoy(indexFila, indexCol)) {
                        lblControl.ForeColor = Color.Blue;
                    }
                }
            }

        }

        private String nombreMes(int mes) {
            String nombre;
            nombre = "";
            switch (mes) {
                case 1:
                    nombre = "Enero";
                    break;
                case 2:
                    nombre = "Febrero";
                    break;
                case 3:
                    nombre = "Marzo";
                    break;
                case 4:
                    nombre = "Abril";
                    break;
                case 5:
                    nombre = "Mayo";
                    break;
                case 6:
                    nombre = "Junio";
                    break;
                case 7:
                    nombre = "Julio";
                    break;
                case 8:
                    nombre = "Agosto";
                    break;
                case 9:
                    nombre = "Septiembre";
                    break;
                case 10:
                    nombre = "Octubre";
                    break;
                case 11:
                    nombre = "Noviembre";
                    break;
                case 12:
                    nombre = "Diciembre";
                    break;
            }
            return nombre;
        }
    }
}
