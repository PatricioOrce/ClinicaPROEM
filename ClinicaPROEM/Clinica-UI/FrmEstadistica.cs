using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica_UI
{
    public partial class FrmEstadistica : Form
    {
        public FrmEstadistica()
        {
            InitializeComponent();
        }
        private void FrmEstadistica_Load(object sender, EventArgs e)
        {
            FillDataGridView(dtgvMedicos, Estadisticas.MedOrderedByAtendQty());
            this.lblMedMayor.Text = $"El medico con mayor cantidad de pacientes atendidos es:\n{Estadisticas.MedicoMasPacientes().Nombre} {Estadisticas.MedicoMasPacientes().Apellido}";
            this.lblMedMenor.Text = $"El medico con menor cantidad de pacientes atendidos es:\n{Estadisticas.MedicoMenosPacientes().Nombre} {Estadisticas.MedicoMenosPacientes().Apellido}";
            this.lblMayorEsp.Text = $"La especialidad con mas cantidad de consultas es: \n{Estadisticas.EspConMasConsultas()}";
        }
        /// <summary>
        /// Llena un data grid view con los datos de un array de medicos enviado por parametro.
        /// </summary>
        /// <param name="dtgv"></param>
        /// <param name="medicos"></param>
        public static void FillDataGridView(DataGridView dtgv, Medico[] medicos)
        {
            dtgv.Rows.Clear();
            int n;
            foreach (Medico item in medicos)
            {
                n = dtgv.Rows.Add();
                dtgv.Rows[n].Cells[0].Value = item.Nombre;
                dtgv.Rows[n].Cells[1].Value = item.Apellido;
                dtgv.Rows[n].Cells[2].Value = item.Edad;
                dtgv.Rows[n].Cells[3].Value = item.Especialidad;
                dtgv.Rows[n].Cells[4].Value = item.CantAtendidos;
            }
        }
    }
}
