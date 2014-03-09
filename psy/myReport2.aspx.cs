using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class myReport2 : System.Web.UI.Page
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

        string sql = "select * from nuser where Id=" + Session["Id"];
        if (!(new MySQLHelper().GetDataTable(sql).Rows[0]["IsFor"].ToString() == "1"))
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('你没有购买该服务请联系管理员！亲');window.location='myTest.aspx'; </script>");
            //   Response.Redirect("myTest.aspx");
            return;
        }

        DataTable dt = new NUserDal().Query(" where Id=" + Session["Id"]);
        Label1.Text = dt.Rows[0]["RealName"].ToString();
        Label2.Text = dt.Rows[0]["Gender"].ToString() == "1" ? "男" : "女";
        Label3.Text = dt.Rows[0]["BorthDay"].ToString();
        DataTable dt2 = new MySQLHelper().GetDataTable("select * from report where USERID=" + Session["Id"]);
        Label4.Text = dt2.Rows[0]["FORECASTTIME"].ToString();
    }

    public string ReportView()
    {
        Dictionary<string, string> dic = new RepostDal().ForReportView(int.Parse(Session["Id"].ToString()));
        StringBuilder str = new StringBuilder();
        Dictionary<string, string> job1dic =dic.ContainsKey("IDFST")? loadJob(dic["IDFST"]):null;
        Dictionary<string, string> job2dic = dic.ContainsKey("IDSEC")?loadJob(dic["IDSEC"]):null;
        str.Append(" <div class=\"detCont\">");
        string s = "select * from ichingresult where RNUMBER=" + Session["Id"];
        str.Append("        	<span class=\" detCont1\">" + new MySQLHelper().GetDataTable(s).Rows[0]["yxzd_1"] + "</span>");
        str.Append("         </div>");
        str.Append("            <div class=\"detCont\">");

           string job1s = "";
            if (job1dic != null && job2dic!=null)
            {
                job1s = "<span class=\"bold14\">" + job1dic["JOBNAME"] + "</span>和<span class=\"bold14\">" + job2dic["JOBNAME"] + "</span>";

            }
            else if (job1dic != null && job2dic == null)
            {
                job1s = "<span class=\"bold14\">" + job1dic["JOBNAME"] + "</span>";
            }
            else if (job1dic == null && job2dic != null)
            {
                job1s = "<span class=\"bold14\">" + job2dic["JOBNAME"] + "</span>";
            }

            str.Append("           融入易学精髓的现代心理学为你提供如下报告：结合你的先天信息，我们为你推荐的最符合你个人特质的职业是：" + job1s + "及其类似的职业。");
        str.Append("              </div>");
        str.Append("             <div class=\"detCont \">");
        str.Append("                    为了帮助你了解我们为你推荐的职业，我们为你收集了该职业的相关资料，罗列于后，供你在选择职业时参考。如果你觉得该资料不够完善，谢谢你的认真阅读，我们会在以后的时间里进一步收集和完善。<br/>");


        if (job1dic != null)
        {
            str.Append("<br/> <h4 class=\"detTit bold14\">关于" + job1dic["JOBNAME"] + "职业</h4><br/>");
            if (job1dic["lib2lib3"] == "2")
            {
                str.Append("<span class=\"detCont1\">工作内容和性质</span><br/>");
            }
            else
            {
                str.Append("<span class=\"bold14\">相关的工作：</span><br/>");
            }
            if (job1dic.ContainsKey("jobName1"))
            {
                str.Append("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + job1dic["jobName1"] + ":" + job1dic["descr1"] + "<br/>");
            }
            if (job1dic.ContainsKey("jobName2"))
            {
                str.Append("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + job1dic["jobName2"] + ":" + job1dic["descr2"] + "<br/>");
            }
            if (job1dic.ContainsKey("jobName3"))
            {
                str.Append("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + job1dic["jobName3"] + ":" + job1dic["descr3"] + "<br/>");
            }
            if (job1dic.ContainsKey("jobName"))
            {
                str.Append("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + job1dic["jobName"] + ":" + job1dic["descr"] + "<br/>");
            }


            str.Append("<span class=\"bold14\">就业前景：</span>以成都地区为例，总体来说就业前景：" +( job1dic.ContainsKey("cnoutlook1")?job1dic["cnoutlook1"]:"") + (job1dic.ContainsKey("cnoutlook2")?job1dic["cnoutlook2"]:"") + "");
            str.Append("<br/><span class=\"bold14\">收入水平：</span>");
            if (job1dic.ContainsKey("cn_salary1") && job1dic.ContainsKey("cn_salary2"))
            {
                str.Append("以成都地区近年来的工资统计数据为例，随着从业时间、资历、职称等的增长变化，相关工作的平均年收入（参考值）如下：<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + job1dic["cn_salary1"] + job1dic["cn_salary2"] + " ");
            }
            else
            {
                str.Append("  暂无     ");
            }

            str.Append("<br/><span class=\"bold14\">高等院校的相关专业:</span>");
            if (job1dic.ContainsKey("cnNMAHOR1") && job1dic["cnNMAHOR1"] != "暂无")
            {
                str.Append("  " + job1dic["cnNMAHOR1"]);
            }
            if (job1dic.ContainsKey("cnNMAHOR2") && job1dic["cnNMAHOR2"] != "暂无")
            {
                str.Append("  " + job1dic["cnNMAHOR2"]);
            }
            if (job1dic.ContainsKey("cnNMAHOR3") && job1dic["cnNMAHOR3"] != "暂无")
            {
                str.Append("  " + job1dic["cnNMAHOR3"]);
            }

            str.Append("<br/><span class=\"bold14\">学习科目和专业课程:</span><br/>");
            if (job1dic.ContainsKey("lib10"))
            {
                str.Append(job1dic["lib10"]);
            }
        }

        #region job2
        if (job2dic != null)
        {
            str.Append("<br/><h4 class=\"detTit bold14\">关于" + job2dic["JOBNAME"] + "职业</h4><br/>");
            if (job2dic["lib2lib3"] == "2")
            {
                str.Append("<span class=\"bold14\">工作内容和性质：</span>");
            }
            else
            {
                str.Append("<span class=\"bold14\">相关的工作：</span><br/>");
            }
            if (job2dic.ContainsKey("jobName1"))
            {
                str.Append("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + job2dic["jobName1"] + ":" + job2dic["descr1"] + "<br/>");
            }
            if (job2dic.ContainsKey("jobName2"))
            {
                str.Append("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + job2dic["jobName2"] + ":" + job2dic["descr2"] + "<br/>");
            }
            if (job2dic.ContainsKey("jobName3"))
            {
                str.Append("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + job2dic["jobName3"] + ":" + job2dic["descr3"] + "<br/>");
            }
            if (job2dic.ContainsKey("jobName"))
            {
                str.Append("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + job2dic["jobName"] + ":" + job2dic["descr"] + "<br/>");
            }

            str.Append("<span class=\"bold14\">就业前景：</span>以成都地区为例，总体来说就业前景：" + (job2dic.ContainsKey("cnoutlook1")?job2dic["cnoutlook1"]:"" )+( job2dic.ContainsKey("cnoutlook2")?job2dic["cnoutlook2"]:"") + "<br/>");
            str.Append("<span class=\"bold14\">收入水平：</span>");
            if (job2dic.ContainsKey("cn_salary1") && job2dic.ContainsKey("cn_salary2"))
            {
                str.Append("以成都地区近年来的工资统计数据为例，随着从业时间、资历、职称等的增长变化，相关工作的平均年收入（参考值）如下：<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + job2dic["cn_salary1"] + job2dic["cn_salary2"] + " ");
            }
            else
            {
                str.Append("  暂无     ");
            }

            str.Append("<br/><span class=\"bold14\">高等院校的相关专业:</span>");
            if (job2dic.ContainsKey("cnNMAHOR1") && job2dic["cnNMAHOR1"] != "暂无")
            {
                str.Append("  " + job2dic["cnNMAHOR1"]);
            }
            if (job2dic.ContainsKey("cnNMAHOR2") && job2dic["cnNMAHOR2"] != "暂无")
            {
                str.Append("  " + job2dic["cnNMAHOR2"]);
            }
            if (job2dic.ContainsKey("cnNMAHOR3") && job2dic["cnNMAHOR3"] != "暂无")
            {
                str.Append("  " + job2dic["cnNMAHOR3"]);
            }
            str.Append("<br/><span class=\"bold14\">学习科目和专业课程:</span><br/>");
            if (job2dic.ContainsKey("lib10"))
            {
                str.Append(job2dic["lib10"]);
            }
        #endregion
            str.Append("       ");
            str.Append("      </div>");
        }

        str.Append("<h4 class=\"detTit bold14\"></h4>");

      //  str.Append("     <div class=\"detCont\">");

        string job1ss = "";
        if (job1dic != null && job2dic != null)
        {
            job1ss = "<span class=\"bold14\">" + job1dic["JOBNAME"] + "</span>或<span class=\"bold14\">" + job2dic["JOBNAME"] + "</span>";

        }
        else if (job1dic != null && job2dic == null)
        {
            job1ss = "<span class=\"bold14\">" + job1dic["JOBNAME"] + "</span>";
        }
        else if (job1dic == null && job2dic != null)
        {
            job1ss = "<span class=\"bold14\">" + job2dic["JOBNAME"] + "</span>";
        }

      //  str.Append("    <div class=\"detCont1\" >	如果你不喜欢我们为你推荐的职业，或者希望有更多的选择，或者想进一步了解你自身的特点与从事" + job1ss + "的理想人选之间的匹配程度，请在完成付费程序后，使用职业匹配功能，读取你的职业匹配报。<a href=\"myReport3.aspx\"><span class=\"bold14\">点击职业匹配报告</sapn></a>");

        str.Append("    <div class=\"detCont1\" >	我们为你推荐的职业，是相对于其它职业而言最适合你的，但并不能保证这些职业与你的个性特质匹配程度很高。建议你使用匹配功能对本报告所预测职业进行匹配，以获取你与这些职业匹配程度的全方位报告。了解你在一旦从事该职业时，所具有的优势素质点和不足的素质点，充分地判断你是否适合该职业。"+
"如果你不喜欢我们为你推荐的职业，或者希望有更多的选择，也可以使用匹配功能，在我们为你提供的职业库里进行选择，了解你与所选职业的匹配程度，了解你在一旦从事该职业时，所具有的优势素质点和不足的素质点，为确定你自己的职业方向掌握更多的底牌。"+
"请在完成付费程序后，使用职业匹配功能，读取你的职业匹配报告。"+
"<a href=\"myReport3.aspx\"><span class=\"bold14\">点击职业匹配报告</sapn></a>");

        str.Append("       </div>");
        str.Append("<div class=\"detCont1\" >请在完成付费程序后，使用职业匹配功能，读取你的职业匹配报告。");
        str.Append("</div>");
                
        str.Append("");
        //str.Append(dic["IDFST"]);
        //str.Append(dic["IDSEC"]);
       // str.Append(dic["INSTTRD"]);
        //str.Append(dic["SYL04RPDes"]);

        //str.Append(dic["SYL13RPDes"]);
        //str.Append(dic["SYL14RPDes"]);
        //str.Append(dic["SYL06RPDes"]);
        //str.Append(dic["SYL16RPDes"]);
        //str.Append(dic["SKL30RPDes"]);
        //str.Append(dic["SKL21RPDes"]);
        //str.Append(dic["SYL03RPDes"]);
        //str.Append(dic["SYL05RPDes"]);
        //str.Append(dic["SYL07RPDes"]);
        //str.Append(dic["SYL08RPDes"]);
        //str.Append(dic["SYL09RPDes"]);
        //str.Append(dic["SYL10RPDes"]);
        //str.Append(dic["SYL11RPDes"]);
        //str.Append(dic["SYL12RPDes"]);
        //str.Append(dic["SYL15RPDes"]);
        //str.Append(dic["SKL19RPDes"]);
        //str.Append(dic["SYL01RPDes"]);
        //str.Append(dic["SYL02RPDes"]);
        //str.Append(dic["SKL11RPDes"]);
        //str.Append(dic["SKL01RPDes"]);
        //str.Append(dic["IDFST"]);
        //str.Append(dic["IDSEC"]);
        return str.ToString();
    
    }
    public Dictionary<string, string> loadJob(string jobid)
    {

        Dictionary<string, string> dic = new Dictionary<string, string>();
        IndexLib indexlib = new IndexLibDal().Query(jobid);
        if (indexlib != null)
        {
            dic.Add("JOBNAME", indexlib.CNName);
            if (indexlib.Lib2 == 2 && indexlib.Lib3 == -1)
            {
                dic.Add("lib2lib3", "2");
                //查询子库2
                //查询cn_duty1
                if (!(indexlib.CN_duty1.Trim() == "-1"))
                {
                    Lib2Profession lib2 = new Lib2Dal().Query(indexlib.CN_duty1);
                    dic.Add("jobName1", lib2.Lib2Name);
                    dic.Add("descr1", lib2.DEScription);
                }
                //查询cn_duty2
                if (!(indexlib.CN_duty2.Trim() == "-1"))
                {
                    Lib2Profession lib2 = new Lib2Dal().Query(indexlib.CN_duty2);
                    dic.Add("jobName2", lib2.Lib2Name);
                    dic.Add("descr2", lib2.DEScription);
                }
                //查询cn_duty3
                if (!(indexlib.CN_duty3.Trim() == "-1"))
                {
                    Lib2Profession lib2 = new Lib2Dal().Query(indexlib.CN_duty3);
                    dic.Add("jobName3", lib2.Lib2Name);
                    dic.Add("descr3", lib2.DEScription);
                }
                if (indexlib.Lib2 == 2)
                {
                    Lib2Profession lib2 = new Lib2Dal().Query(indexlib.CNNumber);
                    dic.Add("jobName", lib2.Lib2Name);
                    dic.Add("descr", lib2.DEScription);
                }

            }
            else if (indexlib.Lib3 == 1 && indexlib.Lib2 != 2)
            {
                dic.Add("lib2lib3", "3");
                //查询子库3
                if (indexlib.CN_duty1.Trim()!="-1")
                { 
                    Lib3 lib3=new Lib3Dal().Query(indexlib.CN_duty1);
                    if (lib3 != null)
                    {
                        dic.Add("jobName1", lib3.Cnname);
                        dic.Add("descr1", lib3.Cndes + "从事的工作主要包括：" + lib3.Cnwork);
                    }
                }
                //查询cn_duty1
                if (!indexlib.CN_duty2.Trim().Equals("-1"))
                {
                    Lib3 lib3 = new Lib3Dal().Query(indexlib.CN_duty2);
                    if (lib3 != null)
                    {
                        dic.Add("jobName2", lib3.Cnname);
                        dic.Add("descr2", lib3.Cndes + "从事的工作主要包括：" + lib3.Cnwork);
                    }
                }
                if (!indexlib.CN_duty3.Trim().Equals("-1"))
                {
                    Lib3 lib3 = new Lib3Dal().Query(indexlib.CN_duty3);
                    if (lib3 != null)
                    {
                        dic.Add("jobName3", lib3.Cnname);
                        dic.Add("descr3", lib3.Cndes + "从事的工作主要包括：" + lib3.Cnwork);
                    }
                }
              


            }
        }

        //显示就业前景
        #region 显示就业前景
        Forecastjob2 fjob2 = new Forecastjob2Dal().Query(jobid);
        if (fjob2 != null)
        {
            dic.Add("cnoutlook1", fjob2.CnoutLook1);
            dic.Add("cnoutlook2", fjob2.CnoutLook2);
        }
        #endregion
        //收入水平查询子库4
        #region 收入水平查询子库4
        if (!(indexlib.CN_salary1.Trim() == "-1"))
        {
            List<Lib4> lib4s = new Lib4Dal().Query(indexlib.CN_salary1);
            string str = "";
            for (int i = 0; i < lib4s.Count; i++)
            {
                str += lib4s[i].Cnname;
                string[] sal1 = new Lib4Dal().QueryBigSmallByParentId(lib4s[i].Id + "");
                if (sal1 != null && !sal1.Equals(null) && sal1.Length == 2)
                {
                    if ((sal1[0] != null && !sal1[0].Equals(null) && !sal1[0].Equals("")) && (sal1[1] != null && !sal1[1].Equals(null) && !sal1[1].Equals("")))
                    {
                        String double1 = (double.Parse(sal1[0]) / 10000) + "";
                        String double2 = (double.Parse(sal1[1]) / 10000) + "";
                        str += "从" + (double1.Substring(0, double1.IndexOf(".") + 2)) + "万元到" + (double2.Substring(0, double2.IndexOf(".") + 2)) + "万元不等";

                    }
                }
                else
                {
                    str += " 收入暂无";
                }
            }
            if (str.Equals(""))
            {
                str = "暂无";
            }

            dic.Add("cn_salary1", str);
        }

        if (!indexlib.CN_salary2.Trim().Equals("-1"))
        {
            List<Lib4> lib4s = new Lib4Dal().Query(indexlib.CN_salary2);
          
            string str = "";
            for (int i = 0; i < lib4s.Count; i++)
            {
                str += lib4s[i].Cnname;
                string[] sal1 = new Lib4Dal().QueryBigSmallByParentId(lib4s[i].Id + "");
                if (sal1 != null && !sal1.Equals(null) && sal1.Length == 2)
                {
                    if ((sal1[0] != null && !sal1[0].Equals(null) && !sal1[0].Equals("")) && (sal1[1] != null && !sal1[1].Equals(null) && !sal1[1].Equals("")))
                    {
                        String double1 = (double.Parse(sal1[0]) / 10000) + "";
                        String double2 = (double.Parse(sal1[1]) / 10000) + "";
                        str += "从" + (double1.Substring(0, double1.IndexOf(".") + 2)) + "万元到" + (double2.Substring(0, double2.IndexOf(".") + 2)) + "万元不等";

                    }
                }
                else
                {
                    str += " 收入暂无";
                }
            }
            if (str.Equals(""))
            {
                str = "暂无";
            }

            dic.Add("cn_salary2", str);
        }
        #endregion

        //查询表1得到高校相关专业
        #region 查询表1得到高校相关专业
        ForecastJob1 forjob1 = new Forecastjob1Dal().Query(jobid);
        if (forjob1 != null)
        {
            dic.Add("cnNMAHOR1", forjob1.Cnmajor1);
            dic.Add("cnNMAHOR2", forjob1.Cnmajor2);
            dic.Add("cnNMAHOR3", forjob1.Cnmajor3);
        }
        #endregion

        //显示学习科目和专业课程
        #region 显示学习科目和专业课程
        string sclstr = new AllLibDal().getSCLById(jobid + ".0");
        if (sclstr.Length > 0)
        {
            string wherestr = "";
            string[] strs = sclstr.Split(',');
            for (int i = 0; i < strs.Length; i++)
            {
                wherestr += "'" + strs[i] + "',";
            }
            if (wherestr != "")
            {
                wherestr = wherestr.Substring(0, wherestr.Length - 1);
            }

           List<Lib5> lib5s= new Lib5Dal().queryLib10Id(wherestr);
           if (lib5s != null && lib5s.Count > 0)
           {
               string s = "";
               for (int i = 0; i < lib5s.Count; i++)
               {
                   s += "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;●   " + lib5s[i].LibName + ":" + lib5s[i].DescripTion + "<br/>";
               }
               dic.Add("lib10", s);
           }
           else {

               dic.Add("lib10", "");
           }
            

        
        }


        #endregion
        return dic;

    }

    

}