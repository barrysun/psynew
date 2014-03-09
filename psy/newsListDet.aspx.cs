using Dal;
using java.lang;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class newsListDet : System.Web.UI.Page
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

        StringBuilder str = new StringBuilder();
        if (Request.QueryString["id"] != null)
        { 
        int type = 0;
        if (Request.QueryString["type"] != null && Request.QueryString["type"].ToString() != "")
        {
            string typeStr = Request.QueryString["type"].ToString();
            int.TryParse(typeStr, out type);
        }
        DataTable dt = null;
        switch (type)
        {
            case 1:
              //  Label1.Text = "高考志愿填报";
              //  new EntranceDal().BindNewLists(DataList1, AspNetPager1, " where ENTRANCETYPE=1 ");
                dt=new EntranceDal().getByWhereStr(" where Id="+Request.QueryString["id"].ToString());
                if (dt.Rows.Count == 1)
                {
                    str.append(" <div class=\"newTit\">");
                    str.append("     	<h4 class=\"bold14\">高考志愿填报 </h4>");
                    str.append("     </div>");
                    str.append("     <div class=\"article\">");
                    str.append("     	<div class=\"artTit\">");
                    str.append("         	<h3>" + dt.Rows[0]["TITLE"] + " &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + dt.Rows[0]["EditTime"] + "</h3><br/><br/>");
                    str.append("         </div>");
                    str.append("         <div class=\"artCont\">");
                    str.append("         	");
                    str.append("             	" + dt.Rows[0]["CONTENT"] + "");
                    str.append("             ");
                    str.append("        </div>");
                    str.append("    </div>");
                }


                break;
            case 2:
             //   Label1.Text = "心理减压";
             //   new EntranceDal().BindNewLists(DataList1, AspNetPager1, " where ENTRANCETYPE=2 ");
                dt = new EntranceDal().getByWhereStr(" where Id=" + Request.QueryString["id"].ToString());
                if (dt.Rows.Count == 1)
                {
                    str.append(" <div class=\"newTit\">");
                    str.append("     	<h4 class=\"bold14\">心理减压 </h4>");
                    str.append("     </div>");
                    str.append("     <div class=\"article\">");
                    str.append("     	<div class=\"artTit\">");
                    str.append("         	<h3>" + dt.Rows[0]["TITLE"] + " &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + dt.Rows[0]["EditTime"] + "</h3><br/><br/>");
                    str.append("         </div>");
                    str.append("         <div class=\"artCont\">");
                    str.append("         	");
                    str.append("             	" + dt.Rows[0]["CONTENT"] + "");
                    str.append("             ");
                    str.append("        </div>");
                    str.append("    </div>");
                }

                break;
            case 3:
              //  Label1.Text = "常用心理学";
              //  new EntranceDal().BindNewLists(DataList1, AspNetPager1, " where ENTRANCETYPE=3 ");
                dt = new EntranceDal().getByWhereStr(" where Id=" + Request.QueryString["id"].ToString());
                if (dt.Rows.Count == 1)
                {
                    str.append(" <div class=\"newTit\">");
                    str.append("     	<h4 class=\"bold14\">常用心理学 </h4>");
                    str.append("     </div>");
                    str.append("     <div class=\"article\">");
                    str.append("     	<div class=\"artTit\">");
                    str.append("         	<h3>" + dt.Rows[0]["TITLE"] + " &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + dt.Rows[0]["EditTime"] + "</h3><br/><br/>");
                    str.append("         </div>");
                    str.append("         <div class=\"artCont\">");
                    str.append("         	");
                    str.append("             	" + dt.Rows[0]["CONTENT"] + "");
                    str.append("             ");
                    str.append("        </div>");
                    str.append("    </div>");
                }

                break;
            case 4:
               // Label1.Text = "应聘面试";
                dt = new CommunityDal().getByWhereStr(" where Id=" + Request.QueryString["id"].ToString());
                     if (dt.Rows.Count == 1)
                {
                    str.append(" <div class=\"newTit\">");
                    str.append("     	<h4 class=\"bold14\">应聘面试 </h4>");
                    str.append("     </div>");
                    str.append("     <div class=\"article\">");
                    str.append("     	<div class=\"artTit\">");
                    str.append("         	<h3>" + dt.Rows[0]["TITLE"] + " &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + dt.Rows[0]["EditTime"] + "</h3><br/><br/>");
                    str.append("         </div>");
                    str.append("         <div class=\"artCont\">");
                    str.append("         	");
                    str.append("             	" + dt.Rows[0]["CONTENT"] + "");
                    str.append("             ");
                    str.append("        </div>");
                    str.append("    </div>");
                }
                break;
            case 5:
               // Label1.Text = "职业介绍";
                dt = new CommunityDal().getByWhereStr(" where Id=" + Request.QueryString["id"].ToString());
                if (dt.Rows.Count == 1)
                {
                    str.append(" <div class=\"newTit\">");
                    str.append("     	<h4 class=\"bold14\">职业介绍 </h4>");
                    str.append("     </div>");
                    str.append("     <div class=\"article\">");
                    str.append("     	<div class=\"artTit\">");
                    str.append("         	<h3>" + dt.Rows[0]["TITLE"] + " &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + dt.Rows[0]["EditTime"] + "</h3><br/><br/>");
                    str.append("         </div>");
                    str.append("         <div class=\"artCont\">");
                    str.append("         	");
                    str.append("             	" + dt.Rows[0]["CONTENT"] + "");
                    str.append("             ");
                    str.append("        </div>");
                    str.append("    </div>");
                }
                break;
            case 6:
                 dt = new EntranceDal().getByWhereStr(" where Id=" + Request.QueryString["id"].ToString());
                if (dt.Rows.Count == 1)
                {
                    str.append(" <div class=\"newTit\">");
                    str.append("     	<h4 class=\"bold14\">会员服务 </h4>");
                    str.append("     </div>");
                    str.append("     <div class=\"article\">");
                    str.append("     	<div class=\"artTit\">");
                    str.append("         	<h3>" + dt.Rows[0]["TITLE"] + " &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + dt.Rows[0]["EditTime"] + "</h3><br/><br/>");
                    str.append("         </div>");
                    str.append("         <div class=\"artCont\">");
                    str.append("         	");
                    str.append("             	" + dt.Rows[0]["CONTENT"] + "");
                    str.append("             ");
                    str.append("        </div>");
                    str.append("    </div>");
                }
                break;
            default:
               //
                
           dt= new NewsDal().getById(int.Parse(Request.QueryString["id"]));
           if (dt.Rows.Count == 1)
           {
               str.append(" <div class=\"newTit\">");
               str.append("     	<h4 class=\"bold14\">新闻动态 </h4>");
               str.append("     </div>");
               str.append("     <div class=\"article\">");
               str.append("     	<div class=\"artTit\">");
               str.append("         	<h3>" + dt.Rows[0]["NewTitle"] + " &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + dt.Rows[0]["EditTime"] + "</h3><br/><br/>");
               str.append("         </div>");
               str.append("         <div class=\"artCont\">");
               str.append("         	");
               if (dt.Rows[0]["PICUrl"] != null && dt.Rows[0]["PICUrl"].ToString() != "")
               {
                   str.append(" &nbsp;&nbsp;&nbsp;    <img src= \"newpic/" + dt.Rows[0]["PICUrl"] + "\"/>");
               }
               str.append("             	"+dt.Rows[0]["NewContent"]+"");
               str.append("             ");
               str.append("        </div>");
               str.append("    </div>");
           }
                break;
         }
        }
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

    public string redian()
    {
        StringBuilder str = new StringBuilder();
        DataTable dt = new NewsDal().getNewsHome(" where PICUrl is not null and PICUrl !=''  order by Id limit 0,1");
        str.append(" <h4 class=\"bold14\">热点新闻</h4>");
        str.append("    <p><a href=\"newsListDet.aspx?id=" + dt.Rows[0]["Id"] + "\"><img src=\"newpic/" + dt.Rows[0]["PICUrl"] + "\" width=\"100%\" /></a></p>");
        str.append("     <p>发布时间：" + dt.Rows[0]["EditTime"] + "</p>");
        str.append("     <div class=\"hotCont\">");
        str.append("     	" + dt.Rows[0]["NewContent"] + "");
        str.append("     </div>");
        str.append("     <div class=\"detBtn\">");
        str.append("     	<a href=\"newsListDet.aspx?id=" + dt.Rows[0]["Id"] + "\">查看详情</a>");
        str.append("     </div>");

        return str.toString();

    }
}