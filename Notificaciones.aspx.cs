using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class Notificaciones : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string sql = "Select * from usuariosmat where NIE='" + Session["NIE"].ToString() + "';";

       
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        builder.Server = "mysql5013.smarterasp.net";
        builder.UserID = "a131fe_bd";
        builder.Password = "prueba123";
        builder.Database = "db_a131fe_bd";
        MySqlConnection con = new MySqlConnection(builder.ToString());
        MySqlCommand cmd = con.CreateCommand();
        cmd.CommandText = sql;
        MySqlDataReader rdr = cmd.ExecuteReader();
        rdr.Read();
        string COM1 = rdr["COM1"].ToString();
        string COM2 = rdr["COM2"].ToString();
        string COM3 = rdr["COM3"].ToString();
        string COM4 = rdr["COM4"].ToString();
        string COM5 = rdr["COM5"].ToString();
        string COM6 = rdr["COM6"].ToString();
        string COM7 = rdr["COM7"].ToString();
        string COM8 = rdr["COM8"].ToString();
        string COM9 = rdr["COM9"].ToString();
        string COM10 = rdr["COM10"].ToString();
        string COM11 = rdr["COM11"].ToString();
        string COM12 = rdr["COM12"].ToString();
        string COM13 = rdr["COM13"].ToString();
        string COM14 = rdr["COM14"].ToString();
        string COM15 = rdr["COM15"].ToString();
        string COM16 = rdr["COM16"].ToString();
        string COM17 = rdr["COM17"].ToString();
        string COM18 = rdr["COM18"].ToString();
        string COM19 = rdr["COM19"].ToString();
        string COM20 = rdr["COM20"].ToString();



        if (!string.IsNullOrEmpty(COM1))
        {
            Label2.Text = COM1;
            Label2.Visible = true;
            Label1.Visible = true;
        }
        if (!string.IsNullOrEmpty(COM2))
        {
            Label4.Text = COM2;
            Label4.Visible = true;
            Label3.Visible = true;
        }
        if (!string.IsNullOrEmpty(COM3))
        {
            Label6.Text = COM3;
            Label6.Visible = true;
            Label5.Visible = true;
        }
        if (!string.IsNullOrEmpty(COM4))
        {
            Label8.Text = COM4;
            Label8.Visible = true;
            Label7.Visible = true;
        }
        if (!string.IsNullOrEmpty(COM5))
        {
            Label10.Text = COM5;
            Label10.Visible = true;
            Label9.Visible = true;
        }
        if (!string.IsNullOrEmpty(COM6))
        {
            Label12.Text = COM6;
            Label12.Visible = true;
            Label11.Visible = true;
        }
        if (!string.IsNullOrEmpty(COM7))
        {
            Label14.Text = COM7;
            Label14.Visible = true;
            Label13.Visible = true;
        }
        if (!string.IsNullOrEmpty(COM8))
        {
            Label16.Text = COM8;
            Label16.Visible = true;
            Label15.Visible = true;
        }
        if (!string.IsNullOrEmpty(COM9))
        {
            Label18.Text = COM9;
            Label18.Visible = true;
            Label17.Visible = true;
        }
        if (!string.IsNullOrEmpty(COM10))
        {
            Label20.Text = COM10;
            Label20.Visible = true;
            Label19.Visible = true;

        }
        if (!string.IsNullOrEmpty(COM11))
        {
            Label22.Text = COM11;
            Label22.Visible = true;
            Label21.Visible = true;
        }
        if (!string.IsNullOrEmpty(COM12))
        {
            Label24.Text = COM12;
            Label24.Visible = true;
            Label23.Visible = true;
        }
        if (!string.IsNullOrEmpty(COM13))
        {
            Label26.Text = COM13;
            Label26.Visible = true;
            Label25.Visible = true;
        }
        if (!string.IsNullOrEmpty(COM14))
        {
            Label28.Text = COM14;
            Label28.Visible = true;
            Label27.Visible = true;

        }
        if (!string.IsNullOrEmpty(COM15))
        {
            Label30.Text = COM15;
            Label30.Visible = true;
            Label29.Visible = true;

        }
        if (!string.IsNullOrEmpty(COM16))
        {
            Label32.Text = COM16;
            Label32.Visible = true;
            Label31.Visible = true;

        }
        if (!string.IsNullOrEmpty(COM17))
        {
            Label34.Text = COM17;
            Label34.Visible = true;
            Label33.Visible = true;

        }
        if (!string.IsNullOrEmpty(COM18))
        {
            Label36.Text = COM18;
            Label36.Visible = true;
            Label35.Visible = true;
        }
        if (!string.IsNullOrEmpty(COM19))
        {
            Label38.Text = COM19;
            Label38.Visible = true;
            Label37.Visible = true;
        }
        if (!string.IsNullOrEmpty(COM20))
        {
            Label40.Text = COM20;
            Label40.Visible = true;
            Label39.Visible = true;
        }
        }
        catch (Exception)
        {

        }

    }

    protected void BtnContinuar_Click(object sender, EventArgs e)
    {
        try
        {
            string sql1 = "Delete alumnospremat from alumnospremat where NIE='" + Session["NIE"].ToString() + "'";
            string sql2 = "Delete usuariosmat from usuariosmat where NIE='" + Session["NIE"].ToString() + "'";
            conexion cone = new conexion();
            cone.eliminar(sql1);
            cone.eliminar(sql2);
        }
        catch (Exception)
        {

        }
        
    }
}