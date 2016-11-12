using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Descripción breve de conexion
/// </summary>
public class conexion
{

    public void conectar()
    {
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

    SqlConnection con = new SqlConnection(@"Data Source = sql5019.smarterasp.net; Persist Security Info = True; User ID = DB_A132F9_SistemaCecees_admin; Password = sistema1234");
    public SqlCommand consulta;



    public void insert(string sql)
    {
        con.Open();
        consulta = new SqlCommand(sql, con);
        int i = consulta.ExecuteNonQuery();
        if (i > 0)
        {

        }
        else
        {

        }
    }

    public bool eliminar(string elimina)
    {
        con.Open();
        consulta = new SqlCommand(elimina, con);
        int i = consulta.ExecuteNonQuery();
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
        con.Open();
        string actualizar = " update " + tabla + " set " + campos + " where " + condicion;
        consulta = new SqlCommand(actualizar, con);
        int i = consulta.ExecuteNonQuery();
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