namespace ProyectoClase.Formularios
{
	partial class frmCitas
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
			this.txtCedula = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.cmbMascota = new System.Windows.Forms.ComboBox();
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbDisponibilidad = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnConsulta = new System.Windows.Forms.Button();
			this.btnModificacion = new System.Windows.Forms.Button();
			this.btnIngreso = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.ltbHora = new System.Windows.Forms.ListBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Cyan;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(348, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 42);
			this.label1.TabIndex = 0;
			this.label1.Text = "Citas";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.PaleTurquoise;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(85, 178);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(143, 42);
			this.label2.TabIndex = 1;
			this.label2.Text = "Cedula";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.PaleTurquoise;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(85, 261);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(156, 42);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nombre";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.PaleTurquoise;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(85, 355);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(167, 42);
			this.label4.TabIndex = 3;
			this.label4.Text = "Mascota";
			// 
			// txtCedula
			// 
			this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCedula.Location = new System.Drawing.Point(253, 175);
			this.txtCedula.Name = "txtCedula";
			this.txtCedula.Size = new System.Drawing.Size(203, 45);
			this.txtCedula.TabIndex = 4;
			this.txtCedula.Leave += new System.EventHandler(this.txtCedula_Leave);
			// 
			// txtNombre
			// 
			this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(253, 272);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(319, 45);
			this.txtNombre.TabIndex = 5;
			// 
			// cmbMascota
			// 
			this.cmbMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbMascota.FormattingEnabled = true;
			this.cmbMascota.Location = new System.Drawing.Point(271, 356);
			this.cmbMascota.Name = "cmbMascota";
			this.cmbMascota.Size = new System.Drawing.Size(314, 46);
			this.cmbMascota.TabIndex = 6;
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Location = new System.Drawing.Point(205, 428);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.PaleTurquoise;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(36, 667);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(265, 42);
			this.label5.TabIndex = 8;
			this.label5.Text = "Disponibilidad";
			// 
			// cmbDisponibilidad
			// 
			this.cmbDisponibilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbDisponibilidad.FormattingEnabled = true;
			this.cmbDisponibilidad.Location = new System.Drawing.Point(307, 668);
			this.cmbDisponibilidad.Name = "cmbDisponibilidad";
			this.cmbDisponibilidad.Size = new System.Drawing.Size(314, 46);
			this.cmbDisponibilidad.TabIndex = 9;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
			this.panel1.Controls.Add(this.btnGuardar);
			this.panel1.Controls.Add(this.btnCancelar);
			this.panel1.Controls.Add(this.btnConsulta);
			this.panel1.Controls.Add(this.btnModificacion);
			this.panel1.Controls.Add(this.btnIngreso);
			this.panel1.Location = new System.Drawing.Point(753, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(445, 739);
			this.panel1.TabIndex = 10;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.Location = new System.Drawing.Point(117, 569);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(240, 66);
			this.btnGuardar.TabIndex = 4;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Location = new System.Drawing.Point(117, 452);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(240, 66);
			this.btnCancelar.TabIndex = 3;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnConsulta
			// 
			this.btnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConsulta.Location = new System.Drawing.Point(117, 321);
			this.btnConsulta.Name = "btnConsulta";
			this.btnConsulta.Size = new System.Drawing.Size(240, 66);
			this.btnConsulta.TabIndex = 2;
			this.btnConsulta.Text = "Consulta";
			this.btnConsulta.UseVisualStyleBackColor = true;
			this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
			// 
			// btnModificacion
			// 
			this.btnModificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificacion.Location = new System.Drawing.Point(117, 212);
			this.btnModificacion.Name = "btnModificacion";
			this.btnModificacion.Size = new System.Drawing.Size(240, 66);
			this.btnModificacion.TabIndex = 1;
			this.btnModificacion.Text = "Modificacion";
			this.btnModificacion.UseVisualStyleBackColor = true;
			this.btnModificacion.Click += new System.EventHandler(this.btnModificacion_Click);
			// 
			// btnIngreso
			// 
			this.btnIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIngreso.Location = new System.Drawing.Point(142, 98);
			this.btnIngreso.Name = "btnIngreso";
			this.btnIngreso.Size = new System.Drawing.Size(175, 66);
			this.btnIngreso.TabIndex = 0;
			this.btnIngreso.Text = "Ingreso";
			this.btnIngreso.UseVisualStyleBackColor = true;
			this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.PaleTurquoise;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(591, 405);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(103, 42);
			this.label6.TabIndex = 11;
			this.label6.Text = "Hora";
			// 
			// ltbHora
			// 
			this.ltbHora.FormattingEnabled = true;
			this.ltbHora.ItemHeight = 16;
			this.ltbHora.Items.AddRange(new object[] {
            "8:00 AM – 8:30 AM",
            "",
            "8:30 AM – 9:00 AM",
            "",
            "9:00 AM – 9:30 AM",
            "",
            "9:30 AM – 10:00 AM",
            "",
            "10:00 AM – 10:30 AM",
            "",
            "10:30 AM – 11:00 AM",
            "",
            "11:00 AM – 11:30 AM",
            "",
            "11:30 AM – 12:00 PM",
            "",
            "12:00 PM – 12:30 PM",
            "",
            "12:30 PM – 1:00 PM",
            "",
            "1:00 PM – 1:30 PM",
            "",
            "1:30 PM – 2:00 PM",
            "",
            "2:00 PM – 2:30 PM",
            "",
            "2:30 PM – 3:00 PM",
            "",
            "3:00 PM – 3:30 PM",
            "",
            "3:30 PM – 4:00 PM",
            "",
            "4:00 PM – 4:30 PM",
            "",
            "4:30 PM – 5:00 PM",
            "",
            "5:00 PM – 5:30 PM"});
			this.ltbHora.Location = new System.Drawing.Point(563, 452);
			this.ltbHora.Name = "ltbHora";
			this.ltbHora.Size = new System.Drawing.Size(155, 196);
			this.ltbHora.TabIndex = 12;
			// 
			// frmCitas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1194, 736);
			this.Controls.Add(this.ltbHora);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.cmbDisponibilidad);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.monthCalendar1);
			this.Controls.Add(this.cmbMascota);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtCedula);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmCitas";
			this.Text = "frmCitas";
			this.Load += new System.EventHandler(this.frmCitas_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtCedula;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.ComboBox cmbMascota;
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbDisponibilidad;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnModificacion;
		private System.Windows.Forms.Button btnIngreso;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ListBox ltbHora;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnConsulta;
	}
}