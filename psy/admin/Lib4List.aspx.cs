using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dal;

public partial class admin_Lib_Lib4List : System.Web.UI.Page
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
        string whereStr = TextBox1.Text;
        if (whereStr != null && whereStr != "")
        {
            whereStr = " where CNUMBER like '%" + whereStr + "%' or CNNAME like '%" + whereStr + "%' ";
        }
        else
        {
            whereStr = "";
        }
        new Lib4Dal().BindPager(GridView1, AspNetPager1, whereStr);
    }
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        bind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        bind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/admin/Lib4Update.aspx");
    }
}