using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dal;

public partial class admin_Ichinglib1List : System.Web.UI.Page
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
        new IchingLib1Dal().BindPager(GridView1, AspNetPager1, "");
    }
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        bind();
    }

    protected void LinkButton1_Command(object sender, CommandEventArgs e)
    {
        string ichinglib1 = e.CommandName.Trim();
        if (!string.IsNullOrEmpty(ichinglib1))
        {
            Response.Redirect("~/admin/IchingLib1Update.aspx?ichinglib1=" + ichinglib1);
        }

    }
    protected void LinkButton2_Command(object sender, CommandEventArgs e)
    {

    }
}