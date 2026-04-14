using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClase.Clases;

namespace ProyectoClase.Formularios
{
	public partial class frmInformeOrden : Form
	{
		cConexion cn;
		SqlCommand cmd;
		SqlDataAdapter da,dax;
		DataTable dt,dtx;
		public frmInformeOrden()
		{
			InitializeComponent();
			cn = new cConexion();

		}

		private void txtCedula_TextChanged(object sender, EventArgs e)
		{

		}

		private void frmInformeOrden_Load(object sender, EventArgs e)
		{

		}

		private void txtCedula_Leave(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand("select nombre from tblCliente where cedula = '" + txtCedula.Text + "'",cn.AbrirConexion());
			SqlDataAdapter da= new SqlDataAdapter(cmd);
			DataTable dt= new DataTable();
			da.Fill(dt);

			if (dt.Rows.Count != 0)
			{
				txtNombre.Text = dt.Rows[0][0].ToString();
				SqlDataAdapter dax = new SqlDataAdapter("select * from tblOrden where cedula = '" + txtCedula.Text + "'", cn.AbrirConexion());
				DataTable dtx = new DataTable();
				dax.Fill(dtx);
				dtgCliente.DataSource = dtx;
			}
		}
	}
}
