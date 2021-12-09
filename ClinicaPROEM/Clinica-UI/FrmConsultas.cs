using Entidades;
using Excepciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica_UI
{
    public partial class FrmConsultas : Form
    {
        public FrmConsultas()
        {
            InitializeComponent();
        }
        private void FrmConsultas_Load(object sender, EventArgs e)
        {
            FillDataGridView(this.dtgvMedicos, Clinica.Medicos);
            FillDataGridView(this.dtgvPacientes, Clinica.Pacientes);
            this.txtNombreMedico.Enabled = false;
            this.cmbEspecialidad.Enabled = false;
            cmbEspecialidad.Items.AddRange(Enum.GetNames(typeof(EEspecialidad)));
            cmbEspecialidad.SelectedIndex = 0;
        }
        /// <summary>
        /// Llena un data grid view de Pacientes con sus datos, en base a una lista que le enviamos por parametro.
        /// </summary>
        /// <param name="dtgv"></param>
        /// <param name="pacientes"></param>
        public static void FillDataGridView(DataGridView dtgv, List<Paciente> pacientes)
        {
            dtgv.Rows.Clear();
            int n;
            foreach (Paciente item in pacientes)
            {
                n = dtgv.Rows.Add();
                dtgv.Rows[n].Cells[0].Value = item.Nombre;
                dtgv.Rows[n].Cells[1].Value = item.Apellido;
                dtgv.Rows[n].Cells[2].Value = item.Edad;
                dtgv.Rows[n].Cells[3].Value = item.Dni;
                dtgv.Rows[n].Cells[4].Value = item.ObraSocial;
                if (!item.Estado)
                    dtgv.Rows[n].Cells[5].Value = "Sin atender";
                else
                    dtgv.Rows[n].Cells[5].Value = "Atendido";

            }
        }
        /// <summary>
        /// Llena un data grid view de Pacientes con sus datos, en base a una cola que le enviamos por parametro.
        /// </summary>
        /// <param name="dtgv"></param>
        /// <param name="pacientes"></param>
        public static void FillDataGridView(DataGridView dtgv, Queue<Paciente> pacientes)
        {
            dtgv.Rows.Clear();
            int n;
            foreach (Paciente item in pacientes)
            {
                n = dtgv.Rows.Add();
                dtgv.Rows[n].Cells[0].Value = item.Nombre;
                dtgv.Rows[n].Cells[1].Value = item.Apellido;
                dtgv.Rows[n].Cells[2].Value = item.Edad;
                dtgv.Rows[n].Cells[3].Value = item.Dni;
                dtgv.Rows[n].Cells[4].Value = item.ObraSocial;
                if (!item.Estado)
                    dtgv.Rows[n].Cells[5].Value = "Sin atender";
                else
                    dtgv.Rows[n].Cells[5].Value = "Atendido";

            }
        }
        /// <summary>
        /// Llena un data grid view de Medicos con sus datos, en base a una lista que le enviamos por parametro.
        /// </summary>
        /// <param name="dtgv"></param>
        /// <param name="pacientes"></param>
        public static void FillDataGridView(DataGridView dtgv, List<Medico> medicos)
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
                dtgv.Rows[n].Cells[4].Value = item.Estado();

            }
        }
        /// <summary>
        /// Cambia el estado de la consulta de un paciente.
        /// </summary>
        /// <param name="pac"></param>
        private void CambiarEstadoConsulta(Paciente pac)
        {
            foreach (Consulta item in Clinica.Consultas)
            {
                if(pac.Dni == item.Paciente.Dni)
                {
                    if(item.Estado)
                    {
                        item.Estado = false;
                    }
                }
            }
        }
        private void btnNewConsulta_Click(object sender, EventArgs e)
        {
            Medico medAux;
            Paciente pacAux;
            bool noMedic = true;
            try
            {
                if (Clinica.PacientesEnEspera.Count > 0)
                {
                    pacAux = Clinica.PacientesEnEspera.Peek();
                    foreach (Medico item in Clinica.Medicos)
                    {
                        if (this.txtNombreMedico.Enabled)
                        {
                            if (this.txtNombreMedico.Text == item.Nombre)
                            {
                                if(!item.atendiendo)
                                {
                                    if (!pacAux.Estado)
                                    {
                                        medAux = item;
                                        Clinica.Consultas.Add(Consulta.NewConsulta(medAux, pacAux));
                                        pacAux.Estado = true;
                                        medAux.atendiendo = true;
                                        MessageBox.Show("Consulta generada con exito, puede ver los cambios abajo!", "Consulta exitosa!");
                                        pacAux.MedicoAsignado = medAux;
                                        noMedic = false;
                                        break;
                                    }
                                }
                                else
                                {
                                    throw new AvailabilityException("Este profesional ya se encuentra en una consulta, espere a que esta termine.");
                                }
                            }
                        }
                        else
                        {
                            EEspecialidad especialidad = (EEspecialidad)this.cmbEspecialidad.SelectedIndex;
                            if (item.Especialidad == especialidad && !item.atendiendo)
                            {
                                medAux = item;
                                Clinica.Consultas.Add(Consulta.NewConsulta(medAux, pacAux));
                                pacAux.Estado = true;
                                medAux.atendiendo = true;
                                MessageBox.Show("Consulta generada con exito, puede ver los cambios abajo!", "Consulta exitosa!");
                                pacAux.MedicoAsignado = medAux;
                                noMedic = false;
                                break;
                            }
                        }
                    }
                    if (noMedic)
                    {
                        throw new AvailabilityException("No hay medicos disponibles con este nombre o especialidad,\nPida un turno con 2 dias habiles de anticipacion en nuestro sitio web\nwww.PROEMClinica.com.ar");
                    }
                    FillDataGridView(this.dtgvMedicos, Clinica.Medicos);
                    FillDataGridView(this.dtgvPacientes, Clinica.PacientesEnEspera);
                    Clinica.PacientesEnEspera.Dequeue();
                }
                else
                {
                    throw new EmptyQueueException("Ya no quedan mas pacientes en lista de espera.");
                }
            }
            catch(EmptyQueueException ex)
            {
                MessageBox.Show(ex.Message, "No hay mas pacientes.");
            }
            catch(AvailabilityException ex)
            {
                MessageBox.Show(ex.Message, "Problema por disponibilidad.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Ah ocurrido un problema.");
            }
           
        }
        private void rdbNombre_CheckedChanged(object sender, EventArgs e)
        {
            this.txtNombreMedico.Enabled = true;
            this.cmbEspecialidad.Enabled = false;
        }
        private void rdbEspecialidad_CheckedChanged(object sender, EventArgs e)
        {
            this.txtNombreMedico.Enabled = false;
            this.cmbEspecialidad.Enabled = true;
        }
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();
            foreach (Paciente item in Clinica.Pacientes)
            {
                if (this.txtDniPacienteFin.Text.Trim() == item.Dni.ToString())
                {
                    if (item.Estado)
                    {
                        try
                        {
                            sb.AppendLine("================================\n==== Observaciones Generales =====\n================================");
                            sb.AppendLine("Datos del Paciente:");
                            sb.AppendLine($"Nombre y Apellido: {item.Nombre} {item.Apellido}");
                            sb.AppendLine($"Edad: {item.Edad} años.");
                            sb.AppendLine($"DNI: {item.Dni}");
                            sb.AppendLine($"Obra social: {item.ObraSocial}");
                            if(item.MedicoAsignado is not null)
                                sb.AppendLine($"Medico: Dr.{item.MedicoAsignado.Apellido}, {item.MedicoAsignado.Especialidad}");
                            sb.AppendLine(this.txtObservaciones.Text);
                            sb.AppendLine("\n");
                            switch (item.ObraSocial)
                            {
                                case EObraSocial.NoTiene:
                                    sb.AppendLine($"Total a abonar: ${rnd.Next(5000, 10000)}");
                                    break;
                                case EObraSocial.CoberturaBasica:
                                    sb.AppendLine($"Total a abonar: ${rnd.Next(1000,5000)}");
                                    break;
                                case EObraSocial.CoberturaCompleta:
                                    sb.AppendLine($"Total a abonar: A cargo de la obra social.");
                                    break;
                                default:
                                    break;
                            }
                            ArchivoText.Escribir(sb.ToString(), Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),$"{item.Nombre}{item.Dni}{rnd.Next(000000,999999)}.txt"));
                            MessageBox.Show("Consulta finalizada con exito.\nTicket generado en el escritorio.");
                            List<Medico> lista = Clinica.Medicos;
                            item.Estado = false;
                            item.MedicoAsignado.atendiendo = false;
                            item.MedicoAsignado.CantAtendidos += 1;
                            item.MedicoAsignado = null;
                            CambiarEstadoConsulta(item);
                            //Quitar esta linea de abajo en caso de no querer re utilizar a los pacientes.
                            Clinica.PacientesEnEspera.Enqueue(item);
                            FillDataGridView(this.dtgvMedicos, Clinica.Medicos);
                            FillDataGridView(this.dtgvPacientes, Clinica.PacientesEnEspera);
                            break;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error al intentar finalizar la consulta.");
                        }
                    }
                }
            }
        }
       
    }
}
