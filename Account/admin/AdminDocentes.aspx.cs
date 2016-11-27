using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;

public partial class Account_admin_AdminDocente : System.Web.UI.Page
{

    bool BuscarActive;

    protected void Page_Load(object sender, EventArgs e)
    {

            txtPrimerNombre.Enabled = false;
            txtPrimerApellido.Enabled = false;
            txtSegundoNombre.Enabled = false;
            txtSegundoApellido.Enabled = false;
            txtEspecialidad.Enabled = false;
            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;


        try
        {
            if (Request.Params["Action"] != null)
            {
                string denied = Request.Params["Action"];

                if (denied == "registrar")
                {
                    txtPrimerNombre.Enabled = true;
                    txtPrimerApellido.Enabled = true;
                    txtSegundoNombre.Enabled = true;
                    txtSegundoApellido.Enabled = true;
                    txtEspecialidad.Enabled = true;
                    txtDireccion.Enabled = true;
                    txtTelefono.Enabled = true;

                    LblNombrePanel.Text = "Registrar Docente";
                    BtnRegistrar.Visible = true;
                    BtnBuscar.Visible = false;
                    BtnActualizar.Visible = false;
                    BtnEliminar.Visible = false;
                }
                else if (denied == "buscar")
                {
                    LblNombrePanel.Text = "Buscar Docente";
                    BtnRegistrar.Visible = false;
                    BtnBuscar.Visible = true;
                    BtnActualizar.Visible = true;
                    BtnEliminar.Visible = true;

                    

                }
            }
           
        }
        catch (Exception ex)
        {

        }

    }

    protected void guardar_Click(object sender, EventArgs e)
    {
        
    }

    protected void BtnRegistrar_Click(object sender, EventArgs e)
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
            consulta = "SELECT * FROM docentes WHERE NIP='" + txtNIP.Text+"'";
            query.CommandText = consulta;
            MySqlDataReader leer = query.ExecuteReader();

            
            bool validar = leer.HasRows;


            if (validar)
            {
                leer.Read();
                string script = "alert('¡El Docente " + leer["primer_nombre"].ToString() + " "+leer["primer_apellido"].ToString() + " ya está registrado!');";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Información", script, true);
            }
            else
            {
                if (txtNIP.Text == "" || txtPrimerNombre.Text == "" || txtSegundoNombre.Text == "" ||
               txtPrimerApellido.Text == "" || txtSegundoApellido.Text == "" || txtEspecialidad.Text == "" ||
               txtTelefono.Text == "" || txtDireccion.Text == "")
                {

                    string script = "alert('¡No puede dejar campos vacíos!');";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Alerta", script, true);

                }
                else
                {
                    string sql = "INSERT INTO docentes (ID_DOCENTE, NIP, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, especialidad, Telefono, direccion) values ('"+txtNIP.Text+ "','" + txtNIP.Text + "', '"+txtPrimerNombre.Text+"','"+txtSegundoNombre.Text+"','"+txtPrimerApellido.Text+"','"+txtSegundoApellido.Text+"','"+txtEspecialidad.Text+"','"+txtTelefono.Text+"','"+txtDireccion.Text+"');";
                    conexion con2 = new conexion();
                    con2.insert(sql);

                    string script = "alert('¡El docente se registró exitosamente!');";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Información", script, true);
                    borrar();
                }
            }
           
        }
        catch (Exception ex)
        {
            string script2 = "alert('¡El docente NO se registró!');";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Información", script2, true);
        }
    }

    public void borrar()
    {
        txtNIP.Text = "";
        txtPrimerNombre.Text = "";
        txtSegundoNombre.Text = "";
        txtPrimerApellido.Text = "";
        txtSegundoApellido.Text = "";
        txtEspecialidad.Text = "";
        txtTelefono.Text = "";
        txtDireccion.Text = "";
    }



    protected void BtnRegistrarDocente_Click(object sender, EventArgs e)
    {
        BuscarActive = true;
        Response.Redirect("AdminDocentes.aspx?Action=registrar");
        
    }

    protected void BtnBuscarDocente_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminDocentes.aspx?Action=buscar");

    }

    protected void BtnBuscar_Click(object sender, EventArgs e)
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
            string query = "SELECT * FROM docentes WHERE NIP='" + txtNIP.Text + "'";
            cmd.CommandText = query;
            //SqlCommand consulta = new SqlCommand(query,con);
            MySqlDataReader leer = cmd.ExecuteReader();

            if (leer.Read() == true)
            {
                txtPrimerNombre.Text = leer["primer_nombre"].ToString();
                txtSegundoNombre.Text = leer["segundo_nombre"].ToString();
                txtPrimerApellido.Text = leer["primer_apellido"].ToString();
                txtSegundoApellido.Text = leer["segundo_apellido"].ToString();
                txtEspecialidad.Text = leer["especialidad"].ToString();
                txtTelefono.Text = leer["Telefono"].ToString();
                txtDireccion.Text = leer["direccion"].ToString();

                BuscarActive = true;

                txtPrimerNombre.Enabled = true;
                txtPrimerApellido.Enabled = true;
                txtSegundoNombre.Enabled = true;
                txtSegundoApellido.Enabled = true;
                txtEspecialidad.Enabled = true;
                txtDireccion.Enabled = true;
                txtTelefono.Enabled = true;

            }
            else
            {
                string script = "alert('¡El docente " + txtNIP.Text + " no existe!');";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Información", script, true);
            }

            

        }
        catch (Exception)
        {

        }


    }

    protected void BtnActualizar_Click(object sender, EventArgs e)
    {

        if (txtNIP.Text == "" || txtPrimerNombre.Text == "" || txtSegundoNombre.Text == "" ||
               txtPrimerApellido.Text == "" || txtSegundoApellido.Text == "" || txtEspecialidad.Text == "" ||
               txtTelefono.Text == "" || txtDireccion.Text == "")
        {
            string script = "alert('¡No puede dejar ningún campo vacío!');";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Información", script, true);
        }
        else
        {
            conexion con = new conexion();
            string query = "NIP='"+txtNIP.Text+"',primer_nombre='"+txtPrimerNombre.Text+"', segundo_nombre='"+txtSegundoNombre.Text+"', primer_apellido='"+txtPrimerApellido.Text+"', segundo_apellido='"+txtSegundoApellido.Text+"', especialidad='"+txtEspecialidad.Text+"', Telefono='"+txtTelefono.Text+"', direccion='"+txtDireccion.Text+"'";

            string nombre = txtPrimerNombre.Text;
            string apellido = txtSegundoApellido.Text;

            con.actualizar("docentes", query, "NIP='" + txtNIP.Text + "'");

            string script = "alert('¡El/la docente "+nombre +" "+ apellido+" se actualizó correctamente!');";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Información", script, true);
            borrar();
            nombre = "";
            apellido = "";
        }


    }

    protected void BtnEliminar_Click(object sender, EventArgs e)
    {
        conexion con = new conexion();
        string query = "DELETE docentes FROM docentes WHERE NIP='" + txtNIP.Text + "'";
        con.eliminar(query);
        string nombre = txtPrimerNombre.Text;
        string apellido = txtSegundoApellido.Text;
        borrar();

        string script = "alert('¡El Docente "+nombre+" "+apellido+" se eliminó correctamente!');";
        ScriptManager.RegisterStartupScript(this, typeof(Page), "Información", script, true);
        nombre = "";
        apellido = "";
    }
}