using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace BasedeDatos
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source = DESKTOP-6B31F1H\\SQLEXPRESS;" +
                "Initial Catalog = VENTAS; Integrated Security = True";
            string selectSQL = "SELECT * FROM Clientes";
            SqlConnection conexion = new SqlConnection(connectionString);
            SqlCommand comando = new SqlCommand(selectSQL, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            
            
            // llenando el dataset
            DataSet ventas = new DataSet();
            adapter.Fill(ventas, "clientes");
            // enlazar el gridview
            GridView1.DataSource = ventas;
            GridView1.DataBind();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = DESKTOP-6B31F1H\\SQLEXPRESS;" +
               "Initial Catalog = VENTAS; Integrated Security = True";
            SqlConnection conexion = new SqlConnection(connectionString);
            String nombrecopia = (System.DateTime.Today.Day.ToString() + "-" + System.DateTime.Today.Month.ToString() + "" + System.DateTime.Today.Year.ToString() + " " + System.DateTime.Now.Hour.ToString() + "-" + System.DateTime.Now.Minute.ToString() + "-" + System.DateTime.Now.Second.ToString()+" Ventas-Clientes");
            String comandoconsulta = "BACKUP DATABASE [Ventas] TO  DISK = N'C:\\Program Files\\Microsoft SQL Server\\MSSQL14.SQLEXPRESS\\MSSQL\\Backup\\" + nombrecopia + ".bak' WITH NOFORMAT, NOINIT,  NAME = N'Ventas-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
            SqlCommand combackup = new SqlCommand(comandoconsulta, conexion);
            try
            {
                conexion.Open();
                combackup.ExecuteNonQuery();
                MessageBox.Show("La copia se ha creado Satisfactoriamente");
            }
            catch (Exception)
            {
                MessageBox.Show("No se realizo correctamente");
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }
        }
    }
}