using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Account_Admin : System.Web.UI.Page
{
    bool SesionActive;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string sesion = Session["TypeUser"].ToString();
            if (sesion != "Admin")
            {
                Response.Redirect("../default.aspx?Active=off");
            }
        }
        catch (Exception x)
        {
            Response.Redirect("../login.aspx?Active=off");
        }



        try
        {


            if (Session["user"] != null)
            {
                Sesion.Text = "Cerrar Sesión";
                SesionActive = true;
                Sesion.Visible = false;
                Sesion.Enabled = false;
                BtnCerrarSesion.Enabled = true;
                BtnCerrarSesion.Visible = true;
                string username = Session["nombreUser"].ToString();
                LblNomUser.Text = "¡Bienvenido " + username + "!";
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


        protected void BtnUsuarios_Click(object sender, EventArgs e)
    {
        Response.Redirect("usuarios.aspx");
    }


    protected void Sesion_Click(object sender, EventArgs e)
    {
        if (SesionActive)
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

    protected void BtnCerrarSesion_Click(object sender, EventArgs e)
    {
        if (SesionActive)
        {
            CerrarSesion();
        }

    }

    public void CerrarSesion()
    {
        Session.Remove("user");
        Session.Remove("nombreUser");
        Session.Remove("TypeUser");
        Sesion.Text = "Iniciar Sesión";
        Response.Redirect("../default.aspx");
        LblNomUser.Text = "Invitado";

    }


    protected void BtnAdministrarALumnos_Click(object sender, EventArgs e)
    {

    }

    protected void BtnAdministrarDocentes_Click(object sender, EventArgs e)
    {

    }

    protected void BtnAdministrarPersonal_Click(object sender, EventArgs e)
    {

    }

    protected void BtnAdministrarNotas_Click(object sender, EventArgs e)
    {

    }

    protected void BtnAdminsitarHorarios_Click(object sender, EventArgs e)
    {

    }

    protected void BtnAdministrarPagos_Click(object sender, EventArgs e)
    {

    }
}