using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ProyectoClase.Clases;
using System.Security.Cryptography;

namespace ProyectoClase.Formularios
{
	public partial class frmMascota : Form
	{
		cConexion cn;
		SqlCommand cmd;
		SqlDataAdapter da;
		DataTable dt, dtBusqueda;
		int i, sw, boton;
		public frmMascota()
		{
			InitializeComponent();
			cn = new cConexion();
			sw = 0;
		}

		private void frmMascota_Load(object sender, EventArgs e)
		{
		}

		private void txtCedula_Leave(object sender, EventArgs e)
		{
			if (!cargarCliente(txtCedula.Text))
			{
				MessageBox.Show("El cliente no existe, debe registrarlo");
				frmCliente frm = new frmCliente();
				frm.Show();
				this.Hide();

				return;
			}
			cargarMascota(txtCedula.Text);
		}

		bool cargarCliente(string cedula)
		{
			cmd = new SqlCommand("select nombre from tblCliente where cedula='" + txtCedula.Text + "'", cn.AbrirConexion());
			da = new SqlDataAdapter(cmd);
			dtBusqueda = new DataTable();
			da.Fill(dtBusqueda);
			if (dtBusqueda.Rows.Count > 0)
			{
				txtNombreP.Text = dtBusqueda.Rows[0][0].ToString();
				return true;
			}
			else
			{
				return false;
			}
		}

		List<string> ObtenerMascotas(string cedula)
		{
			List<string> mascotas = new List<string>();
			cmd = new SqlCommand("SELECT nombreMascota, especie FROM tblMascota WHERE cedula = '" + txtCedula.Text + "'", cn.AbrirConexion());
			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				mascotas.Add(reader["nombreMascota"].ToString());
			}
			reader.Close();
			return mascotas;
		}

		void cargarMascota(string cedula)
		{
			cmbMascota.Items.Clear();
			cmbEspecie.Items.Clear();
			List<string> mascotas = ObtenerMascotas(cedula);
			if (mascotas.Count > 0)
			{
				foreach (var mascota in mascotas)
				{
					cmbMascota.Items.Add(mascotas);
					sw = 1;
				}
				cmbMascota.SelectedIndex = 0;
			}
		}

		private void txtCedula_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnIngreso_Click(object sender, EventArgs e)
		{

		}

		void buscarDatos(string cedulab, string nombreMascotab)
		{
			cmd = new SqlCommand("select especie,raza,fechaNacimiento,sexo from tblMascota where cedula='" + cedulab + "'", cn.AbrirConexion());
			da = new SqlDataAdapter(cmd);
			dt = new DataTable();
			da.Fill(dt);
			if (dt.Rows.Count > 0)
			{
				cmbEspecie.Text = dt.Rows[0][0].ToString();
				txtRaza.Text = dt.Rows[0][1].ToString();
				mskFecha.Text = dt.Rows[0][2].ToString();
				txtSexo.Text = dt.Rows[0][3].ToString();
			}
			else
			{
				MessageBox.Show("Mascota no encontrada");
			}
		}

		private void cmbMascota_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (sw == 0)
			{
				MessageBox.Show("Entrada por primera vez");
			}
			else
			{
				buscarDatos(txtCedula.Text, cmbMascota.Text);
			}
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			cmd = new SqlCommand("SELECT COUNT(*) FROM tblMascota WHERE cedula = @cedula AND nombreMascota = @nombre", cn.AbrirConexion());
			cmd.Parameters.AddWithValue("@cedula", txtCedula.Text);
			cmd.Parameters.AddWithValue("@nombre", cmbMascota.Text);
			int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
			if (cantidad > 0)
			{
				MessageBox.Show("La mascota ya esta registrada");
				return;
			}

			cmd = new SqlCommand("INSERT INTO tblMascota VALUES (@cedula, @nombre,@especie,@raza,@fechaNacimiento,@sexo", cn.AbrirConexion());

			cmd.Parameters.AddWithValue("@cedula", txtCedula.Text);
			cmd.Parameters.AddWithValue("@nombre", cmbMascota.Text);
			cmd.Parameters.AddWithValue("@especie", cmbEspecie.Text);
			cmd.Parameters.AddWithValue("@raza", txtRaza.Text);
			cmd.Parameters.AddWithValue("@fechaNacimiento", mskFecha.Text);
			cmd.Parameters.AddWithValue("@sexo", txtSexo.Text);

			cmd.ExecuteNonQuery();

			MessageBox.Show("Mascota registrada correctamente");
		}
	}
}
