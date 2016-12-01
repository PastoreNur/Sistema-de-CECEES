using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

public partial class Account_admin_asignarmateria : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


        if (!IsPostBack)
        {
            try
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = "mysql5013.smarterasp.net";
                builder.UserID = "a131fe_bd";
                builder.Password = "prueba123";
                builder.Database = "db_a131fe_bd";
                MySqlConnection conn = new MySqlConnection(builder.ToString());
                conn.Open();
                MySqlCommand OrdenSqlSelect = new MySqlCommand("SELECT * FROM grado", conn);
                MySqlDataAdapter da = new MySqlDataAdapter(OrdenSqlSelect.CommandText, conn);
               
                DataSet ds = new DataSet();
                da.Fill(ds);

                this.DpdGradosRegistrados.DataSource = ds;
                this.DpdGradosRegistrados.DataValueField = "nombre_grado";
                this.DpdGradosRegistrados.DataTextField = "nombre_grado";
                this.DpdGradosRegistrados.DataBind();
                this.DpdGradosRegistrados.Items.Insert(0,"");
                conn.Close();
                cargarDocentes();
                cargarMaterias();
            }
            catch (Exception)
            {

            }
        }


    }

    public void cargarMaterias()
    {
        try
        {
            
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        builder.Server = "mysql5013.smarterasp.net";
        builder.UserID = "a131fe_bd";
        builder.Password = "prueba123";
        builder.Database = "db_a131fe_bd";
        MySqlConnection conn = new MySqlConnection(builder.ToString());
        conn.Open();
        MySqlCommand OrdenSqlSelect = new MySqlCommand("SELECT * FROM materia", conn);
        MySqlDataAdapter da = new MySqlDataAdapter(OrdenSqlSelect.CommandText, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
            
        this.DpdMateria.DataSource = ds;
        this.DpdMateria.DataValueField = "nombre_materia";
        this.DpdMateria.DataTextField = "nombre_materia";
        this.DpdMateria.DataBind();
        this.DpdMateria.Items.Insert(0, "");
        conn.Close();
    }
            catch (Exception)
            {

            }
        

    }

    public void cargarDocentes()
    {
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        builder.Server = "mysql5013.smarterasp.net";
        builder.UserID = "a131fe_bd";
        builder.Password = "prueba123";
        builder.Database = "db_a131fe_bd";
        MySqlConnection conn = new MySqlConnection(builder.ToString());
        conn.Open();

       
        
        MySqlCommand OrdenSqlSelect = new MySqlCommand("SELECT nombre_completo_doc FROM docentes", conn);
        MySqlDataAdapter da = new MySqlDataAdapter(OrdenSqlSelect.CommandText, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        this.DpdDocente.DataSource = ds;
        this.DpdDocente.DataValueField = "nombre_completo_doc";
        this.DpdDocente.DataTextField = "nombre_completo_doc";
        this.DpdDocente.DataBind();
        this.DpdDocente.Items.Insert(0, new ListItem("---Elija una opción---", "0"));

        conn.Close();
    }
    string sql;
    protected void BtnAsignar_Click(object sender, EventArgs e)
    {
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        builder.Server = "mysql5013.smarterasp.net";
        builder.UserID = "a131fe_bd";
        builder.Password = "prueba123";
        builder.Database = "db_a131fe_bd";
        MySqlConnection conn = new MySqlConnection(builder.ToString());
        conn.Open();


        string variable ="";
        
        switch(variable){
            case "7:00 - 7:45":
                sql = "INSERT INTO horario_alumno (id_grado, nombre_materia, dia_sem, hora_1) values ('','','','')";
                break;
            case "7:45 - 8:30":
                sql = "INSERT INTO horario_alumno (id_grado, nombre_materia, dia_sem, hora_2) values ('','','','')";
                break;
            case "8:50 - 9:45":
                sql = "INSERT INTO horario_alumno (id_grado, nombre_materia, dia_sem, hora_3) values ('','','','')";
                break;
            case "9:35 - 10:20":
                sql = "INSERT INTO horario_alumno (id_grado, nombre_materia, dia_sem, hora_4) values ('','','','')";
                break;
            case "10:30 - 11:15":
                sql = "INSERT INTO horario_alumno (id_grado, nombre_materia, dia_sem, hora_5) values ('','','','')";
                break;
            case "11:15 - 12:00":
                sql = "INSERT INTO horario_alumno (id_grado, nombre_materia, dia_sem, hora_6) values ('','','','')";
                break;
            case "12:30 - 1:15":
                sql = "INSERT INTO horario_alumno (id_grado, nombre_materia, dia_sem, hora_7) values ('','','','')";
                break;
            case "1:15 - 2:00":
                sql = "INSERT INTO horario_alumno (id_grado, nombre_materia, dia_sem, hora_8) values ('','','','')";
                break;
            case "2:15 - 3:00":
                sql = "INSERT INTO horario_alumno (id_grado, nombre_materia, dia_sem, hora_9) values ('','','','')";
                break;
            case "3:00 - 3:45":
                sql = "INSERT INTO horario_alumno (id_grado, nombre_materia, dia_sem, hora_10) values ('','','','')";
                break;

        }
    }
}