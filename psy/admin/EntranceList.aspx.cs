using Dal;
using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_EntranceList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bind();
        }
    }

    public string whereStr()
    {
        return " where ENTRANCETYPE=" + Request.QueryString["type"];
    }

    public void bind()
    {
        switch (int.Parse(Request.QueryString["type"].ToString().Trim()))
        {
            case 1: Button1.Text = "添加高考志愿填报"; break;
            case 2: Button1.Text = "添加心理解压"; break;
            case 3: Button1.Text = "常用心理学"; break;
            case 4: break;
        }
        new EntranceDal().BindPager(GridView1, AspNetPager1, whereStr());
    
    }
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("EntranceUpdate.aspx?type=" + Request.QueryString["type"]);
    }
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        bind();
    }
}