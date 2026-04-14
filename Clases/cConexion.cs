using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProyectoClase.Clases
{
    class cConexion
    {
		static private String CadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\OneDrive\Documentos\Desktop\VS POO\ProyectoClase\DbVeterinaria.mdf;Integrated Security=True;Connect Timeout=30;";

        private SqlConnection conexion= new SqlConnection(CadenaConexion);

        public SqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }

		public string ObtenerCadena()
		{
			return CadenaConexion;
		}
	}
}
