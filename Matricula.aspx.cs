using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class Matricula : System.Web.UI.Page
{
    public int id = 0;
    int numero = 0;
    string grado1, grado2, grado3, grado4, grado5, grado6, grado7, grado8, grado9, grado10, grado11, grado12, grado13, grado14, grado15, grado16, grado17, grado18, grado19, grado20;
    string gradoalum;
    protected void Page_Load(object sender, EventArgs e)
    {
        gradoalum = (string)(Session["Grado"]);

        try
       {
            string sesion = Session["user"].ToString();
                    }
                catch (Exception x)
        {
            Response.Redirect("login.aspx?Active=off");
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
     
    }
    //
    //




    List<TextBox> milista = new List<TextBox>();
    
    
    
    
    
    //
    //
    //Este el metodo de generacion de controles
    public void Agregarcontroles()
    {



        Label2.Visible = true;
        Label3.Visible = true;

        if (Convert.ToInt16(TxtHermNum.Text) > 0)
        {
            LblGrado1.Visible = true;
            TxtGrado1.Visible = true;

            if (Convert.ToInt16(TxtHermNum.Text) > 1)
            {
                LblGrado2.Visible = true;
                TxtGrado2.Visible = true;
                if (Convert.ToInt16(TxtHermNum.Text) > 2)
                {
                    LblGrado3.Visible = true;
                    TxtGrado3.Visible = true;
                    if (Convert.ToInt16(TxtHermNum.Text) > 3)
                    {
                        LblGrado4.Visible = true;
                        TxtGrado4.Visible = true;
                        if (Convert.ToInt16(TxtHermNum.Text) > 4)
                        {
                            LblGrado5.Visible = true;
                            TxtGrado5.Visible = true;
                            if (Convert.ToInt16(TxtHermNum.Text) > 5)
                            {
                                LblGrado6.Visible = true;
                                TxtGrado6.Visible = true;
                                if (Convert.ToInt16(TxtHermNum.Text) > 6)
                                {
                                    LblGrado7.Visible = true;
                                    TxtGrado7.Visible = true;
                                    if (Convert.ToInt16(TxtHermNum.Text) > 7)
                                    {
                                        LblGrado8.Visible = true;
                                        TxtGrado8.Visible = true;
                                        if (Convert.ToInt16(TxtHermNum.Text) > 8)
                                        {
                                            LblGrado9.Visible = true;
                                            TxtGrado9.Visible = true;
                                            if (Convert.ToInt16(TxtHermNum.Text) > 9)
                                            {
                                                LblGrado10.Visible = true;
                                                TxtGrado10.Visible = true;
                                                if (Convert.ToInt16(TxtHermNum.Text) > 10)
                                                {
                                                    LblGrado11.Visible = true;
                                                    TxtGrado11.Visible = true;
                                                    if (Convert.ToInt16(TxtHermNum.Text) > 11)
                                                    {
                                                        LblGrado12.Visible = true;
                                                        TxtGrado12.Visible = true;
                                                        if (Convert.ToInt16(TxtHermNum.Text) > 12)
                                                        {
                                                            LblGrado13.Visible = true;
                                                            TxtGrado13.Visible = true;
                                                            if (Convert.ToInt16(TxtHermNum.Text) > 13)
                                                            {
                                                                LblGrado14.Visible = true;
                                                                TxtGrado14.Visible = true;
                                                                if (Convert.ToInt16(TxtHermNum.Text) > 14)
                                                                {
                                                                    LblGrado15.Visible = true;
                                                                    TxtGrado15.Visible = true;
                                                                    if (Convert.ToInt16(TxtHermNum.Text) > 15)
                                                                    {
                                                                        LblGrado16.Visible = true;
                                                                        TxtGrado16.Visible = true;
                                                                        if (Convert.ToInt16(TxtHermNum.Text) > 16)
                                                                        {
                                                                            LblGrado17.Visible = true;
                                                                            TxtGrado17.Visible = true;

                                                                            if (Convert.ToInt16(TxtHermNum.Text) > 17)
                                                                            {
                                                                                LblGrado18.Visible = true;
                                                                                TxtGrado18.Visible = true;
                                                                                if (Convert.ToInt16(TxtHermNum.Text) > 18)
                                                                                {
                                                                                    LblGrado19.Visible = true;
                                                                                    TxtGrado19.Visible = true;
                                                                                    if (Convert.ToInt16(TxtHermNum.Text) > 19)
                                                                                    {
                                                                                        LblGrado20.Visible = true;
                                                                                        TxtGrado20.Visible = true;
                                                                                        
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

    }


    protected void Enviar_Click(object sender, EventArgs e)
    {

        //====================================================================================================================================================
        //= Este es el boton que lanza la generacion y depura el valor introducido en realidad lo ideal seria que este boton solo depurara
        //= y que en el load se corriera el metodo pero como la variable vuelve a 0 no lo hace
        //====================================================================================================================================================

        numero = Convert.ToInt16(TxtHermNum.Text);
        Label1.Text = Convert.ToString(numero);

        //  Label1.Text = numero.ToString();
        if (numero > 20 & numero > 0)
        {
            Response.Write("<script>alert('Por favor ingrese solo numeros entre 1 y 20')</script>");
        }
        else
        {
            Enviar.Visible = false;
        }
        Agregarcontroles();

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

    protected void RblVivecon_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        
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
<<<<<<< HEAD
        
       
=======


        if (TxtCel.Text=="")
        {
            TxtCel.Text = "0";
        }
        else
        {
            try
            {
                int i = Convert.ToInt32(TxtCel.Text);
            }
            catch (Exception)
            {

            }
        }
        if (TxtTelCasa.Text == "")
        {
            TxtTelCasa.Text = "0";
        }
        else
        {
            try
            {
                int i = Convert.ToInt32(TxtTelCasa.Text);
            }
            catch (Exception)
            {

            }
        }
>>>>>>> Pastore

        //depuracion
        grado1 = TxtGrado1.Text;
        grado2 = TxtGrado2.Text;
        grado3 = TxtGrado3.Text;
        grado4 = TxtGrado4.Text;
        grado5 = TxtGrado5.Text;
        grado6 = TxtGrado6.Text;
        grado7 = TxtGrado7.Text;
        grado8 = TxtGrado8.Text;
        grado9 = TxtGrado9.Text;
        grado10 = TxtGrado10.Text;
        grado11 = TxtGrado11.Text;
        grado12 = TxtGrado12.Text;
        grado13 = TxtGrado13.Text;
        grado14 = TxtGrado14.Text;
        grado15 = TxtGrado15.Text;
        grado16 = TxtGrado16.Text;
        grado17 = TxtGrado17.Text;
        grado18 = TxtGrado18.Text;
        grado19 = TxtGrado19.Text;
        grado20 = TxtGrado20.Text;

        gradoalum = "ejemplo";
        DateTime thisDay = DateTime.Today;
        string fecha = (thisDay.ToString("d"));
        string insert = "Insert into alumnospremat (NIT,ALUMNONOMBR1,ALUMNONOMBR2,ALUMNOAPELLI1,ALUMNOAPELLI2,GRADOSOLI,FECHASOL,GENERO,FECHANACIMIENTO,LUGNACIMIENTO,DIRECC,ZONARE,NACIONALI,TELCASA,CELULAR,RELIGION,BAUTIZ,PRIMCOMUN,CONFIRM,NUEVOING,INSTPROCE,GRADINGR,PARVULA,HERMAN,GRADHERMAN1,GRADHERMAN2,GRADHERMAN3,GRADHERMAN4,GRADHERMAN5,GRADHERMAN6,GRADHERMAN7,GRADHERMAN8,GRADHERMAN9,GRADHERMAN10,GRADHERMAN11,GRADHERMAN12,GRADHERMAN13,GRADHERMAN14,GRADHERMAN15,GRADHERMAN16,GRADHERMAN17,GRADHERMAN18,GRADHERMAN19,GRADHERMAN20,NOMMAD,PROFMAD,LUGTRABMAD,TELTRAB,NOMPAD,PROFPAD,LUGTRABPAD,TELTRABPAD,ESTADOCIV,VIVECON,DISCAP,CUALDISCAP,REPITENTE,VACUNASCOMPLE,PROBLEMASDESAL,EDUCESPECIAL,TRABREMUN,CUALTRAB,RESPON1NOM1,RESPON1NOM2,RESPON1APELL1,RESPON1APELL2,RESPON1DUI,RESPON1TEL,RESPON1CEL,RESPON2NOM1,RESPON2NOM2,RESPON2APELL1,RESPON2APELL2,RESPON2DUI,RESPON2TEL,RESPON2CEL)";
        string values = " values (" + TxtNIE.Text + ", '" + TxtNombreAlum1.Text + "', '" + TxtNombreAlum2.Text + "', '" + TxtApellidoAlum1.Text + "', '" + TxtApellidoAlum2.Text + "', '" + gradoalum + "', '" + fecha + "', '" + DdlGenero.Text + "', '" + TxtNacimento.Text + "', '" + TxtLugardenac.Text + "', '" + TxtDireccion.Text + "', '" + DdlZona.Text + "', '" + TxtNacionalidad.Text + "', " + TxtTelCasa.Text + ", " + TxtCel.Text + ", '" + TxtReligion.Text + "', '" + bautismo + "', '" + primeracom + "', '" + confirma + "', '" + DdlIngreso.Text + "', '" + TxtInstproc.Text + "', '" + TxtGradodesde.Text + "', '" + DdlParvularia.Text + "', '";
        string values2 = DdlHermanos.Text + "', '" + TxtGrado1.Text + "', '" + TxtGrado2.Text + "', '" + TxtGrado3.Text + "', '" + TxtGrado4.Text + "', '" + TxtGrado5.Text + "', '" + TxtGrado6.Text + "', '" + TxtGrado7.Text + "', '" + TxtGrado8.Text + "', '" + TxtGrado9.Text + "', '" + TxtGrado10.Text + "', '" + TxtGrado11.Text + "', '" + TxtGrado12.Text + "', '" + TxtGrado13.Text + "', '" + TxtGrado14.Text + "', '" + TxtGrado15.Text + "', '" + TxtGrado16.Text + "', '" + TxtGrado17.Text + "', '" + TxtGrado18.Text + "', '" + TxtGrado19.Text + "', '" + TxtGrado20.Text + "', '" + TxtNomMadre.Text + "', '" + TxtProfMadre.Text + "', '" + TxtLugTrabMadre.Text + "', '";
        string values3 = TxtTelTrabMadre.Text + "', '" + TxtNomPadre.Text + "', '" + TxtProfPadre.Text + "', '" + TxtLugTrabPadre.Text + "', '" + TxtTelTrabPadre.Text + "', '" + RblStadCivil.Text + "', '" + RblVivecon.Text + "', '" + DdlDiscp.Text + "', '" + TxtDisc.Text + "', '" + DdlAlumRep.Text + "', '" + DdlAlumVacunas.Text + "', '" + TxtProbSalud.Text + "', '" + DdlSpecial.Text + "', '" + DdlTrabAlum.Text + "', '" + TxtTrabAlum.Text + "', '" + TxtNom1Responsable.Text + "', '" + TxtNom2Responsable.Text + "', '" + TxtApell1Responsable.Text + "', '" + TxtApell2Responsable.Text + "', '" + TxtDUIResponsable.Text + "', '" + TxtTelResponsable.Text + "', '";
            string values4 = TxtCelularResponsable.Text + "', '" + TxtNom1Responsable1.Text + "', '" + TxtNom2Responsable1.Text + "', '" + TxtApell1Responsable1.Text + "', '" + TxtApell2Responsable1.Text + "', '" + TxtDUIResponsable1.Text + "', '" + TxtTelResponsable1.Text + "', '" + TxtCelularResponsable1.Text + "');";
            
        string superconsulta = insert + values + values2 + values3 + values4;
<<<<<<< HEAD

=======

        Label1.Text = superconsulta;

        conexion con2 = new conexion();
        con2.insert2(superconsulta);
>>>>>>> Pastore

        conexion con2 = new conexion();
        con2.insert(superconsulta);


        Label1.Text = superconsulta;



    }
}