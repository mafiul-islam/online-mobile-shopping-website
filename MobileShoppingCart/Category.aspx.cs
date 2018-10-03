using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Category : System.Web.UI.Page
{
    DataAccess DB = new DataAccess();
    protected void Page_Load(object sender, EventArgs e)
    {
        
            if (!IsPostBack)
            {
                string IDCAT = Request.QueryString["IDCAT"];
                if (IDCAT != null)
                {
                    dlCategory.DataSource = DB.SelectQuery("SELECT * FROM Products WHERE IDCAT=" + IDCAT);
                    dlCategory.DataBind();
                }

            }
        }
   }
