using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    MySql.Data.MySqlClient.MySqlConnection conn;
    MySql.Data.MySqlClient.MySqlCommand cmd;
    String queryString;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void onClickMetod(object sender, EventArgs e)
    {
        addElement();
    }

    private void addElement()
    {
        String connString = System.Configuration.ConfigurationManager.ConnectionStrings["webAppConn"].ToString();

        conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
        conn.Open();
        queryString = "INSERT INTO magazyn.capacitors (Name, Capacity, Passive_Id)" +
                      "VALUES('NICHICON20','20','2')";


        cmd = new MySql.Data.MySqlClient.MySqlCommand(queryString, conn);

        cmd.ExecuteReader();
        conn.Close();
    }
}