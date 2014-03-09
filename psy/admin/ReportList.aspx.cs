using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dal;

public partial class admin_Report_ReportList : System.Web.UI.Page
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
        new ReportDal().BindPager(GridView1, AspNetPager1, "");
    }
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        bind();
    }
}