using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dal;
using Model;

public partial class admin_WilTestQuestionUpdate : System.Web.UI.Page
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
        if (Request.QueryString["wilid"] != null && Request.QueryString["wilid"].ToString() != "")
        {
            Button1.Visible = true;
            Button2.Visible = false;
            string wilid = Request.QueryString["wilid"];
            WilTestQuestion wilTestQuestion = new WilQuestionDal().Query(wilid);
            TextBox1.Text = wilTestQuestion.WilType;
            TextBox2.Text = wilTestQuestion.LetterMark;
            TextBox3.Text = wilTestQuestion.WilTitle;
            TextBox4.Text = wilTestQuestion.ImportScore.ToString();
            TextBox5.Text = wilTestQuestion.SecondlyScore.ToString();
            TextBox6.Text = wilTestQuestion.GeneralScore.ToString();
            TextBox7.Text = wilTestQuestion.SomeimportScore.ToString();
            TextBox8.Text = wilTestQuestion.NotinportScore.ToString();
            TextBox9.Text = wilTestQuestion.WilOrder.ToString();
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
        var success = new WilQuestionDal().Update(new WilTestQuestion()
        {
            WilId = int.Parse(Request.QueryString["wilid"]),
            WilType=TextBox1.Text,
            LetterMark = TextBox2.Text,
            WilTitle = TextBox3.Text,
            ImportScore = float.Parse(TextBox4.Text),
            SecondlyScore = float.Parse(TextBox5.Text),
            GeneralScore = float.Parse(TextBox6.Text),
            SomeimportScore = float.Parse(TextBox7.Text),
            NotinportScore = float.Parse(TextBox8.Text),
            WilOrder = int.Parse(TextBox9.Text)
        });
        Page.ClientScript.RegisterStartupScript(this.GetType(), "alert",
       success ? "<script>alert('修改成功！');</script>" : "<script>alert('修改失败！');</script>");

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        //add
        var success = new WilQuestionDal().Add(new WilTestQuestion()
        {
            WilType = TextBox1.Text,
            LetterMark = TextBox2.Text,
            WilTitle = TextBox3.Text,
            ImportScore = float.Parse(TextBox4.Text),
            SecondlyScore = float.Parse(TextBox5.Text),
            GeneralScore = float.Parse(TextBox6.Text),
            SomeimportScore = float.Parse(TextBox7.Text),
            NotinportScore = float.Parse(TextBox8.Text),
            WilOrder = int.Parse(TextBox9.Text)
        });
        Page.ClientScript.RegisterStartupScript(this.GetType(), "alert",
       success ? "<script>alert('添加成功！');</script>" : "<script>alert('添加失败！');</script>");
    }
}