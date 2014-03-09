using System;
using System.Collections.Generic;

using System.Text;
using System.Data;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using Wuqi.Webdiyer;
using Model;

namespace Dal
{
   public  class EqiQuestionDal
    {
       public DataTable GetEqiQuestion() {

           return new MySQLHelper().GetDataTable("select * from eqitestquestions");
       }

       public void BindPager(GridView gv, AspNetPager pager, string whereStr)
       {
           var sql = @"
set @mycnt=0; 
select * from (
select *,(@mycnt := @mycnt + 1) as RowNum from eqitestquestions "+whereStr+@"
)as eqiquestion where RowNum>{0} and RowNum<={1}";
           sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
           pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(EQIID) from eqitestquestions "+ whereStr));
           gv.DataSource = new MySQLHelper().GetDataTable(sql);
           gv.DataBind();
       }

       public void BindPagerAnswer(GridView gv, AspNetPager pager, string whereStr)
       {
           var sql = @"
set @mycnt=0; 
select * from (
select eqianswer.*,(@mycnt := @mycnt + 1) as RowNum,user.NAME,eqitestquestions.EQITITLE from eqianswer,user,eqitestquestions where `user`.USERID=eqianswer.USERID and eqianswer.EQIID=eqitestquestions.EQIID
)as answer where RowNum>{0} and RowNum<={1}";

           sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
           pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(EQIID) from eqianswer"));
           gv.DataSource = new MySQLHelper().GetDataTable(sql);
           gv.DataBind();
       
       }

       public DataTable GetTable(string whereStr)
       {
           var sql = "select eqianswer.*,user.NAME,eqitestquestions.EQITITLE from eqianswer,user,eqitestquestions where `user`.USERID=eqianswer.USERID and eqianswer.EQIID=eqitestquestions.EQIID ";
           if (!string.IsNullOrEmpty(whereStr))
           {
               sql += " AND " + whereStr;
           }
           return new MySQLHelper().GetDataTable(sql);
       }

       public DataTable GetById(string eqiid)
       {
           return new MySQLHelper().GetDataTable("select * from eqitestquestions where EQIID=" + eqiid);

       }

       public bool Add(EqiTestQuestion eqiQuestion)
       {

           const string sql =
               "insert into eqitestquestions (EQITYPE,ORIGINALNUMBER,TEST,TESTNUMBER,SCORE,SPECIALTYPE,ISUSE,EQITITLE," +
               "EQIORDER,VERYSCORE,BASICSCORE,SOMETIMESCORE,DOESNOTSCORE,NOTSCORE)values(?EQITYPE,?ORIGINALNUMBER,?TEST,?TESTNUMBER,?SCORE,?SPECIALTYPE,?ISUSE,?EQITITLE," +
               "?EQIORDER,?VERYSCORE,?BASICSCORE,?SOMETIMESCORE,?DOESNOTSCORE,?NOTSCORE)";
               
           var param = new MySqlParameter[14];
           param[0] = new MySqlParameter("?EQITYPE", MySqlDbType.String) { Value = eqiQuestion.EqiType };
           param[1] = new MySqlParameter("?ORIGINALNUMBER", MySqlDbType.Int32) { Value = eqiQuestion.OriginalNumber };
           param[2] = new MySqlParameter("?TEST", MySqlDbType.String) { Value = eqiQuestion.Test };
           param[3] = new MySqlParameter("?TESTNUMBER", MySqlDbType.Int32) { Value = eqiQuestion.TestNumber };
           param[4] = new MySqlParameter("?SCORE", MySqlDbType.Double) { Value = eqiQuestion.Score };
           param[5] = new MySqlParameter("?SPECIALTYPE", MySqlDbType.String) { Value = eqiQuestion.SpecialType };
           param[6] = new MySqlParameter("?ISUSE", MySqlDbType.Int32) { Value = eqiQuestion.IsUse };
           param[7] = new MySqlParameter("?EQITITLE", MySqlDbType.String) { Value = eqiQuestion.EqiTitle };
           param[8] = new MySqlParameter("?EQIORDER", MySqlDbType.Int32) { Value = eqiQuestion.EqiOrder };
           param[9] = new MySqlParameter("?VERYSCORE", MySqlDbType.Double) { Value = eqiQuestion.VeryScore };
           param[10] = new MySqlParameter("?BASICSCORE", MySqlDbType.Double) { Value = eqiQuestion.BasicScore };
           param[11] = new MySqlParameter("?SOMETIMESCORE", MySqlDbType.Double) { Value = eqiQuestion.SomeTimeScore };
           param[12] = new MySqlParameter("?DOESNOTSCORE", MySqlDbType.Double) { Value = eqiQuestion.DoesnotScore };
           param[13] = new MySqlParameter("?NOTSCORE", MySqlDbType.Double) { Value = eqiQuestion.NotScore };
         
           return new MySQLHelper().ExecuteSql(sql, param) == 1;
       }

       public bool Update(EqiTestQuestion eqiQuestion)
       {
           const string sql = "update eqitestquestions set EQITYPE=?EQITYPE,ORIGINALNUMBER=?ORIGINALNUMBER,TEST=?TEST,TESTNUMBER=?TESTNUMBER,SCORE=?SCORE," +
                              "SPECIALTYPE=?SPECIALTYPE,ISUSE=?ISUSE,EQITITLE=?EQITITLE,EQIORDER=?EQIORDER,VERYSCORE=?VERYSCORE,BASICSCORE=?BASICSCORE," +
                              "SOMETIMESCORE=?SOMETIMESCORE,DOESNOTSCORE=?DOESNOTSCORE,NOTSCORE=?NOTSCORE where EQIID=?EQIID";
           var param = new MySqlParameter[15];
           param[0] = new MySqlParameter("?EQITYPE",MySqlDbType.String){Value = eqiQuestion.EqiType};
           param[1] = new MySqlParameter("?ORIGINALNUMBER",MySqlDbType.Int32){Value = eqiQuestion.OriginalNumber};
           param[2] = new MySqlParameter("?TEST",MySqlDbType.String){Value = eqiQuestion.Test};
           param[3] = new MySqlParameter("?TESTNUMBER",MySqlDbType.Int32){Value = eqiQuestion.TestNumber};
           param[4] = new MySqlParameter("?SCORE",MySqlDbType.Double){Value = eqiQuestion.Score};
           param[5] = new MySqlParameter("?SPECIALTYPE",MySqlDbType.String){Value = eqiQuestion.SpecialType};
           param[6] = new MySqlParameter("?ISUSE",MySqlDbType.Int32){Value = eqiQuestion.IsUse};
           param[7] = new MySqlParameter("?EQITITLE",MySqlDbType.String){Value = eqiQuestion.EqiTitle};
           param[8] = new MySqlParameter("?EQIORDER",MySqlDbType.Int32){Value = eqiQuestion.EqiOrder};
           param[9] = new MySqlParameter("?VERYSCORE",MySqlDbType.Double){Value = eqiQuestion.VeryScore};
           param[10] = new MySqlParameter("?BASICSCORE",MySqlDbType.Double){Value = eqiQuestion.BasicScore};
           param[11] = new MySqlParameter("?SOMETIMESCORE",MySqlDbType.Double){Value = eqiQuestion.SomeTimeScore};
           param[12] = new MySqlParameter("?DOESNOTSCORE",MySqlDbType.Double){Value = eqiQuestion.DoesnotScore};
           param[13] = new MySqlParameter("?NOTSCORE",MySqlDbType.Double){Value = eqiQuestion.NotScore};
           param[14]=new MySqlParameter("?EQIID",MySqlDbType.Int32){Value = eqiQuestion.EqiId};
           return new MySQLHelper().ExecuteSql(sql, param) == 1;
        
       }

       public bool Delete(int id)
       {
           const string sql = "delete from eqitestquestions where EQIID=?EQIID";
           var param = new MySqlParameter[1];
           param[0]=new MySqlParameter("?EQIID",MySqlDbType.Int32){Value = id};
           return new MySQLHelper().ExecuteSql(sql, param) == 1;
       }

       /// <summary>
       /// 添加EQI答题结果的时候出现的是当EQI题出现的问题题目是一样的，但是只有一个题目显示出来让用户答题，
       ///其他的类型为999不显示但是要计入分数和类型。
       /// </summary>
       /// <param name="beans"></param>
       /// <returns></returns>
       public bool addEqiAnswers(List<EqiAnswer> beans)
       {
           string sql = "";
           if (beans.Count > 0) sql = "insert into eqianswer(EQIID,ANSWER,SCORE,USERID) values ";
           for (int i = 0; i < beans.Count; i++)
           {
               sql += " (" + beans[i].EqiId + ",'" + beans[i].Answer + "'," +
           beans[i].Score + "," + beans[i].UserId + "),";
               DataTable dt = new MySQLHelper().GetDataTable("select a.EQIID as EQIID from eqitestquestions a where EQITITLE in ( select x.EQITITLE from eqitestquestions x where x.eqiid=" + beans[i].EqiId + ") and a.EQIORDER=999");
               if (dt != null && dt.Rows.Count > 0)
               {
                   for (int j = 0; j < dt.Rows.Count; j++)
                   {
                       sql += " (" + dt.Rows[j]["EQIID"] + ",'" + beans[i].Answer + "'," +
                           beans[i].Score + "," + beans[i].UserId + "),";
                   }
               }
           }
           if (beans.Count > 0) sql = sql.Substring(0, sql.Length - 1);
           return 1 == new MySQLHelper().ExecuteSql(sql);
       }

       public DataTable getEqiQuestion(int startRow, int pageSize)
       {
           var sql = "select EQIID,EQITYPE,ORIGINALNUMBER,TEST,TESTNUMBER,SCORE,SPECIALTYPE,ISUSE,EQITITLE,EQIORDER,VERYSCORE,BASICSCORE,SOMETIMESCORE,DOESNOTSCORE,NOTSCORE from eqitestquestions   where EQIORDER not in (888 , 999)  order by eqiorder limit " + startRow + "," + pageSize;
           return new MySQLHelper().GetDataTable(sql);
       }


       public Dictionary<string, string> getAnswerAndType(int userID)
       {
           var sql = "select sum(e.score) as myscore,eq.eqitype as myeqitype from eqianswer e,eqitestquestions eq where eq.eqiid=e.eqiid and e.userid=" + userID + " group by eq.eqitype";
           var dt = new MySQLHelper().GetDataTable(sql);
           var dic = new Dictionary<string, string>();
           if (dt == null || dt.Rows.Count <= 0) return null;
           for (var i = 0; i < dt.Rows.Count; i++)
           {
               dic.Add(dt.Rows[i]["myeqitype"].ToString(), dt.Rows[i]["myscore"].ToString());
           }
           return dic;
       }

       /// <summary>
       /// 导出Excel
       /// </summary>
       /// <returns></returns>
       public DataTable getDataTable()
       {
           const string sql = "select EQIID from eqitestquestions limit 0,201";
           DataTable dt1 = new MySQLHelper().GetDataTable(sql);
           DataTable dt = new DataTable();

           dt.Columns.Add("USERID");
           for (int i = 0; i < dt1.Rows.Count; i++)
           {
               dt.Columns.Add(dt1.Rows[i]["EQIID"].ToString());
           }

           string sql2 = "select Id from nuser where IPORDER ='over' and WILORDER='over' and EQIORDER ='over' ";
           DataTable dt2 = new MySQLHelper().GetDataTable(sql2);
           for (int i = 0; i < dt2.Rows.Count; i++)
           {
               DataRow dr = dt.NewRow();
               dr["USERID"] = dt2.Rows[i]["Id"];
               for (int j = 0; j < dt1.Rows.Count; j++)
               {
                   dr[dt1.Rows[j]["EQIID"].ToString()] = new MySQLHelper().ExecuteValue("select ANSWER from eqianswer where EQIID=" + dt1.Rows[j]["EQIID"].ToString() + " and USERID=" + dt2.Rows[i]["ID"].ToString()) + "|" + new MySQLHelper().ExecuteValue("select SCORE from eqianswer where EQIID=" + dt1.Rows[j]["EQIID"].ToString() + " and USERID=" + dt2.Rows[i]["ID"].ToString());
                  
               }
               dt.Rows.Add(dr);
           }
           return dt;   
       }

       /// <summary>
       /// 导出Excel
       /// </summary>
       /// <returns></returns>
       public DataTable getDataTable2()
       {
           string sql = "select EQIID from eqitestquestions limit 201,382";
           DataTable dt1 = new MySQLHelper().GetDataTable(sql);
           DataTable dt = new DataTable();

           dt.Columns.Add("USERID");
           for (int i = 0; i < dt1.Rows.Count; i++)
           {
               dt.Columns.Add(dt1.Rows[i]["EQIID"].ToString());
           }

           string sql2 = "select Id from nuser where IPORDER ='over' and WILORDER='over' and EQIORDER ='over' ";
           DataTable dt2 = new MySQLHelper().GetDataTable(sql2);
           for (int i = 0; i < dt2.Rows.Count; i++)
           {
               DataRow dr = dt.NewRow();
               dr["USERID"] = dt2.Rows[i]["Id"];
               for (int j = 0; j < dt1.Rows.Count; j++)
               {
                   dr[dt1.Rows[j]["EQIID"].ToString()] = new MySQLHelper().ExecuteValue("select ANSWER from eqianswer where EQIID=" + dt1.Rows[j]["EQIID"].ToString() + " and USERID=" + dt2.Rows[i]["ID"].ToString()) + "|" + new MySQLHelper().ExecuteValue("select SCORE from eqianswer where EQIID=" + dt1.Rows[j]["EQIID"].ToString() + " and USERID=" + dt2.Rows[i]["ID"].ToString());

               }
               dt.Rows.Add(dr);
           }
           return dt;
       }

     
    }
}
