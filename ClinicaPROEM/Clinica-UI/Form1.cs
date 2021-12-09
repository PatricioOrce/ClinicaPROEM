using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Clinica_UI
{
    public partial class Form1 : Form
    {
        FrmConsultas frmConsultas;
        FrmEstadistica frmEstadistica;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            FillDataGridView(dtgvConsulta, Clinica.Consultas);
        }
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            frmConsultas = new FrmConsultas();
            frmConsultas.Show();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnClinica_Click(object sender, EventArgs e)
        {
            frmEstadistica = new FrmEstadistica();
            frmEstadistica.Show();
        }
        /// <summary>
        /// Llena un data grid view con los datos de una lista de consultas enviada por parametro. 
        /// </summary>
        /// <param name="dtgv"></param>
        /// <param name="consultas"></param>
        public static void FillDataGridView(DataGridView dtgv, List<Consulta> consultas)
        {
            dtgv.Rows.Clear();
            int n;
            foreach (Consulta item in consultas)
            {
                n = dtgv.Rows.Add();
                dtgv.Rows[n].Cells[0].Value = item.Id;
                dtgv.Rows[n].Cells[1].Value = item.Paciente.Nombre;
                dtgv.Rows[n].Cells[2].Value = item.Medico.Nombre;
                dtgv.Rows[n].Cells[3].Value = item.EstadoStr();
               

            }
        }
        private void btnActualizarConsultas_Click(object sender, EventArgs e)
        {
            FillDataGridView(dtgvConsulta, Clinica.Consultas);
        }
    }
}
