using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    public bool SesionActive;

    protected void Page_Load(object sender, EventArgs e)
    {
        try
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
        }
        catch(Exception ex)
        {

        }

        try
        {
            if (Request.Params["Active"] != null)
            {
                string denied = Request.Params["Active"];

                if (denied == "off")
                {
                    string script = "alert('¡Acceso Denegado!');";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Información", script, true);
                }
            }
        }
        catch (Exception ex)
        {

        }

        try
        {
            

            if(Session["user"] != null)
            {
                Sesion.Text = "Cerrar Sesión";
                SesionActive = true;
                Sesion.Visible = false;
                Sesion.Enabled = false;
                BtnCerrarSesion.Enabled = true;
                BtnCerrarSesion.Visible = true;
                string username = Session["nombreUser"].ToString();
                LblNomUser.Text = "¡Bienvenido "+username+"!";
            }
            else
            {
                LblNomUser.Text = "Invitado";
                Sesion.Text = "Iniciar Sesión";
                Sesion.Enabled = true;
                Sesion.Visible = true;
                BtnCerrarSesion.Enabled = false;
                BtnCerrarSesion.Visible = false;
                SesionActive = false;
            }

        }
        catch (Exception x)
        {
            
            
        }

    }

    

    public void CerrarSesion()
    {
        Session.Remove("user");
        Session.Remove("nombreUser");
        Session.Remove("TypeUser");
        Sesion.Text = "Iniciar Sesión";
        Response.Redirect("Default.aspx");
        LblNomUser.Text = "Invitado";

    }

    protected void Sesion_Click(object sender, EventArgs e)
    {
        if(SesionActive)
        {
            Sesion.Enabled = false;
            Sesion.Visible = false;
            BtnCerrarSesion.Enabled = true;
            BtnCerrarSesion.Visible = true;
        }
        else
        {
            BtnCerrarSesion.Enabled = false;
            BtnCerrarSesion.Visible = false;
            Response.Redirect("Login.aspx");
        }
    }

    protected void PanelAdministracion_Click(object sender, EventArgs e)
    {
        try
        {
            string tipouser = Session["TypeUser"].ToString();
            switch (tipouser)
            {
                case "VIP":
                    Response.Redirect("Account/VIP.aspx");
                    break;
                case "Admin":
                    Response.Redirect("Account/admin.aspx");
                    break;
                case "Secretaria":
                    Response.Redirect("Account/secretaria.aspx");
                    break;
                case "Tesorero":
                    Response.Redirect("Account/tesorero.aspx");
                    break;
                case "Alumno":
                    Response.Redirect("Account/alumno.aspx");
                    break;
                case "Docente":
                    Response.Redirect("Account/docente.aspx");
                    break;
                case "Encargado":
                    Response.Redirect("Account/encargado.aspx");
                    break;
            }
        }
        catch(Exception ex)
        {
            string script = "alert('¡Debe Iniciar Sesión!');";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Información", script, true);
            
        }
    }

    protected void BtnCerrarSesion_Click(object sender, EventArgs e)
    {
        if (SesionActive)
        {
            CerrarSesion();
        }

    }
}