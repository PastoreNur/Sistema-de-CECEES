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
        
            
       

        cargarGrid();
        Label.Visible = false;
        Label1.Visible = false;
        Label2.Visible = false;
        Label3.Visible = false;
        Label4.Visible = false;
        Label5.Visible = false;
        Label6.Visible = false;
        txtHorasClase.Visible = false;
        txtNombreAbreviado.Visible = false;
        DpdEducacion.Visible = false;
        DpdGrado.Visible = false;
        DpdOrientador.Visible = false;
        DpdSeccion.Visible = false;
        BtnRegistrar.Visible = false;
        BtnEliminar.Visible = false;

        try
        {
            if (Request.Params["Action"] != null)
            {
                string denied = Request.Params["Action"];

                if (denied == "registrados")
                {
                    lblHorasClase.Visible = false;
                    txtHorasClasesEdit.Visible = false;
                    Label.Visible = false;
                    Label1.Visible = false;
                    Label2.Visible = false;
                    Label3.Visible = false;
                    Label4.Visible = false;
                    Label5.Visible = false;
                    Label6.Visible = false;
                    txtHorasClase.Visible = false;
                    txtNombreAbreviado.Visible = false;
                    DpdEducacion.Visible = false;
                    DpdGrado.Visible = false;
                    DpdOrientador.Visible = false;
                    DpdSeccion.Visible = false;

                }
                else if (denied == "registrar")
                {
                    GradosRegistradosGV.Visible = false;
                    lblHorasClase.Visible = false;
                    txtHorasClasesEdit.Visible = false;
                    Label.Visible = true;
                    Label1.Visible = true;
                    Label2.Visible = true;
                    Label3.Visible = true;
                    Label4.Visible = true;
                    Label5.Visible = true;
                    Label6.Visible = true;
                    txtHorasClase.Visible = true;
                    txtNombreAbreviado.Visible = true;
                    DpdEducacion.Visible = true;
                    DpdGrado.Visible = true;
                    DpdOrientador.Visible = true;
                    DpdSeccion.Visible = true;
                    BtnRegistrar.Visible = true;
                    BtnEliminar.Visible = false;
                    
                }
                else if (denied == "editar")
                {
                    
                    GradosRegistradosGV.Visible = false;
                    Label.Visible = true;
                    Label1.Visible = true;
                    Label2.Visible = true;
                    Label3.Visible = false;
                    Label4.Visible = true;
                    Label5.Visible = true;
                    Label6.Visible = false;
                    DpdEducacion.Visible = true;
                    DpdGrado.Visible = false;
                    DpdOrientador.Visible = true;
                    DpdSeccion.Visible = false;
                    DpdNomGrado.Visible = true;
                    txtGrado.Visible = true;
                    txtSeccion.Visible = true;
                    txtHorasClase.Visible = false;
                    lblNomG.Visible = true;
                    BtnEliminar.Visible = true;
                    BtnBuscar.Visible = true;
                  
                    cargarDocentes();

                    if (!IsPostBack)
                    {
                        try
                        {
                            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                            builder.Server = "mysql5013.smarterasp.net";
                            builder.UserID = "a131fe_bd";
                            builder.Password = "prueba123";
                            builder.Database = "db_a131fe_bd";
                            MySqlConnection conn = new MySqlConnection(builder.ToString());
                            conn.Open();
                            MySqlCommand OrdenSqlSelect = new MySqlCommand("SELECT * FROM grado", conn);
                            MySqlDataAdapter da = new MySqlDataAdapter(OrdenSqlSelect.CommandText, conn);
                            DataSet ds = new DataSet();
                            da.Fill(ds);

                            this.DpdNomGrado.DataSource = ds;
                            this.DpdNomGrado.DataValueField = "nombre_grado";
                            this.DpdNomGrado.DataTextField = "nombre_grado";
                            this.DpdNomGrado.DataBind();

                            conn.Close();
                        }
                        catch (Exception)
                        {

                        }
                    }
                
                    
                }
                else
                {
                    
                    GradosRegistradosGV.Visible = true;
                }
            }
            
        }
        catch (Exception ex)
        {

        }
    }

   public void cargarGrid()
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

    }

    protected void DpdEducacion_SelectedIndexChanged(object sender, EventArgs e)
    {
        string tipoEducacion = DpdEducacion.SelectedItem.ToString();
        switch (tipoEducacion)
        {
            case "Basica":
                DpdGrado.Items.Clear();
                DpdGrado.Items.Insert(0,"");
                for (int i = 1; i <= 5; i++)
                {
                    DpdGrado.Items.Add(i.ToString());
                }
                cargarDocentes();
                DpdGrado.Enabled = true;
                break;
            case "Bachillerato":
                DpdGrado.Items.Clear();
                DpdGrado.Items.Insert(0, "");
                DpdGrado.Items.Add("1");
                DpdGrado.Items.Add("2");
                DpdGrado.Enabled = true;
                cargarDocentes();
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
            consulta = "SELECT * FROM grado WHERE grado='" + DpdGrado.SelectedItem.Text + "' AND seccion='" + DpdSeccion.SelectedItem.Text + "' AND tipo_grado='" + DpdEducacion.SelectedItem.Text + "'";
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

                if (txtHorasClase.Text == "" || DpdEducacion.SelectedIndex == 0 || DpdGrado.SelectedIndex == 0 || DpdSeccion.SelectedIndex == 0 || DpdOrientador.SelectedIndex == 0)
                {

                    string script = "alert('¡No puede dejar campos vacíos!');";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Alerta", script, true);

                }
                else
                {


                    string sql = "INSERT INTO grado (horas_clase, grado, seccion, nombre_grado, id_orientador, tipo_grado) values ('" + txtHorasClase.Text + "','" + DpdGrado.SelectedItem.Text + "', '" + DpdSeccion.SelectedItem.Text + "','" + txtNombreAbreviado.Text + "','" + iddocente() + "','" + DpdEducacion.SelectedItem.Text + "');";
                    conexion con2 = new conexion();
                    con2.insert(sql);

                    string script = "alert('¡El grado se registró exitosamente!');";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Información", script, true);



                }
            }

        }
        catch (Exception ex)
        {
            string script2 = "alert('¡El grado NO se registró!');";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Información", script2, true);
        }
    }

    protected void Button4_Click(object sender, EventArgs e)
    {

    }
    string tipo;
    public void cargarDocentes()
    {
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        builder.Server = "mysql5013.smarterasp.net";
        builder.UserID = "a131fe_bd";
        builder.Password = "prueba123";
        builder.Database = "db_a131fe_bd";
        MySqlConnection conn = new MySqlConnection(builder.ToString());
        conn.Open();
        
        if (DpdEducacion.SelectedValue == "Bachillerato")
        {
            tipo = "Bachillerato";
        }
        else if(DpdEducacion.SelectedValue == "Basica")
        {
            tipo = "Basica";
        }
        MySqlCommand OrdenSqlSelect = new MySqlCommand("SELECT nombre_completo_doc FROM docentes Where Tipo='"+tipo+"' OR Tipo='Basica y Bachillerato'", conn);
        MySqlDataAdapter da = new MySqlDataAdapter(OrdenSqlSelect.CommandText, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        this.DpdOrientador.DataSource = ds;
        this.DpdOrientador.DataValueField = "nombre_completo_doc";
        this.DpdOrientador.DataTextField = "nombre_completo_doc";
        this.DpdOrientador.DataBind();
        this.DpdOrientador.Items.Insert(0, new ListItem("---Elija una opción---", "0"));

        conn.Close();
    }

    public string iddocente()
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
        string query = "SELECT* FROM docentes WHERE nombre_completo_doc='"+DpdOrientador.SelectedItem.Text+"'";
        cmd.CommandText = query;
        //SqlCommand consulta = new SqlCommand(query,con);
        MySqlDataReader leer = cmd.ExecuteReader();
        leer.Read();

        string Docente = leer["ID_DOCENTE"].ToString();

        return Docente;
    }


    protected void BtnGRegistrados_Click(object sender, EventArgs e)
    {
        Response.Redirect("grado.aspx?Action=registrados");
    }

    protected void BtnGRegistrar_Click(object sender, EventArgs e)
    {
        Response.Redirect("grado.aspx?Action=registrar");
    }

    protected void BtnEditarG_Click(object sender, EventArgs e)
    {

        
        Response.Redirect("grado.aspx?Action=editar");

    }

    protected void BtnBuscar_Click(object sender, EventArgs e)
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
        string query = "SELECT * FROM grado WHERE nombre_grado='" + DpdNomGrado.SelectedItem.Text + "'";
        cmd.CommandText = query;
        //SqlCommand consulta = new SqlCommand(query,con);
        MySqlDataReader leer = cmd.ExecuteReader();

        if (leer.Read() == true)
        {
            txtHorasClasesEdit.Text = leer["horas_clase"].ToString();

            string selected = leer["tipo_grado"].ToString();
            switch (selected)
            {
                case "Bachillerato":
                    DpdEducacion.SelectedValue = "Bachillerato";
                    break;
                case "Basica":
                    DpdEducacion.SelectedValue = "Basica";
                    break;

            }

            try
            {
                txtGrado.Text = leer["grado"].ToString();
                txtSeccion.Text = leer["seccion"].ToString();
                string idOrientador = leer["id_orientador"].ToString();
                leer.Close();
                string consulta = "Select * from docentes Where ID_DOCENTE='" + idOrientador + "'";
                MySqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandText = consulta;
                MySqlDataReader dt = cmd2.ExecuteReader();
                dt.Read();
                DpdOrientador.SelectedValue = dt["nombre_completo_doc"].ToString();
                dt.Close();
            }
            catch (Exception)
            {

            }
           
            
            


        }

    }



    


}

    


