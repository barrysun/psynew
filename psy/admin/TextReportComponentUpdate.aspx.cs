using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dal;
using System.Data;
using Model;

public partial class admin_TextReportComponentUpdate : System.Web.UI.Page
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
        string textrecomid = Request.QueryString["textrecomid"].Trim();
        if (textrecomid != null)
        {
            DataTable dt = new TextReportComponentDal().GetById(textrecomid);
            if (dt != null && dt.Rows.Count > 0)
            {
                TextBox1.Text = dt.Rows[0]["CSNUM"].ToString();
                TextBox2.Text = dt.Rows[0]["VARIABLE"].ToString();
                TextBox3.Text = dt.Rows[0]["VARIABLEVALUE"].ToString();
                TextBox4.Text = dt.Rows[0]["REPORTCOMPONENT"].ToString();
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        var success = new TextReportComponentDal().Upate(new TextReportComponent()
        {
            TextRecomId = int.Parse(Request.QueryString["textrecomid"]),
             CsNum =int.Parse(TextBox1.Text),
             Variable = TextBox2.Text,
             VariableValue = int.Parse(TextBox3.Text),
             ReportComPonent = TextBox4.Text
        });
        Page.ClientScript.RegisterStartupScript(this.GetType(), "alert",
            success ? "<script>alert('修改成功！');</script>" : "<script>alert('修改失败！');</script>");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        //add
        var success = new TextReportComponentDal().Add(new TextReportComponent()
        {
            CsNum = int.Parse(TextBox1.Text),
            Variable = TextBox2.Text,
            VariableValue = int.Parse(TextBox3.Text),
            ReportComPonent = TextBox4.Text
        });
        Page.ClientScript.RegisterStartupScript(this.GetType(), "alert",
           success ? "<script>alert('添加成功！');</script>" : "<script>alert('添加失败！');</script>");
    }
}