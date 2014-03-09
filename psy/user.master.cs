using java.lang;
using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            if (Session["Id"] != null && Session["Id"].ToString() != "")
            {

            }
            else
            {
                Response.Redirect("index.aspx");
            }
            if (Session["Role"] != null && Session["Role"].ToString() != "")
            {

            }
            else
            {
                Response.Redirect("index.aspx");
            }
        }
    }

    public string navStr()
    {

        int type = int.Parse(Session["Role"].ToString());
           
           
        StringBuilder str = new StringBuilder();
        if (type == 1)
        {
            //企业
            //str.append("<a class=\"navFirst\" href=\"#\">首页</a>");
            str.append("<dl class=\"navFirst \"><dt><a class=\" current\" href=\"firmInfo.aspx\">招聘管理</a></dt></dl>");
            str.append("<dl><dt><a href=\"myPay.aspx\">支付与服务</a></dt></dl>");
            str.append("<dl><dt><a href=\"talentback.aspx\">找人才</a></dt></dl>");
            str.append("<dl><dt><a href=\"firmInfo1.aspx\">企业信息管理</a></dt></dl>");
            str.append("<dl><dt><a href=\"mima.aspx\">密码管理</a></dt></dl>");
        }
        else { 
        //str.append("<a class=\"navFirst\" href=\"#\">首页</a>");
            str.append("<dl class=\"navFirst\"><dt><a  href=\"myTest.aspx\">职业选择及定位</a></dt></dl>");
            str.append("<dl><dt><a  href=\"myJobs.aspx\">我的求职</a></dt></dl>");
    //talentback2.aspx
            str.append("<dl><dt><a href=\"myPay.aspx\">报告购买</a></dt></dl>");
           // str.append("<dl><dt><a  href=\"talentback2.aspx\">找工作</a></dt></dl>");

            str.append("<dl><dt> <a href=\"myInfo.aspx\">完备个人信息</a></dt></dl>");
   //str.append(" <a href=\"\">会员服务</a>");
            str.append(" <dl><dt><a href=\"mima.aspx\">密码管理</a></dt></dl>");
            str.append(" <dl><dt><a href=\"rensheng.aspx\">常见问题</a></dt></dl>");
         
        }

        return str.toString();
    
    }
    /// <summary>
    /// 退出
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
       Session.Clear();
        Response.Redirect("login.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("index.aspx");
    }
}
