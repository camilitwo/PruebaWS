using System;
using System.Data;
using System.Data.OleDb;
using System.Web;

namespace datos
{
    public class DatosDAO
    {
        private static string string_conn = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + HttpContext.Current.Server.MapPath(@"App_Data\AUTOS.mdb") + ";";

        internal static DataTable listarAutos()
        {
            string conn = string_conn;

            string sql = "SELECT * FROM AUTO";
            OleDbConnection cnn = new OleDbConnection(conn);
            OleDbDataAdapter da = new OleDbDataAdapter(sql, cnn);
            DataTable datos = new DataTable();

            cnn.Open();
            da.Fill(datos);

            datos.TableName = "dt";
            return datos;
        }
    }
}