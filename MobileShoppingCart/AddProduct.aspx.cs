using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddProduct : System.Web.UI.Page
{
    DataAccess DB = new DataAccess();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        Insert_Data();
    }

    public void Insert_Data()
    {
        if (FileUpload1.HasFile)
        {
            string Path = "~/Images/" + FileUpload1.FileName.ToString();
            string query =
                @"INSERT INTO [dbo].[Products]
                         ([NAME]
                        ,[IMAGE]
                         ,[PRICE]
                         ,[DESCRIPTION]
                        ,[IDCAT])
                        VALUES('" + txtname.Text + "','" + Path + "','" + txtprice.Text + "','" + txtdescription.Text + "','" + txtcategory.Text + "')";

            DB.Input_data(query);
            Response.Write("Success");

        }
        else
        {
            Response.Write("Faild");
        }

        
    }
}