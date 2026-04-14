using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using ProyectoClase.Clases;
using Word = Microsoft.Office.Interop.Word;
using NetDataTable = System.Data.DataTable;


namespace ProyectoClase.Formularios
{
	public partial class frmOrdenCompra : Form
	{
		cConexion cn;
		int nOrden;
		SqlCommand cmd;
		SqlDataAdapter da;
		NetDataTable dt, dtBusqueda;
		int i, sw, boton;
		decimal totalF;
		public frmOrdenCompra()
		{
			InitializeComponent();

			cn = new cConexion();
		}



		void numeral()
		{
			SqlCommand cmd = new SqlCommand("select max (idOrden) from tblOrden", cn.AbrirConexion());
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			NetDataTable dt = new NetDataTable();
			da.Fill(dt);
			if (dt.Rows.Count != 0)
			{
				nOrden = int.Parse(dt.Rows[0][0].ToString()) + 1;
				lblNumeroOrden.Text = nOrden.ToString();
			}
			else
			{
				lblNumeroOrden.Text = "1";
			}
		}

		void llenarProducto()
		{
			int n = 0;
			SqlCommand cmd = new SqlCommand("select * from tblProducto", cn.AbrirConexion());
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			NetDataTable dt = new NetDataTable();
			da.Fill(dt);
			if (dt.Rows.Count != 0)
			{
				n = dt.Rows.Count;
				dgbProducto.Rows.Add(n - 1);
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					dgbProducto.Rows[i].Cells[1].Value = dt.Rows[i][0].ToString();
					dgbProducto.Rows[i].Cells[2].Value = dt.Rows[i][1].ToString();
					dgbProducto.Rows[i].Cells[3].Value = dt.Rows[i][2].ToString();
				}
			}
		}

		bool cargarCliente(string cedula)
		{
			cmd = new SqlCommand("select nombre from tblCliente where cedula='" + txtCedula.Text + "'", cn.AbrirConexion());
			da = new SqlDataAdapter(cmd);
			dtBusqueda = new NetDataTable();
			da.Fill(dtBusqueda);
			if (dtBusqueda.Rows.Count > 0)
			{
				txtNombre.Text = dtBusqueda.Rows[0][0].ToString();
				return true;
			}
			else
			{
				txtNombre.Text = "";
				return false;
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void frmOrdenCompra_Load(object sender, EventArgs e)
		{
			dgbProducto.Columns[3].DefaultCellStyle.Format = "C";
			dgbSeleccionado.Columns[2].DefaultCellStyle.Format = "C";
			dgbSeleccionado.Columns[4].DefaultCellStyle.Format = "C";
			numeral();
			llenarProducto();
		}

		private void txtCedula_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				cargarCliente(txtCedula.Text);
				e.SuppressKeyPress = true;
			}
		}

		private void dgbSeleccionado_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			decimal cantidad = 0;
			decimal precio_unit = 0;
			decimal precio_total = 0;
			decimal total = 0;

			if (dgbSeleccionado.Columns[e.ColumnIndex].Name == "cantidad")
			{
				if (dgbSeleccionado.Rows[e.RowIndex].Cells[3].Value != null)
				{
					decimal.TryParse(dgbSeleccionado.Rows[e.RowIndex].Cells[3].Value.ToString(), out cantidad);

					decimal.TryParse(

						dgbSeleccionado.Rows[e.RowIndex].Cells[2].Value.ToString(), System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out precio_unit);

					precio_total = cantidad * precio_unit;
					dgbSeleccionado.Rows[e.RowIndex].Cells[4].Value = precio_total;
				}

				foreach (DataGridViewRow row in dgbSeleccionado.Rows)
				{
					if (!row.IsNewRow && row.Cells["Total"].Value != null)
					{
						decimal valorFila;
						decimal.TryParse(row.Cells["Total"].Value.ToString(),
						System.Globalization.NumberStyles.Currency,
						System.Globalization.CultureInfo.CurrentCulture,
						out valorFila);

						total += valorFila;

					}
				}
				totalF = total;
				txtTotal.Text = total.ToString("C");
			}
		}

		private void dgbSeleccionado_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			numeral();
			txtCedula.Clear();
			txtTotal.Clear();
			txtNombre.Clear();
			dgbSeleccionado.Rows.Clear();
		}

		private void btnImprimir_Click(object sender, EventArgs e)
		{
			//Rutas de acceso
			string rutaWord = @"C:\Users\USER\OneDrive\Documentos\Desktop\VS POO\ProyectoClase\OrdenCompra.docx";
			string rutaPDF = @"C:\Users\USER\OneDrive\Documentos\Desktop\VS POO\ProyectoClase\OrdenCompra.pdf";

			Word.Application wordApp = new Word.Application();
			Word.Document doc = wordApp.Documents.Add();

			Word.Section section = doc.Sections[1];
			Word.HeaderFooter header = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary];

			Word.InlineShape logo = header.Range.InlineShapes.AddPicture(@"C:\Users\USER\OneDrive\Documentos\Desktop\VS POO\Satanas.jpg");
			logo.ScaleHeight = 50;
			logo.ScaleWidth = 50;

			header.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;

			wordApp.Selection.Font.Size = 18;
			wordApp.Selection.Font.Bold = 1;
			wordApp.Selection.TypeText("ORDEN DE COMPRA N: " + lblNumeroOrden.Text);

			wordApp.Selection.TypeParagraph();
			wordApp.Selection.TypeParagraph();

			wordApp.Selection.Font.Size = 12;
			wordApp.Selection.Font.Bold = 0;

			wordApp.Selection.TypeText("Cedula: " + txtCedula.Text);
			wordApp.Selection.TypeParagraph();

			wordApp.Selection.TypeText("Nombre Cliente: " + txtNombre.Text);
			wordApp.Selection.TypeParagraph();
			wordApp.Selection.TypeParagraph();

			int filas = dgbSeleccionado.Rows.Count;
			int columnas = 5;

			Word.Table tabla = doc.Tables.Add(wordApp.Selection.Range, filas, columnas);

			tabla.Cell(1, 1).Range.Text = "Codigo";
			tabla.Cell(1, 2).Range.Text = "Descripcion";
			tabla.Cell(1, 3).Range.Text = "Valor";
			tabla.Cell(1, 4).Range.Text = "Cantidad";
			tabla.Cell(1, 5).Range.Text = "Total";

			for (int i = 0; i < dgbSeleccionado.Rows.Count - 1; i++)
			{
				tabla.Cell(i + 2, 1).Range.Text = dgbSeleccionado.Rows[i].Cells[0].Value.ToString();
				tabla.Cell(i + 2, 2).Range.Text = dgbSeleccionado.Rows[i].Cells[1].Value.ToString();
				tabla.Cell(i + 2, 3).Range.Text = dgbSeleccionado.Rows[i].Cells[2].Value.ToString();
				tabla.Cell(i + 2, 4).Range.Text = dgbSeleccionado.Rows[i].Cells[3].Value.ToString();
				tabla.Cell(i + 2, 5).Range.Text = dgbSeleccionado.Rows[i].Cells[4].Value.ToString();
			}

			doc.SaveAs(rutaWord);

			doc.ExportAsFixedFormat(rutaPDF, WdExportFormat.wdExportFormatPDF);

			wordApp.Visible = true;

			MessageBox.Show("Documento Word y PDF generados Correctamente");
		}

		private void txtTotal_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (txtCedula.Text.Equals(" "))
			{
				MessageBox.Show("Ingrese Cedula");
			}
			else
			{
				SqlCommand cmd = new SqlCommand("insert into tblOrden values ('" + txtCedula.Text + "','" + dtpFecha.Text + "','" + 1 + "')", cn.AbrirConexion());
				cmd.ExecuteNonQuery();
				for (int i = 0; i < dgbSeleccionado.Rows.Count - 1; i++)
				{
					SqlCommand cmd1 = new SqlCommand("insert into detalleOrden values('" + nOrden + "','" + dgbSeleccionado.Rows[i].Cells[0].Value.ToString() + "','" + dgbSeleccionado.Rows[i].Cells[3].Value.ToString().Trim().Replace(",",".") + "','" + dgbSeleccionado.Rows[i].Cells[2].Value.ToString().Trim().Replace(",",".") + "')", cn.AbrirConexion());
					cmd1.ExecuteNonQuery();
				}
				MessageBox.Show("Orden de compra guardada correctamente");
			}
		}

		private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)) {
				MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Handled = true;
				return;
			}
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			for (int i = dgbProducto.Rows.Count - 1; i >= 0; i--)
			{
				DataGridViewRow row = dgbProducto.Rows[i];

				bool seleccionado = Convert.ToBoolean(row.Cells["Elegir"].Value);
				if (seleccionado)
				{

					int n = dgbSeleccionado.Rows.Add();
					dgbSeleccionado.Rows[n].Cells[0].Value = row.Cells[1].Value.ToString();
					dgbSeleccionado.Rows[n].Cells[1].Value = row.Cells[2].Value.ToString();
					dgbSeleccionado.Rows[n].Cells[2].Value = row.Cells[3].Value.ToString();

					//ELIMINAR DEL GRID ORIGINAL
					dgbProducto.Rows.RemoveAt(i);

				}
			}
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
		}
	}
}
