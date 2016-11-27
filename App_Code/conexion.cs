using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

/// <summary>
/// Descripción breve de conexion
/// </summary>
public class conexion
{
  
    public void conectar()
    {
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        builder.Server = "mysql5013.smarterasp.net";
        builder.UserID = "a131fe_bd";
        builder.Password = "prueba123";
        builder.Database = "db_a131fe_bd";
        MySqlConnection con = new MySqlConnection(builder.ToString());
        MySqlCommand cmd = con.CreateCommand();
        try
        {
            con.Open();
        }
        catch (Exception)
        {

        }
        finally
        {
            con.Close();
        }
    }


   // SqlConnection con = new SqlConnection(@"Data Source = sql5019.smarterasp.net; Persist Security Info = True; User ID = DB_A132F9_SistemaCecees_admin; Password = sistema1234");
    //public SqlCommand consulta;



    public void insert(string sql)
    {
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        builder.Server = "mysql5013.smarterasp.net";
        builder.UserID = "a131fe_bd";
        builder.Password = "prueba123";
        builder.Database = "db_a131fe_bd";
        MySqlConnection con = new MySqlConnection(builder.ToString());
        MySqlCommand cmd = con.CreateCommand();

        con.Open();
        cmd.CommandText = sql;
        int i = cmd.ExecuteNonQuery();
        if (i > 0)
        {

        }
        else
        {

        }
    }

    public bool eliminar(string elimina)
    {
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        builder.Server = "mysql5013.smarterasp.net";
        builder.UserID = "a131fe_bd";
        builder.Password = "prueba123";
        builder.Database = "db_a131fe_bd";
        MySqlConnection con = new MySqlConnection(builder.ToString());
        MySqlCommand cmd = con.CreateCommand();
        con.Open();
        cmd.CommandText = elimina;
        int i = cmd.ExecuteNonQuery();
        if (i > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool actualizar(string tabla, string campos, string condicion)
    {
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        builder.Server = "mysql5013.smarterasp.net";
        builder.UserID = "a131fe_bd";
        builder.Password = "prueba123";
        builder.Database = "db_a131fe_bd";
        MySqlConnection con = new MySqlConnection(builder.ToString());
        MySqlCommand cmd = con.CreateCommand();
        con.Open();
        string actualizar = " update " + tabla + " set " + campos + " where " + condicion;
        cmd.CommandText = actualizar;
        int i = cmd.ExecuteNonQuery();
        con.Close();
        if (i > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


}