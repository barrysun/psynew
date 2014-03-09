using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class myJobs2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            if (Session["Id"] == null || Session["Id"].ToString() == "")
                Response.Redirect("login.aspx");
            else{
                DataTable dt = new JobsDal().Query(" where Id=" + Request.QueryString["Id"]);
                TextBox1.Text = dt.Rows[0]["TeChang"].ToString();
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
        string TeChang = TextBox1.Text;
        if (Session["Id"] == null || Session["Id"].ToString() == "")
            Response.Redirect("login.aspx");
        Jobs job = new Jobs();
        job.Id = int.Parse(Request.QueryString["Id"].ToString());
        job.TeChang = TeChang;
        new JobsDal().UpdateJob2(job);
        Response.Redirect("myJobs3.aspx?Id="+Request.QueryString["Id"]);

    }
    /// <summary>
    /// 上一步
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("myJobs1.aspx?Id="+Request.QueryString["Id"]);
    }
}