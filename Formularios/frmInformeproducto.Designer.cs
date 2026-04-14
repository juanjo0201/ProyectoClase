namespace ProyectoClase.Formularios
{
	partial class frmInformeproducto
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
			this.dtgProducto = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dtgProducto)).BeginInit();
			this.SuspendLayout();
			// 
			// dtgProducto
			// 
			this.dtgProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgProducto.Location = new System.Drawing.Point(222, 139);
			this.dtgProducto.Name = "dtgProducto";
			this.dtgProducto.RowHeadersWidth = 51;
			this.dtgProducto.RowTemplate.Height = 24;
			this.dtgProducto.Size = new System.Drawing.Size(720, 504);
			this.dtgProducto.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(411, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(352, 39);
			this.label1.TabIndex = 2;
			this.label1.Text = "Listado de productos";
			// 
			// frmInformeproducto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1136, 729);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtgProducto);
			this.Name = "frmInformeproducto";
			this.Text = "frmInformeproducto";
			this.Load += new System.EventHandler(this.frmInformeproducto_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtgProducto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dtgProducto;
		private System.Windows.Forms.Label label1;
	}
}