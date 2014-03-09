using Dal;
using java.lang;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class myReport3 : System.Web.UI.Page
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
        if (Session["Id"] == null)
        {
            Response.Redirect("~/login.aspx");
        }

        DataTable dt = new NUserDal().Query(" where Id=" + Session["Id"]);
        Label1.Text = dt.Rows[0]["RealName"].ToString();
        Label2.Text = dt.Rows[0]["Gender"].ToString() == "1" ? "男" : "女";
        Label3.Text = dt.Rows[0]["BorthDay"].ToString();

        DataTable dt2=new MySQLHelper().GetDataTable("select * from matchreport where ID="+Request.QueryString["Id"]);

        Label4.Text = dt2.Rows[0]["MATCHTIME"].ToString();
    }


    public string ReportView()
    {
        StringBuilder str = new StringBuilder();
        Dictionary<string, string> dic = new RepostDal().MatchReportView(int.Parse(Request.QueryString["Id"].ToString().Trim()));
        str.append("<div class=\"detCont\">");
        str.append("<span class=\"bold14\">你和 " + new MySQLHelper().GetDataTable("select TITLE from jobview,matchreport  where matchreport.JOBID=jobview.JOBID and  matchreport.ID=" + Request.QueryString["Id"].ToString()).Rows[0]["TITLE"] + " 总体匹配度: " + dic["MATCHRP"] + "</span>");
        str.append("</div>");
        str.append("<br/>");
        int j = 0;
        str.append("<div class=\"detCont\">");
        str.append("<span class=\"bold14\">{0}</span><br/>");
        str.append("</div>");
        if (dic.ContainsKey("SYL04MCHVal") && (int)double.Parse(dic["SYL04MCHVal"].ToString()) == 1)
        {
            j++;
            str.append("<div class=\"detCont\">");
            str.append("●   " +dic["SYL04RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SYL13MCHVal") && (int)double.Parse(dic["SYL13MCHVal"].ToString()) == 1)
        {
            j++;
            str.append("<div class=\"detCont\">");
            str.append("●   " + dic["SYL13RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SYL14MCHVal") && (int)double.Parse(dic["SYL14MCHVal"].ToString()) == 1)
        {
            j++;
            str.append("<div class=\"detCont\">");
            str.append("●   " + dic["SYL14RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SYL06MCHVal") && (int)double.Parse(dic["SYL06MCHVal"].ToString()) == 1)
        {
            j++;
            str.append("<div class=\"detCont\">");
            str.append("●   " + dic["SYL06RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SYL16MCHVal") && (int)double.Parse(dic["SYL16MCHVal"].ToString()) == 1)
        {
            j++;
            str.append("<div class=\"detCont\">");
            str.append("●   " + dic["SYL16RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }

        if (dic.ContainsKey("SKL30MCHVal") && (int)double.Parse(dic["SKL30MCHVal"].ToString()) == 1)
        {
            j++;
            str.append("<div class=\"detCont\">");
            str.append("●   " + dic["SKL30RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SKL21MCHVal")  && (int)double.Parse(dic["SKL21MCHVal"].ToString()) == 1)
        {
            j++;
            str.append("<div class=\"detCont\">");
            str.append("●   " + dic["SKL21RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SYL03MCHVal")  && (int)double.Parse(dic["SYL03MCHVal"].ToString()) == 1)
        {
            j++;
            str.append("<div class=\"detCont\">");
            str.append("●   " + dic["SYL03RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SYL07MCHVal") && (int)double.Parse(dic["SYL07MCHVal"].ToString()) == 1)
        {
            j++;
            str.append("<div class=\"detCont\">");
            str.append("●   " + dic["SYL07RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SYL08MCHVal")  && (int)double.Parse(dic["SYL08MCHVal"].ToString()) == 1)
        {
            j++;
            str.append("<div class=\"detCont\">");
            str.append("●   " + dic["SYL08RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SYL09MCHVal")  && (int)double.Parse(dic["SYL09MCHVal"].ToString()) == 1)
        {
            j++;
            str.append("<div class=\"detCont\">");
            str.append("●   " + dic["SYL09RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SYL10MCHVal")  && (int)double.Parse(dic["SYL10MCHVal"].ToString()) == 1)
        {
            j++;
            str.append("<div class=\"detCont\">");
            str.append("●   " + dic["SYL10RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SYL11MCHVal")  && (int)double.Parse(dic["SYL11MCHVal"].ToString()) == 1)
        {
            j++;
            str.append("<div class=\"detCont\">");
            str.append("●   " + dic["SYL11RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SYL12MCHVal")  && (int)double.Parse(dic["SYL12MCHVal"].ToString()) == 1)
        {
            j++;
            str.append("<div class=\"detCont\">");
            str.append("●   " + dic["SYL12RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SYL15MCHVal") && (int)double.Parse(dic["SYL15MCHVal"].ToString()) == 1)
        {
            j++;
            str.append("<div class=\"detCont\">");
            str.append("●   " + dic["SYL15RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SKL19MCHVal") && (int)double.Parse(dic["SKL19MCHVal"].ToString()) == 1)
        {
            j++;
            str.append("<div class=\"detCont\">");
            str.append("●   " + dic["SKL19RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SYL02MCHVal") && (int)double.Parse(dic["SYL02MCHVal"].ToString()) == 1)
        {
            j++;
            str.append("<div class=\"detCont\">");
            str.append("●   " + dic["SYL02RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SKL11MCHVal") && (int)double.Parse(dic["SKL11MCHVal"].ToString()) == 1)
        {
            j++;
            str.append("<div class=\"detCont\">");
            str.append("●   " + dic["SKL11RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SKL01MCHVal")  && (int)double.Parse(dic["SKL01MCHVal"].ToString()) == 1)
        {
            j++;
            str.append("<div class=\"detCont\">");
            str.append("●   " + dic["SKL01RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SYL05MCHVal")  && (int)double.Parse(dic["SYL05MCHVal"].ToString()) == 1)
        {
            j++;
            str.append("<div class=\"detCont\">");
            str.append("●   " + dic["SYL05RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SYL01MCHVal")  && (int)double.Parse(dic["SYL01MCHVal"].ToString()) == 1)
        {
            j++;
            str.append("<div class=\"detCont\">");
            str.append("●   " + dic["SYL01RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        //第二部分
        str.append("<br/>");
        str.append("<div class=\"detCont\">");
        str.append("<span class=\"bold14\">{1}</span><br/>");
        str.append("</div>");
        int i = 0;
        if (dic.ContainsKey("SYL04MCHVal") && (int)double.Parse(dic["SYL04MCHVal"].ToString()) == -1)
        {
            i++;
            str.append("<div class=\"detCont\">");
            str.append("         ●   " + dic["SYL04RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SYL13MCHVal")  && (int)double.Parse(dic["SYL13MCHVal"].ToString()) == -1)
        {
            i++;
            str.append("<div class=\"detCont\">");
            str.append("         ●   " + dic["SYL13RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SYL14MCHVal") && (int)double.Parse(dic["SYL14MCHVal"].ToString()) == -1)
        {
            i++;
            str.append("<div class=\"detCont\">");
            str.append("         ●   " + dic["SYL14RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SYL06MCHVal") && (int)double.Parse(dic["SYL06MCHVal"].ToString()) == -1)
        {
            i++;
            str.append("<div class=\"detCont\">");
            str.append("         ●   " + dic["SYL06RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SYL16MCHVal") && (int)double.Parse(dic["SYL16MCHVal"].ToString()) == -1)
        {
            i++;
            str.append("<div class=\"detCont\">");
            str.append("         ●   " + dic["SYL16RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SKL30MCHVal")  && (int)double.Parse(dic["SKL30MCHVal"].ToString()) == -1)
        {
            i++;
            str.append("<div class=\"detCont\">");
            str.append("         ●   " + dic["SKL30RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SKL21MCHVal")&& (int)double.Parse(dic["SKL21MCHVal"].ToString()) == -1)
        {
            i++;
            str.append("<div class=\"detCont\">");
            str.append("         ●   " + dic["SKL21RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SYL03MCHVal")  && (int)double.Parse(dic["SYL03MCHVal"].ToString()) == -1)
        {
            i++;
            str.append("<div class=\"detCont\">");
            str.append("         ●   " + dic["SYL03RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SYL07MCHVal")  && (int)double.Parse(dic["SYL07MCHVal"].ToString()) == -1)
        {
            i++;
            str.append("<div class=\"detCont\">");
            str.append("         ●   " + dic["SYL07RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SYL08MCHVal")  && (int)double.Parse(dic["SYL08MCHVal"].ToString()) == -1)
        {
            i++;
            str.append("<div class=\"detCont\">");
            str.append("         ●   " + dic["SYL08RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SYL09MCHVal")  && (int)double.Parse(dic["SYL09MCHVal"].ToString()) == -1)
        {
            i++;
            str.append("<div class=\"detCont\">");
            str.append("         ●   " + dic["SYL09RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SYL10MCHVal")  && (int)double.Parse(dic["SYL10MCHVal"].ToString()) == -1)
        {
            i++;
            str.append("<div class=\"detCont\">");
            str.append("         ●   " + dic["SYL10RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SYL11MCHVal") && (int)double.Parse(dic["SYL11MCHVal"].ToString()) == -1)
        {
            i++;
            str.append("<div class=\"detCont\">");
            str.append("         ●   " + dic["SYL11RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SYL12MCHVal")&& (int)double.Parse(dic["SYL12MCHVal"].ToString()) == -1)
        {
            i++;
            str.append("<div class=\"detCont\">");
            str.append("         ●   " + dic["SYL12RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SYL15MCHVal")  && (int)double.Parse(dic["SYL15MCHVal"].ToString()) == -1)
        {
            i++;
            str.append("<div class=\"detCont\">");
            str.append("         ●   " + dic["SYL15RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SKL19MCHVal") && (int)double.Parse(dic["SKL19MCHVal"].ToString()) == -1)
        {
            i++;
            str.append("<div class=\"detCont\">");
            str.append("         ●   " + dic["SKL19RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SYL02MCHVal")  && (int)double.Parse(dic["SYL02MCHVal"].ToString()) == -1)
        {
            i++;
            str.append("<div class=\"detCont\">");
            str.append("         ●   " + dic["SYL02RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SKL11MCHVal")  && (int)double.Parse(dic["SKL11MCHVal"].ToString()) == -1)
        {
            i++;
            str.append("<div class=\"detCont\">");
            str.append("         ●   " + dic["SKL11RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SKL01MCHVal") && (int)double.Parse(dic["SKL01MCHVal"].ToString()) == -1)
        {
            i++;
            str.append("<div class=\"detCont\">");
            str.append("         ●   " + dic["SKL01RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SYL05MCHVal")  && (int)double.Parse(dic["SYL05MCHVal"].ToString()) == -1)
        {
            i++;
            str.append("<div class=\"detCont\">");
            str.append("         ●   " + dic["SYL05RPDes"].ToString() + "<br/>");
            str.append("</div>");
        }
        if (dic.ContainsKey("SYL01MCHVal")  && (int)double.Parse(dic["SYL01MCHVal"].ToString()) == -1)
        {
            i++;
            str.append("<div class=\"detCont\">");
            str.append("         ●   " + dic["SYL01RPDes"].ToString() );
            str.append("</div>");
        }

        return string.Format(str.toString(), (j == 0) ? "" : "如果你打算选择这个职业，在工作方面，你最具“优势”的个人特质是：", (i == 0) ? "" : "如果你打算选择这个职业，在工作方面，你尤其需要注意”改进“的是：");
       // return str.toString();

    }

   
}