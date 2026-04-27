namespace ProyectoClase.Formularios
{
	partial class frmInformeOrden
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.dtgCliente = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCedula = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.chtOrdenes = new System.Windows.Forms.DataVisualization.Charting.Chart();
			((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chtOrdenes)).BeginInit();
			this.SuspendLayout();
			// 
			// dtgCliente
			// 
			this.dtgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgCliente.Location = new System.Drawing.Point(19, 309);
			this.dtgCliente.Name = "dtgCliente";
			this.dtgCliente.RowHeadersWidth = 51;
			this.dtgCliente.RowTemplate.Height = 24;
			this.dtgCliente.Size = new System.Drawing.Size(425, 346);
			this.dtgCliente.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(321, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(472, 38);
			this.label1.TabIndex = 1;
			this.label1.Text = "listado de ordenes por cliente";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 164);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(136, 38);
			this.label2.TabIndex = 2;
			this.label2.Text = "Cedula:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(622, 164);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(149, 38);
			this.label3.TabIndex = 3;
			this.label3.Text = "Nombre:";
			// 
			// txtCedula
			// 
			this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCedula.Location = new System.Drawing.Point(160, 166);
			this.txtCedula.Name = "txtCedula";
			this.txtCedula.Size = new System.Drawing.Size(205, 38);
			this.txtCedula.TabIndex = 4;
			this.txtCedula.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
			this.txtCedula.Leave += new System.EventHandler(this.txtCedula_Leave);
			// 
			// txtNombre
			// 
			this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(792, 166);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(205, 38);
			this.txtNombre.TabIndex = 5;
			// 
			// chtOrdenes
			// 
			chartArea1.Name = "ChartArea1";
			this.chtOrdenes.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chtOrdenes.Legends.Add(legend1);
			this.chtOrdenes.Location = new System.Drawing.Point(509, 309);
			this.chtOrdenes.Name = "chtOrdenes";
			this.chtOrdenes.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chtOrdenes.Series.Add(series1);
			this.chtOrdenes.Size = new System.Drawing.Size(476, 346);
			this.chtOrdenes.TabIndex = 6;
			this.chtOrdenes.Text = "chart1";
			// 
			// frmInformeOrden
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1154, 745);
			this.Controls.Add(this.chtOrdenes);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtCedula);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtgCliente);
			this.Name = "frmInformeOrden";
			this.Text = "frmInformeOrden";
			this.Load += new System.EventHandler(this.frmInformeOrden_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chtOrdenes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dtgCliente;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCedula;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.DataVisualization.Charting.Chart chtOrdenes;
	}
}