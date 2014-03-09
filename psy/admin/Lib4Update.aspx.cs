using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dal;
using Model;

public partial class admin_Lib4Update : System.Web.UI.Page
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

        if (Request.QueryString["id"] != null && Request.QueryString["id"].ToString() != "")
        {
            Button1.Visible = true;
            Button2.Visible = false;
            Lib4 lib4 = new Lib4Dal().GetById(Request.QueryString["id"]);
            if (lib4 == null) return;
            TextBox1.Text = lib4.ParentId.ToString();
            TextBox2.Text = lib4.Cnumber.ToString();
            TextBox3.Text = lib4.Cnname;
            TextBox4.Text = lib4.Score.ToString();
            TextBox5.Text = lib4.IsNode.ToString();
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
        var success = new Lib4Dal().Update(new Lib4()
        {
            Id = int.Parse(Request.QueryString["id"]),
            ParentId = int.Parse(TextBox1.Text),
            Cnumber = int.Parse(TextBox2.Text),
            Cnname = TextBox3.Text,
            Score = float.Parse(TextBox4.Text),
            IsNode = int.Parse(TextBox5.Text)
        });
        Page.ClientScript.RegisterStartupScript(this.GetType(), "alert",
         success ? "<script>alert('修改成功！');</script>" : "<script>alert('修改失败！');</script>");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        //add
        var success = new Lib4Dal().Add(new Lib4()
        {
            ParentId = int.Parse(TextBox1.Text),
            Cnumber = int.Parse(TextBox2.Text),
            Cnname = TextBox3.Text,
            Score = float.Parse(TextBox4.Text),
            IsNode = int.Parse(TextBox5.Text)
        });
        Page.ClientScript.RegisterStartupScript(this.GetType(), "alert",
         success ? "<script>alert('添加成功！');</script>" : "<script>alert('添加失败！');</script>");

    }
}