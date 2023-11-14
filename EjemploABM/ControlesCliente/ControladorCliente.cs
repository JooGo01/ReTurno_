﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjemploABM.Controladores;
using EjemploABM.Modelo;

namespace EjemploABM.ControlesCliente
{
    public partial class ControladorCliente : UserControl
    {
        public ControladorCliente()
        {
            InitializeComponent();
            btnAgregar.Visible = false;
            cargarCliente();
        }

        private void cargarCliente()
        {
            Cliente cli = new Cliente();

            if (Program.logueado.tipo_usuario == "S")
            {
                cli = Cliente_Controller.obtenerPorId(Program.cli.id);
            }
            
            dgv_evento.Rows.Clear();
            int rowIndex = dgv_evento.Rows.Add();
            dgv_evento.Rows[rowIndex].Cells[0].Value = cli.id.ToString();
            dgv_evento.Rows[rowIndex].Cells[1].Value = cli.razon_social.ToString();
            dgv_evento.Rows[rowIndex].Cells[2].Value = cli.rubro.nombre.ToString();
            dgv_evento.Rows[rowIndex].Cells[3].Value = cli.usr.id.ToString();
            dgv_evento.Rows[rowIndex].Cells[4].Value = cli.usr.email.ToString();
            dgv_evento.Rows[rowIndex].Cells[5].Value = "Editar";
            dgv_evento.Rows[rowIndex].Cells[6].Value = "Eliminar";
        }

        private void dgv_evento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            //String id_check = dgv_evento.Rows[e.RowIndex].Cells[0].Value.ToString();
            if ((dgv_evento.Rows[e.RowIndex].Cells[0].Value) != null)
            {
                if (e.ColumnIndex == 6 && senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    //eliminar
                    String id_baja = dgv_evento.Rows[e.RowIndex].Cells[0].Value.ToString();
                    Cliente cli_baja = new Cliente();
                    cli_baja = Cliente_Controller.obtenerPorId(Int32.Parse(id_baja));
                    Cliente_Controller.bajaSucursalCliente(cli_baja, 1);
                    MessageBox.Show("Cliente dado de baja con exito", "ReTurno");
                    //TODO - Button Clicked - Execute Code Here
                }

                if (e.ColumnIndex == 5 && senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    //editar
                    String id = dgv_evento.Rows[e.RowIndex].Cells[0].Value.ToString();
                    Cliente cli = new Cliente();
                    cli = Cliente_Controller.obtenerPorId(Int32.Parse(id));
                    FormClienteEditar frmCliEdit = new FormClienteEditar(cli);

                    DialogResult dr = frmCliEdit.ShowDialog();

                    if (dr == DialogResult.OK)
                    {
                    }
                    //TODO - Button Clicked - Execute Code Here
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
