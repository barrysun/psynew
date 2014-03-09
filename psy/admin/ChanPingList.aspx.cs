using Dal;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_ChanPingList : System.Web.UI.Page
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
        new ChangpingDal().BindPager(GridView1, AspNetPager1, "");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/admin/chanPingUpdate.aspx");
    }
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        bind();
    }
}