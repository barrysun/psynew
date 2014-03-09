using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dal;
using Model;

public partial class admin_Ichinglib1Update : System.Web.UI.Page
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
        if (Request.QueryString["id"] != null && Request.QueryString["id"] != "")
        {
            Button1.Visible = true;
            Button2.Visible = false;
           Ichinglib1 ichinglib1=new IchingLib1Dal().GetById(Request.QueryString["id"]);
            if (ichinglib1 == null) return;
            TextBox1.Text = ichinglib1.Date;
            TextBox2.Text = ichinglib1.Time;
            TextBox3.Text = ichinglib1.Ng.ToString();
            TextBox4.Text = ichinglib1.Nz.ToString();
        }
        else
        {
            Button1.Visible = false;
            Button2.Visible = true;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //update
        var success = new IchingLib1Dal().Update(new Ichinglib1()
        {
            Id=int.Parse(Request.QueryString["id"]),
            Date=TextBox1.Text,
            Time=TextBox2.Text,
            Ng=int.Parse(TextBox3.Text),
            Nz=int.Parse(TextBox4.Text)
        });
        Page.ClientScript.RegisterStartupScript(this.GetType(), "alert",
            success ? "<script>alert('保存成功！');</script>" : "<script>alert('保存失败！');</script>");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        //add
        var success = new IchingLib1Dal().Add(new Ichinglib1()
        {
            Date = TextBox1.Text,
            Time = TextBox2.Text,
            Ng = int.Parse(TextBox3.Text),
            Nz = int.Parse(TextBox4.Text)
        });
        Page.ClientScript.RegisterStartupScript(this.GetType(), "alert",
            success ? "<script>alert('保存成功！');</script>" : "<script>alert('保存失败！');</script>");
    }
}