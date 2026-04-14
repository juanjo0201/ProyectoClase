namespace ProyectoClase.Formularios
{
	partial class frmOrdenCompra
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgbProducto = new System.Windows.Forms.DataGridView();
			this.elegir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.id_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.vlrUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCedula = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dgbSeleccionado = new System.Windows.Forms.DataGridView();
			this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descripcion1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.vlrUnitario1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnImprimir = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.lblNumeroOrden = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgbProducto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgbSeleccionado)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(203, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(412, 54);
			this.label1.TabIndex = 0;
			this.label1.Text = "Orden de Compra";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(18, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 54);
			this.label2.TabIndex = 1;
			this.label2.Text = "No.";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Location = new System.Drawing.Point(7, 138);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1152, 13);
			this.panel1.TabIndex = 2;
			// 
			// dgbProducto
			// 
			this.dgbProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgbProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.elegir,
            this.id_Producto,
            this.descripcion,
            this.vlrUnitario});
			this.dgbProducto.Location = new System.Drawing.Point(91, 304);
			this.dgbProducto.Name = "dgbProducto";
			this.dgbProducto.RowHeadersVisible = false;
			this.dgbProducto.RowHeadersWidth = 51;
			this.dgbProducto.RowTemplate.Height = 24;
			this.dgbProducto.Size = new System.Drawing.Size(1068, 163);
			this.dgbProducto.TabIndex = 4;
			this.dgbProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// elegir
			// 
			this.elegir.Frozen = true;
			this.elegir.HeaderText = "Elegir";
			this.elegir.MinimumWidth = 6;
			this.elegir.Name = "elegir";
			this.elegir.Width = 125;
			// 
			// id_Producto
			// 
			this.id_Producto.Frozen = true;
			this.id_Producto.HeaderText = "Codígo";
			this.id_Producto.MinimumWidth = 6;
			this.id_Producto.Name = "id_Producto";
			this.id_Producto.Width = 125;
			// 
			// descripcion
			// 
			this.descripcion.FillWeight = 200F;
			this.descripcion.HeaderText = "Descripcion";
			this.descripcion.MinimumWidth = 6;
			this.descripcion.Name = "descripcion";
			this.descripcion.Width = 200;
			// 
			// vlrUnitario
			// 
			this.vlrUnitario.FillWeight = 150F;
			this.vlrUnitario.HeaderText = "VlrUnitario";
			this.vlrUnitario.MinimumWidth = 6;
			this.vlrUnitario.Name = "vlrUnitario";
			this.vlrUnitario.Width = 150;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(511, 186);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(361, 54);
			this.label3.TabIndex = 5;
			this.label3.Text = "Nombre Cliente";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 173);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(177, 54);
			this.label4.TabIndex = 6;
			this.label4.Text = "Cedula";
			// 
			// txtCedula
			// 
			this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCedula.Location = new System.Drawing.Point(195, 186);
			this.txtCedula.Name = "txtCedula";
			this.txtCedula.Size = new System.Drawing.Size(250, 41);
			this.txtCedula.TabIndex = 7;
			this.txtCedula.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			this.txtCedula.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCedula_KeyDown);
			this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
			this.txtCedula.Leave += new System.EventHandler(this.txtCedula_Leave);
			// 
			// txtNombre
			// 
			this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(923, 198);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(183, 41);
			this.txtNombre.TabIndex = 8;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel2.Location = new System.Drawing.Point(7, 264);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1152, 13);
			this.panel2.TabIndex = 3;
			// 
			// dgbSeleccionado
			// 
			this.dgbSeleccionado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgbSeleccionado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descripcion1,
            this.vlrUnitario1,
            this.cantidad,
            this.total});
			this.dgbSeleccionado.Location = new System.Drawing.Point(91, 520);
			this.dgbSeleccionado.Name = "dgbSeleccionado";
			this.dgbSeleccionado.RowHeadersVisible = false;
			this.dgbSeleccionado.RowHeadersWidth = 51;
			this.dgbSeleccionado.RowTemplate.Height = 24;
			this.dgbSeleccionado.Size = new System.Drawing.Size(1068, 150);
			this.dgbSeleccionado.TabIndex = 9;
			this.dgbSeleccionado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbSeleccionado_CellContentClick);
			this.dgbSeleccionado.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbSeleccionado_CellEndEdit);
			// 
			// codigo
			// 
			this.codigo.HeaderText = "Codígo";
			this.codigo.MinimumWidth = 6;
			this.codigo.Name = "codigo";
			this.codigo.Width = 125;
			// 
			// descripcion1
			// 
			this.descripcion1.HeaderText = "Descrípcion";
			this.descripcion1.MinimumWidth = 6;
			this.descripcion1.Name = "descripcion1";
			this.descripcion1.Width = 200;
			// 
			// vlrUnitario1
			// 
			this.vlrUnitario1.HeaderText = "Valor Unitario";
			this.vlrUnitario1.MinimumWidth = 6;
			this.vlrUnitario1.Name = "vlrUnitario1";
			this.vlrUnitario1.Width = 150;
			// 
			// cantidad
			// 
			this.cantidad.HeaderText = "cantidad";
			this.cantidad.MinimumWidth = 6;
			this.cantidad.Name = "cantidad";
			this.cantidad.Width = 125;
			// 
			// total
			// 
			this.total.HeaderText = "Total";
			this.total.MinimumWidth = 6;
			this.total.Name = "total";
			this.total.Width = 125;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.Location = new System.Drawing.Point(45, 688);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(177, 66);
			this.btnGuardar.TabIndex = 10;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// dtpFecha
			// 
			this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFecha.Location = new System.Drawing.Point(749, 70);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(458, 34);
			this.dtpFecha.TabIndex = 11;
			// 
			// btnNuevo
			// 
			this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNuevo.Location = new System.Drawing.Point(268, 688);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(177, 63);
			this.btnNuevo.TabIndex = 12;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// btnImprimir
			// 
			this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImprimir.Location = new System.Drawing.Point(481, 688);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(177, 63);
			this.btnImprimir.TabIndex = 13;
			this.btnImprimir.Text = "Imprimir";
			this.btnImprimir.UseVisualStyleBackColor = true;
			this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(690, 688);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(146, 54);
			this.label5.TabIndex = 14;
			this.label5.Text = "Total:";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// txtTotal
			// 
			this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotal.Location = new System.Drawing.Point(824, 700);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(250, 41);
			this.txtTotal.TabIndex = 15;
			this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(481, 482);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(256, 23);
			this.btnAceptar.TabIndex = 16;
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// lblNumeroOrden
			// 
			this.lblNumeroOrden.AutoSize = true;
			this.lblNumeroOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumeroOrden.Location = new System.Drawing.Point(117, 63);
			this.lblNumeroOrden.Name = "lblNumeroOrden";
			this.lblNumeroOrden.Size = new System.Drawing.Size(0, 42);
			this.lblNumeroOrden.TabIndex = 17;
			// 
			// frmOrdenCompra
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.ClientSize = new System.Drawing.Size(1219, 763);
			this.Controls.Add(this.lblNumeroOrden);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnImprimir);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.dtpFecha);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.dgbSeleccionado);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtCedula);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dgbProducto);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmOrdenCompra";
			this.Text = "Total:";
			this.Load += new System.EventHandler(this.frmOrdenCompra_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgbProducto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgbSeleccionado)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dgbProducto;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtCedula;
		private System.Windows.Forms.DataGridViewCheckBoxColumn elegir;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_Producto;
		private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn vlrUnitario;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView dgbSeleccionado;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Button btnImprimir;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Label lblNumeroOrden;
		private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn descripcion1;
		private System.Windows.Forms.DataGridViewTextBoxColumn vlrUnitario1;
		private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn total;
	}
}