using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class UsuarioPremat : System.Web.UI.Page
{
    string NIE;
    protected void Page_Load(object sender, EventArgs e)
    {
        NIE = Convert.ToString(Session["NIE"]);
    }

    protected void guardar_Click(object sender, EventArgs e)
    {
        try
        {
            string consulta;

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "mysql5013.smarterasp.net";
            builder.UserID = "a131fe_bd";
            builder.Password = "prueba123";
            builder.Database = "db_a131fe_bd";
            MySqlConnection con = new MySqlConnection(builder.ToString());
            MySqlCommand query = con.CreateCommand();

            con.Open();
            consulta = "SELECT cod_user FROM usuarios WHERE cod_user='" + txtCodUser.Text + "'";
            query.CommandText = consulta;
            MySqlDataReader leer = query.ExecuteReader();

            //SqlCommand query;
            //SqlConnection con = new SqlConnection("Data Source=sql5019.smarterasp.net;Persist Security Info=True;User ID=DB_A132F9_SistemaCecees_admin;Password=sistema1234");

            //query = new SqlCommand(consulta, con);
            //SqlDataReader leer = query.ExecuteReader();
            bool validar = leer.HasRows;


            if (validar)
            {
                string script = "alert('¡El usuario " + txtCodUser.Text + " ya existe!');";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Información", script, true);
            }
            else
            {

                if (txtCodUser.Text == "" || txtEmail.Text == "" || txtFirstLastName.Text == "" || txtFirstName.Text == ""
            || txtSecondLastName.Text == "" || txtSecondName.Text == "")
                {
                    string script2 = "alert('¡No puede dejar ningún campo vacío!');";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Información", script2, true);
                }
                else
                {
                    string sql1 = "INSERT INTO usuarios (ID_USUARIO, cod_user, contra, nombre_user, correo, tipo_user, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, NIE) values ('" + txtCodUser.Text + "','" + txtCodUser.Text + "','" + txtPassword.Text + "','" + txtFirstName.Text + " " + txtFirstLastName.Text +
                "','" + txtEmail.Text + "', '" + "matricula" + "','" + txtFirstName.Text + "', '" + txtSecondName.Text + "', '" + txtFirstLastName.Text +
                "', '" + txtSecondLastName.Text + "','" + NIE + "'); ";
                    string sql2 = "INSERT INTO usuariosmat (NIE,NOM,NOM1,APELL,APELL1,COD_USER) values ('"+NIE+"', '"+ txtFirstName.Text+"', '"+txtSecondName.Text+"', '"+txtFirstLastName.Text+"', '" + txtSecondLastName.Text +"', '"+txtCodUser.Text+"');";
                        string sql = sql1 + sql2;
                    conexion con2 = new conexion();
                    con2.insert(sql);

                    string script = "alert('¡El usuario se registró exitosamente!');";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Información", script, true);
                }


            }


        }
        catch (Exception ex)
        {
            string script = "alert('¡ERROR!');";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Información", script, true);
        }
    }
}