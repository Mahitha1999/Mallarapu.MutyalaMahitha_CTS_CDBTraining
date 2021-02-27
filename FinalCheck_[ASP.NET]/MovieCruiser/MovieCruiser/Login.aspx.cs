using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace MovieCruiser
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnclick_Click(object sender, EventArgs e)
        {

            if (TxtName.Text == "Mahitha" && TxtPass.Text == "895183")
            {
                Session["name"] = TxtName.Text;
                FormsAuthentication.RedirectFromLoginPage(TxtName.Text, true);
            }
            else if(TxtName.Text == "Indu" && TxtPass.Text == "460")
            {
                Response.Redirect("MovieListCustomer.aspx");
            }
            else
            {
                Msg.Visible = true;
            }
        }

     
    }
}