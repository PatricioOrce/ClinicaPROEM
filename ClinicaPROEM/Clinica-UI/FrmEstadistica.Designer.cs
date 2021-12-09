
namespace Clinica_UI
{
    partial class FrmEstadistica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstadistica));
            this.dtgvMedicos = new System.Windows.Forms.DataGridView();
            this.bame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMedMayor = new System.Windows.Forms.Label();
            this.lblMedMenor = new System.Windows.Forms.Label();
            this.lblMayorEsp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvMedicos
            // 
            this.dtgvMedicos.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dtgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMedicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bame,
            this.lastname,
            this.age,
            this.labor,
            this.state});
            this.dtgvMedicos.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvMedicos.Location = new System.Drawing.Point(442, 12);
            this.dtgvMedicos.Name = "dtgvMedicos";
            this.dtgvMedicos.RowTemplate.Height = 25;
            this.dtgvMedicos.Size = new System.Drawing.Size(544, 313);
            this.dtgvMedicos.TabIndex = 5;
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
            this.state.HeaderText = "Atendidos";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            // 
            // lblMedMayor
            // 
            this.lblMedMayor.AutoSize = true;
            this.lblMedMayor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMedMayor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMedMayor.Location = new System.Drawing.Point(12, 34);
            this.lblMedMayor.Name = "lblMedMayor";
            this.lblMedMayor.Size = new System.Drawing.Size(41, 15);
            this.lblMedMayor.TabIndex = 6;
            this.lblMedMayor.Text = "label1";
            // 
            // lblMedMenor
            // 
            this.lblMedMenor.AutoSize = true;
            this.lblMedMenor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMedMenor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMedMenor.Location = new System.Drawing.Point(12, 125);
            this.lblMedMenor.Name = "lblMedMenor";
            this.lblMedMenor.Size = new System.Drawing.Size(41, 15);
            this.lblMedMenor.TabIndex = 7;
            this.lblMedMenor.Text = "label2";
            // 
            // lblMayorEsp
            // 
            this.lblMayorEsp.AutoSize = true;
            this.lblMayorEsp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMayorEsp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMayorEsp.Location = new System.Drawing.Point(12, 223);
            this.lblMayorEsp.Name = "lblMayorEsp";
            this.lblMayorEsp.Size = new System.Drawing.Size(41, 15);
            this.lblMayorEsp.TabIndex = 8;
            this.lblMayorEsp.Text = "label3";
            // 
            // FrmEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(998, 333);
            this.Controls.Add(this.lblMayorEsp);
            this.Controls.Add(this.lblMedMenor);
            this.Controls.Add(this.lblMedMayor);
            this.Controls.Add(this.dtgvMedicos);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEstadistica";
            this.Text = "Estadisticas de la Clinica";
            this.Load += new System.EventHandler(this.FrmEstadistica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvMedicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn bame;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn labor;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.Label lblMedMayor;
        private System.Windows.Forms.Label lblMedMenor;
        private System.Windows.Forms.Label lblMayorEsp;
    }
}