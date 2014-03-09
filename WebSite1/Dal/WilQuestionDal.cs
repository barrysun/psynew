using Model;
using System;
using System.Collections.Generic;
using System.Data;

using System.Text;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using Wuqi.Webdiyer;

namespace Dal
{
   public  class WilQuestionDal
    {
       public void BindPager(GridView gv, AspNetPager pager, string whereStr)
       {
           string sql = @"
set @mycnt=0; 
select * from (
select *,(@mycnt := @mycnt + 1) as RowNum from wiltestquestions "+whereStr+@"
)as wilquestion where RowNum>{0} and RowNum<={1}";
           sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
           pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(WILID) from wiltestquestions "+whereStr));
           gv.DataSource = new MySQLHelper().GetDataTable(sql);
           gv.DataBind();
       }
       public void BindPagerAnswer(GridView gv, AspNetPager pager, string whereStr)
       {
           string sql = @"
set @mycnt=0; 
select * from (
select wilanswer.*,(@mycnt := @mycnt + 1) as RowNum,user.NAME,wiltestquestions.WILTITLE from wilanswer,user,wiltestquestions where `user`.USERID=wilanswer.USERID and wilanswer.WILID=wiltestquestions.WILID
)as answer where RowNum>{0} and RowNum<={1}";
           sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
           pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(WILID) from wilanswer"));
           gv.DataSource = new MySQLHelper().GetDataTable(sql);
           gv.DataBind();
       }

    
        public DataTable GetDataTable(string whereStr)
       {
           string sql = @"select wilanswer.*,(@mycnt := @mycnt + 1) as RowNum,user.NAME,wiltestquestions.WILTITLE from wilanswer,user,wiltestquestions where `user`.USERID=wilanswer.USERID and wilanswer.WILID=wiltestquestions.WILID";
           if (!string.IsNullOrEmpty(whereStr))
           {
               sql += " AND " + whereStr;
           }
           return new MySQLHelper().GetDataTable(sql);    
       }

       public WilTestQuestion Query(string wilid)
       {
           const string sql = "select * from wiltestquestions where WILID=?WILID";
           var param = new MySqlParameter[1];
           param[0]=new MySqlParameter("?WILID",MySqlDbType.Int32){Value = wilid};
           DataTable dt = new MySQLHelper().GetDataTable(sql, param);
           if (dt != null && dt.Rows.Count > 0)
           {
               return new WilTestQuestion()
               {
                   WilId = int.Parse(dt.Rows[0]["WILID"].ToString()),
                   WilType = dt.Rows[0]["WILTYPE"].ToString(),
                   LetterMark = dt.Rows[0]["LETTERMARK"].ToString(),
                   WilTitle = dt.Rows[0]["WILTITLE"].ToString(),
                   ImportScore = float.Parse(dt.Rows[0]["IMPORTSCORE"].ToString()),
                   SecondlyScore = float.Parse(dt.Rows[0]["SECONDLYSCORE"].ToString()),
                   GeneralScore = float.Parse(dt.Rows[0]["GENERALSCORE"].ToString()),
                   SomeimportScore = float.Parse(dt.Rows[0]["SOMEIMPORTSCORE"].ToString()),
                   NotinportScore = float.Parse(dt.Rows[0]["NOTINORTSCORE"].ToString()),
                   WilOrder = int.Parse(dt.Rows[0]["WILORDER"].ToString())
               };
           }
           return null;
       }


       #region CUD
       public bool Update(WilTestQuestion wilTestQuestion)
       {
           const string sql =
               "update wiltestquestions set WILTYPE=?WILTYPE,LETTERMARK=?LETTERMARK,WILTITLE=?WILTITLE," +
               "IMPORTSCORE=?IMPORTSCORE,SECONDLYSCORE=?SECONDLYSCORE,GENERALSCORE=?GENERALSCORE," +
               "SOMEIMPORTSCORE=?SOMEIMPORTSCORE,NOTINPORTSCORE=?NOTINPORTSCORE,WILORDER=?WILORDER where WILID=?WILID";
           var param = new MySqlParameter[10];
           param[0] = new MySqlParameter("?WILTYPE",MySqlDbType.String){Value = wilTestQuestion.WilType};
           param[1] = new MySqlParameter("?LETTERMARK",MySqlDbType.String){Value = wilTestQuestion.LetterMark};
           param[2]=new MySqlParameter("?WILTITLE",MySqlDbType.String){Value = wilTestQuestion.WilTitle};
           param[3]=new MySqlParameter("?IMPORTSCORE",MySqlDbType.Double){Value = wilTestQuestion.ImportScore};
           param[4] = new MySqlParameter("?SECONDLYSCORE",MySqlDbType.Double){Value = wilTestQuestion.SecondlyScore};
           param[5] = new MySqlParameter("?GENERALSCORE",MySqlDbType.Double){Value = wilTestQuestion.GeneralScore};
           param[6] = new MySqlParameter("?SOMEIMPORTSCORE",MySqlDbType.Double){Value = wilTestQuestion.SomeimportScore};
           param[7] = new MySqlParameter("?NOTINPORTSCORE",MySqlDbType.Double){Value = wilTestQuestion.NotinportScore};
           param[8] = new MySqlParameter("?WILORDER",MySqlDbType.Double){Value = wilTestQuestion.WilOrder};
           param[9]=new MySqlParameter("?WILID",MySqlDbType.Int32){Value = wilTestQuestion.WilId};
           return new MySQLHelper().ExecuteSql(sql, param) == 1;

       }

       public bool Add(WilTestQuestion wilTestQuestion)
       {
           const string sql = "insert into wiltestquestions (WILTYPE,LETTERMARK,WILTITLE,IMPORTSCORE,SECONDLYSCORE,GENERALSCORE,SOMEIMPORTSCORE,NOTINPORTSCORE,WILORDER )values " +
                              "(?WILTYPE,?LETTERMARK,?WILTITLE,?IMPORTSCORE,?SECONDLYSCORE,?GENERALSCORE,?SOMEIMPORTSCORE,?NOTINPORTSCORE,?WILORDER)";
             
           var param = new MySqlParameter[9];
           param[0] = new MySqlParameter("?WILTYPE", MySqlDbType.String) { Value = wilTestQuestion.WilType };
           param[1] = new MySqlParameter("?LETTERMARK", MySqlDbType.String) { Value = wilTestQuestion.LetterMark };
           param[2] = new MySqlParameter("?WILTITLE", MySqlDbType.String) { Value = wilTestQuestion.WilTitle };
           param[3] = new MySqlParameter("?IMPORTSCORE", MySqlDbType.Double) { Value = wilTestQuestion.ImportScore };
           param[4] = new MySqlParameter("?SECONDLYSCORE", MySqlDbType.Double) { Value = wilTestQuestion.SecondlyScore };
           param[5] = new MySqlParameter("?GENERALSCORE", MySqlDbType.Double) { Value = wilTestQuestion.GeneralScore };
           param[6] = new MySqlParameter("?SOMEIMPORTSCORE", MySqlDbType.Double) { Value = wilTestQuestion.SomeimportScore };
           param[7] = new MySqlParameter("?NOTINPORTSCORE", MySqlDbType.Double) { Value = wilTestQuestion.NotinportScore };
           param[8] = new MySqlParameter("?WILORDER", MySqlDbType.Double) { Value = wilTestQuestion.WilOrder };
           return new MySQLHelper().ExecuteSql(sql, param) == 1;
       }

       public bool Delete(WilTestQuestion wilTestQuestion)
       {
           const string sql = "delete from wiltestquestions where WILID=?WILID";

           var param = new MySqlParameter[1];
           param[0] = new MySqlParameter("?WILID", MySqlDbType.Int32) { Value = wilTestQuestion.WilId };
           return new MySQLHelper().ExecuteSql(sql, param) == 1;
       }

       #endregion

       public DataTable getByStarRowAndEndRow(string startRow, string pageSize)
        {
            string sql = "select WILID,WILTYPE,LETTERMARK,WILTITLE,IMPORTSCORE,SECONDLYSCORE,GENERALSCORE,SOMEIMPORTSCORE,NOTINPORTSCORE,WILORDER from wiltestquestions order by WILID limit " + startRow + "," + pageSize;
            return new MySQLHelper().GetDataTable(sql); 
        }

        public Dictionary<string, string> getTypeAndAnswer(int userId)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            string sql = "select sum(w.score) as myscore,wi.wiltype mywiltype from wilanswer w,wiltestquestions wi where wi.wilid=w.wilid and w.userid=" + userId + " group by wi.wiltype";
            DataTable dt = new MySQLHelper().GetDataTable(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dic.Add(dt.Rows[i]["mywiltype"].ToString(), dt.Rows[i]["myscore"].ToString());
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
            string sql = "select WILID from wiltestquestions";
            DataTable dt1 = new MySQLHelper().GetDataTable(sql);
            DataTable dt = new DataTable();

            dt.Columns.Add("USERID");
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                dt.Columns.Add(dt1.Rows[i]["WILID"].ToString());
            }

            string sql2 = "select Id from nuser where IPORDER ='over' and WILORDER='over' and EQIORDER ='over' ";
            DataTable dt2 = new MySQLHelper().GetDataTable(sql2);
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr["USERID"] = dt2.Rows[i]["Id"];
                for (int j = 0; j < dt1.Rows.Count; j++)
                {
                    dr[dt1.Rows[j]["WILID"].ToString()] = new MySQLHelper().ExecuteValue("select ANSWER from wilanswer where WILID=" + dt1.Rows[j]["WILID"].ToString() + " and USERID=" + dt2.Rows[i]["ID"].ToString()) + "|" + new MySQLHelper().ExecuteValue("select SCORE from WILanswer where WILID=" + dt1.Rows[j]["WILID"].ToString() + " and USERID=" + dt2.Rows[i]["ID"].ToString());

                }
                dt.Rows.Add(dr);
            }
            return dt;
        }

        public void Test()
        {
            getDataTable();
        }
    }
}
