using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dal;

public partial class admin_Lib_Lib5List : System.Web.UI.Page
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
            whereStr = " where MARK like '%" + whereStr + "%' or LIBNAME like '%" + whereStr + "%' or DESCRIPTION like '%" + whereStr + "%'";
        }
        else
        {
            whereStr = "";
        }

        new Lib5Dal().BindPager(GridView1, AspNetPager1, whereStr);
    }
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        bind();
    }
    //修改
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {

    }
    /// <summary>
    /// 查询
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button1_Click(object sender, EventArgs e)
    {
        bind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/admin/Lib5Update.aspx");
    }
}