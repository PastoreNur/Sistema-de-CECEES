using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

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
        // SqlConnection conexion = new SqlConnection(@"Data Source = sql5019.smarterasp.net; Persist Security Info = True; User ID = DB_A132F9_SistemaCecees_admin; Password = sistema1234");

        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        builder.Server = "mysql5013.smarterasp.net";
        builder.UserID = "a131fe_bd";
        builder.Password = "prueba123";
        builder.Database = "db_a131fe_bd";
        MySqlConnection conexion = new MySqlConnection(builder.ToString());
        conexion.Open();
        string consulta = "SELECT cod_user, contra, tipo_user, nombre_user from usuarios WHERE cod_user='" + txtUsuario.Text + "'AND contra='" + txtPassword.Text + "';";

        MySqlCommand Ejecutar_Consulta = new MySqlCommand(consulta,conexion);

        //MySqlCommand Ejecutar_Consulta = conexion.CreateCommand();
        MySqlDataReader LectorDatos = Ejecutar_Consulta.ExecuteReader();
        //Esto de abajo y esto de arriba son lo mismo pero con otro servidor

        //SqlCommand Ejecutar_Consulta = new SqlCommand(consulta,conexion);
        //SqlDataReader LectorDatos = Ejecutar_Consulta.ExecuteReader();

     
        Boolean Validar_Usuario = LectorDatos.HasRows;


        try
        {
            if (Validar_Usuario && LectorDatos.Read() == true)
            {

                Session["user"] = LectorDatos["cod_user"].ToString();
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