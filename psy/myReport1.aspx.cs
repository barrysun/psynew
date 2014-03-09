using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class myReport1 : System.Web.UI.Page
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
        //string sql = "select * from nuser where Id=" + Session["Id"];
        //if (!(new MySQLHelper().GetDataTable(sql).Rows[0]["IsTest"].ToString() == "1"))
        //{
        //    Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('你没有购买该服务请联系管理员！亲');window.location='myTest.aspx'; </script>");
        // //   Response.Redirect("myTest.aspx");
        //    return;
        //}
        if (Session["Id"] == null)
        {
            Response.Redirect("~/login.aspx");
        }
        int userId = int.Parse(Session["Id"].ToString());
        DataTable dt = new NUserDal().Query(" where Id=" + userId);
        Label1.Text = dt.Rows[0]["RealName"].ToString();
        Label2.Text = dt.Rows[0]["Gender"].ToString()=="1"?"男":"女";
        Label3.Text = dt.Rows[0]["BorthDay"].ToString();
        if (!(dt.Rows[0]["BorthDay"] != null && dt.Rows[0]["BorthDay"].ToString() != "") || !(dt.Rows[0]["Gender"] != null && dt.Rows[0]["Gender"].ToString() != ""))
        {

            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('必须完善先天信息！亲');window.location='xtxx.aspx';</script>");
            return ;
        }
        if (new IchingResultDal().count(int.Parse(userId.ToString())) == 0)
        {
            new IchingResultDal().yjsf(int.Parse(userId.ToString()));
            new IchingResultDal().exesql("update nuser set Isiching=1 where Id=" + userId);
        }

        if (new RepostDal().count(userId) == 0)
        {
            new Calculate().TestResult(userId);
            new IchingResultDal().exesql("update nuser set IsTest=1 where Id=" + userId);
        }


        
        

        DataTable dt2 = new MySQLHelper().GetDataTable("select * from report where USERID=" + Session["Id"]);
        Label4.Text = dt2.Rows[0]["TESTTIME"].ToString();


    }

    /// <summary>
    ///  显示报告
    /// </summary>
    /// <returns></returns>
    public string reportView()
    {
        DataTable dt = new NUserDal().Query(" where Id=" + Session["Id"]);
      
        if (!(dt.Rows[0]["BorthDay"] != null && dt.Rows[0]["BorthDay"].ToString() != "") || !(dt.Rows[0]["Gender"] != null && dt.Rows[0]["Gender"].ToString() != ""))
        {

            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('必须完善先天信息！亲');</script>");
            return "";
        }
        //string sql = "select * from nuser where Id=" + Session["Id"];
        //if (!(new MySQLHelper().GetDataTable(sql).Rows[0]["IsTest"].ToString() == "1"))
        //{
        //  //  Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('你没有购买该服务请联系管理员！亲');window.location='myTest.aspx'; </script>");
        //    //   Response.Redirect("myTest.aspx");
        //    return "";
        //}


        StringBuilder str = new StringBuilder();
        int UserId = int.Parse(Session["Id"].ToString());
        Dictionary<string, string> dic = new RepostDal().TextReportView(UserId);

        str.Append("<br/>");
         str.Append("<h4 class=\"detTit bold14\">第一部分：你的立体画像</h4>");
         str.Append("      <div class=\"detCont detCont1\">");
          str.Append("      	这部分展现你是什么样的人。即你的做事风格，你对目标和奋斗的态度，你的自我管理能力，你在创造性和处理人际关系方面的特点等等。知己知彼，百战不殆，准确地了解自己，是对人生做出正确选择的前提。");
          str.Append("          ");
          str.Append("      </div>");

          if (
              (dic["NEOC2"] != null && dic["NEOC2"] != "") ||
              (dic["NEOC3"] != null && dic["NEOC3"] != "") ||
              (dic["EQIIN"] != null && dic["EQIIN"] != "") ||
              (dic["NEOA4"] != null && dic["NEOA4"] != "") ||
              (dic["NEOE3"] != null && dic["NEOE3"] != "") ||
              (dic["EQIPS"] != null && dic["EQIPS"] != "") ||
              (dic["EQIRT"] != null && dic["EQIRT"] != "") ||
              (dic["EQIFL"] != null && dic["EQIFL"] != "")
               )
          {
              str.Append("<h4 class=\"detTit bold14\">做事风格</h4>");
          }
          
          //1做事风格
          str.Append("<div class=\"detCont\"> " + dic["NEOC2"] + "</div>");
          str.Append("<div class=\"detCont\"> " + dic["NEOC3"] + "</div>");
          str.Append("<div class=\"detCont\"> " + dic["EQIIN"] + "</div>");
          str.Append("<div class=\"detCont\"> " + dic["NEOA4"] + "</div>");
          str.Append("<div class=\"detCont\"> " + dic["NEOE3"] + "</div>");
          str.Append("<div class=\"detCont\"> " + dic["EQIPS"] + "</div>");
          str.Append("<div class=\"detCont\"> " + dic["EQIRT"] + "</div>");
          str.Append("<div class=\"detCont\"> " + dic["EQIFL"] + "</div>");


          if ((dic["EQISA"] != null && dic["EQISA"] != "") ||
              (dic["NEOC4"] != null && dic["NEOC4"] != "") ||
              (dic["NEOE4"] != null && dic["NEOE4"] != "") ||
              (dic["NEOC5"] != null && dic["NEOC5"] != "") ||
              (dic["EQIOP"] != null && dic["EQIOP"] != ""))
          {
              str.Append("<h4 class=\"detTit bold14\">目标和奋斗</h4>");
              // str.Append("      <div class=\"detCont\">");
              //目标和奋斗
          }

          str.Append("<div class=\"detCont\"> " + dic["EQISA"] + "</div>");
          str.Append("<div class=\"detCont\"> " + dic["NEOC4"] + "</div>");
          str.Append("<div class=\"detCont\"> " + dic["NEOE4"] + "</div>");
          str.Append("<div class=\"detCont\"> " + dic["NEOC5"] + "</div>");
          str.Append("<div class=\"detCont\"> " + dic["EQIOP"] + "</div>");
        //  str.Append("      </div>");
          if ((dic["EQIIC"] != null && dic["EQIIC"] != "") ||
              (dic["NEOC6"] != null && dic["NEOC6"] != "") ||
              (dic["EQIST"] != null && dic["EQIST"] != ""))
          {
              str.Append("<h4 class=\"detTit bold14\">自我管理</h4>");
              //     str.Append("      <div class=\"detCont\">");
              //自我管理
          }

          str.Append("<div class=\"detCont\"> " + dic["EQIIC"] + "</div>");
          str.Append("<div class=\"detCont\"> " + dic["NEOC6"] + "</div>");
          str.Append("<div class=\"detCont\"> " + dic["EQIST"] + "</div>");
         // str.Append("      </div>");

          if ((dic["NEOO5"] != null && dic["NEOO5"] != "") ||
              (dic["NEOO4"] != null && dic["NEOO4"] != ""))
          {
              str.Append("<h4 class=\"detTit bold14\">创造性</h4>");
              //  str.Append("      <div class=\"detCont\">");
              //创造性
          }
          str.Append("<div class=\"detCont\"> " + dic["NEOO5"] + "</div>");
          str.Append("<div class=\"detCont\"> " + dic["NEOO4"] + "</div>");
          // str.Append(dic["NQIES"]);
         // str.Append("      </div>");
        if((dic["NEOA2"]!=null&&dic["NEOA2"]!="")||
            (dic["NEOA3"]!=null&&dic["NEOA3"]!="")||
            (dic["NEOA6"]!=null&&dic["NEOA6"]!="")||
            (dic["NEOE1"]!=null&&dic["NEOE1"]!="")||
            (dic["EQIEM"]!=null&&dic["EQIEM"]!="")||
            (dic["EQIRE"]!=null&&dic["EQIRE"]!="")||
            (dic["NEON4"]!=null&&dic["NEON4"]!="")){
          str.Append("<h4 class=\"detTit bold14\">人际和社会</h4>");
         // str.Append("      <div class=\"detCont\">");
          //人际和社会
        }
          str.Append("<div class=\"detCont\"> " + dic["NEOA2"] + "</div>");
          str.Append("<div class=\"detCont\"> " + dic["NEOA3"] + "</div>");
          str.Append("<div class=\"detCont\"> " + dic["NEOA6"] + "</div>");
          str.Append("<div class=\"detCont\"> " + dic["NEOE1"] + "</div>");
          str.Append("<div class=\"detCont\"> " + dic["EQIEM"] + "</div>");
          str.Append("<div class=\"detCont\"> " + dic["EQIRE"] + "</div>");
          // str.Append(dic["REOE2"]);
          str.Append("<div class=\"detCont\"> " + dic["NEON4"] + "</div>");
         // str.Append("      </div>");
          str.Append("<br/>");
          str.Append("      <h4 class=\"detTit bold14\">第二部分：你的兴趣点</h4>");
          str.Append("      <div class=\"detCont detCont1\">");
          str.Append("      	这部分显示你的兴趣爱好。兴趣爱好是你一生中能够坚持下去的最原始、最持久、最有效的动力。而坚持又是成功的必要条件。沿着兴趣的方向选择和规划你的人生，十分重要。");

          str.Append("      </div>");
        //你的兴趣

         // str.Append("      <div class=\"detCont\">");
          str.Append("<div class=\"detCont\">" + dic["INSTFST"] + "</div>");
          str.Append("<div class=\"detCont\">" + dic["INSTSEC"] + "</div>");
          str.Append("<div class=\"detCont\">" + dic["INSTTRD"] + "</div>");
        
      //  str.Append("      </div>");
          str.Append("      ");
          str.Append("<br/>");
          str.Append("        <h4 class=\"detTit bold14\">第三部分：你的价值观</h4>");
          str.Append("       <div class=\"detCont detCont1\">");
         str.Append("       	这部分展示你的价值观。价值观是世界观的最本质、最核心的取向。它将对你一生所能企及的成就产生深远的影响，也是你在做人生规划时做战略性思考的重要参考。");
         str.Append("       </div>");
     //   str.Append("      <div class=\"detCont\">");
         //三部分
         str.Append("<div class=\"detCont\">" + dic["VALFST"] + "</div>");
         str.Append("<div class=\"detCont\">" + dic["VALSEC"] + "</div>");
         str.Append("<div class=\"detCont\">" + dic["VALTRD"] + "</div>");
   //     str.Append("       </div>");
       
        return str.ToString();
    }
}