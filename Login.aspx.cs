using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        try
        {
            string sesion = Session["user"].ToString();
            Response.Redirect("default.aspx?Active="+sesion);
        }
        catch(Exception x)
        {
            
        }

        try
        {
            if (Request.Params["Active"] != null)
            {
                string denied = Request.Params["Active"];

                if (denied == "off")
                {
                    string script = "alert('¡Debe Iniciar Sesión!');";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Información", script, true);
                }
            }
        }
        catch (Exception ex)
        {

        }

    }

   


    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conexion = new SqlConnection(@"Data Source = sql5019.smarterasp.net; Persist Security Info = True; User ID = DB_A132F9_SistemaCecees_admin; Password = sistema1234");

        conexion.Open();

        string consulta = "SELECT user_name, password, tipo_user, nombre_user from usuarios WHERE user_name='" + txtUsuario.Text+"'AND password='"+txtPassword.Text+"';";
        SqlCommand Ejecutar_Consulta = new SqlCommand(consulta,conexion);
        SqlDataReader LectorDatos = Ejecutar_Consulta.ExecuteReader();
        Boolean Validar_Usuario = LectorDatos.HasRows;

        try
        {
            if (Validar_Usuario && LectorDatos.Read() == true)
            {

                Session["user"] = LectorDatos["user_name"].ToString();
                Session["nombreUser"] = LectorDatos["nombre_user"].ToString();
                Session["TypeUser"] = LectorDatos["tipo_user"].ToString();
                Response.Redirect("default.aspx");
                
                conexion.Close(); 
            }
            else
            {
                string script = "alert('¡Usuario o Contraseña incorrecto!');";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Error", script, true);
            }
        }
        catch
        {
            string script = "alert('¡ERROR!');";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Error", script, true);
        }
    }
}