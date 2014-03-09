using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Data;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class myInfo3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["Id"] == null || Session["Id"].ToString() == "")
                Response.Redirect("login.aspx");
            bind();
        }
    }

    public void bind()
    {
        DataTable dt = new NUserDal().Query(" where Id=" + Session["Id"]);
        if (dt != null && dt.Rows.Count == 1)
        {
            TextBox1.Text = dt.Rows[0]["ShuKan"].ToString();
            TextBox2.Text = dt.Rows[0]["XiangMu"].ToString();
            TextBox3.Text = dt.Rows[0]["YongYu"].ToString();
            TextBox4.Text = dt.Rows[0]["Peixun"].ToString();
        
        }
    
    }
    /// <summary>
    /// 保存
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Session["Id"] == null || Session["Id"].ToString() == "")
            Response.Redirect("login.aspx");

        NUser user = new NUser();
        user.Peixun = TextBox4.Text;
        user.YongYu = TextBox3.Text;
        user.XiangMu = TextBox2.Text;
        user.ShuKan = TextBox1.Text;
        user.Id = int.Parse(Session["Id"].ToString());

        if (new NUserDal().UpdateUserInfo3(user))
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("", "保存成功！"));
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("", "保存失败！"));
        }

    }
}