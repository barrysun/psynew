using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dal;

public partial class admin_Lib_IndexlibList : System.Web.UI.Page
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
        string whereStr = TextBox1.Text ;
        if (whereStr != null && whereStr != "")
        {
            whereStr = " where CNNAME like '%" + whereStr + "%' or CNNUMBER like '%" + whereStr + "%'";
        }
        else
        {
            whereStr = "";
        }
        new IndexLibDal().BindPager(GridView1, AspNetPager1, whereStr);
    }
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        bind();

    }
    protected void LinkButton1_Command(object sender, CommandEventArgs e)
    {
        string eqiid = e.CommandName.Trim();
        if (!string.IsNullOrEmpty(eqiid))
        {
            Response.Redirect("~/admin/ForecastJob1Update.aspx?forecastjob1id=" + eqiid);
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