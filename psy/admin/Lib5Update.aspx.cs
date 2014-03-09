using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dal;
using Model;

public partial class admin_Lib5Update : System.Web.UI.Page
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
        if (Request.QueryString["lib5id"] != null && Request.QueryString["lib5id"].ToString() != "")
        {
            Button1.Visible = true;
            Button2.Visible = false;
            Lib5 lib5 = new Lib5Dal().GetById(Request.QueryString["lib5id"]);
            if (lib5 == null) return;
            TextBox1.Text = lib5.LibFiveTypeId.ToString();
            TextBox2.Text = lib5.Mark;
            TextBox3.Text = lib5.LibName;
            TextBox4.Text = lib5.DescripTion;
        }
        else
        {
            Button1.Visible = false;
            Button2.Visible = true;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        //udpate
        var success = new Lib5Dal().Update(new Lib5()
        {
            LibFiveDetailId = int.Parse(Request.QueryString["lib5id"]),
            LibFiveTypeId = int.Parse(TextBox1.Text),
            Mark = TextBox2.Text,
            LibName = TextBox3.Text,
            DescripTion = TextBox4.Text
            
        });
        Page.ClientScript.RegisterStartupScript(this.GetType(), "alert",
        success ? "<script>alert('修改成功！');</script>" : "<script>alert('修改失败！');</script>");

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        //add
        var success = new Lib5Dal().Add(new Lib5()
        {
            LibFiveTypeId = int.Parse(TextBox1.Text),
            Mark = TextBox2.Text,
            LibName = TextBox3.Text,
            DescripTion = TextBox4.Text
        });
        Page.ClientScript.RegisterStartupScript(this.GetType(), "alert",
        success ? "<script>alert('添加成功！');</script>" : "<script>alert('添加失败！');</script>");
    }
}