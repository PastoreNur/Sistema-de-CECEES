using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

public partial class Verificacioncupo : System.Web.UI.Page
{
    string textoddl;

    

    protected void Page_Load(object sender, EventArgs e)
    {


        try
        {
            string sesion = Session["user"].ToString();
        }
        catch (Exception x)
        {
            Response.Redirect("login.aspx?Active=off");
        }

        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        builder.Server = "mysql5013.smarterasp.net";
        builder.UserID = "a131fe_bd";
        builder.Password = "prueba123";
        builder.Database = "db_a131fe_bd";
        MySqlConnection con = new MySqlConnection(builder.ToString());

        if (!IsPostBack)
        {

            try
            {
                con.Open();
                MySqlCommand OrdenSqlSelect = new MySqlCommand("SELECT NUMERO_SEC FROM secciones", con );
                MySqlDataAdapter da = new MySqlDataAdapter(OrdenSqlSelect.CommandText, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                this.DropDownList1.DataSource = ds;
                this.DropDownList1.DataValueField = "NUMERO_SEC";
                this.DropDownList1.DataTextField = "NUMERO_SEC";
                this.DropDownList1.DataBind();
                this.DropDownList1.Items.Insert(0,new ListItem("---Elija una opción---","0"));

                con.Close();
            }
            catch (Exception)
            {

                throw;
            }

        }
        else
        {
           
            
        }

        
    }


    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int comparacion;

        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        builder.Server = "mysql5013.smarterasp.net";
        builder.UserID = "a131fe_bd";
        builder.Password = "prueba123";
        builder.Database = "db_a131fe_bd";
        MySqlConnection con = new MySqlConnection(builder.ToString());



        if (DropDownList1.Text == "---Elija una opción---")
        {

            string script = "alert('Elija una opción por favor')";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Cupo", script, true);


        }
        else
        {

            BtnSigCupo.Enabled = true;



            try
            {
                con.Open();

                    textoddl = DropDownList1.Text;

                if (textoddl == "---Elija una opción---")
                {
                    string script = "alert('Elija una opción por favor')";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Cupo", script, true);
                }
                else
                {

                    string query = "Select CUPO_SEC from secciones where NUMERO_SEC='" + textoddl + "';";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        MySqlDataReader leer = cmd.ExecuteReader();


                        leer.Read();

                        try
                        {
                            comparacion = Convert.ToInt32(leer["CUPO_SEC"]);
                            if (comparacion == 0)
                            {
                                Label1.Text = "Lo sentimos cupo agotado para la seccion seleccionada";
                                BtnContinuar.Enabled = false;

                            }
                            else
                            {
                                Label1.Text = "El cupo actual es de " + Convert.ToString(comparacion);
                                BtnContinuar.Enabled = true;
                            }

                        }
                        catch (Exception)
                        {

                            Label1.Text = "¡Seleccione una seccion de la lista!";
                            BtnContinuar.Enabled = false;

                        }


                    }



                }
            }
            catch (Exception)
            {

                Label1.Text = "¡Error vuelva a intentarlo mas tarde!";
            }
            
        }
        }


    protected void BtnSigCupo_Click(object sender, EventArgs e)
    {
        

        
    }

    protected void BtnContinuar_Click(object sender, EventArgs e)
    {
        Session.Add("Grado", DropDownList1.Text);
        Server.Transfer("Hojadecompromiso.aspx");
        Response.Redirect("/Hojadecompromiso.aspx");
    }
}