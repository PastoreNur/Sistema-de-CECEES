using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class Account_materias : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    string consulta;
    protected void BtnRegistrar_Click(object sender, EventArgs e)
    {

        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        builder.Server = "mysql5013.smarterasp.net";
        builder.UserID = "a131fe_bd";
        builder.Password = "prueba123";
        builder.Database = "db_a131fe_bd";
        MySqlConnection con = new MySqlConnection(builder.ToString());
        MySqlCommand query = con.CreateCommand();
        con.Open();
        consulta = "SELECT nombre_materia FROM materia WHERE nombre_materia='" + txtNomMateria.Text + "'";
        query.CommandText = consulta;
        MySqlDataReader leer = query.ExecuteReader();
        bool validar = leer.HasRows;
        if (validar)
        {
            string script = "alert('¡La Materia " + txtNomMateria.Text + " ya ha existe!');";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Información", script, true);
            borrar();
        }
        else
        {
            if (txtNomMateria.Text ==null||DpdTipoMateria.SelectedValue == "")
            {
                string script = "alert('¡NO puede dejar campos vacíos!');";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Información", script, true);
            }
            else
            {
                string sql = "Insert into materia (nombre_materia, tipo_materia) values ('" + txtNomMateria.Text + "', '"+DpdTipoMateria.SelectedItem.Text+"')";
                conexion conn = new conexion();
                conn.insert(sql);

                string script = "alert('¡La Materia " + txtNomMateria.Text + " se registró exitosamente!');";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Información", script, true);

                borrar();
            }
        }

        
    }

    public void borrar()
    {
        txtNomMateria.Text = "";
        DpdTipoMateria.ClearSelection();
    }
}