using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

public partial class Account_grado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        builder.Server = "mysql5013.smarterasp.net";
        builder.UserID = "a131fe_bd";
        builder.Password = "prueba123";
        builder.Database = "db_a131fe_bd";
        MySqlConnection conn = new MySqlConnection(builder.ToString());
        conn.Open();
        MySqlCommand cmd = new MySqlCommand("SELECT * from grado", conn);
        DataTable dtDatos = new DataTable();
        MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, conn);
        da.Fill(dtDatos);
        GradosRegistradosGV.DataSource = dtDatos;
        GradosRegistradosGV.DataBind();
        conn.Close();

        try
        {
           
        }
        catch (Exception)
        {

        }

    }

    protected void Button3_Click(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
    }

    protected void DpdEducacion_SelectedIndexChanged(object sender, EventArgs e)
    {
        string tipoEducacion = DpdEducacion.SelectedItem.ToString();
        switch (tipoEducacion)
        {
            case "Basica":
                DpdGrado.Items.Clear();
                DpdGrado.Items.Insert(0,"");
                for (int i = 1; i <= 9; i++)
                {
                    DpdGrado.Items.Add(i.ToString());
                }

                DpdGrado.Enabled = true;
                break;
            case "Bachillerato":
                DpdGrado.Items.Clear();
                DpdGrado.Items.Add("1");
                DpdGrado.Items.Add("2");
                DpdGrado.Enabled = true;
                break;
        }

        AsignarNombre();

    }

    protected void DpdSeccion_SelectedIndexChanged(object sender, EventArgs e)
    {
        AsignarNombre();
        txtHorasClase.Enabled = true;
    }

    protected void DpdGrado_SelectedIndexChanged(object sender, EventArgs e)
    {
        AsignarNombre();
        DpdSeccion.Enabled = true;
        
    }

    public void AsignarNombre()
    {
        if (DpdEducacion.SelectedItem != null && DpdGrado.SelectedItem != null && DpdSeccion.SelectedItem != null)
        {
            if(DpdEducacion.SelectedItem.Text != "" && DpdGrado.SelectedItem.Text != "" && DpdSeccion.SelectedItem.Text != "")
            {
                string educacion = DpdEducacion.SelectedItem.Text;
                switch (educacion)
                {
                    case "Basica":

                        txtNombreAbreviado.Text = DpdGrado.SelectedItem.Text + "º Grado Sección " + DpdSeccion.SelectedItem.Text + " - " + DpdEducacion.SelectedItem.Text;

                        break;
                    case "Bachillerato":
                        txtNombreAbreviado.Text = DpdGrado.SelectedItem.Text + "º Año Sección " + DpdSeccion.SelectedItem.Text + " - " + DpdEducacion.SelectedItem.Text;

                        break;
                    case "":
                        txtNombreAbreviado.Text = "";
                        break;
                }
            }
            else
            {
                txtNombreAbreviado.Text = "";
            }
        }
    }

    protected void BtnRegistrar_Click(object sender, EventArgs e)
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
        consulta = "SELECT * FROM grado WHERE grado='" + DpdGrado.SelectedItem.Text + "' AND seccion='"+DpdSeccion.SelectedItem.Text+"' AND tipo_grado='"+DpdEducacion.SelectedItem.Text+"'; SELECT ID_DOCENTE FROM docentes WHERE nombre_completo_doc='"+DpdOrientador.SelectedItem.Text+"'";
        query.CommandText = consulta;
        MySqlDataReader leer = query.ExecuteReader();


        bool validar = leer.HasRows;


        if (validar)
        {
            leer.Read();
            if (leer["tipo_grado"].ToString() == "Bachillerato")
            {
                string script = "alert('¡El " + DpdGrado.SelectedItem.Text + "º año de Bachillerato Sección " + leer["seccion"].ToString() + " ya está registrado!');";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Información", script, true);
            }
            else
            {
                string script = "alert('¡El " + DpdGrado.SelectedItem.Text + "º Grado Sección " + leer["seccion"].ToString() + " ya está registrado!');";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Información", script, true);
            }
        }
        else
        {
            if (txtHorasClase.Text == ""|| DpdEducacion.SelectedIndex == 0 || DpdGrado.SelectedIndex == 0|| DpdSeccion.SelectedIndex == 0||DpdOrientador.SelectedIndex==0)
            {

                string script = "alert('¡No puede dejar campos vacíos!');";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Alerta", script, true);

            }
            else
            {
                string sql = "INSERT INTO grado (horas_clase, grado, seccion, nombre_grado, id_orientador, tipo_grado) values ('" + txtHorasClase.Text + "','" + DpdGrado.SelectedItem.Text + "', '" + DpdSeccion.SelectedItem.Text+ "','" + txtNombreAbreviado.Text + "','" + txtPrimerApellido.Text + "','" + txtSegundoApellido.Text + "','" + txtEspecialidad.Text + "','" + txtTelefono.Text + "','" + txtDireccion.Text + "', '" + DpdEducacion.SelectedItem.Text + "', '" + DpdTurno.SelectedItem.Text + "');";
                conexion con2 = new conexion();
                con2.insert(sql);

                string script = "alert('¡El/la docente se registró exitosamente!');";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Información", script, true);

                sql = "INSERT INTO usuarios (ID_USUARIO, cod_user, contra, nombre_user, tipo_user, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido) values ('" + txtNIP.Text + "','" + txtNIP.Text + "','" + txtNIP.Text + "','" + txtPrimerNombre.Text + " " + txtPrimerApellido.Text + "','Docente','" + txtPrimerNombre.Text + "','" + txtSegundoNombre.Text + "','" + txtPrimerApellido.Text + "','" + txtSegundoApellido.Text + "');";
                con2.insert(sql);
                borrar();
            }
        }

    }
        catch (Exception ex)
        {
            string script2 = "alert('¡El/la docente NO se registró!');";
    ScriptManager.RegisterStartupScript(this, typeof(Page), "Información", script2, true);
        }
    }

    protected void Button4_Click(object sender, EventArgs e)
    {

    }
}