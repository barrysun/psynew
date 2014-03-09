using Dal;
using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Report_MatchReportList : System.Web.UI.Page
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
        new RepostDal().MatchBindPager(GridView1, AspNetPager1, getWhereStr());
    }

    public string getWhereStr()
    {
        return null;
    }
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        bind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ExcelDown exceldown = new ExcelDown();
        exceldown.downExcel(Response, new RepostDal().getMatchTable(getWhereStr()), "MatchReport" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "-" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second + "-" + DateTime.Now.Millisecond, Server.MapPath("~/Excel"));
    }
}