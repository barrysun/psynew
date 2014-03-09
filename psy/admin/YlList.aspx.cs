using Dal;
using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_YlList : System.Web.UI.Page
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
        new YlDal().BindPager(GridView1, AspNetPager1, "");
    }

    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        bind();
    }
}