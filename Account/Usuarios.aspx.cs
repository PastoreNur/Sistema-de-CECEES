using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Account_Usuarios : System.Web.UI.Page
{

    public bool SesionActive;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["TypeUser"].ToString() == "VIP")
        {
            txtTipoUser.Items.Add("VIP");
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

        try
        {
            
            string type = Session["TypeUser"].ToString();

            if(type != "VIP" )
            {
                Response.Redirect("../default.aspx?Active=off");
            }
            
        }
        catch (Exception x)
        {   
            Response.Redirect("../login.aspx?Active=off");
        }
    }

    protected void BtnReturnPanelAdmin_Click(object sender, EventArgs e)
    {
        string tipouser = Session["TypeUser"].ToString();
        switch (tipouser)
        {
            case "VIP":
                Response.Redirect("VIP.aspx");
                break;
            case "Admin":
                Response.Redirect("admin.aspx");
                break;
            case "Secretaria":
                Response.Redirect("secretaria.aspx");
                break;
            case "Tesorero":
                Response.Redirect("tesorero.aspx");
                break;
            case "Alumno":
                Response.Redirect("alumno.aspx");
                break;
            case "Docente":
                Response.Redirect("docente.aspx");
                break;
            case "Encargado":
                Response.Redirect("encargado.aspx");
                break;
        }
    }

    public void borrar()
    {
        txtCodUser.Text = "";
        txtEmail.Text = "";
        txtFirstLastName.Text = "";
        txtFirstName.Text = "";
        txtPassword.Text = "";
        txtSecondLastName.Text = "";
        txtSecondName.Text = "";
        txtTipoUser.Text = "";
        
    }

    protected void guardar_Click(object sender, EventArgs e)
    {
      
        
        try
        {
            string consulta;
            SqlCommand query;
            SqlConnection con = new SqlConnection("Data Source=sql5019.smarterasp.net;Persist Security Info=True;User ID=DB_A132F9_SistemaCecees_admin;Password=sistema1234");
            con.Open();
            consulta = "SELECT cod_user FROM usuarios WHERE cod_user='"+txtCodUser.Text+"'";
            query = new SqlCommand(consulta, con);
            SqlDataReader leer = query.ExecuteReader();
            bool validar = leer.HasRows;

           
            if (validar)
            {
                    string script = "alert('¡El usuario "+txtCodUser.Text+" ya existe!');";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Información", script, true);
            }
            else
            {
               
                string sql = "INSERT INTO usuarios values ('" + txtCodUser.Text + "','" + txtPassword.Text + "','" + txtFirstName.Text + " " + txtFirstLastName.Text +
                "','" + txtEmail.Text + "', '" + txtTipoUser.Text + "','" + txtFirstName.Text + "', '" + txtSecondName.Text + "', '" + txtFirstLastName.Text +
                "', '" + txtSecondLastName.Text + "');";

                conexion con2 = new conexion();
                con2.insert(sql);
                
                string script = "alert('¡El usuario se registró exitosamente!');";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Información", script, true);
                borrar();
            }
            
        }
        catch(Exception ex)
        {
            string script = "alert('¡ERROR!');";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Información", script, true);
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
        catch (Exception ex)
        {
            string script = "alert('Error');";
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

    protected void BtnUsuarios_Click(object sender, EventArgs e)
    {
        Response.Redirect("usuarios.aspx");
    }
}