using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeePortal
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (ViewState["clicks"] == null)
                {
                    ViewState["clicks"] = 0;
                }
                Textbox1.Text = ViewState["clicks"].ToString();

            }
        }
            protected void Button1_click(object sender, EventArgs e)
            {
                int clickcount = (int)ViewState["clicks"] + 1;
                Textbox1.Text = clickcount.ToString();
                ViewState["clicks"] = clickcount;
            }

        protected void Textbox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }