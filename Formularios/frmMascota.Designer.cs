namespace ProyectoClase.Formularios
{
    partial class frmMascota
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtCedula = new System.Windows.Forms.TextBox();
			this.txtNombreP = new System.Windows.Forms.TextBox();
			this.txtRaza = new System.Windows.Forms.TextBox();
			this.txtSexo = new System.Windows.Forms.TextBox();
			this.cmbMascota = new System.Windows.Forms.ComboBox();
			this.cmbEspecie = new System.Windows.Forms.ComboBox();
			this.mskFecha = new System.Windows.Forms.MaskedTextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.btnIngreso = new System.Windows.Forms.Button();
			this.btnModificacion = new System.Windows.Forms.Button();
			this.btnConsulta = new System.Windows.Forms.Button();
			this.btnRetiro = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(253, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(348, 46);
			this.label1.TabIndex = 0;
			this.label1.Text = "Registro Mascota";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 146);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(136, 38);
			this.label2.TabIndex = 1;
			this.label2.Text = "Cedula:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 207);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(327, 38);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nombre Propietario:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 273);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(290, 38);
			this.label4.TabIndex = 3;
			this.label4.Text = "Nombre Mascota:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 332);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(151, 38);
			this.label5.TabIndex = 4;
			this.label5.Text = "Especie:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(12, 394);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(108, 38);
			this.label6.TabIndex = 5;
			this.label6.Text = "Raza:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(12, 452);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(306, 38);
			this.label7.TabIndex = 6;
			this.label7.Text = "Fecha Nacimiento:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(12, 515);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(106, 38);
			this.label8.TabIndex = 7;
			this.label8.Text = "Sexo:";
			// 
			// txtCedula
			// 
			this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCedula.Location = new System.Drawing.Point(176, 144);
			this.txtCedula.Name = "txtCedula";
			this.txtCedula.Size = new System.Drawing.Size(212, 41);
			this.txtCedula.TabIndex = 8;
			this.txtCedula.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
			this.txtCedula.Leave += new System.EventHandler(this.txtCedula_Leave);
			// 
			// txtNombreP
			// 
			this.txtNombreP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombreP.Location = new System.Drawing.Point(389, 207);
			this.txtNombreP.Name = "txtNombreP";
			this.txtNombreP.Size = new System.Drawing.Size(266, 41);
			this.txtNombreP.TabIndex = 9;
			// 
			// txtRaza
			// 
			this.txtRaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRaza.Location = new System.Drawing.Point(152, 393);
			this.txtRaza.Name = "txtRaza";
			this.txtRaza.Size = new System.Drawing.Size(308, 41);
			this.txtRaza.TabIndex = 11;
			// 
			// txtSexo
			// 
			this.txtSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSexo.Location = new System.Drawing.Point(140, 513);
			this.txtSexo.Name = "txtSexo";
			this.txtSexo.Size = new System.Drawing.Size(289, 41);
			this.txtSexo.TabIndex = 12;
			// 
			// cmbMascota
			// 
			this.cmbMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbMascota.FormattingEnabled = true;
			this.cmbMascota.Items.AddRange(new object[] {
            "M",
            "F"});
			this.cmbMascota.Location = new System.Drawing.Point(337, 273);
			this.cmbMascota.Name = "cmbMascota";
			this.cmbMascota.Size = new System.Drawing.Size(318, 44);
			this.cmbMascota.TabIndex = 13;
			this.cmbMascota.SelectedIndexChanged += new System.EventHandler(this.cmbMascota_SelectedIndexChanged);
			// 
			// cmbEspecie
			// 
			this.cmbEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbEspecie.FormattingEnabled = true;
			this.cmbEspecie.Items.AddRange(new object[] {
            "M",
            "F"});
			this.cmbEspecie.Location = new System.Drawing.Point(176, 332);
			this.cmbEspecie.Name = "cmbEspecie";
			this.cmbEspecie.Size = new System.Drawing.Size(121, 44);
			this.cmbEspecie.TabIndex = 14;
			// 
			// mskFecha
			// 
			this.mskFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mskFecha.Location = new System.Drawing.Point(355, 450);
			this.mskFecha.Mask = "00/00/0000";
			this.mskFecha.Name = "mskFecha";
			this.mskFecha.Size = new System.Drawing.Size(263, 41);
			this.mskFecha.TabIndex = 15;
			this.mskFecha.ValidatingType = typeof(System.DateTime);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.label9.Location = new System.Drawing.Point(624, 462);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(122, 25);
			this.label9.TabIndex = 16;
			this.label9.Text = "dd/mm/aaaa";
			// 
			// btnIngreso
			// 
			this.btnIngreso.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIngreso.Location = new System.Drawing.Point(872, 186);
			this.btnIngreso.Name = "btnIngreso";
			this.btnIngreso.Size = new System.Drawing.Size(185, 80);
			this.btnIngreso.TabIndex = 17;
			this.btnIngreso.Text = "Ingreso";
			this.btnIngreso.UseVisualStyleBackColor = false;
			this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
			// 
			// btnModificacion
			// 
			this.btnModificacion.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnModificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificacion.Location = new System.Drawing.Point(816, 273);
			this.btnModificacion.Name = "btnModificacion";
			this.btnModificacion.Size = new System.Drawing.Size(282, 80);
			this.btnModificacion.TabIndex = 18;
			this.btnModificacion.Text = "Modificacion";
			this.btnModificacion.UseVisualStyleBackColor = false;
			// 
			// btnConsulta
			// 
			this.btnConsulta.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConsulta.Location = new System.Drawing.Point(853, 359);
			this.btnConsulta.Name = "btnConsulta";
			this.btnConsulta.Size = new System.Drawing.Size(223, 80);
			this.btnConsulta.TabIndex = 19;
			this.btnConsulta.Text = "Consulta";
			this.btnConsulta.UseVisualStyleBackColor = false;
			// 
			// btnRetiro
			// 
			this.btnRetiro.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnRetiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRetiro.Location = new System.Drawing.Point(882, 445);
			this.btnRetiro.Name = "btnRetiro";
			this.btnRetiro.Size = new System.Drawing.Size(194, 80);
			this.btnRetiro.TabIndex = 20;
			this.btnRetiro.Text = "Retiro";
			this.btnRetiro.UseVisualStyleBackColor = false;
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.Location = new System.Drawing.Point(872, 531);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(204, 80);
			this.btnGuardar.TabIndex = 21;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = false;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// frmMascota
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1157, 733);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.btnRetiro);
			this.Controls.Add(this.btnConsulta);
			this.Controls.Add(this.btnModificacion);
			this.Controls.Add(this.btnIngreso);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.mskFecha);
			this.Controls.Add(this.cmbEspecie);
			this.Controls.Add(this.cmbMascota);
			this.Controls.Add(this.txtSexo);
			this.Controls.Add(this.txtRaza);
			this.Controls.Add(this.txtNombreP);
			this.Controls.Add(this.txtCedula);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmMascota";
			this.Text = "frmMasota";
			this.Load += new System.EventHandler(this.frmMascota_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.ComboBox cmbMascota;
        private System.Windows.Forms.ComboBox cmbEspecie;
        private System.Windows.Forms.MaskedTextBox mskFecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Button btnModificacion;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnRetiro;
        private System.Windows.Forms.Button btnGuardar;
    }
}