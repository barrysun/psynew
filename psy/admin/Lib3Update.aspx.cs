using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Dal;
using Model;

public partial class admin_Lib3Update : System.Web.UI.Page
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
        if (Request.QueryString["cnnumber"] != null && Request.QueryString["cnnumber"].ToString() != "")
        {

            Button1.Visible = true;
            Button2.Visible = false;
            string cnnumber = Request.QueryString["cnnumber"].Trim();
            if (!string.IsNullOrEmpty(cnnumber))
            {
                DataTable dt = new Lib3Dal().GetById(cnnumber);
                if (dt != null && dt.Rows.Count > 0)
                {
                    TextBox1.Text = dt.Rows[0]["CNNUMBER"].ToString();
                    TextBox2.Text = dt.Rows[0]["CNNAME"].ToString();
                    TextBox3.Text = dt.Rows[0]["CNDES"].ToString();
                    TextBox4.Text = dt.Rows[0]["CNWORK"].ToString();
                }
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
      var success=  new Lib3Dal().Update(new Lib3()
        {
             Cnnumber = int.Parse(TextBox1.Text),
             Cnname = TextBox2.Text,
             Cndes = TextBox3.Text,
             Cnwork = TextBox4.Text
        });
      Page.ClientScript.RegisterStartupScript(this.GetType(), "alert",
       success ? "<script>alert('修改成功！');</script>" : "<script>alert('修改失败！');</script>");

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        //add
        var success = new Lib3Dal().Add(new Lib3()
        {
            Cnnumber = int.Parse(TextBox1.Text),
            Cnname = TextBox2.Text,
            Cndes = TextBox3.Text,
            Cnwork = TextBox4.Text
        });
        Page.ClientScript.RegisterStartupScript(this.GetType(), "alert",
         success ? "<script>alert('添加成功！');</script>" : "<script>alert('添加失败！');</script>");
    }
}