using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Dal;
using Model;

public partial class admin_IpTestQuestionUpdate : System.Web.UI.Page
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
        if (Request.QueryString["ipid"] != null && Request.QueryString["ipid"].ToString() != "")
        {
            Button1.Visible = true;
            Button2.Visible = false;

            string ipid = Request.QueryString["ipid"].Trim();
            DataTable dt = new IpQuestionDal().GetById(ipid);
            if (dt != null && dt.Rows.Count > 0)
            {
                TextBox1.Text = dt.Rows[0]["IPTYPE"].ToString();
                TextBox2.Text = dt.Rows[0]["IPTITLE"].ToString();
                TextBox3.Text = dt.Rows[0]["LIKESCORE"].ToString();
                TextBox4.Text = dt.Rows[0]["NOTLIKESCORE"].ToString();
                TextBox5.Text = dt.Rows[0]["UNCERTAINSCORE"].ToString();
                TextBox6.Text = dt.Rows[0]["IPORDER"].ToString();
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
        //update
        var success = new IpQuestionDal().Update(new IpTestQuestion()
        {
            IpId=int.Parse(Request.QueryString["ipid"]),
            IpType=TextBox1.Text,
            IpTitle = TextBox2.Text,
            IpOrder = int.Parse(TextBox6.Text),
            LikeScore = float.Parse(TextBox3.Text),
            NotLikeScore = float.Parse(TextBox4.Text),
            UncertainScore = float.Parse(TextBox5.Text)
        });

        Page.ClientScript.RegisterStartupScript(this.GetType(), "alert",
         success ? "<script>alert('修改成功！');</script>" : "<script>alert('修改失败！');</script>");

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        //add
        var success = new IpQuestionDal().Add(new IpTestQuestion()
        {
           // IpId = int.Parse(Request.QueryString["ipid"]),
            IpType = TextBox1.Text,
            IpTitle = TextBox2.Text,
            IpOrder = int.Parse(TextBox6.Text),
            LikeScore = float.Parse(TextBox3.Text),
            NotLikeScore = float.Parse(TextBox4.Text),
            UncertainScore = float.Parse(TextBox5.Text)
        });

        Page.ClientScript.RegisterStartupScript(this.GetType(), "alert",
         success ? "<script>alert('添加成功！');</script>" : "<script>alert('添加失败！');</script>");
    }
}