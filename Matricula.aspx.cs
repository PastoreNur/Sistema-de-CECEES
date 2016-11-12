using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Matricula : System.Web.UI.Page
{

    public double numero = 0;
    public int id = 0;

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

    protected override void LoadViewState(object savedState)
    {
        base.LoadViewState(savedState);
        if (ViewState["controsladded"] == null)
            Agregarcontroles(numero);
    }

    public void Agregarcontroles(double controles)
    {
        PanelHermanos.Controls.Add(new LiteralControl("<p>En las siguientes casillas escriba el numero del grado a los que los hermanos del alumno asisten.</p>"));
        PanelHermanos.Controls.Add(new LiteralControl("<p>Ejemplo: Si uno de ellos asiste a tercero escriba 3, Y si asiste a primer año de bachillerato escriba b1 </p>"));

        for (int i = 1; i <= controles; i++)
        {
            id++;
            TextBox dynamictextbox = new TextBox();
            dynamictextbox.ID = "dynamictextbox" + id.ToString();
            dynamictextbox.CssClass = "form-control";
            PanelHermanos.Controls.Add(new LiteralControl("<h3>Grado " + id.ToString() + "</h3>"));
            PanelHermanos.Controls.Add(dynamictextbox);
            PanelHermanos.Controls.Add(new LiteralControl("<BR>"));
            PanelHermanos.Controls.Add(new LiteralControl("<BR>"));
            ViewState["controlsadded"] = true;

        }

    }


    protected void Enviar_Click(object sender, EventArgs e)
    {
        numero = Convert.ToDouble(TxtHermNum.Text);
        

        if (numero > 20 & numero > 0)
        {
            Response.Write("<script>alert('Por favor ingrese solo numeros entre 1 y 20')</script>");
        }
        else
        {
            TextBox tb = new TextBox();
            tb = (TextBox)(PanelHermanos.FindControl("dynamictextbox"));
            Agregarcontroles(numero);
        }

        

    }

    protected void DdlHermanos_SelectedIndexChanged1(object sender, EventArgs e)
    {
        if (DdlHermanos.Text == "Si")
        {

            PanelHermanos.Visible = true;
        }
        else if (DdlHermanos.Text == "No")
        {
            PanelHermanos.Visible = false;
        }
        else
        {

            PanelHermanos.Visible = false;
        }
    }
}