using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    public bool SesionActive;

    protected void Page_Load(object sender, EventArgs e)
    {

        if (Request.Params["Active"] != null)
        {
            string denied = Request.Params["Active"];

            if (denied == Session["user"].ToString())
            {
                string script = "alert('¡Ya ha iniciado sesión!');";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Información", script, true);
            }
        }

        try
        {
            string usuario = Session["user"].ToString();
            Sesion.Text = "Cerrar Sesión";
            SesionActive = true;
            
        }
        catch(Exception x)
        {
            Sesion.Text = "Iniciar Sesión";
            SesionActive = false;
        }

       
        
    }

    public void CerrarSesion()
    {
        Session.Remove("user");
        Sesion.Text = "Iniciar Sesión";
        Response.Redirect("Default.aspx");

    }

    protected void Sesion_Click(object sender, EventArgs e)
    {
        if(SesionActive)
        {
            CerrarSesion();
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }
}