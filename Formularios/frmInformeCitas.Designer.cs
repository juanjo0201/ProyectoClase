namespace ProyectoClase.Formularios
{
	partial class frmInformeCitas
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
			this.cmbVeterinario = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dtpFechaD = new System.Windows.Forms.DateTimePicker();
			this.dtpFechaH = new System.Windows.Forms.DateTimePicker();
			this.dtgCitas = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dtgCitas)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(352, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(453, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "Listado de citas por veterinario";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(131, 172);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(180, 36);
			this.label2.TabIndex = 1;
			this.label2.Text = "Veterinario:";
			// 
			// cmbVeterinario
			// 
			this.cmbVeterinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbVeterinario.FormattingEnabled = true;
			this.cmbVeterinario.Location = new System.Drawing.Point(317, 169);
			this.cmbVeterinario.Name = "cmbVeterinario";
			this.cmbVeterinario.Size = new System.Drawing.Size(534, 39);
			this.cmbVeterinario.TabIndex = 2;
			this.cmbVeterinario.SelectedIndexChanged += new System.EventHandler(this.cmbVeterinario_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(85, 310);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 36);
			this.label3.TabIndex = 3;
			this.label3.Text = "Desde:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(633, 310);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(105, 36);
			this.label4.TabIndex = 4;
			this.label4.Text = "Hasta:";
			// 
			// dtpFechaD
			// 
			this.dtpFechaD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFechaD.Location = new System.Drawing.Point(205, 314);
			this.dtpFechaD.Name = "dtpFechaD";
			this.dtpFechaD.Size = new System.Drawing.Size(381, 30);
			this.dtpFechaD.TabIndex = 12;
			// 
			// dtpFechaH
			// 
			this.dtpFechaH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFechaH.Location = new System.Drawing.Point(744, 316);
			this.dtpFechaH.Name = "dtpFechaH";
			this.dtpFechaH.Size = new System.Drawing.Size(380, 30);
			this.dtpFechaH.TabIndex = 13;
			// 
			// dtgCitas
			// 
			this.dtgCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgCitas.Location = new System.Drawing.Point(91, 410);
			this.dtgCitas.Name = "dtgCitas";
			this.dtgCitas.RowHeadersWidth = 51;
			this.dtgCitas.RowTemplate.Height = 24;
			this.dtgCitas.Size = new System.Drawing.Size(983, 291);
			this.dtgCitas.TabIndex = 14;
			// 
			// frmInformeCitas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1219, 733);
			this.Controls.Add(this.dtgCitas);
			this.Controls.Add(this.dtpFechaH);
			this.Controls.Add(this.dtpFechaD);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cmbVeterinario);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmInformeCitas";
			this.Text = "frmInformeCitas";
			this.Load += new System.EventHandler(this.frmInformeCitas_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtgCitas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbVeterinario;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpFechaD;
		private System.Windows.Forms.DateTimePicker dtpFechaH;
		private System.Windows.Forms.DataGridView dtgCitas;
	}
}