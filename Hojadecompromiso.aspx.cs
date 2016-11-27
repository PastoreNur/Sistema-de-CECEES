using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Hojadecompromiso : System.Web.UI.Page
{
    string grado;
    protected void Page_Load(object sender, EventArgs e)
    {
        grado = (string)(Session["Grado"]);
        try
        {
            string sesion = Session["user"].ToString();
        }
        catch (Exception x)
        {
            Response.Redirect("login.aspx?Active=off");
        }
    }

    protected void ChcBCompromiso_CheckedChanged(object sender, EventArgs e)
    {

        if (ChcBCompromiso.Checked == true)
        {
            BtnSigcompromiso.Enabled = true;
        }
        else
        {
            BtnSigcompromiso.Enabled = false;
        }
        
    }

    protected void BtnSigcompromiso_Click(object sender, EventArgs e)
    {
        Session.Add("Grado", grado);
        Server.Transfer("Matricula.aspx");
        Response.Redirect("/Matricula.aspx");
    }
}