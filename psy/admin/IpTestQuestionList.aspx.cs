using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dal;

public partial class admin_IpTestQuestionList : System.Web.UI.Page
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
            whereStr = " where IPTITLE like '%" + whereStr + "%'";
        }
        else
        {
            whereStr = "";
        }
        new IpQuestionDal().BindPager(GridView1, AspNetPager1, whereStr);
    }
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        bind();
    }
    protected void LinkButton1_Command(object sender, CommandEventArgs e)
    {
        string ipid = e.CommandName.Trim();
        if (!string.IsNullOrEmpty(ipid))
        {
            Response.Redirect("~/admin/IpTestQuestionUpdate.aspx?ipid=" + ipid);
        }

    }
    protected void LinkButton2_Command(object sender, CommandEventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        bind();
        //查询
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        //添加IP试题
    }
}