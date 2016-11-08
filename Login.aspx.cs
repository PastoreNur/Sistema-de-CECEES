using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    private string usuario = "admin";
    private string contra = "1234";


    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            if(TextBox1.Text == "admin" || TextBox1.Text == "Admin")
            {
                if(TextBox2.Text == "1234")
                {
                    this.Page.Response.Write("<script language='JavaScript'>window.alert('Ha iniciado Sesión');</script>");
                    System.Diagnostics.Process.Start("http://www.xvideos.com");
                }
                else
                {
                    this.Page.Response.Write("<script language='JavaScript'>window.alert('Contraseña Incorrecta');</script>");
                }
            }
            else
            {
                this.Page.Response.Write("<script language='JavaScript'>window.alert('Usuario Incorrecto');</script>");
            }
        }
        catch
        {
            this.Page.Response.Write("<script language='JavaScript'>window.alert('Error');</script>");
        }
    }
}