using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dal;
using Model;

public partial class admin_ForecastJob2Update : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Bind();
        }
    }

    public void Bind()
    {
        if (Request.QueryString["forecastjob2id"] == null || Request.QueryString["forecastjob2id"].ToString() == "")
            return;
        Forecastjob2Dal forecastjob2Dal = new Forecastjob2Dal();
        Forecastjob2 forecastjob2=  forecastjob2Dal.Query(Request.QueryString["forecastjob2id"]);
        Label1.Text = forecastjob2.JobId.ToString();
        TextBox1.Text = forecastjob2.CnoutLook1;
        TextBox2.Text = forecastjob2.CnoutLook2;
    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/admin/ForecastJob2List.aspx");
    }
    /// <summary>
    /// 修改
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button1_Click(object sender, EventArgs e)
    {
        bool success =   new Forecastjob2Dal().Update(new Forecastjob2(){
          JobId = int.Parse(Label1.Text.Trim()),
           CnoutLook1 = TextBox1.Text,
           CnoutLook2 = TextBox2.Text
        });
        Page.ClientScript.RegisterStartupScript(this.GetType(), "alert",
            success ? "<script>alert('修改成功！');</script>" : "<script>alert('修改失败！');</script>");
    }
}