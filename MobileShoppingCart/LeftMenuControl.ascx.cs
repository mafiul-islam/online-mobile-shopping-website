using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class LeftMenuControl : System.Web.UI.UserControl

{
    DataAccess DB = new DataAccess();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dlMenu.DataSource =DB.SelectQuery("SELECT * FROM Categorie");
            dlMenu.DataBind();
        }
    }

    protected void dlMenu_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}