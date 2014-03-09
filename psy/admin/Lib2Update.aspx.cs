using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dal;
using System.Data;
using Model;

public partial class admin_Lib2Update : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            
            bind();
        }
    }

    public void bind()
    {
        if (Request.QueryString["number"] != null && Request.QueryString["number"].ToString() != "")
        {
            Button1.Visible = true;
            Button2.Visible = false;
            DataTable dt = new Lib2Dal().GetById(Request.QueryString["number"].Trim());
            if (dt.Rows.Count > 0)
            {
                TextBox1.Text = dt.Rows[0]["NUMBER"].ToString();
                TextBox2.Text = dt.Rows[0]["Lib2NAME"].ToString();
                TextBox3.Text = dt.Rows[0]["DESCRIPTION"].ToString();

            }
        }
        else
        {
            Button1.Visible = false;
            Button2.Visible = true;

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
      var success=  new Lib2Dal().Update(new Lib2Profession()
        {
           Lib2Name = TextBox2.Text,
           Number = TextBox1.Text,
           DEScription = TextBox3.Text
        });
      Page.ClientScript.RegisterStartupScript(this.GetType(), "alert",
         success ? "<script>alert('修改成功！');</script>" : "<script>alert('修改失败！');</script>");


    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        //add
         var success=  new Lib2Dal().Add(new Lib2Profession()
        {
           Lib2Name = TextBox2.Text,
           Number = TextBox1.Text,
           DEScription = TextBox3.Text
        });
        Page.ClientScript.RegisterStartupScript(this.GetType(), "alert",
            success ? "<script>alert('添加成功！');</script>" : "<script>alert('添加失败！');</script>");
    }
}