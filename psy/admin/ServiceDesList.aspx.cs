using Dal;
using System;
using System.Collections.Generic;
using System.Data;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_ServiceDesList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bind();
        }
    }
    public void bind()
    {
        DataTable dt = new ServiceDesDal().getDataTable();
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }

    protected void LinkButton1_Command(object sender, CommandEventArgs e)
    {
        string ichinglib1 = e.CommandName.Trim();
        if (!string.IsNullOrEmpty(ichinglib1))
        {
            Response.Redirect("~/admin/ServiceDesUpdate.aspx?id=" + ichinglib1);
        }

    }
    
}