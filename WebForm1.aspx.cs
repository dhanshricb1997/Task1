using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Entity.SqlServer;



namespace Task1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                string CS = ConfigurationManager.ConnectionStrings["SampleDBEntities"].ConnectionString;
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("Select Id, Department from tblTask2", con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    DropDownList1.DataTextField = "Department";
                    DropDownList1.DataValueField = "Id";
                    DropDownList1.DataSource = rdr;
                    DropDownList1.DataBind();
                }
            }

        }



        protected void Button1_Click(object sender, EventArgs e)
        {


            string CS = ConfigurationManager.ConnectionStrings["SampleDBEntities"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("spFetchData", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParamId = new SqlParameter();
                {
                    ParamId.ParameterName = "@Id";
                    ParamId.Value = Convert.ToInt32(DropDownList1.SelectedValue.ToString());

                }
                    cmd.Parameters.Add(ParamId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

               

                Label1.Text = DropDownList1.SelectedItem.Text;
            }
        }
    }
}