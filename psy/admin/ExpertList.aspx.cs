using Dal;
using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_ExpertList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Bind();
        }
    }
    public string whereStr()
    {
        return "";
    }
    public void Bind()
    {
        new ExpertDal().BindPager(GridView1, AspNetPager1, whereStr());
    }

    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        Bind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/admin/ExpertUpdate.aspx");
    }
}