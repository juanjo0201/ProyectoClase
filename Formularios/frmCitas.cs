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
	public partial class frmCitas : Form
	{
		cConexion cn;       //LLama la clase
		SqlCommand cmd;     // Llama los comandos
		SqlDataAdapter da;  //Necesario para las consultas
		DataTable dt, dtBusqueda;       //especifica como se van a traer los datos
		int boton, sw;

		public frmCitas()
		{
			InitializeComponent();
			sw = 0; boton = 0;
			cn = new cConexion();
			CargarHoras();
			deshabilita();


		}

		void habilita()
		{
			txtCedula.Enabled = true;
			cmbMascota.Enabled = true;
			monthCalendar1.Enabled = true;
			ltbHora.Enabled = true;
			cmbDisponibilidad.Enabled = true;
		}

		void deshabilita()
		{
			txtCedula.Enabled = false;
			cmbMascota.Enabled = false;
			monthCalendar1.Enabled = false;
			ltbHora.Enabled = false;
			cmbDisponibilidad.Enabled = false;
			btnGuardar.Visible = false;
		}

		void Limpiar()
		{
			txtCedula.Clear();
			txtNombre.Clear();
			cmbMascota.Items.Clear();
			cmbMascota.Text = "";
			ltbHora.ClearSelected();
			cmbDisponibilidad.SelectedIndex = -1;
			monthCalendar1.SetDate(DateTime.Today);
		}

		void CargarHoras()
		{
			ltbHora.Items.Clear();
			string[] horas = {
				"8:00 AM – 8:30 AM",
				"8:30 AM – 9:00 AM",
				"9:00 AM – 9:30 AM",
				"9:30 AM – 10:00 AM",
				"10:00 AM – 10:30 AM",
				"10:30 AM – 11:00 AM",
				"11:00 AM – 11:30 AM",
				"11:30 AM – 12:00 PM",
				"2:00 PM – 2:30 PM",
				"2:30 PM – 3:00 PM",
				"3:00 PM – 3:30 PM",
				"3:30 PM – 4:00 PM",
				"4:00 PM – 4:30 PM",
				"4:30 PM – 5:00 PM"
			};
			foreach (var h in horas)
				ltbHora.Items.Add(h);
		}

		bool cargarCliente(string cedula)
		{
			cmd = new SqlCommand(
				"SELECT nombre FROM tblCliente WHERE cedula = @cedula",
				cn.AbrirConexion());
			cmd.Parameters.AddWithValue("@cedula", cedula);
			da = new SqlDataAdapter(cmd);
			dtBusqueda = new DataTable();
			da.Fill(dtBusqueda);

			if (dtBusqueda.Rows.Count > 0)
			{
				txtNombre.Text = dtBusqueda.Rows[0][0].ToString();
				return true;
			}
			return false;
		}

		void cargarMascotas(string cedula)
		{
			cmbMascota.Items.Clear();
			cmd = new SqlCommand(
				"SELECT nombreMascota FROM tblMascota WHERE cedula = @cedula",
				cn.AbrirConexion());
			cmd.Parameters.AddWithValue("@cedula", cedula);
			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
				cmbMascota.Items.Add(reader["nombreMascota"].ToString());
			reader.Close();

			if (cmbMascota.Items.Count > 0)
				cmbMascota.SelectedIndex = 0;
		}

		private void txtCedula_Leave(object sender, EventArgs e)
		{
			if (txtCedula.Text.Trim() == "") return;

			if (!cargarCliente(txtCedula.Text.Trim()))
			{
				MessageBox.Show("El cliente no existe, debe registrarlo primero.");
				txtCedula.Focus();
				return;
			}
			cargarMascotas(txtCedula.Text.Trim());
			if (boton == 2 || boton == 3 || boton == 4)
			{
				if (!CargarCita(txtCedula.Text.Trim()))
					MessageBox.Show("El cliente no tiene citas registradas.");
			}
			if (boton == 1)
				btnGuardar.Visible = true;
		}

		private void btnIngreso_Click(object sender, EventArgs e)
		{
			boton = 1;
			Limpiar();
			habilita();
			btnGuardar.Visible = false;   // se muestra al confirmar cédula
			txtCedula.Focus();
		}

		private void btnModificacion_Click(object sender, EventArgs e)
		{
			boton = 2;
			Limpiar();
			habilita();
			btnGuardar.Visible = true;
			txtCedula.Focus();
		}

		private void btnConsulta_Click(object sender, EventArgs e)
		{
			boton = 3;
			Limpiar();
			// Solo habilita cédula para buscar, el resto solo lectura
			txtCedula.Enabled = true;
			cmbMascota.Enabled = false;
			monthCalendar1.Enabled = false;
			ltbHora.Enabled = false;
			cmbDisponibilidad.Enabled = false;
			btnGuardar.Visible = false;
			txtCedula.Focus();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			boton = 4;
			Limpiar();
			txtCedula.Enabled = true;
			cmbMascota.Enabled = false;
			monthCalendar1.Enabled = false;
			ltbHora.Enabled = false;
			cmbDisponibilidad.Enabled = false;
			btnGuardar.Visible = false;
			txtCedula.Focus();
		}
		public string CadenaConexion()
		{
			return "Server=TU_SERVIDOR; Database=TU_BD; Integrated Security=True;";
			// O la misma cadena que ya usas en AbrirConexion()
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (txtCedula.Text.Trim() == "" || cmbMascota.Text == "" ||
			   ltbHora.SelectedItem == null)
			{
				MessageBox.Show("Por favor complete todos los campos.");
				return;
			}

			string fecha = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
			string hora = ltbHora.SelectedItem.ToString();
			string disp = cmbDisponibilidad.Text;

			if (boton == 1)  // INGRESO
			{
				// Verificar si ya tiene cita ese día y hora
				int ocupado = 0;
				using (SqlConnection conn = new SqlConnection(cn.ObtenerCadena()))
				{
					conn.Open();
					SqlCommand cmdVerificar = new SqlCommand(
						"SELECT COUNT(*) FROM tblCita WHERE fecha = @fechaCita AND hora = @horaCita",
						conn);
					cmdVerificar.Parameters.AddWithValue("@fechaCita", fecha);
					cmdVerificar.Parameters.AddWithValue("@horaCita", hora);
					ocupado = Convert.ToInt32(cmdVerificar.ExecuteScalar());
				}

				if (ocupado > 0)
				{
					MessageBox.Show("Ese horario ya está ocupado. Seleccione otro.");
					return;
				}

				using (SqlConnection conn = new SqlConnection(cn.ObtenerCadena()))
				{
					conn.Open();
					SqlCommand cmdInsert = new SqlCommand(
						"INSERT INTO tblCita (cedula, nombreMascota, fecha, hora, disponibilidad) " +
						"VALUES (@cedula, @mascota, @fecha, @hora, @disp)", conn);
					cmdInsert.Parameters.AddWithValue("@cedula", txtCedula.Text.Trim());
					cmdInsert.Parameters.AddWithValue("@mascota", cmbMascota.Text);
					cmdInsert.Parameters.AddWithValue("@fecha", fecha);
					cmdInsert.Parameters.AddWithValue("@hora", hora);
					cmdInsert.Parameters.AddWithValue("@disp", disp);
					cmdInsert.ExecuteNonQuery();
				}

				MessageBox.Show("Cita registrada correctamente.");
			
		}
			else if (boton == 2)  // MODIFICACIÓN
			{
				cmd = new SqlCommand(
					"UPDATE tblCita SET nombreMascota = @mascota, fecha = @fecha, " +
					"hora = @hora, disponibilidad = @disp " +
					"WHERE cedula = @cedula",
					cn.AbrirConexion());
				cmd.Parameters.AddWithValue("@mascota", cmbMascota.Text);
				cmd.Parameters.AddWithValue("@fecha", fecha);
				cmd.Parameters.AddWithValue("@hora", hora);
				cmd.Parameters.AddWithValue("@disp", disp);
				cmd.Parameters.AddWithValue("@cedula", txtCedula.Text.Trim());
				cmd.ExecuteNonQuery();
				MessageBox.Show("Cita modificada correctamente.");
			}
			else if (boton == 4)  // CANCELAR (eliminar)
			{
				var res = MessageBox.Show(
					"¿Realmente desea cancelar esta cita?",
					"Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (res == DialogResult.Yes)
				{
					cmd = new SqlCommand(
						"DELETE FROM tblCita WHERE cedula = @cedula",
						cn.AbrirConexion());
					cmd.Parameters.AddWithValue("@cedula", txtCedula.Text.Trim());
					cmd.ExecuteNonQuery();
					MessageBox.Show("Cita cancelada.");
					Limpiar();
					deshabilita();
				}
			}
		}

		private void ltbHora_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		bool CargarCita(string cedula)
		{
			cmd = new SqlCommand(
				"SELECT nombreMascota, fecha, hora, disponibilidad " +
				"FROM tblCita WHERE cedula = '" + txtCedula + "'",
				cn.AbrirConexion());
			cmd.Parameters.AddWithValue("@cedula", cedula);
			da = new SqlDataAdapter(cmd);
			dt = new DataTable();
			da.Fill(dt);

			if (dt.Rows.Count > 0)
			{
				// Mascota
				cmbMascota.Text = dt.Rows[0]["nombreMascota"].ToString();

				// Fecha en el calendario
				if (DateTime.TryParse(dt.Rows[0]["fecha"].ToString(), out DateTime fecha))
					monthCalendar1.SetDate(fecha);

				// Hora en el listbox
				string hora = dt.Rows[0]["hora"].ToString();
				for (int j = 0; j < ltbHora.Items.Count; j++)
				{
					if (ltbHora.Items[j].ToString() == hora)
					{
						ltbHora.SelectedIndex = j;
						break;
					}
				}
				// Disponibilidad
				cmbDisponibilidad.Text = dt.Rows[0]["disponibilidad"].ToString();
				return true;
			}
			return false;
		}
	

		


		private void frmCitas_Load(object sender, EventArgs e)
		{
		
		}
	}
}
