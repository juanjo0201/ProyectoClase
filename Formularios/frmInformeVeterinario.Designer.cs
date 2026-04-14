namespace ProyectoClase.Formularios
{
	partial class frmInformeVeterinario
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
			this.dtgVeterinario = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dtgVeterinario)).BeginInit();
			this.SuspendLayout();
			// 
			// dtgVeterinario
			// 
			this.dtgVeterinario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgVeterinario.Location = new System.Drawing.Point(176, 161);
			this.dtgVeterinario.Name = "dtgVeterinario";
			this.dtgVeterinario.RowHeadersWidth = 51;
			this.dtgVeterinario.RowTemplate.Height = 24;
			this.dtgVeterinario.Size = new System.Drawing.Size(806, 534);
			this.dtgVeterinario.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(367, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(388, 39);
			this.label1.TabIndex = 2;
			this.label1.Text = "Listado de Veterinarios";
			// 
			// frmInformeVeterinario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1142, 739);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtgVeterinario);
			this.Name = "frmInformeVeterinario";
			this.Text = "frmInformeVeterinario";
			this.Load += new System.EventHandler(this.frmInformeVeterinario_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtgVeterinario)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dtgVeterinario;
		private System.Windows.Forms.Label label1;
	}
}