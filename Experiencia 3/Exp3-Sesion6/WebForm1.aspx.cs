using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Exp3_Sesion6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string connectionString = "Data Source=DESKTOP-6B31F1H\\SQLEXPRESS;" + "Initial Catalog=VENTAS;Integrated Security=SSPI";
        protected void Page_Load(object sender, EventArgs e)
        {
            string JQueryVer = "1.7.1";
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
            {
                Path = "~/Scripts/jquery-" + JQueryVer + ".min.js",
                DebugPath = "~/Scripts/jquery-" + JQueryVer + ".js",
                CdnPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-" + JQueryVer + ".min.js",
                CdnDebugPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-" + JQueryVer + ".js",
                CdnSupportsSecureConnection = true,
                LoadSuccessExpression = "window.jQuery"
            });
        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            if (!this.IsValid) return;
            string insertSQL = "INSERT INTO CLIENTES VALUES (" +
                txtCodigo.Text + ", '" + txtNombres.Text + "', '" +
                txtDireccion.Text + "', '" + txtTelefono.Text + "', '" +
                txtMail.Text + "', " + txtEdad.Text + ")";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(insertSQL, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                lblResult.Text = "Cliente registrado con exito";
                con.Close();
                txtCodigo.Text = "";
                txtNombres.Text = "";
                txtDireccion.Text = "";
                txtTelefono.Text = "";
                txtMail.Text = "";
                txtEdad.Text = "";
            }
            catch(Exception err)
            {
                lblResult.Text = "Error al registrar al cliente";
                lblResult.Text += err.Message;
            }
        }
    }
}