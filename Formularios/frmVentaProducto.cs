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
	public partial class frmVentaProducto : Form
	{
		cConexion cn;
		SqlCommand cmd;
		SqlDataAdapter da;
		DataTable dt;

		public frmVentaProducto()
		{
			InitializeComponent();
			cn = new cConexion();
		}

		private void frmVentaProducto_Load(object sender, EventArgs e)
		{
			SqlDataAdapter da = new SqlDataAdapter("SELECT tblProducto.idProducto, descripcion, sum(cantidad*vlrUnitario) FROM tblProducto INNER JOIN detalleOrden on tblProducto.idProducto = detalleOrden.id_Producto GROUP BY tblProducto.idProducto, descripcion", cn.AbrirConexion());
			DataTable dt = new DataTable();
			da.Fill(dt);
			dtgVentas.DataSource = dt;
		}
	}
}
