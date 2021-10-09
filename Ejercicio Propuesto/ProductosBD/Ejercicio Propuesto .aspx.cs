using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PRACTICA_6
{
    public partial class Ejercicio_Propuesto_3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = DESKTOP-6B31F1H\\SQLEXPRESS;" + "Initial Catalog = VENTAS; Integrated Security = SSPI";
            lblResult.Text = "";
            string selectSQL = "SELECT * FROM PRODUCTOS where codpro = " + txtCodigo.Text;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(selectSQL, con);
            SqlDataReader dr;
            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtNombres.Text = dr[1].ToString();
                    txtPrecio.Text = dr[2].ToString();
                    txtStock.Text = dr[3].ToString();
                }
                con.Close();
                dr.Close();
            }
            catch (Exception err)
            {
                lblResult.Text = "Error al registrar el Productos ";
                lblResult.Text += err.Message;
            }
        }

        protected void butnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombres.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = J3R3MY\\SQLEXPRESS;" + "Initial Catalog = VENTAS; Integrated Security = SSPI";
            string selectSQL = "SELECT * FROM PRODUCTOS";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(selectSQL, con);
            SqlDataReader dr;
            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                GridView1.DataSource = dr;
                GridView1.DataBind();
                con.Close();
            }
            catch (Exception err)
            {
                lblResult.Text = "Error al registrar el Productos ";
                lblResult.Text += err.Message;
            }
        }
    }
    
}