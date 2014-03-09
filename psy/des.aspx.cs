using Dal;
using java.lang;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class talentList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public string bindnav()
    {
        return Nav.NavStr();
    }

    public string bind()
    { 
        StringBuilder str=new StringBuilder();
        string name = "";
        switch (int.Parse(Request.QueryString["id"]))
        {
            case 1: name = "职业测评专栏"; break;
            case 2: name = "职业培训"; break;
            case 3: name = "人生规划研究中心"; break;
            case 4: name = "关于我们"; break;
        }
    str.append("<div class=\"curmbs\">");
	str.append("<span>您现在所在的位置：</span>");
    str.append("<a href=\"index.aspx\">首页</a>");
    str.append("<span>&gt;</span>");
   

    str.append("<span>"+name+"</span>");
    str.append("</div>");
    str.append("<div class=\"content clearfix\">");
    str.append(" <div class=\"tabs1 platform\">");
    str.append(" 	<ul class=\"tab_menu studyTit clearfix\">");
    str.append("         <li class=\"current\"><a href=\"javascript:;\">"+name+"</a></li>");
    str.append("        ");
    str.append("     </ul>");
    str.append("     <div class=\"tab_box\">");
    str.append(new DesDal().GetDes(int.Parse(Request.QueryString["id"])));
    str.append("     </div>");
    str.append(" </div>");
    str.append("</div>");
        return str.toString();
    
    }

    /// <summary>
    /// 快速登陆
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button1_Click(object sender, EventArgs e)
    {
        string UserName = TextBox1.Text;
        string Password = TextBox2.Text;
        //  int role = 0;//1是企业
        //2是个人用户

        DataTable dt = new NUserDal().Login(UserName, Password);
        if (dt != null && dt.Rows.Count == 1)
        {
            Session["Role"] = 2+"";
            Session["UserName"] = UserName;
            Session["Password"] = Password;
            Session["Id"] = dt.Rows[0]["Id"].ToString();
            Response.Redirect("myTest.aspx");
        }

        DataTable dt2 = new CompanyDal().Login(UserName, Password);
        if (dt2 != null && dt2.Rows.Count == 1)
        {
            Session["Role"] = 1 + "";
            Session["UserName"] = UserName;
            Session["Password"] = Password;
            Session["Id"] = dt2.Rows[0]["Id"].ToString();
            Response.Redirect("firmInfo.aspx");
        }
        Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("", "登陆失败，请检查用户名密码是否有误！", "error"));

    }
}