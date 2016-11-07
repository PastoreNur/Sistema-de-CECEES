using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Matricula : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Unnamed1_TextChanged(object sender, EventArgs e)
    {
        if (DdlIngreso.Text == "Si")
        {
            PnlAntiguo.Visible = false;

            PnlNuevo.Visible = true;

        }
        else if (DdlIngreso.Text == "No")
        {
            PnlNuevo.Visible = false;

            PnlAntiguo.Visible = true;
        }
        else
        {
            PnlAntiguo.Visible = false;
            PnlNuevo.Visible = false;
        }
    }
}