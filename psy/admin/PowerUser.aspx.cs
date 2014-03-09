using Dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_PowerUser : System.Web.UI.Page
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
        string whereStr = TextBox2.Text.Trim();
        if (whereStr != null && whereStr != "")
        {
            whereStr = " where RealName like '%"+whereStr+"%' or LoginName like '%"+whereStr+"%' "; 
        }
        else {
            whereStr = "";
        }
        return whereStr;
    }

    public void bind()
    {
        new NUserDal().BindPager(GridView1, AspNetPager1, whereStr());
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            ((Button)GridView1.Rows[i].FindControl("Button2")).Enabled = ((Button)GridView1.Rows[i].FindControl("Button2")).CommandArgument=="1"?false:true;
            ((Button)GridView1.Rows[i].FindControl("Button1")).Enabled = ((Button)GridView1.Rows[i].FindControl("Button1")).CommandArgument == "1" ? false : true;
            ((Button)GridView1.Rows[i].FindControl("Button3")).Enabled = ((Button)GridView1.Rows[i].FindControl("Button3")).CommandArgument == "1" ? false : true;
        }
    }
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        bind();
    }
    /// <summary>
    /// 生成测评报告
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button1_Command(object sender, CommandEventArgs e)
    {
        new Calculate().TestResult(int.Parse(e.CommandName));
        new IchingResultDal().exesql("update nuser set IsTest=1 where Id=" + e.CommandName);
        bind();
    }
    /// <summary>
    /// 生成预测报告
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button1_Command1(object sender, CommandEventArgs e)
    {
        new Calculate().ForResult(int.Parse(e.CommandName), "");
        new IchingResultDal().exesql("update nuser set IsFor=1 where Id=" + e.CommandName);
        bind();
    }
    /// <summary>
    /// 易经计算
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button3_Command(object sender, CommandEventArgs e)
    {
        new IchingResultDal().yjsf(int.Parse(e.CommandName));
        new IchingResultDal().exesql("update nuser set Isiching=1 where Id=" + e.CommandName);
        bind();
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
       // ((Button)e.Row.FindControl("Button2")).Enabled = false;
    }

    public string  IsTrue(string str)
    {
        if (str == "true")
        {
            return "Enabled = \"true\"";
        }
        return "Enabled = \"false\"";
    }
    /// <summary>
    /// 设置
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button5_Click(object sender, EventArgs e)
    {
        new IchingResultDal().exesql("update nuser set McCount="+TextBox1.Text+" where Id=" + Label2.Text);
        Label1.Text = "";
        Label2.Text = "";
        TextBox1.Text = "";
        bind();
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button4_Command(object sender, CommandEventArgs e)
    {
      DataTable  dt= new NUserDal().Query(" where Id=" + e.CommandName);
      Label1.Text = dt.Rows[0]["RealName"].ToString();
      TextBox1.Text = dt.Rows[0]["McCount"].ToString();
      Label2.Text = dt.Rows[0]["Id"].ToString();
    }
    /// <summary>
    /// 查询
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button6_Click(object sender, EventArgs e)
    {
        bind();
    }
}