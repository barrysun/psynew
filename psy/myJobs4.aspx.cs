using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class myJobs4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            if (Session["Id"] == null || Session["Id"].ToString() == "")
                Response.Redirect("login.aspx");
            else
            {
                DataTable dt = new JobsDal().Query(" where Id=" + Request.QueryString["Id"]);
                TextBox1.Text = dt.Rows[0]["GerenNengLi"].ToString();
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
        string GerenNengLi = TextBox1.Text;
        if (Session["Id"] == null || Session["Id"].ToString() == "")
            Response.Redirect("login.aspx");
        Jobs job = new Jobs();
        job.Id = int.Parse(Request.QueryString["Id"].ToString());
        job.GerenNengLi = GerenNengLi;
        if (new JobsDal().UpdateJob4(job))
        {
            Response.Redirect("myJobs5.aspx?Id="+Request.QueryString["Id"]);
        }
        
    }
    /// <summary>
    /// 上一步
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("myJobs3.aspx?Id="+Request.QueryString["Id"]);
    }
}