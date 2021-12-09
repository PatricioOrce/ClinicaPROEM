
namespace Clinica_UI
{
    partial class FrmConsultas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultas));
            this.lblPacientes = new System.Windows.Forms.Label();
            this.lblMedicos = new System.Windows.Forms.Label();
            this.dtgvPacientes = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obraSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvMedicos = new System.Windows.Forms.DataGridView();
            this.bame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbEspecialidad = new System.Windows.Forms.RadioButton();
            this.rdbNombre = new System.Windows.Forms.RadioButton();
            this.btnNewConsulta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreMedico = new System.Windows.Forms.TextBox();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.lblNuevaConsulta = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDniPacienteFin = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedicos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPacientes
            // 
            this.lblPacientes.AutoSize = true;
            this.lblPacientes.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblPacientes.Location = new System.Drawing.Point(431, 314);
            this.lblPacientes.Name = "lblPacientes";
            this.lblPacientes.Size = new System.Drawing.Size(80, 16);
            this.lblPacientes.TabIndex = 7;
            this.lblPacientes.Text = "Pacientes:";
            // 
            // lblMedicos
            // 
            this.lblMedicos.AutoSize = true;
            this.lblMedicos.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblMedicos.Location = new System.Drawing.Point(431, 9);
            this.lblMedicos.Name = "lblMedicos";
            this.lblMedicos.Size = new System.Drawing.Size(65, 16);
            this.lblMedicos.TabIndex = 6;
            this.lblMedicos.Text = "Medicos:";
            // 
            // dtgvPacientes
            // 
            this.dtgvPacientes.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dtgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.dataGridViewTextBoxColumn1,
            this.pacAge,
            this.dni,
            this.obraSocial,
            this.estado});
            this.dtgvPacientes.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvPacientes.Location = new System.Drawing.Point(431, 333);
            this.dtgvPacientes.Name = "dtgvPacientes";
            this.dtgvPacientes.RowTemplate.Height = 25;
            this.dtgvPacientes.Size = new System.Drawing.Size(642, 262);
            this.dtgvPacientes.TabIndex = 5;
            // 
            // name
            // 
            this.name.Frozen = true;
            this.name.HeaderText = "Nombre";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pacAge
            // 
            this.pacAge.Frozen = true;
            this.pacAge.HeaderText = "Edad";
            this.pacAge.Name = "pacAge";
            this.pacAge.ReadOnly = true;
            this.pacAge.Width = 50;
            // 
            // dni
            // 
            this.dni.Frozen = true;
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            // 
            // obraSocial
            // 
            this.obraSocial.Frozen = true;
            this.obraSocial.HeaderText = "ObraSocial";
            this.obraSocial.Name = "obraSocial";
            this.obraSocial.ReadOnly = true;
            this.obraSocial.Width = 150;
            // 
            // estado
            // 
            this.estado.Frozen = true;
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // dtgvMedicos
            // 
            this.dtgvMedicos.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dtgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMedicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bame,
            this.lastname,
            this.age,
            this.labor,
            this.state});
            this.dtgvMedicos.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvMedicos.Location = new System.Drawing.Point(431, 28);
            this.dtgvMedicos.Name = "dtgvMedicos";
            this.dtgvMedicos.RowTemplate.Height = 25;
            this.dtgvMedicos.Size = new System.Drawing.Size(544, 273);
            this.dtgvMedicos.TabIndex = 4;
            // 
            // bame
            // 
            this.bame.Frozen = true;
            this.bame.HeaderText = "Nombre";
            this.bame.Name = "bame";
            this.bame.ReadOnly = true;
            // 
            // lastname
            // 
            this.lastname.Frozen = true;
            this.lastname.HeaderText = "Apellido";
            this.lastname.Name = "lastname";
            this.lastname.ReadOnly = true;
            // 
            // age
            // 
            this.age.Frozen = true;
            this.age.HeaderText = "Edad";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            // 
            // labor
            // 
            this.labor.Frozen = true;
            this.labor.HeaderText = "Especialidad";
            this.labor.Name = "labor";
            this.labor.ReadOnly = true;
            // 
            // state
            // 
            this.state.Frozen = true;
            this.state.HeaderText = "Estado";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbEspecialidad);
            this.panel1.Controls.Add(this.rdbNombre);
            this.panel1.Controls.Add(this.btnNewConsulta);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNombreMedico);
            this.panel1.Controls.Add(this.cmbEspecialidad);
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 161);
            this.panel1.TabIndex = 8;
            // 
            // rdbEspecialidad
            // 
            this.rdbEspecialidad.AutoSize = true;
            this.rdbEspecialidad.Location = new System.Drawing.Point(256, 41);
            this.rdbEspecialidad.Name = "rdbEspecialidad";
            this.rdbEspecialidad.Size = new System.Drawing.Size(90, 19);
            this.rdbEspecialidad.TabIndex = 20;
            this.rdbEspecialidad.TabStop = true;
            this.rdbEspecialidad.Text = "Especialidad";
            this.rdbEspecialidad.UseVisualStyleBackColor = true;
            this.rdbEspecialidad.CheckedChanged += new System.EventHandler(this.rdbEspecialidad_CheckedChanged);
            // 
            // rdbNombre
            // 
            this.rdbNombre.AutoSize = true;
            this.rdbNombre.Location = new System.Drawing.Point(34, 41);
            this.rdbNombre.Name = "rdbNombre";
            this.rdbNombre.Size = new System.Drawing.Size(72, 19);
            this.rdbNombre.TabIndex = 19;
            this.rdbNombre.TabStop = true;
            this.rdbNombre.Text = "Nombre:";
            this.rdbNombre.UseVisualStyleBackColor = true;
            this.rdbNombre.CheckedChanged += new System.EventHandler(this.rdbNombre_CheckedChanged);
            // 
            // btnNewConsulta
            // 
            this.btnNewConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewConsulta.Location = new System.Drawing.Point(147, 116);
            this.btnNewConsulta.Name = "btnNewConsulta";
            this.btnNewConsulta.Size = new System.Drawing.Size(121, 23);
            this.btnNewConsulta.TabIndex = 17;
            this.btnNewConsulta.Text = "Generar Consulta";
            this.btnNewConsulta.UseVisualStyleBackColor = true;
            this.btnNewConsulta.Click += new System.EventHandler(this.btnNewConsulta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Asignar medico por:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "O";
            // 
            // txtNombreMedico
            // 
            this.txtNombreMedico.Location = new System.Drawing.Point(34, 61);
            this.txtNombreMedico.Name = "txtNombreMedico";
            this.txtNombreMedico.Size = new System.Drawing.Size(127, 23);
            this.txtNombreMedico.TabIndex = 11;
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(256, 61);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(121, 23);
            this.cmbEspecialidad.TabIndex = 10;
            // 
            // lblNuevaConsulta
            // 
            this.lblNuevaConsulta.AutoSize = true;
            this.lblNuevaConsulta.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblNuevaConsulta.Location = new System.Drawing.Point(0, 20);
            this.lblNuevaConsulta.Name = "lblNuevaConsulta";
            this.lblNuevaConsulta.Size = new System.Drawing.Size(120, 16);
            this.lblNuevaConsulta.TabIndex = 9;
            this.lblNuevaConsulta.Text = "Nueva consulta:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFinalizar);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtObservaciones);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtDniPacienteFin);
            this.panel2.Location = new System.Drawing.Point(0, 352);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 205);
            this.panel2.TabIndex = 19;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Location = new System.Drawing.Point(261, 60);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(121, 23);
            this.btnFinalizar.TabIndex = 19;
            this.btnFinalizar.Text = "Finalizar Consulta";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(25, 117);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(357, 68);
            this.txtObservaciones.TabIndex = 16;
            this.txtObservaciones.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "DNI del Paciente:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(384, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "A continuacion te solicitaremos algunos datos para finalizar la consulta:\r\n";
            // 
            // txtDniPacienteFin
            // 
            this.txtDniPacienteFin.Location = new System.Drawing.Point(25, 61);
            this.txtDniPacienteFin.Name = "txtDniPacienteFin";
            this.txtDniPacienteFin.Size = new System.Drawing.Size(127, 23);
            this.txtDniPacienteFin.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(0, 333);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 16);
            this.label13.TabIndex = 20;
            this.label13.Text = "Finalizar Consulta:";
            // 
            // FrmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1080, 604);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblNuevaConsulta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPacientes);
            this.Controls.Add(this.lblMedicos);
            this.Controls.Add(this.dtgvPacientes);
            this.Controls.Add(this.dtgvMedicos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultas";
            this.Text = "Gestionador de Consultas";
            this.Load += new System.EventHandler(this.FrmConsultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedicos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPacientes;
        private System.Windows.Forms.Label lblMedicos;
        private System.Windows.Forms.DataGridView dtgvPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn obraSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridView dtgvMedicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn bame;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn labor;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreMedico;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Label lblNuevaConsulta;
        private System.Windows.Forms.Button btnNewConsulta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtObservaciones;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDniPacienteFin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.RadioButton rdbEspecialidad;
        private System.Windows.Forms.RadioButton rdbNombre;
    }
}