using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    private string usuario = "admin";
    private string contra = "1234";


    protected void Button1_Click(object sender, EventArgs e)
    {
        OleDbConnection conexion = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\josue\OneDrive\Documents\GitHub\Sistema-de-CECEES\App_Data\sistema_cecees.accdb;Persist Security Info=True");

        conexion.Open();

        string consulta = "SELECT user_name, password from usuarios WHERE user_name='"+TextBox1.Text+"'AND password='"+TextBox2.Text+"';";
        OleDbCommand Ejecutar_Consulta = new OleDbCommand(consulta,conexion);

        OleDbDataReader LectorDatos = Ejecutar_Consulta.ExecuteReader();

        Boolean Validar_Usuario = LectorDatos.HasRows;

        try
        {
            if (Validar_Usuario)
            {
                this.Page.Response.Write("<script language='JavaScript'>window.alert('Ha iniciado Sesión');</script>");
                System.Diagnostics.Process.Start("http://www.Google.com");
                conexion.Close();
                
            }
            else
            {
                this.Page.Response.Write("<script language='JavaScript'>window.alert('Usuario o Contaseña incorrecta');</script>");
            }
        }
        catch
        {
            this.Page.Response.Write("<script language='JavaScript'>window.alert('Error');</script>");
        }
    }
}