using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class specialty : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bind();
        }
    }

    public string bindnav()
    {
        return Nav.NavStr();
    }

    public void bind()
    {
        string text = TextBox3.Text;
        if (text != null && text != "")
        {
            text = " where TITLE3 like '%" + text + "%'";
        }
        else {
            text = "";
        }
        new ProfessionalDesDal().BindPager(Repeater1, AspNetPager1, text);
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
            Session["Role"] = 2 + "";
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

    public string bindMenu()
    {
        StringBuilder str = new StringBuilder();
        str.Append("<div class=\"oneMenu\">");
        DataTable dt1 = new ProfessionalDesDal().getTitle1();
        StringBuilder strTitle2 = new StringBuilder();
        for (int i = 0; i < dt1.Rows.Count; i++)
        {
            if (i == 0)
            {
                str.Append("<a class=\"on\" id=\"a"+(i+1)+"\" href=\"#\">" + dt1.Rows[0]["TITLE1"] + "</a>");
            }
            else
            {
                str.Append("<a id=\"a"+(i+1)+"\" href=\"\">理科</a>");
            }
        }
    str.Append(" </div>");
     str.Append("<div class=\"twoMenu\">");
     for (int i = 0; i < dt1.Rows.Count; i++)
     {
         DataTable dt2 = new ProfessionalDesDal().getTitle2(dt1.Rows[0]["TITLE1"].ToString());
         str.Append("<div class=\"a" + (i + 1) + " hide\">");
         for (int j = 0; j < dt2.Rows.Count; j++)
         {
          
                 str.Append("     <a id=\"a" + (i + 1) + "_" + (j + 1) + "\" href=\"\">"+dt2.Rows[j]["TITLE2"]+"</a>");

         }
         str.Append("  </div>");
     }
    str.Append(" </div>");
    str.Append(" <div class=\"threeMenu\">");

    for (int i = 0; i < dt1.Rows.Count; i++)
    {
        DataTable dt2 = new ProfessionalDesDal().getTitle2(dt1.Rows[i]["TITLE1"].ToString());
        for (int j = 0; j < dt2.Rows.Count; j++)
        {
            DataTable dt3 = new ProfessionalDesDal().getTitle3(dt2.Rows[j]["TITLE2"].ToString());
            str.Append("<div class=\"a" + (i + 1) + "_"+(j+1)+" hide\">");
            for (int x = 0; x < dt3.Rows.Count; x++)
            {
                    str.Append("     <a  href=\"#\">"+dt3.Rows[x]["TITLE3"]+"</a>");
            }
            str.Append("  </div>");
           
        }
    }
     str.Append("</div>");

     return str.ToString();



    }
  /// <summary>
  /// 查询
  /// </summary>
  /// <param name="sender"></param>
  /// <param name="e"></param>
    protected void Button2_Click(object sender, EventArgs e)
    {
        bind();
    }

    /// <summary>
    /// 绑定
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        bind();
    }
}