namespace ProyectoClase.Formularios
{
	partial class frmInformeMascota
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
			this.dtgMascota = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dtgMascota)).BeginInit();
			this.SuspendLayout();
			// 
			// dtgMascota
			// 
			this.dtgMascota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgMascota.Location = new System.Drawing.Point(218, 177);
			this.dtgMascota.Name = "dtgMascota";
			this.dtgMascota.RowHeadersWidth = 51;
			this.dtgMascota.RowTemplate.Height = 24;
			this.dtgMascota.Size = new System.Drawing.Size(722, 426);
			this.dtgMascota.TabIndex = 0;
			this.dtgMascota.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMascota_CellContentClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(401, 78);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(336, 38);
			this.label1.TabIndex = 2;
			this.label1.Text = "Listado de mascotas";
			// 
			// frmInformeMascota
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1140, 738);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtgMascota);
			this.Name = "frmInformeMascota";
			this.Text = "frmInformeMascota";
			this.Load += new System.EventHandler(this.frmInformeMascota_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtgMascota)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dtgMascota;
		private System.Windows.Forms.Label label1;
	}
}