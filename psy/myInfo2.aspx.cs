using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Data;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class myInfo2 : System.Web.UI.Page
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
        if (Session["Id"] == null || Session["Id"].ToString() == "")
            Response.Redirect("login.aspx");

        DataTable dt = new NUserDal().Query(" where Id=" + Session["Id"]);
        if (dt != null && dt.Rows.Count == 1)
        {
            TextBox1.Text = dt.Rows[0]["Danwei"].ToString();
            TextBox2.Text = dt.Rows[0]["Zhiwu"].ToString();
            TextBox3.Text = dt.Rows[0]["Xinzi"].ToString();
            TextBox5.Text = dt.Rows[0]["GongZuo"].ToString();
            TextBox4.Text = dt.Rows[0]["Zuogongzuo"].ToString();
        
        }

    }
    /// <summary>
    /// 添加
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Session["Id"] == null || Session["Id"].ToString() == "")
            Response.Redirect("login.aspx");

        NUser user = new NUser();
        user.Danwei = TextBox1.Text;
        user.Zhiwu = TextBox2.Text;
        user.Xinzi = TextBox3.Text;
        user.Zuogongzuo = TextBox4.Text;
        user.GongZuo = TextBox5.Text;
        user.Id = int.Parse(Session["Id"].ToString());

        if (new NUserDal().UpdateUserInfo2(user))
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("", "保存成功！"));
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("", "保存失败！"));
        }
     
    }
}