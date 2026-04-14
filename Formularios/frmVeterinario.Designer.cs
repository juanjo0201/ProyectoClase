namespace ProyectoClase.Formularios
{
    partial class frmVeterinario
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
			this.label5 = new System.Windows.Forms.Label();
			this.txtEspecializacion = new System.Windows.Forms.TextBox();
			this.txtTelefonoV = new System.Windows.Forms.TextBox();
			this.txtNombreV = new System.Windows.Forms.TextBox();
			this.txtCedulaV = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnUltimo = new System.Windows.Forms.Button();
			this.btnSiguiente = new System.Windows.Forms.Button();
			this.btnAnterior = new System.Windows.Forms.Button();
			this.btnPrimero = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnIngreso = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnConsulta = new System.Windows.Forms.Button();
			this.btnRetiro = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Enabled = false;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(168, 33);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(329, 69);
			this.label5.TabIndex = 17;
			this.label5.Text = "Veterinario";
			// 
			// txtEspecializacion
			// 
			this.txtEspecializacion.Enabled = false;
			this.txtEspecializacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEspecializacion.Location = new System.Drawing.Point(294, 462);
			this.txtEspecializacion.Name = "txtEspecializacion";
			this.txtEspecializacion.Size = new System.Drawing.Size(282, 49);
			this.txtEspecializacion.TabIndex = 25;
			// 
			// txtTelefonoV
			// 
			this.txtTelefonoV.Enabled = false;
			this.txtTelefonoV.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefonoV.Location = new System.Drawing.Point(239, 346);
			this.txtTelefonoV.Name = "txtTelefonoV";
			this.txtTelefonoV.Size = new System.Drawing.Size(282, 49);
			this.txtTelefonoV.TabIndex = 24;
			this.txtTelefonoV.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
			// 
			// txtNombreV
			// 
			this.txtNombreV.Enabled = false;
			this.txtNombreV.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombreV.Location = new System.Drawing.Point(239, 264);
			this.txtNombreV.Name = "txtNombreV";
			this.txtNombreV.Size = new System.Drawing.Size(282, 49);
			this.txtNombreV.TabIndex = 23;
			// 
			// txtCedulaV
			// 
			this.txtCedulaV.Enabled = false;
			this.txtCedulaV.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCedulaV.Location = new System.Drawing.Point(239, 180);
			this.txtCedulaV.Name = "txtCedulaV";
			this.txtCedulaV.Size = new System.Drawing.Size(282, 49);
			this.txtCedulaV.TabIndex = 22;
			this.txtCedulaV.TextChanged += new System.EventHandler(this.txtCedulaV_TextChanged);
			this.txtCedulaV.Leave += new System.EventHandler(this.txtCedulaV_Leave);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label4.Enabled = false;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 469);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(261, 38);
			this.label4.TabIndex = 21;
			this.label4.Text = "Especializacion: ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label3.Enabled = false;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(59, 346);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(161, 38);
			this.label3.TabIndex = 20;
			this.label3.Text = "Telefono: ";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(68, 264);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(142, 38);
			this.label2.TabIndex = 19;
			this.label2.Text = "Nombre:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(68, 187);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 38);
			this.label1.TabIndex = 18;
			this.label1.Text = "Cedula:";
			// 
			// btnUltimo
			// 
			this.btnUltimo.Location = new System.Drawing.Point(438, 570);
			this.btnUltimo.Name = "btnUltimo";
			this.btnUltimo.Size = new System.Drawing.Size(93, 47);
			this.btnUltimo.TabIndex = 29;
			this.btnUltimo.Text = ">>";
			this.btnUltimo.UseVisualStyleBackColor = true;
			this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
			// 
			// btnSiguiente
			// 
			this.btnSiguiente.Location = new System.Drawing.Point(310, 570);
			this.btnSiguiente.Name = "btnSiguiente";
			this.btnSiguiente.Size = new System.Drawing.Size(93, 47);
			this.btnSiguiente.TabIndex = 28;
			this.btnSiguiente.Text = ">";
			this.btnSiguiente.UseVisualStyleBackColor = true;
			this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
			// 
			// btnAnterior
			// 
			this.btnAnterior.Location = new System.Drawing.Point(180, 570);
			this.btnAnterior.Name = "btnAnterior";
			this.btnAnterior.Size = new System.Drawing.Size(93, 47);
			this.btnAnterior.TabIndex = 27;
			this.btnAnterior.Text = "<";
			this.btnAnterior.UseVisualStyleBackColor = true;
			this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
			// 
			// btnPrimero
			// 
			this.btnPrimero.Location = new System.Drawing.Point(56, 570);
			this.btnPrimero.Name = "btnPrimero";
			this.btnPrimero.Size = new System.Drawing.Size(93, 47);
			this.btnPrimero.TabIndex = 26;
			this.btnPrimero.Text = "<<";
			this.btnPrimero.UseVisualStyleBackColor = true;
			this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.btnGuardar);
			this.panel1.Controls.Add(this.btnIngreso);
			this.panel1.Controls.Add(this.btnModificar);
			this.panel1.Controls.Add(this.btnConsulta);
			this.panel1.Controls.Add(this.btnRetiro);
			this.panel1.Location = new System.Drawing.Point(683, -5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(396, 723);
			this.panel1.TabIndex = 30;
			// 
			// btnGuardar
			// 
			this.btnGuardar.AllowDrop = true;
			this.btnGuardar.Enabled = false;
			this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.Location = new System.Drawing.Point(110, 453);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(193, 49);
			this.btnGuardar.TabIndex = 35;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// btnIngreso
			// 
			this.btnIngreso.AllowDrop = true;
			this.btnIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIngreso.Location = new System.Drawing.Point(110, 140);
			this.btnIngreso.Name = "btnIngreso";
			this.btnIngreso.Size = new System.Drawing.Size(193, 55);
			this.btnIngreso.TabIndex = 31;
			this.btnIngreso.Text = "Ingreso";
			this.btnIngreso.UseVisualStyleBackColor = true;
			this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.AllowDrop = true;
			this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.Location = new System.Drawing.Point(71, 217);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(255, 49);
			this.btnModificar.TabIndex = 34;
			this.btnModificar.Text = "Modificacion";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// btnConsulta
			// 
			this.btnConsulta.AllowDrop = true;
			this.btnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConsulta.Location = new System.Drawing.Point(110, 299);
			this.btnConsulta.Name = "btnConsulta";
			this.btnConsulta.Size = new System.Drawing.Size(193, 49);
			this.btnConsulta.TabIndex = 32;
			this.btnConsulta.Text = "Consulta";
			this.btnConsulta.UseVisualStyleBackColor = true;
			this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
			// 
			// btnRetiro
			// 
			this.btnRetiro.AllowDrop = true;
			this.btnRetiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRetiro.Location = new System.Drawing.Point(110, 373);
			this.btnRetiro.Name = "btnRetiro";
			this.btnRetiro.Size = new System.Drawing.Size(193, 49);
			this.btnRetiro.TabIndex = 33;
			this.btnRetiro.Text = "Retiro";
			this.btnRetiro.UseVisualStyleBackColor = true;
			// 
			// frmVeterinario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1081, 711);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnUltimo);
			this.Controls.Add(this.btnSiguiente);
			this.Controls.Add(this.btnAnterior);
			this.Controls.Add(this.btnPrimero);
			this.Controls.Add(this.txtEspecializacion);
			this.Controls.Add(this.txtTelefonoV);
			this.Controls.Add(this.txtNombreV);
			this.Controls.Add(this.txtCedulaV);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label5);
			this.Name = "frmVeterinario";
			this.Text = "frmVeterinario";
			this.Load += new System.EventHandler(this.frmVeterinario_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEspecializacion;
        private System.Windows.Forms.TextBox txtTelefonoV;
        private System.Windows.Forms.TextBox txtNombreV;
        private System.Windows.Forms.TextBox txtCedulaV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnRetiro;
    }
}