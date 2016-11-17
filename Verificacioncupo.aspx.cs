using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Verificacioncupo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string sesion = Session["user"].ToString();
        }
        catch (Exception x)
        {
            Response.Redirect("login.aspx?Active=off");
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        BtnSigCupo.Enabled = true;
    }

}