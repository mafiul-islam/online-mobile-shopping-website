using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class ProductDetail : System.Web.UI.Page
   
{
    Cart myCart;

    DataAccess DB = new DataAccess();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string id = Request.QueryString["ID"];
            if (id!= null)
            {
                dlproduct.DataSource = DB.SelectQuery("SELECT * FROM Products WHERE ID=" + id);
                dlproduct.DataBind();
            }
        }
    }


   

    protected void btnAddTo_Click(object sender, EventArgs e)
    {
        if (Session["myCart"] == null)
        {
            myCart = new Cart();
            Session["myCart"] = myCart;
        }

        string id = Request.QueryString["ID"];

        myCart = (Cart)Session["myCart"];

        DataTable dt = DB.SelectQuery("SELECT * FROM Products WHERE ID = " + id);
        DataRow row = dt.Rows[0];
        myCart.Insert(new CartItem(Int32.Parse(id),
            row["NAME"].ToString(),
            row["IMAGE"].ToString(),
            row["DESCRIPTION"].ToString(),
            Double.Parse(row["PRICE"].ToString()),
            1)
            );

    }
}