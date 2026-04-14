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
    public partial class frmProducto : Form
    {
		cConexion cn;       //LLama la clase
		SqlCommand cmd;     // Llama los comandos
		SqlDataAdapter da;  //Necesario para las consultas
		DataTable dt, dtBusqueda;       //especifica como se van a traer los datos
		int i, contador, boton;     //var.indice, contador y boton

		public frmProducto()
        {
            InitializeComponent();
			i = 0;
            boton = 0;
			cn = new cConexion();
			cmd = new SqlCommand("select * from tblProducto",
				cn.AbrirConexion());
			da = new SqlDataAdapter(cmd);
			dt = new DataTable();
			da.Fill(dt);
			Llenar(dt, i);
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
				i =0;
			}
			Llenar(dt, i);
		}

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
			i++;
			if (i >= contador)
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

		void cargarProductos()
		{
			i = 0; boton = 0;
			cn = new cConexion();
			cmd = new SqlCommand("select * from tblProducto",
				cn.AbrirConexion());
			da = new SqlDataAdapter(cmd);
			dt = new DataTable();
			da.Fill(dt);
			if (dt.Rows.Count > 0)
			{
				Llenar(dt, i);
			}
		}

		private void btnIngreso_Click(object sender, EventArgs e)
        {
			boton = 1;
			Limpiar();
			habilita();
			txtIdProducto.Focus();
		}

		void deshabilita()
		{
			txtIdProducto.Enabled = false;
			txtDescripcion.Enabled = false;
			txtExistencias.Enabled = false;
			txtSMaximo.Enabled = false;
			txtSMinimo.Enabled = false;	
			txtVUnitario.Enabled = false;	
		}

		private void txtIdProducto_Leave(object sender, EventArgs e)
		{
			cmd = new SqlCommand("select *  from tblProducto where id_Producto ='" + txtIdProducto.Text + "'", cn.AbrirConexion());
			da = new SqlDataAdapter(cmd);
			dtBusqueda = new DataTable();
			da.Fill(dtBusqueda);
			if (boton == 1)
			{
				if (dtBusqueda.Rows.Count > 0)
				{
					MessageBox.Show("EL producto ya existe");
					Llenar(dtBusqueda, 0);
				}
				else
				{
					btnGuardar.Visible = true;
				}
			}
			if (boton == 3)
			{
				if (dtBusqueda.Rows.Count > 0)
				{
					Llenar(dt, 0);
				}
				else
				{
					MessageBox.Show("El Producto no existe ");
				}
			}
			if (boton == 2)
			{
				if (dtBusqueda.Rows.Count > 0)
				{
					Llenar(dtBusqueda, 0);
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
						SqlCommand comando = new SqlCommand("delete from tblProducto where idProducto = '" + txtIdProducto.Text + "'", cn.AbrirConexion());
						comando.ExecuteNonQuery();
						MessageBox.Show("Producto retirado");
						cargarProductos();
					}
					else
					{
						MessageBox.Show("El producto no existe ");
					}
				}
			}
		}
		

        private void btnGuardar_Click(object sender, EventArgs e)
        {
			if (boton == 1)
			{
				cmd = new SqlCommand("insert into tblProducto values('" + txtIdProducto.Text + "','" + txtDescripcion.Text + "'," + txtVUnitario.Text + "', '" + txtExistencias.Text + "', '" + txtSMaximo.Text + "', '" + txtSMinimo.Text + "'", cn.AbrirConexion());
				cmd.ExecuteNonQuery();
				MessageBox.Show("Producto Guardado");
				i = 0;
			}
			if (boton == 2)
			{
				cmd = new SqlCommand("update tblProducto set descripcion = '" + txtDescripcion.Text + "', vlrUnitario = '" + txtVUnitario.Text + "',existencias = '" + txtExistencias.Text + "',stockMaximo = '" + txtSMaximo.Text + "', stockMinimo = '" + txtSMinimo.Text  + "'", cn.AbrirConexion());
				cmd.ExecuteNonQuery();
				MessageBox.Show("Producto modificado ");
			}


		}

        private void btnConsulta_Click(object sender, EventArgs e)
        {
			boton = 3;
			Limpiar();
			txtIdProducto.Enabled = true;
			txtIdProducto.Focus();

		}

        private void btnModificacion_Click(object sender, EventArgs e)
        {
			boton = 2;
			Limpiar();
			habilita();
			txtIdProducto.Focus();
		}

		void Limpiar()
		{
			txtIdProducto.Clear();
			txtDescripcion.Clear();
			txtVUnitario.Clear();
			txtExistencias.Clear();
			txtSMaximo.Clear();
			txtSMinimo.Clear();	
		}
		void Llenar(DataTable dt, int i)
		{
			txtIdProducto.Text = dt.Rows[i][0].ToString();
			txtDescripcion.Text = dt.Rows[i][1].ToString();
			txtVUnitario.Text = dt.Rows[i][2].ToString();
			txtExistencias.Text = dt.Rows[i][3].ToString();
			txtSMaximo.Text = dt.Rows[i][4].ToString();
			txtSMinimo.Text = dt.Rows[i][5].ToString();
			contador = dt.Rows.Count;
		}

		private void frmProducto_Load(object sender, EventArgs e)
        {

        }

		void habilita()
		{
			txtIdProducto.Enabled = true;
			txtDescripcion.Enabled = true;
			txtExistencias.Enabled = true;
			txtSMaximo.Enabled = true;
			txtSMinimo.Enabled = true;
			txtVUnitario.Enabled = true;	
		}
	}
}
