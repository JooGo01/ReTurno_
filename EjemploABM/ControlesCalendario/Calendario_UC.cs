using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploABM.ControlesCalendario
{
    public partial class Calendario_UC : UserControl
    {
        public Calendario_UC()
        {
            InitializeComponent();
        }

        private void Calendario_UC_Load(object sender, EventArgs e)
        {
        }

        private void btnExpandir_Click(object sender, EventArgs e)
        {
            this.Width = 843;
            resizePanel();
        }

        private void btnContraer_Click(object sender, EventArgs e)
        {
            this.Width = 276;
            resizePanel();
        }

        private void resizePanel() {
            Form formularioPadre = this.ParentForm as Form;
            if (formularioPadre != null)
            {
                Panel pnl = new Panel();
                pnl = (Panel)formularioPadre.Controls.Find("panel_actividad", true).First();
                if (pnl != null) {
                    pnl.Width = this.Width;
                }
                /*foreach (Control ctlEvento in formularioPadre.Controls)
                {
                    if (ctlEvento.GetType() == typeof(MaterialTabControl))
                    {
                        foreach (Control ctlTab in ctlEvento.Controls)
                        {
                            Trace.WriteLine(ctlTab.GetType().Name);
                            foreach (Control ctlPanel in ctlTab.Controls)
                            {
                                Trace.WriteLine(ctlPanel.GetType().Name);
                                if (ctlPanel.GetType() == typeof(Panel))
                                {
                                    Panel panel_actividad = (Panel)ctlPanel;
                                    if (panel_actividad.Name.Contains("panel_actividad"))
                                    {
                                        panel_actividad.Width = this.Width;
                                    }
                                }
                            }
                        }
                    }
                }*/
            }
        }

        private void btnAgregarEvento_Click(object sender, EventArgs e)
        {

        }
    }
}
