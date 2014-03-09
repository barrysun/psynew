using System;
using System.Collections.Generic;

using System.Text;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using Wuqi.Webdiyer;
using System.Data;
using Model;

namespace Dal
{
   public  class IpQuestionDal
    {
       public void BindPagerAnswer(GridView gv, AspNetPager pager, string whereStr)
       {
           string sql = @"
set @mycnt=0; 
select * from (
select ipanswer.*,(@mycnt := @mycnt + 1) as RowNum,user.NAME,iptestquestions.IPTITLE from ipanswer,user,iptestquestions where `user`.USERID=ipanswer.USERID and ipanswer.IPID=iptestquestions.IPID
)as answer where RowNum>{0} and RowNum<={1}";
           string sqlCount = "select count(IPID) from ipanswer,user where user.USERID=ipanswer.USERID";
           if (whereStr != null && whereStr != "")
           {
               sql = @"
set @mycnt=0; 
select * from (
select ipanswer.*,(@mycnt := @mycnt + 1) as RowNum,user.NAME,iptestquestions.IPTITLE from ipanswer,user,iptestquestions where `user`.USERID=ipanswer.USERID and ipanswer.IPID=iptestquestions.IPID AND "+whereStr+")as answer where  RowNum>{0} and RowNum<={1}";
               sqlCount = "select count(IPID) from ipanswer,user where user.USERID=ipanswer.USERID AND " + whereStr;
           }
           sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
           pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue(sqlCount));
           gv.DataSource = new MySQLHelper().GetDataTable(sql);
           gv.DataBind();
       }

       public void BindPager(GridView gv, AspNetPager pager, string whereStr)
       {
           string sql = @"
set @mycnt=0; 
select * from (
select *,(@mycnt := @mycnt + 1) as RowNum from iptestquestions "+whereStr+@"
)as ipquestion where RowNum>{0} and RowNum<={1}";
           sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
           pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(IPID) from iptestquestions"+whereStr));
           gv.DataSource = new MySQLHelper().GetDataTable(sql);
           gv.DataBind();
       }

       public DataTable GetDataTable(string whereStr)
       {
           string sql = @"set @mycnt=0; 
select ipanswer.*,(@mycnt := @mycnt + 1) as RowNum,user.NAME,iptestquestions.IPTITLE from ipanswer,user,iptestquestions where `user`.USERID=ipanswer.USERID and ipanswer.IPID=iptestquestions.IPID";
           if (whereStr != null && whereStr != "")
           {
               sql = @"set @mycnt=0; 
select ipanswer.*,(@mycnt := @mycnt + 1) as RowNum,user.NAME,iptestquestions.IPTITLE from ipanswer,user,iptestquestions where `user`.USERID=ipanswer.USERID and ipanswer.IPID=iptestquestions.IPID AND "+whereStr;
           }
           
           return new MySQLHelper().GetDataTable(sql);

       }

       public DataTable GetById(string ipid)
       {
           string sql = "select * from iptestquestions where IPID=" + ipid;
           return new MySQLHelper().GetDataTable(sql);
       }
       /// <summary>
       /// 保存答案
       /// </summary>
       /// <param name="beans"></param>
       /// <returns></returns>
       public bool addAnswers(List<IpAnswer> beans)
       {
           String sql = "";
           if (beans.Count > 0)
               sql = "insert into ipanswer (USERID,IPID,ANSWER,SCORE) values ";
           for (int i = 0; i < beans.Count; i++)
           {
               sql += "(" + beans[i].UserId + "," + beans[i].IpId +
                       ",'" + beans[i].Answer + "'," + beans[i].Score + "),";
           }
           if (beans.Count > 0) sql = sql.Substring(0, sql.Length - 1);
           if (1 <=new MySQLHelper().ExecuteSql(sql))
           {
               return true;
           }
           return false;
       }

       /// <summary>
       /// 查询数据
       /// </summary>
       /// <param name="startRow"></param>
       /// <param name="pageSize"></param>
       /// <returns></returns>
       public DataTable getIpQuestions(int startRow, int pageSize)
       {
           string sql = "select IPID,IPTYPE,IPTITLE,LIKESCORE,NOTLIKESCORE,UNCERTAINSCORE,IPORDER from iptestquestions order by IPORDER limit " + startRow + "," + pageSize;
           return new MySQLHelper().GetDataTable(sql); 
       }

       public Dictionary<string, string> getAnswerAndType(int userID)
       {
           Dictionary<string, string> dic = new Dictionary<string, string>();
           string sql = "select sum(score) as rescore,iptest.iptype as myiptype  from ipanswer i,iptestquestions iptest  where i.ipid=iptest.ipid and i.userid=" + userID + " group by iptest.iptype order by iptest.iptype";
           DataTable dt = new MySQLHelper().GetDataTable(sql);
           if (dt != null && dt.Rows.Count > 0)
           {
               for (int i = 0; i < dt.Rows.Count; i++)
               {
                   dic.Add(dt.Rows[i]["myiptype"].ToString(), dt.Rows[i]["rescore"].ToString());
               }
           }
           return dic;
       }

       /// <summary>
       /// 导出Excel
       /// </summary>
       /// <returns></returns>
       public DataTable getDataTable()
       {
           string sql = "select IPID from iptestquestions";
           DataTable dt1 = new MySQLHelper().GetDataTable(sql);
           DataTable dt = new DataTable();

           dt.Columns.Add("USERID");
           for (int i = 0; i < dt1.Rows.Count; i++)
           {
               dt.Columns.Add(dt1.Rows[i]["IPID"].ToString());
           }

           string sql2 = "select Id from nuser where IPORDER ='over' and WILORDER='over' and EQIORDER ='over' ";
           DataTable dt2 = new MySQLHelper().GetDataTable(sql2);
           for (int i = 0; i < dt2.Rows.Count; i++)
           {
               DataRow dr = dt.NewRow();
               dr["USERID"] = dt2.Rows[i]["Id"];
               for (int j = 0; j < dt1.Rows.Count; j++)
               {
                   dr[dt1.Rows[j]["IPID"].ToString()] = new MySQLHelper().ExecuteValue("select ANSWER from ipanswer where IPID=" + dt1.Rows[j]["IPID"].ToString() + " and USERID=" + dt2.Rows[i]["ID"].ToString()) + "|" + new MySQLHelper().ExecuteValue("select SCORE from ipanswer where IPID=" + dt1.Rows[j]["IPID"].ToString() + " and USERID=" + dt2.Rows[i]["ID"].ToString());

               }
               dt.Rows.Add(dr);
           }
           return dt;
       }

      

       public bool Update(IpTestQuestion ipTestQuestion)
       {
           const string sql =
               "update iptestquestions set IPTYPE=?IPTYPE,IPTITLE=?IPTITLE,LIKESCORE=?LIKESCORE," +
               "NOTLIKESCORE=?NOTLIKESCORE,UNCERTAINSCORE=?UNCERTAINSCORE,IPORDER=?IPORDER where IPID=?IPID";
           var param = new MySqlParameter[6];
           param[0] = new MySqlParameter("?IPTYPE",MySqlDbType.String){Value = ipTestQuestion.IpType};
           param[1] = new MySqlParameter("?IPTITLE",MySqlDbType.String){Value = ipTestQuestion.IpTitle};
           param[2] = new MySqlParameter("?LIKESCORE",MySqlDbType.Double){Value = ipTestQuestion.LikeScore};
           param[3] = new MySqlParameter("?NOTLIKESCORE",MySqlDbType.Double){Value = ipTestQuestion.NotLikeScore};
           param[4] = new MySqlParameter("?UNCERTAINSCORE",MySqlDbType.Double){Value = ipTestQuestion.UncertainScore};
           param[5]=new MySqlParameter("?IPID",MySqlDbType.Int32){Value = ipTestQuestion.IpId};
           return new MySQLHelper().ExecuteSql(sql, param) == 1;
       }

       public bool Add(IpTestQuestion ipTestQuestion)
       {
           const string sql =
               "insert into iptestquestions (IPTYPE,IPTITLE,LIKESCORE,NOTLIKESCORE,UNCERTAINSCORE,IPORDER) values" +
               "(?IPTYPE,?IPTITLE,?LIKESCORE,?NOTLIKESCORE,?UNCERTAINSCORE,?IPORDER)";
           var param = new MySqlParameter[5];
           param[0] = new MySqlParameter("?IPTYPE", MySqlDbType.String) { Value = ipTestQuestion.IpType };
           param[1] = new MySqlParameter("?IPTITLE", MySqlDbType.String) { Value = ipTestQuestion.IpTitle };
           param[2] = new MySqlParameter("?LIKESCORE", MySqlDbType.Double) { Value = ipTestQuestion.LikeScore };
           param[3] = new MySqlParameter("?NOTLIKESCORE", MySqlDbType.Double) { Value = ipTestQuestion.NotLikeScore };
           param[4] = new MySqlParameter("?UNCERTAINSCORE", MySqlDbType.Double) { Value = ipTestQuestion.UncertainScore };
           return new MySQLHelper().ExecuteSql(sql, param) == 1;
       }

       public bool Delete(IpTestQuestion ipTestQuestion)
       {
           const string sql = "delete from iptestquestions where IPID=?IPID";
           var param = new MySqlParameter[1];
           param[0]=new MySqlParameter("?IPID",MySqlDbType.Int32){Value = ipTestQuestion.IpId};
           return new MySQLHelper().ExecuteSql(sql, param) == 1;
       }


       public void Test()
       {
           getDataTable();
       }

    }
}
