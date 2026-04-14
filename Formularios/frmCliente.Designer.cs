namespace ProyectoClase
{
    partial class frmCliente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCedula = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.btnIngreso = new System.Windows.Forms.Button();
			this.btnConsulta = new System.Windows.Forms.Button();
			this.btnRetiro = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnPrimero = new System.Windows.Forms.Button();
			this.btnAnterior = new System.Windows.Forms.Button();
			this.btnSiguiente = new System.Windows.Forms.Button();
			this.btnUltimo = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(59, 125);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 38);
			this.label1.TabIndex = 0;
			this.label1.Text = "Cedula:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(59, 202);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(142, 38);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nombre:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label3.Enabled = false;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(59, 284);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(163, 38);
			this.label3.TabIndex = 2;
			this.label3.Text = "Direccion:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label4.Enabled = false;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(59, 358);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(152, 38);
			this.label4.TabIndex = 3;
			this.label4.Text = "Telefono:";
			// 
			// txtCedula
			// 
			this.txtCedula.Enabled = false;
			this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCedula.Location = new System.Drawing.Point(230, 118);
			this.txtCedula.Name = "txtCedula";
			this.txtCedula.Size = new System.Drawing.Size(282, 49);
			this.txtCedula.TabIndex = 4;
			this.txtCedula.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
			this.txtCedula.Leave += new System.EventHandler(this.txtCedula_Leave);
			// 
			// txtNombre
			// 
			this.txtNombre.Enabled = false;
			this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(230, 202);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(282, 49);
			this.txtNombre.TabIndex = 5;
			this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
			// 
			// txtDireccion
			// 
			this.txtDireccion.Enabled = false;
			this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDireccion.Location = new System.Drawing.Point(230, 284);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(282, 49);
			this.txtDireccion.TabIndex = 6;
			// 
			// txtTelefono
			// 
			this.txtTelefono.Enabled = false;
			this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefono.Location = new System.Drawing.Point(230, 358);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(282, 49);
			this.txtTelefono.TabIndex = 7;
			// 
			// btnIngreso
			// 
			this.btnIngreso.AllowDrop = true;
			this.btnIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIngreso.Location = new System.Drawing.Point(818, 125);
			this.btnIngreso.Name = "btnIngreso";
			this.btnIngreso.Size = new System.Drawing.Size(193, 55);
			this.btnIngreso.TabIndex = 8;
			this.btnIngreso.Text = "Ingreso";
			this.btnIngreso.UseVisualStyleBackColor = true;
			this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
			// 
			// btnConsulta
			// 
			this.btnConsulta.AllowDrop = true;
			this.btnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConsulta.Location = new System.Drawing.Point(818, 284);
			this.btnConsulta.Name = "btnConsulta";
			this.btnConsulta.Size = new System.Drawing.Size(193, 49);
			this.btnConsulta.TabIndex = 9;
			this.btnConsulta.Text = "Consulta";
			this.btnConsulta.UseVisualStyleBackColor = true;
			this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
			// 
			// btnRetiro
			// 
			this.btnRetiro.AllowDrop = true;
			this.btnRetiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRetiro.Location = new System.Drawing.Point(818, 358);
			this.btnRetiro.Name = "btnRetiro";
			this.btnRetiro.Size = new System.Drawing.Size(193, 49);
			this.btnRetiro.TabIndex = 10;
			this.btnRetiro.Text = "Retiro";
			this.btnRetiro.UseVisualStyleBackColor = true;
			// 
			// btnModificar
			// 
			this.btnModificar.AllowDrop = true;
			this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.Location = new System.Drawing.Point(779, 202);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(255, 49);
			this.btnModificar.TabIndex = 11;
			this.btnModificar.Text = "Modificacion";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// btnPrimero
			// 
			this.btnPrimero.Location = new System.Drawing.Point(239, 457);
			this.btnPrimero.Name = "btnPrimero";
			this.btnPrimero.Size = new System.Drawing.Size(93, 47);
			this.btnPrimero.TabIndex = 12;
			this.btnPrimero.Text = "<<";
			this.btnPrimero.UseVisualStyleBackColor = true;
			this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
			// 
			// btnAnterior
			// 
			this.btnAnterior.Location = new System.Drawing.Point(363, 457);
			this.btnAnterior.Name = "btnAnterior";
			this.btnAnterior.Size = new System.Drawing.Size(93, 47);
			this.btnAnterior.TabIndex = 13;
			this.btnAnterior.Text = "<";
			this.btnAnterior.UseVisualStyleBackColor = true;
			this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
			// 
			// btnSiguiente
			// 
			this.btnSiguiente.Location = new System.Drawing.Point(493, 457);
			this.btnSiguiente.Name = "btnSiguiente";
			this.btnSiguiente.Size = new System.Drawing.Size(93, 47);
			this.btnSiguiente.TabIndex = 14;
			this.btnSiguiente.Text = ">";
			this.btnSiguiente.UseVisualStyleBackColor = true;
			this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
			// 
			// btnUltimo
			// 
			this.btnUltimo.Location = new System.Drawing.Point(621, 457);
			this.btnUltimo.Name = "btnUltimo";
			this.btnUltimo.Size = new System.Drawing.Size(93, 47);
			this.btnUltimo.TabIndex = 15;
			this.btnUltimo.Text = ">>";
			this.btnUltimo.UseVisualStyleBackColor = true;
			this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Enabled = false;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(484, 28);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(164, 51);
			this.label5.TabIndex = 16;
			this.label5.Text = "Cliente";
			// 
			// btnGuardar
			// 
			this.btnGuardar.AllowDrop = true;
			this.btnGuardar.Enabled = false;
			this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.Location = new System.Drawing.Point(818, 438);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(193, 49);
			this.btnGuardar.TabIndex = 17;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// frmCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1133, 700);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnUltimo);
			this.Controls.Add(this.btnSiguiente);
			this.Controls.Add(this.btnAnterior);
			this.Controls.Add(this.btnPrimero);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnRetiro);
			this.Controls.Add(this.btnConsulta);
			this.Controls.Add(this.btnIngreso);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.txtDireccion);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtCedula);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmCliente";
			this.Text = "FormularioCliente";
			this.Load += new System.EventHandler(this.frmCliente_Load);
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
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnRetiro;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardar;
    }
}

