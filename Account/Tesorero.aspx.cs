using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Account_Tesorero : System.Web.UI.Page
{
    bool SesionActive;
    protected void Page_Load(object sender, EventArgs e)
    {
        

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
}