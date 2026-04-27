using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoClase.Formularios
{
    public partial class frmIngreso : Form
    {
        private Form activeForm = null;
        public frmIngreso()
        {
            InitializeComponent();
			disenoPersonal();
        }

		private void disenoPersonal()
		{
			pnlCliente.Visible = false;
			pnlProducto.Visible = false;
			pnlVeterinario.Visible = false;
			pnlMascota.Visible = false;
			pnlCitas.Visible = false;
			
		}

		void ocultarSubmenu()
		{
			if (pnlCliente.Visible)
				pnlCliente.Visible = false;
			if (pnlProducto.Visible)
				pnlProducto.Visible = false;
			if (pnlVeterinario.Visible)
				pnlVeterinario.Visible = false;
			if (pnlMascota.Visible)
				pnlMascota.Visible = false;
			if (pnlCitas.Visible)
				pnlCitas.Visible = false;

		}

		void mostrarSubmenu(Panel submenu)
		{
			if (submenu.Visible == false)
			{
				ocultarSubmenu();
				submenu.Visible = true;
			}
		}

		private void abrirEnPanel(Form frmHijo)
		{
			if (activeForm != null)
				activeForm.Close();
			activeForm = frmHijo;
			frmHijo.TopLevel = false;
			frmHijo.FormBorderStyle = FormBorderStyle.None;
			frmHijo.Dock = DockStyle.Fill;
			pnlCentral.Controls.Add(frmHijo);
			pnlCentral.Tag = frmHijo;
			frmHijo.BringToFront();
			frmHijo.Show();
		}



		private void pnlCentral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
			mostrarSubmenu(pnlCliente);
		}

        private void btnIngresoC_Click(object sender, EventArgs e)
        {
			abrirEnPanel(new frmCliente());
			ocultarSubmenu();
		}

        private void btnProducto_Click(object sender, EventArgs e)
        {
			mostrarSubmenu(pnlProducto);
		}

        private void btnIngresoP_Click(object sender, EventArgs e)
        {
			abrirEnPanel(new frmProducto());
			ocultarSubmenu();
		}

        private void btnVeterinario_Click(object sender, EventArgs e)
        {
			mostrarSubmenu(pnlVeterinario);
		}

        private void btnIngresoV_Click(object sender, EventArgs e)
        {
			abrirEnPanel(new frmVeterinario());
			ocultarSubmenu();
		}

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

		private void btnOrdenCompra_Click(object sender, EventArgs e)
		{
			abrirEnPanel(new frmOrdenCompra());
			ocultarSubmenu();
		}

		private void pnlMascota_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnMascota_Click(object sender, EventArgs e)
		{
			mostrarSubmenu(pnlMascota);
		}

		private void pnlVeterinario_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnInformeM_Click(object sender, EventArgs e)
		{
			abrirEnPanel(new frmInformeMascota());
			ocultarSubmenu();
		}

		private void btnMascota_Click_1(object sender, EventArgs e)
		{
			mostrarSubmenu(pnlMascota);

		}

		private void btnIngresoM_Click(object sender, EventArgs e)
		{
			abrirEnPanel(new frmMascota());
			ocultarSubmenu();
		}

		private void btnInformeC_Click(object sender, EventArgs e)
		{
			abrirEnPanel(new frmInformeCliente());
			ocultarSubmenu();
		}

		private void btnInformeP_Click(object sender, EventArgs e)
		{
			abrirEnPanel(new frmInformeMascota());
			ocultarSubmenu();
		}

		private void btnInformeV_Click(object sender, EventArgs e)
		{
			abrirEnPanel(new frmInformeVeterinario());
			ocultarSubmenu();
		}

		private void btnVeterinario_Click_1(object sender, EventArgs e)
		{
			mostrarSubmenu(pnlVeterinario);
		}

		private void btnInformeCompra_Click(object sender, EventArgs e)
		{
			abrirEnPanel(new frmInformeOrden());
			ocultarSubmenu();
		}

		private void frmIngreso_Load(object sender, EventArgs e)
		{

		}

		private void pnlMenu_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnIngresoCitas_Click(object sender, EventArgs e)
		{
			abrirEnPanel(new frmCitas());
			ocultarSubmenu();
		}

		private void btnCitas_Click(object sender, EventArgs e)
		{
			mostrarSubmenu(pnlCitas);
		}

		private void btnInformeCitas_Click(object sender, EventArgs e)
		{
			abrirEnPanel(new frmInformeCitas());
			ocultarSubmenu();
		}
	}
}
