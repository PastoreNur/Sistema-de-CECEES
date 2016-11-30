using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class Matricula : System.Web.UI.Page
{
    string bautismo, confirma, primeracom;

    public int id = 0;
    int numero = 0;
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
        string NIE = TxtNIE.Text;

        gradoalum = "ejemplo";
        DateTime thisDay = DateTime.Today;
        string fecha = (thisDay.ToString("d"));
        string insert = "Insert into alumnospremat (NIE,ALUMNONOMBR1,ALUMNONOMBR2,ALUMNOAPELLI1,ALUMNOAPELLI2,GRADOSOLI,FECHASOL,GENERO,FECHANACIMIENTO,LUGNACIMIENTO,DIRECC,ZONARE,NACIONALI,TELCASA,CELULAR,RELIGION,BAUTIZ,PRIMCOMUN,CONFIRM,NUEVOING,INSTPROCE,GRADINGR,PARVULA,HERMAN,GRADHERMAN1,GRADHERMAN2,GRADHERMAN3,GRADHERMAN4,GRADHERMAN5,GRADHERMAN6,GRADHERMAN7,GRADHERMAN8,GRADHERMAN9,GRADHERMAN10,GRADHERMAN11,GRADHERMAN12,GRADHERMAN13,GRADHERMAN14,GRADHERMAN15,GRADHERMAN16,GRADHERMAN17,GRADHERMAN18,GRADHERMAN19,GRADHERMAN20,NOMMAD,PROFMAD,LUGTRABMAD,TELTRAB,NOMPAD,PROFPAD,LUGTRABPAD,TELTRABPAD,ESTADOCIV,VIVECON,DISCAP,CUALDISCAP,REPITENTE,VACUNASCOMPLE,PROBLEMASDESAL,EDUCESPECIAL,TRABREMUN,CUALTRAB,RESPON1NOM1,RESPON1NOM2,RESPON1APELL1,RESPON1APELL2,RESPON1DUI,RESPON1TEL,RESPON1CEL,RESPON2NOM1,RESPON2NOM2,RESPON2APELL1,RESPON2APELL2,RESPON2DUI,RESPON2TEL,RESPON2CEL,EDAD,NUMHERMAN)";
        string values = " values (" + TxtNIE.Text + ", '" + TxtNombreAlum1.Text + "', '" + TxtNombreAlum2.Text + "', '" + TxtApellidoAlum1.Text + "', '" + TxtApellidoAlum2.Text + "', '" + gradoalum + "', '" + fecha + "', '" + DdlGenero.Text + "', '" + TxtNacimento.Text + "', '" + TxtLugardenac.Text + "', '" + TxtDireccion.Text + "', '" + DdlZona.Text + "', '" + TxtNacionalidad.Text + "', " + TxtTelCasa.Text + ", " + TxtCel.Text + ", '" + TxtReligion.Text + "', '" + bautismo + "', '" + primeracom + "', '" + confirma + "', '" + DdlIngreso.Text + "', '" + TxtInstproc.Text + "', '" + TxtGradodesde.Text + "', '" + DdlParvularia.Text + "', '";
        string values2 = DdlHermanos.Text + "', '" + TxtGrado1.Text + "', '" + TxtGrado2.Text + "', '" + TxtGrado3.Text + "', '" + TxtGrado4.Text + "', '" + TxtGrado5.Text + "', '" + TxtGrado6.Text + "', '" + TxtGrado7.Text + "', '" + TxtGrado8.Text + "', '" + TxtGrado9.Text + "', '" + TxtGrado10.Text + "', '" + TxtGrado11.Text + "', '" + TxtGrado12.Text + "', '" + TxtGrado13.Text + "', '" + TxtGrado14.Text + "', '" + TxtGrado15.Text + "', '" + TxtGrado16.Text + "', '" + TxtGrado17.Text + "', '" + TxtGrado18.Text + "', '" + TxtGrado19.Text + "', '" + TxtGrado20.Text + "', '" + TxtNomMadre.Text + "', '" + TxtProfMadre.Text + "', '" + TxtLugTrabMadre.Text + "', '";
        string values3 = TxtTelTrabMadre.Text + "', '" + TxtNomPadre.Text + "', '" + TxtProfPadre.Text + "', '" + TxtLugTrabPadre.Text + "', '" + TxtTelTrabPadre.Text + "', '" + RblStadCivil.Text + "', '" + RblVivecon.Text + "', '" + DdlDiscp.Text + "', '" + TxtDisc.Text + "', '" + DdlAlumRep.Text + "', '" + DdlAlumVacunas.Text + "', '" + TxtProbSalud.Text + "', '" + DdlSpecial.Text + "', '" + DdlTrabAlum.Text + "', '" + TxtTrabAlum.Text + "', '" + TxtNom1Responsable.Text + "', '" + TxtNom2Responsable.Text + "', '" + TxtApell1Responsable.Text + "', '" + TxtApell2Responsable.Text + "', '" + TxtDUIResponsable.Text + "', '" + TxtTelResponsable.Text + "', '";
            string values4 = TxtCelularResponsable.Text + "', '" + TxtNom1Responsable1.Text + "', '" + TxtNom2Responsable1.Text + "', '" + TxtApell1Responsable1.Text + "', '" + TxtApell2Responsable1.Text + "', '" + TxtDUIResponsable1.Text + "', '" + TxtTelResponsable1.Text + "', '" + TxtCelularResponsable1.Text + "', '" + TxtEdad.Text +"', '"+ TxtHermNum.Text+ "');";
        string superconsulta = insert + values + values2 + values3 + values4;
        CleanControl(this.Controls);
        conexion con2 = new conexion();
        con2.insert2(superconsulta);
        Session.Add("NIE", NIE);
        Server.Transfer("UsuarioPremat.aspx");
        Response.Redirect("UsuarioPramat.aspx");
    }

    public void limpiar()
    {
        TxtNIE.Text = "";
        TxtNombreAlum1.Text = "";
        TxtNombreAlum2.Text = "";
        TxtApellidoAlum1.Text = "";
        TxtApellidoAlum2.Text = "";
        gradoalum = "";
        Session.Remove("Grado");
        DdlGenero.SelectedIndex = 0;
        TxtNacimento.Text = "";

    }

    public void CleanControl(ControlCollection controles)
    {
        foreach (Control control in controles)
        {
            if (control is TextBox)
                ((TextBox)control).Text = string.Empty;
            else if (control is DropDownList)
                ((DropDownList)control).ClearSelection();
            else if (control is RadioButtonList)
                ((RadioButtonList)control).ClearSelection();
            else if (control is CheckBoxList)
                ((CheckBoxList)control).ClearSelection();
            else if (control is RadioButton)
                ((RadioButton)control).Checked = false;
            else if (control is CheckBox)
                ((CheckBox)control).Checked = false;
            else if (control.HasControls())
                //Esta linea detécta un Control que contenga otros Controles
                //Así ningún control se quedará sin ser limpiado.
                CleanControl(control.Controls);
        }
    }
    protected void Verificar_Click(object sender, EventArgs e)
    {
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        builder.Server = "mysql5013.smarterasp.net";
        builder.UserID = "a131fe_bd";
        builder.Password = "prueba123";
        builder.Database = "db_a131fe_bd";
        MySqlConnection conn = new MySqlConnection(builder.ToString());
        conn.Open();
        //nel

        bool error = false;

        Label4.Text = "";
        //txt vacios
        if (string.IsNullOrEmpty(TxtNIE.Text))
        {
            Label5.Text = "Lista de errores.";
            Label4.Text = "<br/> - El NIE es un campo obligatorio";
            error = true;
        }
        else
        {
            string sql = "Select NIE from alumnos where NIE="+TxtNIE.Text;

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            bool validar = rdr.HasRows;
            if (validar)
            {
                Label4.Text = " - El NIE que intenta introducir ya esta en la base de datos <br/>";
                error = true;
            }
        }

        if (string.IsNullOrEmpty(TxtNombreAlum1.Text))
        {
            Label5.Text = "Lista de errores.";
            Label4.Text = Label4.Text + "<br/> - El nombre es un campo obligatorio";
            error = true;
        }
        if (string.IsNullOrEmpty(TxtApellidoAlum1.Text))
        {
            Label5.Text = "Lista de errores.";
            Label4.Text = Label4.Text + "<br/> - El apellido es un campo obligatorio";
        }

        if (string.IsNullOrEmpty(TxtNacimento.Text))
        {
            Label5.Text = "Lista de errores.";
            Label4.Text = Label4.Text + "<br/> - La fecha de nacimiento es un campo obligatorio";
            error = true;
        }
        if (string.IsNullOrEmpty(TxtEdad.Text))
        {
            Label5.Text = "Lista de errores.";
            Label4.Text = Label4.Text + "<br/> - La edad es un campo obligatorio";
            error = true;
        }
        if (string.IsNullOrEmpty(TxtLugardenac.Text))
        {
            Label5.Text = "Lista de errores.";
            Label4.Text = Label4.Text + "<br/> - El lugar de nacimiento es un campo obligatorio";
            error = true;
        }
        if (string.IsNullOrEmpty(TxtDireccion.Text))
        {
            Label5.Text = "Lista de errores.";
            Label4.Text = Label4.Text + "<br/> - La dirección es un campo obligatorio";
            error = true;
        }
        if (string.IsNullOrEmpty(TxtNacionalidad.Text))
        {
            Label5.Text = "Lista de errores.";
            Label4.Text = Label4.Text + "<br/> - La nacionalidad es un campo obligatorio";
            error = true;
        }
        if (string.IsNullOrEmpty(TxtTelCasa.Text))
        {
            Label5.Text = "Lista de errores.";
            Label4.Text = Label4.Text + "<br/> - El telefono de casa es un campo obligatorio";
            error = true;
        }
        else
        {
            try
            {
                int i = Convert.ToInt32(TxtTelCasa.Text);
            }
            catch (Exception)
            {
                Label5.Text = "Lista de errores.";
                Label4.Text = Label4.Text + "<br/> - El telefono de casa debe estar solo en numeros y sin espacios.";
                error = true;
            }
        }
        if (string.IsNullOrEmpty(TxtCel.Text))
        {
            TxtCel.Text = "0";
        }
        else
        {
            try
            {
                int i = Convert.ToInt32(TxtTelCasa.Text);
            }
            catch (Exception)
            {
                Label5.Text = "Lista de errores.";
                Label4.Text = Label4.Text + "<br/> - El celular debe estar solo en numeros y sin espacios.";
                error = true;
            }
        }
        if (DdlIngreso.Text== "")
        {
            Label5.Text = "Lista de errores.";
            Label4.Text = Label4.Text + "<br/> - El campo 'El alumno es de nuevo ingreso:' es obligatorio.";
            error = true;
        }
        else
        {
            if (DdlIngreso.Text == "Si" && string.IsNullOrEmpty(TxtInstproc.Text))
            {
                Label5.Text = "Lista de errores.";
                Label4.Text = Label4.Text + "<br/> - El instituto de procedencia es un campo obligatorio si el alumno es de nuevo ingreso.";
                error = true;
            }
            if (DdlIngreso.Text == "No" && string.IsNullOrEmpty(TxtGradodesde.Text))
            {
                Label5.Text = "Lista de errores.";
                Label4.Text = Label4.Text + "<br/> - El grado desde el que estudia aqui es un campo obligatorio si el alumno es de antiguo ingreso.";
                error = true;
            }
        }
        if (DdlParvularia.Text == "")
        {
            Label5.Text = "Lista de errores.";
            Label4.Text = Label4.Text + "<br/> - El campo 'Estudio parvularia:' es obligatorio.";
            error = true;
        }
        if (DdlHermanos.Text == "")
        {
            Label5.Text = "Lista de errores.";
            Label4.Text = Label4.Text + "<br/> - El campo '¿Tiene hermanos estudiando aqui?' es obligatorio.";
            error = true;
        }
        else
        {
            if (DdlHermanos.Text == "Si" && string.IsNullOrEmpty(TxtHermNum.Text))
            {
                Label5.Text = "Lista de errores.";
                Label4.Text = Label4.Text + "<br/> - Por favor defina el numero de hermanos que estudian aqui.";
                error = true;
            }
        }
        if (string.IsNullOrEmpty(RblStadCivil.Text))
        {
            Label5.Text = "Lista de errores.";
            Label4.Text = Label4.Text + "<br/> - Definir el estado civil de los padres es obligatorio.";
            error = true;
        }
        if (string.IsNullOrEmpty(RblVivecon.Text))
        {
            Label5.Text = "Lista de errores.";
            Label4.Text = Label4.Text + "<br/> - Definir con quien vive el alumno es obligatorio.";
            error = true;
        }
        if (DdlDiscp.Text=="")
        {
            Label5.Text = "Lista de errores.";
            Label4.Text = Label4.Text + "<br/> - Definir si alumno tiene alguna discapacidad es obligatorio.";
            error = true;
        }
        else
        {
            if (DdlDiscp.Text == "Si" && string.IsNullOrEmpty(TxtDisc.Text))
            {
                Label5.Text = "Lista de errores.";
                Label4.Text = Label4.Text + "<br/> - Definir la discapacidad del alumno (sí la posee) es obligatorio.";
                error = true;
            }
        }
        if (DdlAlumRep.Text=="")
        {
            Label5.Text = "Lista de errores.";
            Label4.Text = Label4.Text + "<br/> - Definir si el alumno repite grado es obligatorio.";
            error = true;
        }
        if (DdlAlumVacunas.Text=="")
        {
            Label5.Text = "Lista de errores.";
            Label4.Text = Label4.Text + "<br/> - Definir si alumno tiene sus vacunas completas es obligatorio.";
            error = true;
        }
        if (DdlSpecial.Text == "")
        {
            Label5.Text = "Lista de errores.";
            Label4.Text = Label4.Text + "<br/> - Definir si alumno el alumno recibe alguna educación especial es obligatorio.";
            error = true;
        }

        if (DdlTrabAlum.Text == "")
        {
            Label5.Text = "Lista de errores.";
            Label4.Text = Label4.Text + "<br/> - Definir si alumno tiene realiza un trabajo es obligatorio.";
            error = true;
        }
        else
        {
            if (DdlTrabAlum.Text == "Si" && string.IsNullOrEmpty(TxtTrabAlum.Text))
            {
                Label5.Text = "Lista de errores.";
                Label4.Text = Label4.Text + "<br/> - Definir el trabajo del alumno (si lo realiza) es obligatorio.";
                error = true;
            }
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
            
                if (error)
                {
                    BtnVer.CssClass = "btn btn-danger form-control";
                    BtnVer.Visible = true;
                Aceptar.Enabled = false;
            }
                else
                {
                Label5.Text = "Verificado";
                Label4.Text = "Matricula enviada sin errores espere la verificacion de la administración";
                    BtnVer.CssClass = "btn btn-primary form-control";
                    BtnVer.Visible = true;
                Aceptar.Enabled = true;
                }
            
            
            
        }
      
        

    }
}