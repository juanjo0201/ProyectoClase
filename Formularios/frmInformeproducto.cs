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
	public partial class frmInformeproducto : Form
	{
		cConexion cn;
		SqlCommand cmd;
		SqlDataAdapter da;
		DataTable dt;

		public frmInformeproducto()
		{
			InitializeComponent();
			cn = new cConexion();
		}

		private void frmInformeproducto_Load(object sender, EventArgs e)
		{
			SqlDataAdapter da = new SqlDataAdapter("select * from tblProducto", cn.AbrirConexion());
			DataTable dt = new DataTable();
			da.Fill(dt);
			dtgProducto.DataSource = dt;
		}
	}
}
