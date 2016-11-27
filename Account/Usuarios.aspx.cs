using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class Account_Usuarios : System.Web.UI.Page
{


    public bool SesionActive;
    protected void Page_Load(object sender, EventArgs e)
    {

      
        try
        {
            if (Request.Params["Action"] != null)
            {
                string denied = Request.Params["Action"];

                if (denied == "guardar")
                {
                    eliminar.Visible = false;
                    eliminar.Enabled = false;
                    buscar.Enabled = false;
                    buscar.Visible = false;
                    actualizar.Enabled = false;
                    actualizar.Visible = false;

                    txtTipoUser.Enabled = true;
                    txtTipoUser.Visible = true;
                    txtTipoUserbx.Enabled = false;
                    txtTipoUserbx.Visible = false;
                    Label11.Visible = false;
                    Label4.Visible = true;
                    txtNombreUsuario.Enabled = false;
                    txtNombreUsuario.Visible = false;
                    Label10.Visible = false;
                    txtPassword.Enabled = true;
                    txtPassword.Visible = true;

                }
                else if (denied == "buscar")
                {
                    Label12.Text = "Buscar Usuario";
                    guardar.Enabled = false;
                    guardar.Visible = false;
                    Label3.Visible = false;
                    txtTipoUser.Enabled = false;
                    txtTipoUser.Visible = false;
                    txtTipoUserbx.Enabled = true;
                    txtTipoUserbx.Visible = true;
                    Label11.Visible = true;
                    Label4.Visible = false;
                    txtNombreUsuario.Enabled = true;
                    txtNombreUsuario.Visible = true;
                    Label10.Visible = true;
                    txtPassword.Enabled = false;
                    txtPassword.Visible = false;
                }
            }
            else
            {
                eliminar.Visible = false;
                eliminar.Enabled = false;
                buscar.Enabled = false;
                buscar.Visible = false;
                actualizar.Enabled = false;
                actualizar.Visible = false;

            }
        }
        catch (Exception ex)
        {

        }

        BtnUsuarios.Visible = false;

        try
        {
            if (Session["TypeUser"].ToString() == "VIP")
            {
                txtTipoUser.Items.Add("VIP");
            }

            if (Session["TypeUser"].ToString() == "Admin")
            {
                txtTipoUser.Items.Remove("VIP");
                txtTipoUser.Items.Remove("Admin");

            }
        }catch(Exception es)
        {

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

            if(type == "Secretaria" || type == "Tesorero" || type == "Docente" || type == "Encargado" || type == "Alumno")
            {
                Response.Redirect("../default.aspx?Denegate=on");
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

    public void borrar(bool guardarAcc)
    {
        txtCodUser.Text = "";
        txtEmail.Text = "";
        txtFirstLastName.Text = "";
        txtFirstName.Text = "";
        txtPassword.Text = "";
        txtSecondLastName.Text = "";
        txtSecondName.Text = "";
        txtNombreUsuario.Text = "";
        if (guardarAcc)
        {
            txtTipoUser.Text = "Admin";
        }

    }

    protected void guardar_Click(object sender, EventArgs e)
    {
      
        
        try
        {
            string consulta;

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "mysql5013.smarterasp.net";
            builder.UserID = "a131fe_bd";
            builder.Password = "prueba123";
            builder.Database = "db_a131fe_bd";
            MySqlConnection con = new MySqlConnection(builder.ToString());
            MySqlCommand query = con.CreateCommand();

            con.Open();
            consulta = "SELECT cod_user FROM usuarios WHERE cod_user='" + txtCodUser.Text + "'";
            query.CommandText = consulta;
            MySqlDataReader leer = query.ExecuteReader();

            //SqlCommand query;
            //SqlConnection con = new SqlConnection("Data Source=sql5019.smarterasp.net;Persist Security Info=True;User ID=DB_A132F9_SistemaCecees_admin;Password=sistema1234");
           
            //query = new SqlCommand(consulta, con);
            //SqlDataReader leer = query.ExecuteReader();
            bool validar = leer.HasRows;

           
            if (validar)
            {
                    string script = "alert('¡El usuario "+txtCodUser.Text+" ya existe!');";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Información", script, true);
            }
            else
            {

                if (txtCodUser.Text == "" || txtEmail.Text == "" || txtFirstLastName.Text == "" || txtFirstName.Text == ""
            || txtSecondLastName.Text == "" || txtSecondName.Text == "" )
                {
                    string script2 = "alert('¡No puede dejar ningún campo vacío!');";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Información", script2, true);
                }
                else
                {
                    string sql = "INSERT INTO usuarios (ID_USUARIO, cod_user, contra, nombre_user, correo, tipo_user, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido) values ('"+txtCodUser.Text+"','" + txtCodUser.Text + "','" + txtPassword.Text + "','" + txtFirstName.Text + " " + txtFirstLastName.Text +
                "','" + txtEmail.Text + "', '" + txtTipoUser.Text + "','" + txtFirstName.Text + "', '" + txtSecondName.Text + "', '" + txtFirstLastName.Text +
                "', '" + txtSecondLastName.Text + "');";

                    conexion con2 = new conexion();
                    con2.insert(sql);

                    string script = "alert('¡El usuario se registró exitosamente!');";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Información", script, true);
                    bool guardarAcc = true;
                    borrar(guardarAcc);
                }

                
            }


            txtTipoUser.Items.Remove("VIP");
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

    protected void buscar_Click(object sender, EventArgs e)
    {

        try
        {

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "mysql5013.smarterasp.net";
            builder.UserID = "a131fe_bd";
            builder.Password = "prueba123";
            builder.Database = "db_a131fe_bd";
            MySqlConnection con = new MySqlConnection(builder.ToString());
            MySqlCommand cmd = con.CreateCommand();

            // SqlConnection con = new SqlConnection("Data Source=sql5019.smarterasp.net;Persist Security Info=True;User ID=DB_A132F9_SistemaCecees_admin;Password=sistema1234");
            con.Open();
            string query = "SELECT * FROM usuarios WHERE cod_user='" + txtCodUser.Text + "'";
            cmd.CommandText = query;
            //SqlCommand consulta = new SqlCommand(query,con);
            MySqlDataReader leer = cmd.ExecuteReader();

            if (leer.Read() == true)
            {
                txtFirstName.Text = leer["primer_nombre"].ToString();
                txtSecondName.Text = leer["segundo_nombre"].ToString();
                txtFirstLastName.Text = leer["primer_apellido"].ToString();
                txtSecondLastName.Text = leer["segundo_apellido"].ToString();
                txtEmail.Text = leer["correo"].ToString();
                Label3.Visible = false;
                txtTipoUser.Enabled = false;
                txtTipoUser.Visible = false;
                txtTipoUserbx.Text = leer["tipo_user"].ToString();
                txtTipoUserbx.Enabled = true;
                txtTipoUserbx.Visible = true;
                Label11.Visible = true;
                txtNombreUsuario.Text = leer["nombre_user"].ToString();
                Label4.Visible = false;
                txtNombreUsuario.Enabled = true;
                txtNombreUsuario.Visible = true;
                Label10.Visible = true;
                txtPassword.Enabled = false;
                txtPassword.Visible = false;
            }
            else
            {
                string script = "alert('¡El usuario " + txtCodUser.Text + " no existe!');";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Información", script, true);
            }

            txtTipoUser.Items.Remove("VIP");

        }
        catch (Exception)
        {
            
        }
    }

   

    protected void actualizar_Click(object sender, EventArgs e)
    {
        if (txtCodUser.Text == "" || txtEmail.Text=="" || txtFirstLastName.Text == ""|| txtFirstName.Text==""
            || txtSecondLastName.Text == ""|| txtSecondName.Text==""||
            txtTipoUserbx.Text == ""|| txtNombreUsuario.Text=="" )
        {
            string script = "alert('¡No puede dejar ningún campo vacío!');";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Información", script, true);
        }
        else
        {
            conexion con = new conexion();
            string query = "nombre_user='" + txtNombreUsuario.Text + "',correo='" + txtEmail.Text +
                "',tipo_user='" + txtTipoUserbx.Text + "',primer_nombre='" + txtFirstName.Text +
                "',segundo_nombre='" + txtSecondName.Text + "',primer_apellido='" + txtFirstLastName.Text +
                    "', segundo_apellido='" + txtSecondLastName.Text + "'";

            con.actualizar("usuarios", query, "cod_user='" + txtCodUser.Text + "'");

            string script = "alert('¡El usuario se actualizó correctamente!');";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Información", script, true);

            bool guardarAcc = false;
            borrar(guardarAcc);
        }

        txtTipoUser.Items.Remove("VIP");

    }

    protected void eliminar_Click(object sender, EventArgs e)
    {
        conexion con = new conexion();
        string query = "DELETE usuarios FROM usuarios WHERE cod_user='"+txtCodUser.Text+"'";
        con.eliminar(query);
        bool guardarAcc = true;
        borrar(guardarAcc);
        txtTipoUser.Items.Remove("VIP");
        txtCodUser.Text = "";
        txtTipoUserbx.Text = "";

        string script = "alert('¡El usuario se eliminó correctamente!');";
        ScriptManager.RegisterStartupScript(this, typeof(Page), "Información", script, true);
    }

    protected void BtnGuardarUser_Click(object sender, EventArgs e)
    {
       
        Response.Redirect("usuarios.aspx?Action=guardar");
    }

    protected void BtnBuscar_Click(object sender, EventArgs e)
    {
       
        Response.Redirect("usuarios.aspx?Action=buscar");
    }

   

   
}