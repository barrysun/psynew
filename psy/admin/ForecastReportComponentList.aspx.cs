using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dal;

public partial class admin_Component_ForecastReportComponentList : System.Web.UI.Page
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
            whereStr = " where VARIABLE like '%" + whereStr + "%' or REPORTCOMPONENT like '%" + whereStr + "%'";
        }
        else
        {
            whereStr = "";
           }
        new ForecastReportComponentDal().BindPager(GridView1, AspNetPager1, whereStr);
    }
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        bind();
    }
    protected void LinkButton2_Command(object sender, CommandEventArgs e)
    {

    }
    //修改
    protected void LinkButton1_Command(object sender, CommandEventArgs e)
    {
        //
        string idstr = e.CommandName.Trim();
        if (idstr != null)
        {
            Response.Redirect("~/admin/ForecastReportComponentUpdate.aspx?forecastrepcompid=" + idstr);
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        bind();
    }
}