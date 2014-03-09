using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dal;

public partial class admin_Lib3List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) { bind(); }
    }
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        bind();
    }
    public void bind()
    {
        string whereStr = TextBox1.Text;
        if (whereStr != null && whereStr != "")
        {
            whereStr = " where  CNNAME like '%" + whereStr + "%' or CNDES like '%" + whereStr + "%' or CNWORK like '%" + whereStr + "%' ";
        }
        else
        {
            whereStr = "";
        }
        new Lib3Dal().BindPager(GridView1, AspNetPager1, whereStr);
    }
    //修改


    protected void LinkButton2_Command(object sender, CommandEventArgs e)
    {

    }
    protected void LinkButton1_Command(object sender, CommandEventArgs e)
    {
        string cnnumber = e.CommandName.Trim();
        if (cnnumber != null)
        {
            Response.Redirect("~/admin/Lib3Update.aspx?cnnumber=" + cnnumber);
        }
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
        Response.Redirect("~/admin/Lib3Update.aspx");
    }
}