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
        public FormCalendario()
        {
            InitializeComponent();
        }

        private void FormCalendario_Load(object sender, EventArgs e)
        {
            crearDias();
            ajustePanel();
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
                panel_semana0,
                panel_semana1,
                panel_semana2,
                panel_semana3,
                panel_semana4,
                panel_semana5,
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
    }
}
