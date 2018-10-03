using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;

public class DataAccess
{
    static SqlConnection conn;
    static SqlCommand cmd;
     static SqlDataAdapter da;
    static   DataTable dt;
    public static void DB_Con()
    {
        conn = new SqlConnection(@"Data Source=DESKTOP-D8JFTQ3;Initial Catalog=MobileCart;Integrated Security=True");
        conn.Open();
    }
    public DataTable SelectQuery(string query)
    {
        DB_Con();

        cmd = new SqlCommand(query, conn);
        da = new SqlDataAdapter(cmd);
        dt = new DataTable();
        da.Fill(dt);
        return dt;


    }
    public int Input_data(string query)
    {
        DB_Con();
        cmd = new SqlCommand(query, conn);
        try
        {
            cmd.ExecuteNonQuery();
            return 1;
        }
        catch (SqlException ex)
        {
            if (ex.Number == -2)
            {
                Console.WriteLine("Timeout occurred");
            }
            return 0;
        }

    }
}
