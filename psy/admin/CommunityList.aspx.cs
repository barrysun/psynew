using Dal;
using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_CommunityList : System.Web.UI.Page
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
        return "community where community.TYPE=" + Request.QueryString["type"];
    }

    public void bind()
    {
        string typestr=Request.QueryString["type"];
        switch(int.Parse(typestr.Trim()))
        {
            case 1:
                Button1.Text = "添加应聘面试";
                break;
            case 2:
                Button1.Text = "添加社会职业介绍";
                break;
        }
        new CommunityDal().BindPager(GridView1, AspNetPager1, whereStr());
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("CommunityUpdate.aspx?type="+Request.QueryString["type"]);
    }
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        bind();
    }

    //修改
    protected void LinkButton1_Command(object sender, CommandEventArgs e)
    {
        Response.Redirect("CommunityUpdate.aspx?type=" + Request.QueryString["type"]+"&id="+e.CommandName); 

    }
    protected void LinkButton2_Command(object sender, CommandEventArgs e)
    {

    }
}