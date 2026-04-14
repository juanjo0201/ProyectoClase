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
    public partial class frmVeterinario : Form
    {
		cConexion cn;       //LLama la clase
		SqlCommand cmd;     // Llama los comandos
		SqlDataAdapter da;  //Necesario para las consultas
		DataTable dt, dtBusqueda;       //especifica como se van a traer los datos
		int i, contador, boton;     //var.indice, contador y boton

		public frmVeterinario()
        {
            InitializeComponent();
			i = 0; boton = 0;
			cn = new cConexion();
			cmd = new SqlCommand("select * from tblVeterinario",
				cn.AbrirConexion());
			da = new SqlDataAdapter(cmd);
			dt = new DataTable();
			da.Fill(dt);
			Llenar(dt, i);
		}

		void cargarVeterinarios()
		{
			i = 0; boton = 0;
			cn = new cConexion();
			cmd = new SqlCommand("select * from tblCliente",
				cn.AbrirConexion());
			da = new SqlDataAdapter(cmd);
			dt = new DataTable();
			da.Fill(dt);
			if (dt.Rows.Count > 0)
			{
				Llenar(dt, i);
			}
		}

		void habilita()
		{
			txtCedulaV.Enabled = true;
			txtNombreV.Enabled = true;
			txtTelefonoV.Enabled = true;
			txtEspecializacion.Enabled = true;
		}

        private void btnPrimero_Click(object sender, EventArgs e)
        {
			i = 0;
			Llenar(dt, i);
		}

        private void btnAnterior_Click(object sender, EventArgs e)
        {

			i--;
			if (i < 0)
			{
				MessageBox.Show("Estas en el primer cliente");
				i = 0;
			}
			Llenar(dt, i);
		}

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
			i++;
			if (i == contador)
			{
				MessageBox.Show("Estas en el ultimo cliente");
				i--;
			}
			Llenar(dt, i);
		}

        private void btnUltimo_Click(object sender, EventArgs e)
        {
			i = contador - 1;
			Llenar(dt, i);
		}

        private void btnIngreso_Click(object sender, EventArgs e)
        {
			boton = 1;
			Limpiar();
			habilita();
			txtCedulaV.Focus();
		}

        private void txtCedulaV_Leave(object sender, EventArgs e)
        {
			cmd = new SqlCommand("select *  from tblVeterinario where cedula ='" + txtCedulaV.Text + "'", cn.AbrirConexion());
			da = new SqlDataAdapter(cmd);
			dtBusqueda = new DataTable();
			da.Fill(dtBusqueda);
			if (boton == 1)
			{
				if (dtBusqueda.Rows.Count > 0)
				{
					MessageBox.Show("EL Veterinario ya existe");
					Llenar(dtBusqueda, 0);
				}
				else
				{
					btnGuardar.Visible = true;
				}
			}

			if (boton == 2)
			{
				if (dtBusqueda.Rows.Count > 0)
				{
					Llenar(dtBusqueda, 0);
				}
				else
				{
					MessageBox.Show("El cliente no existe");
				}
			}
			if (boton == 3)
			{
				if (dtBusqueda.Rows.Count > 0)
				{
					Llenar(dtBusqueda, 0);
				}
				else
				{
					MessageBox.Show("El cliente no existe ");
				}
			}
			if (boton == 4)
			{
				if (dtBusqueda.Rows.Count > 0)
				{
					Llenar(dtBusqueda, 0);
					var result = MessageBox.Show("Realmente desea borrarlo?", "Mensaje de Alerta ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (result == DialogResult.Yes)
					{
						SqlCommand comando = new SqlCommand("delete from tblVeterinario where cedula = '" + txtCedulaV.Text + "'", cn.AbrirConexion());
						comando.ExecuteNonQuery();
						MessageBox.Show("CLiente retirado");
						cargarVeterinarios();
					}
				}

				else
				{
					MessageBox.Show("El cliente no existe ");
				}
			}

		}

        private void btnGuardar_Click(object sender, EventArgs e)
        {
			if (boton == 1)
			{
				cmd = new SqlCommand("insert into tblVeterinario values('" + txtCedulaV.Text + "','" + txtNombreV.Text + "'," + txtTelefonoV.Text + "', '" + txtEspecializacion.Text + "')", cn.AbrirConexion());
				cmd.ExecuteNonQuery();
				MessageBox.Show("Veterinario guardado");
				i = 0;
			}
			if (boton == 2)
			{
				cmd = new SqlCommand("update tblVeterinario set nombre = '" + txtNombreV.Text + "', telefono = '" + txtTelefonoV.Text + "',especializacion = '" + txtEspecializacion.Text + "'", cn.AbrirConexion());
				cmd.ExecuteNonQuery();
				MessageBox.Show("Veterinario modificado ");
			}
		}

        private void btnConsulta_Click(object sender, EventArgs e)
        {
			boton = 3;
			Limpiar();
			txtCedulaV.Enabled = true;
			txtCedulaV.Focus();
		}

        private void btnModificar_Click(object sender, EventArgs e)
        {
			boton = 2;
			Limpiar();
			habilita();
			txtCedulaV.Focus();
		}

		void Limpiar()
		{
			txtCedulaV.Clear();
			txtNombreV.Clear();
			txtTelefonoV.Clear();
			txtEspecializacion.Clear();
		}

		void Llenar(DataTable dt, int i)
		{
			txtCedulaV.Text = dt.Rows[i][0].ToString();
			txtNombreV.Text = dt.Rows[i][1].ToString();
			txtTelefonoV.Text = dt.Rows[i][2].ToString();
			txtEspecializacion.Text = dt.Rows[i][3].ToString();
			contador = dt.Rows.Count;
		}

        private void txtCedulaV_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmVeterinario_Load(object sender, EventArgs e)
        {

        }
    }
}
