using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class myJobs3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["Id"] == null || Session["Id"].ToString() == "")
                Response.Redirect("login.aspx");
            else
            {
                DataTable dt = new JobsDal().Query(" where Id=" + Session["Id"]);
                TextBox1.Text = dt.Rows[0]["JiaoYu"].ToString();
                TextBox2.Text = dt.Rows[0]["HuiJiang"].ToString();
                TextBox3.Text = dt.Rows[0]["Zhengshu"].ToString();
                TextBox4.Text = dt.Rows[0]["PeiXun"].ToString();
                TextBox5.Text = dt.Rows[0]["GongZuoJinli"].ToString();
            
            }
        }
    }
    /// <summary>
    /// 下一步
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button1_Click(object sender, EventArgs e)
    {

        if (Session["Id"] == null || Session["Id"].ToString() == "")
            Response.Redirect("login.aspx");
        string JiaoYu = TextBox1.Text;
        string HuiJiang = TextBox2.Text;
        string Zhengshu = TextBox3.Text;
        string PeiXun = TextBox4.Text;
        string GongZuoJinli = TextBox5.Text;
        Jobs job = new Jobs();
        job.Id = int.Parse(Request.QueryString["Id"]);
        job.JiaoYu = JiaoYu;
        job.HuiJiang = HuiJiang;
        job.Zhengshu = Zhengshu;
        job.PeiXun = PeiXun;
        job.GongZuoJinli = GongZuoJinli;
        if (new JobsDal().UpdateJob3(job))
        {
            Response.Redirect("myJobs4.aspx?Id="+Request.QueryString["Id"]);
        }
        
       
    }
    /// <summary>
    /// 上一步
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("myJobs2.aspx?Id="+Request.QueryString["Id"]);
    }
}