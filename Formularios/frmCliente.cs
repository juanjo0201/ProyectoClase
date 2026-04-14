using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using ProyectoClase.Clases;

namespace ProyectoClase
{
    public partial class frmCliente : Form
    {
        cConexion cn;       //LLama la clase
        SqlCommand cmd;     // Llama los comandos
        SqlDataAdapter da;  //Necesario para las consultas
        DataTable dt, dtBusqueda;       //especifica como se van a traer los datos
        int i, contador, boton;     //var.indice, contador y boton



        public frmCliente()
        {
            InitializeComponent();
            i = 0; boton = 0;
            cn =new cConexion();
            cmd = new SqlCommand("select * from tblCliente",
                cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            Llenar(dt, i);

        }

        void cargarClientes()
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

        private void frmCliente_Load(object sender, EventArgs e)
        {

        }
        void habilita()
        {
            txtCedula.Enabled = true;
            txtDireccion.Enabled = true;
            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;
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
                i=0;
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

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            boton = 1;
            Limpiar();
            habilita();
            txtCedula.Focus();
        }

        void deshabilita()
        {
            txtCedula.Enabled = false;
            txtDireccion.Enabled = false;
            txtNombre.Enabled = false;
            txtTelefono.Enabled = false;
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select *  from tblCliente where cedula ='" + txtCedula.Text + "'", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dtBusqueda = new DataTable();
            da.Fill(dtBusqueda);
            if (boton == 1)
            {
                if (dtBusqueda.Rows.Count > 0)
                {
                    MessageBox.Show("EL cliente ya existe");
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
                        SqlCommand comando = new SqlCommand("delete from tblCliente where cedula = '" + txtCedula.Text + "'", cn.AbrirConexion());
                        comando.ExecuteNonQuery();
                        MessageBox.Show("CLiente retirado");
                        cargarClientes();
                    }
                }

                else
                {
                    MessageBox.Show("El cliente no existe ");
                }
            }

        
            }
        
        private void txtNombre_Leave(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (boton == 1)
            {
                cmd = new SqlCommand("insert into tblCliente values('" + txtCedula.Text + "','" + txtNombre.Text + "'," + txtDireccion.Text + "', '" + txtTelefono.Text + "')", cn.AbrirConexion());
                cmd.ExecuteNonQuery();
                MessageBox.Show("CLiente guardado");
                i = 0;
            }
            if (boton == 2)
            {
                cmd = new SqlCommand("updaate tblCliente set nombre = '" + txtNombre.Text + "', direccion = '" + txtDireccion.Text + "',telefono = '" + txtTelefono.Text + "'",cn.AbrirConexion());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente modificado ");
            }
           
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            boton = 3;
            Limpiar();
            txtCedula.Enabled = true;
            txtCedula.Focus();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            boton = 2;
            Limpiar();
            habilita();
            txtCedula.Focus();
        }

        void Limpiar()
        {
            txtCedula.Clear();
            txtDireccion.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
        }


        void Llenar(DataTable dt, int i )
        {
            txtCedula.Text = dt.Rows[i][0].ToString();
            txtTelefono.Text = dt.Rows[i][3].ToString();
            txtDireccion.Text = dt.Rows[i][2].ToString();
            txtNombre.Text = dt.Rows[i][1].ToString();
            contador = dt.Rows.Count;
        } 


	}
}
