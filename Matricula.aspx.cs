using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Matricula : System.Web.UI.Page
{
    string[] grados = new string[20];
    public int id = 0;


    //Instancia para supuestamente guardar el valor
    InformacionMatricula informaciondetodo = new InformacionMatricula();


    protected void Page_Load(object sender, EventArgs e)
    {
        //Esa label esta al final es para probar el valor con el que regresa
        Label1.Text = Convert.ToString(informaciondetodo.Leer());

        //Esa es la comparacion entre la variable guardada en la otra clase, es para que cuando haya cambios en ese valor haga desde aca la generacion
        if (informaciondetodo.Leer() != 0)
        {
            //El metodo que genera los controles con la variable supuestamente guardada
            Agregarcontroles(informaciondetodo.Leer());
        }
        else
        {

        }
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
            Agregarcontroles(informaciondetodo.Leer());
    }

    List<TextBox> milista = new List<TextBox>();


    //Este el metodo de generacion de controles
    public void Agregarcontroles(double controles)
    {
        
        PanelHermanos.Controls.Add(new LiteralControl("<p>En las siguientes casillas escriba el numero del grado a los que los hermanos del alumno asisten.</p>"));
        PanelHermanos.Controls.Add(new LiteralControl("<p>Ejemplo: Si uno de ellos asiste a tercero escriba 3, Y si asiste a primer año de bachillerato escriba b1 </p>"));


        //este for no corre por la falta del valor de la variable
        //Solo corre cuando le das click al boton que es antes de perder el valor
        //Por eso es que si le das otro click a cualquier otro boton los elementos desaparecen
        for (int i = 1; i <= informaciondetodo.Leer(); i++)
        {
            TextBox dynamictextbox = new TextBox();

            id++;
            dynamictextbox.ID = "dynamictextbox" + id.ToString();
            dynamictextbox.CssClass = "form-control";
            PanelHermanos.Controls.Add(new LiteralControl("<h3>Grado " + id.ToString() + "</h3>"));
            PanelHermanos.Controls.Add(dynamictextbox);
            milista.Add(dynamictextbox);
            PanelHermanos.Controls.Add(new LiteralControl("<BR>"));
            PanelHermanos.Controls.Add(new LiteralControl("<BR>"));
            ViewState["controlsadded"] = true;

        }

        BtnAceptarHerm.Visible = true;



    }


    protected void Enviar_Click(object sender, EventArgs e)
    {

        //====================================================================================================================================================
        //= Este es el boton que lanza la generacion y depura el valor introducido en realidad lo ideal seria que este boton solo depurara
        //= y que en el load se corriera el metodo pero como la variable vuelve a 0 no lo hace
        //====================================================================================================================================================

        informaciondetodo.temporales(Convert.ToDouble(TxtHermNum.Text));

        //  Label1.Text = numero.ToString();
        if (informaciondetodo.Leer() > 20 & informaciondetodo.Leer() > 0)
        {
            Response.Write("<script>alert('Por favor ingrese solo numeros entre 1 y 20')</script>");
        }
        else
        {
            Enviar.Visible = false;
        }
        Agregarcontroles(informaciondetodo.Leer());

    }

    //Esta instancia no me acuerdo para que era pero de seguro ya no sirve :v
    TextBox tb = new TextBox();

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

    protected void RblVivecon_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (RblVivecon.Text == "Otros")
        {
            PanelOtros.Visible = true;
        }
        else
        {
            PanelOtros.Visible = false;

        }
        
    }

    protected void Unnamed1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DdlDiscp.Text == "Si")
        {
            PanelDisc.Visible = true;
        }
        else
        {
            PanelDisc.Visible = false;
        }
    }

    protected void DdlTrabAlum_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DdlTrabAlum.Text == "Si")
        {
            PanelTrabajo.Visible = true;
        }
        else
        {
            PanelTrabajo.Visible = false;
        }
    }



    //Este es el boton mas importante de todos
    // es aqui donde se depura todo y en el futuro sera donde se pase la informacion a la otra clase
    protected void Aceptar_Click(object sender, EventArgs e)
    {
        int edadalum, telcasa,celular,grado,numhermanos;
        string bautismo, confirma, primeracom;

        try
        {
            numhermanos = Convert.ToInt16(TxtHermNum.Text);
        }
        catch (Exception)
        {

        }

        try
        {
            grado = Convert.ToInt16(TxtGradodesde.Text);
        }
        catch (Exception)
        {

        }

        if (ChBBautismo.Checked == true)
        {
            bautismo = "Si";
        }
        else
        {
            bautismo = "No";
        }
        if (ChBPrimeracom.Checked == true)
        {
            primeracom = "Si";
        }
        else
        {
            primeracom = "No";
        }
        if (ChBConfirmacion.Checked == true)
        {
            confirma = "Si";
        }
        else
        {
            confirma = "No";
        }
        try
        {
           edadalum = Convert.ToInt16(TxtEdad.Text);
        }
        catch (Exception)
        {

        }
        try
        {
            telcasa = Convert.ToInt16(TxtTelCasa.Text);
        }
        catch (Exception)
        {

        }
        try
        {
            celular = Convert.ToInt16(TxtCel.Text);
        }
        catch (Exception)
        {

        }



        

        for (int i = 0; i < milista.Count; i++)
        {
            TextBox Dinami = new TextBox();
            grados[i] = Dinami.Text;
            Label1.Text = "Hola" + Label1.Text + Dinami.Text + "\n";
        }


        // InformacionMatricula pase = new InformacionMatricula();
        //pase.informacion(TxtApellidosAlum.Text, TxtNombresAlum.Text, DdlGenero.Text,TxtNacimento.Text,edadalum,TxtLugardenac.Text,DdlZona.Text,TxtNacionalidad.Text,telcasa,celular,
        //  TxtReligion.Text,bautismo,confirma,primeracom,DdlIngreso.Text,TxtInstproc.Text,grado,DdlParvularia.Text,DdlHermanos.Text,numhermanos);
    }
}