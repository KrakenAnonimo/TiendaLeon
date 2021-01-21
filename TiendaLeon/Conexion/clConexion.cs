using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaLeon.Conexion
{
    class clConexion
    {
        SqlConnection objConexionBd = null;
        public SqlConnection mtdConexion()
        {
            string cadena = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DbTienda.mdf; Integrated Security = True";
           
            try
            {
                objConexionBd = new SqlConnection(cadena);
            }
            catch (Exception)
            {
                objConexionBd = null;
            }
            return objConexionBd;
        }
    }
}
