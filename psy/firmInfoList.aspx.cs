using Dal;
using Model;
using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class firmInfo : System.Web.UI.Page
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
        new FirmInfoDal().BindPager(Repeater1, AspNetPager1, " ");
    }

    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        bind();
    }
    //编辑
    protected void LinkButton1_Command(object sender, CommandEventArgs e)
    {
        if (e.CommandName != null)
        {
            Response.Redirect("firmInfo.aspx?id=" + e.CommandName);
        }
    }
    //删除
    protected void LinkButton2_Command(object sender, CommandEventArgs e)
    {
        if (e.CommandName != null && e.CommandName.ToString() != "")
        {
            if (new FirmInfoDal().Delete(int.Parse(e.CommandName)))
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("", "删除成功！"));
                bind();
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("", "删除失败！"));
            }

        }
    }
   
}