using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dal;

public partial class admin_Component_MatchReportComponentList : System.Web.UI.Page
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
            whereStr = " where VARIABLE like '" + whereStr + "' or REPORTCOMPONENT like '%" + whereStr + "%' ";

        }
        else
        {
            whereStr = "";
        }
        new MatchReportComponentDal().BindPager(GridView1, AspNetPager1, whereStr);
    }
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        bind();
    }
    protected void LinkButton1_Command(object sender, CommandEventArgs e)
    {
        string matchid = e.CommandName.Trim();
        if (!string.IsNullOrEmpty(matchid))
        {
            Response.Redirect("~/admin/MatchReportComponentUpdate.aspx?matchid=" + matchid);
        }

    }
    protected void LinkButton2_Command(object sender, CommandEventArgs e)
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
}