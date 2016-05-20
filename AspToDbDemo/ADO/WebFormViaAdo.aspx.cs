using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sample
{
    public partial class WebForm_Ado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DemoDbConnectionString"].ConnectionString))
            {
                var adapter = new SqlDataAdapter("Select * From Reports", connection);
                var dataSet = new DataSet();
                adapter.Fill(dataSet);
                GridView1.DataSource = dataSet;
                GridView1.DataBind();
            }
        }
    }
}