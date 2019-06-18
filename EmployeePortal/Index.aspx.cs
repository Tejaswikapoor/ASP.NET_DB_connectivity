using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeePortal
{
    public partial class Index : System.Web.UI.Page
    {
        public void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    if (ViewState["clicks"] == null)
            //    {
            //        ViewState["clicks"] = 0;
            //    }
            //    Textbox1.Text = ViewState["clicks"].ToString();

            //}

          


           



        }
            protected void Button1_click(object sender, EventArgs e)
            {
            //int clickcount = (int)ViewState["clicks"] + 1;
            //Textbox1.Text = clickcount.ToString();
            //ViewState["clicks"] = clickcount;


           
            string connetionString;
            SqlConnection con;

            connetionString = @"Data Source=(LocalDB)\mydb;Initial Catalog=Employee ;Integrated Security=True";



            con = new SqlConnection(connetionString);

            SqlCommand cmd = new SqlCommand("SP_Inserttestdetails", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            
            string s = Textbox1.Text.ToString();

            cmd.Parameters.AddWithValue("@inputval", s);

            int t = cmd.ExecuteNonQuery();
            con.Close();
            
            
            

        }

        protected void Textbox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }