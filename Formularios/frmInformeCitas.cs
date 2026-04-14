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
	public partial class frmInformeCitas : Form
	{
		cConexion cn;
		string cedula;
		SqlCommand cmd;
		SqlDataAdapter da;
		DataTable dt, dtBusqueda;
		public frmInformeCitas()
		{
			cn= new cConexion();
		
			InitializeComponent();
		}

		private void frmInformeCitas_Load(object sender, EventArgs e)
		{
			SqlDataAdapter da= new SqlDataAdapter("select nombre from tblVeterinario",cn.AbrirConexion());
			DataTable dt = new DataTable();
			da.Fill(dt);
			MessageBox.Show(dt.Rows.Count.ToString());
			cmbVeterinario.DataSource = dt;
			cmbVeterinario.DisplayMember = "Nombre";
		}

		void cargarVeterinario()
		{
			cmd= new SqlCommand(" select tblCliente.nombre, nombreMascota, fechaCita,horaCita " + " from tblCliente " + "join  tblCita on tblCliente.cedula = tblCita.cedula " + "join tblMascota on tblCita.idMascota = tblMascota.id_Mascota " + "where nombre = '" + cmbVeterinario.Text + "'", cn.AbrirConexion());
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dtgCitas.DataSource = dt;
		}
		private void cmbVeterinario_SelectedIndexChanged(object sender, EventArgs e)
		{
			cargarVeterinario();
		}
	}
}
