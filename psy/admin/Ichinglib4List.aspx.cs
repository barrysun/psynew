using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dal;

public partial class admin_Iching_Ichinglib4List : System.Web.UI.Page
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
        new IchingLib4Dal().BindPager(GridView1, AspNetPager1, "");
    }
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        bind();
    }
    protected void LinkButton1_Command(object sender, CommandEventArgs e)
    {
        string ichinglib4 = e.CommandName.Trim();
        if (!string.IsNullOrEmpty(ichinglib4))
        {
            Response.Redirect("~/admin/IchingLib4Update.aspx?ichinglib4=" + ichinglib4);
        }

    }
    protected void LinkButton2_Command(object sender, CommandEventArgs e)
    {

    }
}