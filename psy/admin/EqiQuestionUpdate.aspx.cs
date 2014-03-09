using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Dal;
using Model;

public partial class admin_EqiQuestionUpdate : System.Web.UI.Page
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
        if (Request.QueryString["eqiid"] != null && Request.QueryString["eqiid"].ToString() != "")
        {
            Button1.Visible = true;
            Button2.Visible = false;

            string eqiid = Request.QueryString["eqiid"].Trim();
            DataTable dt = new EqiQuestionDal().GetById(eqiid);
            if (dt != null && dt.Rows.Count > 0)
            {
                TextBox1.Text = dt.Rows[0]["ORIGINALNUMBER"].ToString();
                TextBox2.Text = dt.Rows[0]["EQITYPE"].ToString();
                TextBox3.Text = dt.Rows[0]["TESTNUMBER"].ToString();
                TextBox4.Text = dt.Rows[0]["SCORE"].ToString();

                TextBox5.Text = dt.Rows[0]["ISUSE"].ToString();
                TextBox6.Text = dt.Rows[0]["SPECIALTYPE"].ToString();
                TextBox7.Text = dt.Rows[0]["EQITITLE"].ToString();
                TextBox8.Text = dt.Rows[0]["EQIORDER"].ToString();
                TextBox9.Text = dt.Rows[0]["VERYSCORE"].ToString();
                TextBox10.Text = dt.Rows[0]["BASICSCORE"].ToString();
                TextBox11.Text = dt.Rows[0]["SOMETIMESCORE"].ToString();
                TextBox12.Text = dt.Rows[0]["DOESNOTSCORE"].ToString();
                TextBox13.Text = dt.Rows[0]["NOTSCORE"].ToString();
                TextBox14.Text = dt.Rows[0]["TEST"].ToString();
                // TextBox15.Text = dt.Rows[0]["DOESNOTSCORE"].ToString();
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
        var success = new EqiQuestionDal().Update(new EqiTestQuestion()
        {
            EqiId = int.Parse(Request.QueryString["eqiid"]),
            EqiType = TextBox2.Text,
            TestNumber = int.Parse(TextBox3.Text),
            Score = double.Parse(TextBox4.Text),
            IsUse = int.Parse(TextBox5.Text),
            SpecialType = TextBox6.Text,
            EqiTitle = TextBox7.Text,
            EqiOrder = int.Parse(TextBox8.Text),
            VeryScore = double.Parse(TextBox9.Text),
            BasicScore = double.Parse(TextBox10.Text),
            SomeTimeScore = double.Parse(TextBox11.Text),
            DoesnotScore = double.Parse(TextBox12.Text),
            NotScore = double.Parse(TextBox13.Text),
            Test=TextBox14.Text
        });
        Page.ClientScript.RegisterStartupScript(this.GetType(), "alert",
        success ? "<script>alert('修改成功！');</script>" : "<script>alert('修改失败！');</script>");
    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        var success = new EqiQuestionDal().Add(new EqiTestQuestion()
        {
            EqiType = TextBox2.Text,
            TestNumber = int.Parse(TextBox3.Text),
            Score = double.Parse(TextBox4.Text),
            IsUse = int.Parse(TextBox5.Text),
            SpecialType = TextBox6.Text,
            EqiTitle = TextBox7.Text,
            EqiOrder = int.Parse(TextBox8.Text),
            VeryScore = double.Parse(TextBox9.Text),
            BasicScore = double.Parse(TextBox10.Text),
            SomeTimeScore = double.Parse(TextBox11.Text),
            DoesnotScore = double.Parse(TextBox12.Text),
            NotScore = double.Parse(TextBox13.Text),
            Test = TextBox14.Text
        });
        Page.ClientScript.RegisterStartupScript(this.GetType(), "alert",
        success ? "<script>alert('添加成功！');</script>" : "<script>alert('添加失败！');</script>");
    }
}