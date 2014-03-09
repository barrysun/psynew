using System;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Admin : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("~/Login2.aspx");
            }
        }
    }

    public string GetMenuString()
    {
       // if (Response.Cookies["User"]["AdminID"] != null)
       //     return MenuDAL.Current.CreateHTML(Response.Cookies["User"]["AdminID"].ToString());
 
       //if (Response.Cookies["User"]["TeacherID"] != null)
       //    return MenuDAL.Current.CreateHTML(Response.Cookies["User"]["TeacherID"].ToString());
       // else
       // {
       //     Response.Redirect("login.aspx");
       //     return null;
       // }
        return null;
    }

    public string GetTreeJSON()
    {
       // return ExtTree.Current.CreateExtTreeJSON();
        return null;

    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
      
        Response.Redirect("login.aspx");
    }
}
