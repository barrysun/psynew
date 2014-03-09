using Dal;
using java.lang;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Question : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        { 
           //判断是否答题完成如果答题完成返回的Test.aspx页面
            if (Session["Id"] == null)
            {
                Response.Redirect("~/index.aspx");
            }
            else
            {
                string sql = "select count(*) from nuser where Id=" + Session["Id"] + " and IPORDER = 'over' and WILORDER='over' and EQIORDER='over' ";
                if (int.Parse(new MySQLHelper().ExecuteValue(sql)) == 1)
                {
                    Response.Redirect("myTest.aspx");
                }
            }
        }
    }

    public string strFilePath = "~/tep/ip.temp";

    public string HtmlTep(string path)
    {
        return File.ReadAllText(Server.MapPath(path));
    }

    public string getTitle()
    {
        return addIpAnswer();
    }
    /// <summary>
    /// 返回HTML代码如果查询的题为空，这返回null
    /// </summary>
    /// <param name="startRow"></param>
    /// <param name="pageSize"></param>
    /// <returns></returns>
    private  string IpTitleHtml(int startRow, int pageSize)
    {
       DataTable dt= new IpQuestionDal().getIpQuestions(startRow,pageSize);
       StringBuilder str = new StringBuilder("<br><input type=\"hidden\" name=\"type\"  value=\"ip\"/>");
          StringBuilder titleStr=new StringBuilder();
           if (dt == null || dt.Rows.Count == 0) return null;
           for (int i = 0; i < dt.Rows.Count; i++)
           {
               str.append("<div class=\"qusList\">");
               
               str.append("<h3 class=\"qlTit\"><span>"+dt.Rows[i]["IPORDER"]+"、</span> &nbsp;&nbsp;&nbsp;&nbsp;"+dt.Rows[i]["IPTITLE"] + "<input type=\"hidden\" name=\"IPN_" + dt.Rows[i]["IPORDER"] + "\" value=\"" + dt.Rows[i]["IPID"] + "\"/></h3>");
               str.append("<ul class=\"answer clearfix\">");
               str.append("<li><input type=\"radio\" onclick=\"checkAnswer('title_"+(dt.Rows[i]["IPORDER"])+"');\"  name=\"IP_" + dt.Rows[i]["IPID"] + "\" id=\"IP_" + dt.Rows[i]["IPID"] + "_1\" value=\"喜欢#" + dt.Rows[i]["LIKESCORE"] + "\"> <label for=\"IP_" + dt.Rows[i]["IPID"] + "_1\">喜欢</label></li>");
               str.append("<li><input type=\"radio\" onclick=\"checkAnswer('title_" + (dt.Rows[i]["IPORDER"]) + "');\" name=\"IP_" + dt.Rows[i]["IPID"] + "\" id=\"IP_" + dt.Rows[i]["IPID"] + "_2\" value=\"不喜欢#" + dt.Rows[i]["NOTLIKESCORE"] + "\"> <label for=\"IP_" + dt.Rows[i]["IPID"] + "_2\">不喜欢</label></li>");
               str.append("<li><input type=\"radio\" onclick=\"checkAnswer('title_" + (dt.Rows[i]["IPORDER"]) + "');\" name=\"IP_" + dt.Rows[i]["IPID"] + "\" id=\"IP_" + dt.Rows[i]["IPID"] + "_3\" value=\"不确定#" + dt.Rows[i]["UNCERTAINSCORE"] + "\"> <label for=\"IP_" + dt.Rows[i]["IPID"] + "_3\">不确定</label></li>");
               str.append("</ul>");
               str.append("</div>");
               titleStr.append("<span id=\"title_"+(dt.Rows[i]["IPORDER"])+"\">" + (dt.Rows[i]["IPORDER"]) + "</span> &nbsp;");
           }
      //  return str.toString();
           return HtmlTep("~/temp/ip.temp").Replace("#{IPHTML}#",str.toString()).Replace("#{TITLESTR}#",titleStr.toString());
    }
    /// <summary>
    /// 返回HTML代码如果查询的题目为空，则返回null
    /// </summary>
    /// <param name="startRow"></param>
    /// <param name="pageSize"></param>
    /// <returns></returns>
    private string WilTitleHtml(int startRow, int pageSize)
    {

        DataTable dt = new WilQuestionDal().getByStarRowAndEndRow(startRow.ToString(), pageSize.ToString());
        StringBuilder str =new StringBuilder();
        StringBuilder titleStr = new StringBuilder();
        if (dt != null && dt.Rows.Count > 0)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str.append("<option value=\""+dt.Rows[i]["WILID"]+"\">"+dt.Rows[i]["WILTITLE"]+"</option>");
              
            }
            return HtmlTep("~/temp/wil.temp").Replace("#{WILOPTIONS}#", str.toString());
        }
        return null;
    }

    /// <summary>
    /// 返回HTML代码如果查询的题目为空，则返回null
    /// </summary>
    /// <param name="startRow"></param>
    /// <param name="pageSize"></param>
    /// <returns></returns>
    public string EqiTitleHtml(int startRow, int pageSize)
    {
        DataTable dt = new EqiQuestionDal().getEqiQuestion(startRow, pageSize);
        if (dt != null && dt.Rows.Count > 0)
        {
            StringBuilder str = new StringBuilder();
            StringBuilder titleStr = new StringBuilder();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str.append("<div class=\"qusList\">");

                str.append("<h3 class=\"qlTit\"><span>" + dt.Rows[i]["EQIORDER"] + "、</span> &nbsp;&nbsp;&nbsp;&nbsp;" + dt.Rows[i]["EQITITLE"] + "<input type=\"hidden\" name=\"EQIN_" + dt.Rows[i]["EQIORDER"] + "\" value=\"" + dt.Rows[i]["EQIID"] + "\"/></h3>");
                str.append("<ul class=\"answer clearfix\">");
                str.append("<li><input type=\"radio\"  onclick=\"checkAnswer('title_" + (dt.Rows[i]["EQIORDER"]) + "');\"  name=\"EQI_" + dt.Rows[i]["EQIID"] + "\" id=\"EQI_" + dt.Rows[i]["EQIID"] + "_1\" value=\"非常符合#" + dt.Rows[i]["VERYSCORE"] + "\"> <label for=\"EQI_" + dt.Rows[i]["EQIID"] + "_1\">非常符合</label></li>");
                str.append("<li><input type=\"radio\"  onclick=\"checkAnswer('title_" + (dt.Rows[i]["EQIORDER"]) + "');\"  name=\"EQI_" + dt.Rows[i]["EQIID"] + "\" id=\"EQI_" + dt.Rows[i]["EQIID"] + "_2\" value=\"基本符合#" + dt.Rows[i]["BASICSCORE"] + "\"> <label for=\"EQI_" + dt.Rows[i]["EQIID"] + "_2\">基本符合</label></li>");
                str.append("<li><input type=\"radio\"  onclick=\"checkAnswer('title_" + (dt.Rows[i]["EQIORDER"]) + "');\"  name=\"EQI_" + dt.Rows[i]["EQIID"] + "\" id=\"EQI_" + dt.Rows[i]["EQIID"] + "_3\" value=\"有时符合#" + dt.Rows[i]["SOMETIMESCORE"] + "\"> <label for=\"EQI_" + dt.Rows[i]["EQIID"] + "_3\">有时符合</label></li>");
                str.append("<li><input type=\"radio\"  onclick=\"checkAnswer('title_" + (dt.Rows[i]["EQIORDER"]) + "');\"  name=\"EQI_" + dt.Rows[i]["EQIID"] + "\" id=\"EQI_" + dt.Rows[i]["EQIID"] + "_4\" value=\"不太符合#" + dt.Rows[i]["DOESNOTSCORE"] + "\"> <label for=\"EQI_" + dt.Rows[i]["EQIID"] + "_4\">不太符合</label></li>");
                str.append("<li><input type=\"radio\"  onclick=\"checkAnswer('title_" + (dt.Rows[i]["EQIORDER"]) + "');\"  name=\"EQI_" + dt.Rows[i]["EQIID"] + "\" id=\"EQI_" + dt.Rows[i]["EQIID"] + "_5\" value=\"不符合#" + dt.Rows[i]["NOTSCORE"] + "\"> <label for=\"EQI_" + dt.Rows[i]["EQIID"] + "_5\">不符合</label></li>");
                str.append("</ul>");
                str.append("</div>");
                titleStr.append("<span id=\"title_" + (dt.Rows[i]["EQIORDER"]) + "\">" + (dt.Rows[i]["EQIORDER"]) + "</span> &nbsp;");
            }
            return HtmlTep("~/temp/eqi.temp").Replace("#{IPHTML}#", str.toString()).Replace("#{TITLESTR}#", titleStr.toString());
        }

        return null;
    }
    /// <summary>
    /// 执行添加ip测试题答案
    /// </summary>
    /// <returns></returns>
    public string addIpAnswer()
    {
        if (Session["Id"] == null || Session["Id"].ToString() == "")
            Response.Redirect("login.aspx");

        int userid = int.Parse(Session["Id"].ToString());
        string iporder_str = new UserDal().getAnswerOrder(userid).Rows[0]["IPORDER"].ToString().Trim();//查询IpOrder
        if (!string.IsNullOrEmpty(iporder_str) && iporder_str == "over")
        {
            return addWilAnswer();
        }
        else
        {
            if (string.IsNullOrEmpty(iporder_str))
            {
                new UserDal().updateAnswerOrder("0", "IPORDER", userid);
                return IpTitleHtml(0, 24);
            }
            else
            {
                int ipnumber = int.Parse(iporder_str);
                List<IpAnswer> ipanswers = new List<IpAnswer>();
                for (int i = ipnumber+1; i <= ipnumber + 24; i++)
                {
                    if (Request.Form.Get("IPN_" + i) != null &&
                        Request.Form.Get("IP_" + Request.Form.Get("IPN_" + i)) != null)
                    {
                        IpAnswer ipanswer = new IpAnswer();
                        string ans = Request.Form.Get("IP_" + Request.Form.Get("IPN_" + i));
                        ipanswer.IpId = int.Parse(Request.Form.Get("IPN_" + i));
                        string answer = "";
                        ipanswer.UserId = userid;
                        float ipscore = 0F;
                        if (ans != null)
                        {
                            answer = ans.Split('#')[0];
                            ipscore = float.Parse(ans.Split('#')[1]);
                        }
                        ipanswer.Answer = answer;
                        ipanswer.Score = ipscore;
                        ipanswers.Add(ipanswer);
                    }
                }
                if (ipanswers.Count > 0)
                {
                    if (new IpQuestionDal().addAnswers(ipanswers))
                    {
                        //设置值添加
                       // iporder_str = "24";//查询iporder
                        ipnumber = int.Parse(iporder_str);
                        new UserDal().updateAnswerOrder((ipnumber+ipanswers.Count).ToString().Trim(), "IPORDER", userid);
                        ipnumber = ipnumber + ipanswers.Count;
                    }
                    string ipTitleHtml = IpTitleHtml(ipnumber, 24);
                    if (string.IsNullOrEmpty(ipTitleHtml))
                    {
                        //设置为over
                        new UserDal().updateAnswerOrder("over", "IPORDER", userid);
                        return addWilAnswer();
                    }
                    else {

                        return ipTitleHtml;
                    }
                }
                else {
                    //查询iporder
                    iporder_str = new UserDal().getAnswerOrder(userid).Rows[0]["IPORDER"].ToString();
                    ipnumber = int.Parse(iporder_str);
                    string ipTitleHtml = IpTitleHtml(ipnumber, 24);
                    if (string.IsNullOrEmpty(ipTitleHtml))
                    {
                        //设置为over
                        new UserDal().updateAnswerOrder("over", "IPORDER", userid);
                        return addWilAnswer();
                    }
                    else
                    {
                        return ipTitleHtml;
                    }
                }
            }
        }
       // return null; 
    }

    public string addWilAnswer()
    {
        //Response.Cookies["User"]
        if (Session["Id"] == null || Session["Id"].ToString() == "")
            Response.Redirect("login.aspx");

        int userid = int.Parse(Session["Id"].ToString());
        string eqinumber = new UserDal().getAnswerOrder(userid).Rows[0]["WILORDER"].ToString().Trim();//查询eqinumber
        if (!string.IsNullOrEmpty(eqinumber) && eqinumber.Equals("over"))
        {
            return addEqiAnswer();
        }
        if (Request.Form.Get("answer1") != null &&
            Request.Form.Get("answer2") != null &&
            Request.Form.Get("answer3") != null &&
            Request.Form.Get("answer4") != null &&
            Request.Form.Get("answer5") != null)
        {
            string[] answer1list = Request.Form.Get("answer1").Split('=');
            string[] answer2list = Request.Form.Get("answer2").Split('=');
            string[] answer3list = Request.Form.Get("answer3").Split('=');
            string[] answer4list = Request.Form.Get("answer4").Split('=');
            string[] answer5list = Request.Form.Get("answer5").Split('=');

            int MAX_INPUT_SIZE = 4;
            if (
                answer1list.Length >= MAX_INPUT_SIZE &&
                answer2list.Length >= MAX_INPUT_SIZE &&
                answer3list.Length >= MAX_INPUT_SIZE &&
                answer4list.Length >= MAX_INPUT_SIZE &&
                answer5list.Length >= MAX_INPUT_SIZE)
            {
                string sql = "insert into wilanswer (WILID,USERID,ANSWER,SCORE) values ";
                //回答问题完成
                //
                for (int i = 0; i < 4; i++)
                {

                    sql += "(" + answer1list[i] + "," + userid + ",'第1重要的重要的选项',(select IMPORTSCORE FROM wiltestquestions where WILID=" + answer1list[i] + ")),";
                    sql += "(" + answer2list[i] + "," + userid + ",'第2重要的重要的选项',(select SECONDLYSCORE FROM wiltestquestions where WILID=" + answer2list[i] + ")),";
                    sql += "(" + answer3list[i] + "," + userid + ",'第3重要的重要的选项',(select GENERALSCORE FROM wiltestquestions where WILID=" + answer3list[i] + ")),";
                    sql += "(" + answer4list[i] + "," + userid + ",'第4重要的重要的选项',(select SOMEIMPORTSCORE FROM wiltestquestions where WILID=" + answer4list[i] + ")),";
                    sql += "(" + answer5list[i] + "," + userid + ",'第5重要的重要的选项',(select NOTINPORTSCORE FROM wiltestquestions where WILID=" + answer5list[i] + ")),";
                }
                sql = sql.EndsWith(",") ? sql.Substring(0, sql.Length - 1) : sql;

                if (new MySQLHelper().ExecuteSql(sql) == 1)
                {
                    new UserDal().updateAnswerOrder("over", "WILORDER", userid);
                    return addEqiAnswer();
                }
            }
        
        }
        return WilTitleHtml(0,20);
    }


    public string addEqiAnswer()
    {
        //Response.Cookies["User"]
        if (Session["Id"] == null || Session["Id"].ToString() == "")
            Response.Redirect("login.aspx");

        int userid = int.Parse(Session["Id"].ToString());
        string eqiorder_str = new UserDal().getAnswerOrder(userid).Rows[0]["EQIORDER"].ToString().Trim();//查询Eqi的order
        if (!string.IsNullOrEmpty(eqiorder_str) && eqiorder_str.Equals("over"))
        {
            return "<script> window.close();</script>";//答题完成
        }
        else
        {

            if (string.IsNullOrEmpty(eqiorder_str))
            {
                //修改答题为0
                new UserDal().updateAnswerOrder("0", "EQIORDER",userid);
                return EqiTitleHtml(0, 24);
            }

            if (!string.IsNullOrEmpty(eqiorder_str))
            {
                int eqinumber = int.Parse(eqiorder_str);
                List<EqiAnswer> listanswer = new List<EqiAnswer>();
                for (int i = eqinumber+1; i <= eqinumber + 24; i++)
                {
                    EqiAnswer eqianswer = new EqiAnswer();
                    if (Request.Form.Get("EQIN_" + i) != null &&
                        Request.Form.Get("EQI_" + Request.Form.Get("EQIN_" + i)) != null)
                    {
                        string ans = Request.Form.Get("EQI_" + Request.Form.Get("EQIN_" + i));
                        eqianswer.EqiId = int.Parse(Request.Form.Get("EQIN_" + i));
                        double eqiscore = 0.0;
                        string answer = "";
                        if (ans != null)
                        {
                            answer = ans.Split('#')[0];
                            eqiscore=double.Parse(ans.Split('#')[1]);
                        }
                        eqianswer.Answer = answer;
                        eqianswer.Score = (float)eqiscore;
                        eqianswer.UserId = userid;
                        listanswer.Add(eqianswer);
                    }
                }
                if (listanswer.Count > 0)
                {
                    if (new EqiQuestionDal().addEqiAnswers(listanswer))
                    {
                        new UserDal().updateAnswerOrder((eqinumber + listanswer.Count).ToString(), "EQIORDER", userid);

                        string HTMLEqi = EqiTitleHtml(eqinumber + listanswer.Count, 24);
                        if (string.IsNullOrEmpty(HTMLEqi))
                        {
                            //结束答题
                            new UserDal().updateAnswerOrder("over", "EQIORDER", userid);
                            Response.Redirect("myTest.aspx");
                        }
                        else
                        {
                            return HTMLEqi;
                        }
                    }
                    else
                    {

                        return EqiTitleHtml(eqinumber, 24);
                    }
                }
                else {
                    return EqiTitleHtml(eqinumber, 24);
                
                }

            }
        
        
        }

        return null;
    }
}