using Dal;
using Model;
using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class myInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    /// <summary>
    /// 保存
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    

    protected void Button1_Click1(object sender, EventArgs e)
    {
        //Response.Cookies["User"]

        if (Session["Id"] == null || Session["Id"].ToString() == "")
            Response.Redirect("login.aspx");

        switch (int.Parse(Response.Cookies["User"]["Role"].ToString()))
        {
            case 1:
                Company company = new Company();
                company.Id = int.Parse(Session["Id"].ToString());
                company.Password=TextBox1.Text.Trim();
                if (new CompanyDal().UpdatePassword(company))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("", "修改密码成功！"));
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("", "修改密码失败！"));
                }
                break;
            case 2:
                NUser user = new NUser();
                user.Id = int.Parse(Session["Id"].ToString());
                user.Password = TextBox1.Text.Trim();
                if (new NUserDal().UpdatePassword(user))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("", "修改密码成功！"));
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("", "修改密码失败！"));
                }
                break;
        }
    }
}