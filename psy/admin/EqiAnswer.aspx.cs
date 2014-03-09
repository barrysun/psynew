using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dal;

public partial class admin_Answer_EqiAnswer : System.Web.UI.Page
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
        new EqiQuestionDal().BindPagerAnswer(GridView1, AspNetPager1, getWhere());
    }

    private string getWhere()
    {
        string where = TextBox1.Text.Trim();
        if (where != null && where != "")
        {
            if (DropDownList1.SelectedValue == "1")//用户ID
            {
                where = " `user`.USERID =" + where;

            }
            else if (DropDownList1.SelectedValue == "2")
            {
                where = " `user`.NAME like '%" + where + "%'";
            }
           
        }
        return where;
    }
  
    protected void Button1_Click(object sender, EventArgs e)
    {
        ExcelDown exceldown = new ExcelDown();
        exceldown.downExcel(Response,new EqiQuestionDal().GetTable(getWhere()),"eqi"+DateTime.Now.Year+"-"+DateTime.Now.Month+"-"+DateTime.Now.Day+"-"+DateTime.Now.Hour+"-"+DateTime.Now.Minute+"-"+DateTime.Now.Second+"-"+DateTime.Now.Millisecond,Server.MapPath("~/Excel"));
    }

    
    protected void Button2_Click(object sender, EventArgs e)
    {
        //点击查询
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        ExcelDown exceldown = new ExcelDown();
        exceldown.downExcel(Response, new EqiQuestionDal().getDataTable(), "eqititle1-" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "-" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second + "-" + DateTime.Now.Millisecond, Server.MapPath("~/Excel"));
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        ExcelDown exceldown = new ExcelDown();
        exceldown.downExcel(Response, new EqiQuestionDal().getDataTable2(), "eqititle2-" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "-" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second + "-" + DateTime.Now.Millisecond, Server.MapPath("~/Excel"));
   
    }
}