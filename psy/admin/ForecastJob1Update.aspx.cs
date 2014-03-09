using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dal;
using Model;

public partial class admin_ForecastJob1Update : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Bind();
        }
    }

    private void Bind()
    {
        if (Request.QueryString["jobid"] != null && Request.QueryString["jobid"].ToString() != "")
        {
            ForecastJob1 forecastJob1 = new Forecastjob1Dal().Query(Request.QueryString["jobid"]);
            Label1.Text = forecastJob1.ForecastJob1Id.ToString();
            TextBox1.Text = forecastJob1.JobId.ToString();
            TextBox2.Text = forecastJob1.Cnmajor1;
            TextBox3.Text = forecastJob1.Cnmajor2;
            TextBox4.Text = forecastJob1.Cnmajor3;

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        var success = new Forecastjob1Dal().Update(new ForecastJob1()
        {
            ForecastJob1Id = int.Parse(Label1.Text),
            JobId = int.Parse(TextBox1.Text),
            Cnmajor1 = TextBox2.Text,
            Cnmajor2 = TextBox3.Text,
            Cnmajor3 = TextBox4.Text
        });
        Page.ClientScript.RegisterStartupScript(this.GetType(), "alert",
        success ? "<script>alert('修改成功！');</script>" : "<script>alert('修改失败！');</script>");

    }
}