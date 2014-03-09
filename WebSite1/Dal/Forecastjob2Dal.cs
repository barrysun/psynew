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
   public  class Forecastjob2Dal
   {
       public void BindPager(GridView gv, AspNetPager pager, string whereStr)
       {
           var sql = @"
set @mycnt=0; 
select * from (
select *,(@mycnt := @mycnt + 1) as RowNum from forecastjob2 "+whereStr +@"
)as component where RowNum>{0} and RowNum<={1}";
           sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
           pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(FORECASTJOB2ID) from forecastjob2 " + whereStr));
           gv.DataSource = new MySQLHelper().GetDataTable(sql);
           gv.DataBind();
       }

       public Forecastjob2 Query(string jobid)
       {
           var sql = "select FORECASTJOB2ID,JOBID,CNOUTLOOK1,CNOUTLOOK2 from forecastjob2 where FORECASTJOB2ID='" + ((int)double.Parse(jobid)) + "'";
           var dt = new MySQLHelper().GetDataTable(sql);
           Forecastjob2 fjob2 = null;
           if (dt == null || dt.Rows.Count <= 0) return null;
           fjob2 = new Forecastjob2
           {
               ForecastJob2Id = int.Parse(dt.Rows[0]["FORECASTJOB2ID"].ToString()),
               JobId = int.Parse(dt.Rows[0]["JOBID"].ToString()),
               CnoutLook1 = dt.Rows[0]["CNOUTLOOK1"].ToString(),
               CnoutLook2 = dt.Rows[0]["CNOUTLOOK2"].ToString()
           };
           return fjob2;
       }

       #region AUD
       public bool Update(Forecastjob2 forjob2)
       {
           const string sql = "update forecastjob2 set CNOUTLOOK1=?CNOUTLOOK1,CNOUTLOOK2=?CNOUTLOOK2 where JOBID=?JOBID";
           var param=new MySqlParameter[3];
           param[0] = new MySqlParameter("?CNOUTLOOK1",MySqlDbType.String) {Value = forjob2.CnoutLook1};
           param[1] = new MySqlParameter("?CNOUTLOOK2",MySqlDbType.String) {Value = forjob2.CnoutLook2};
           param[2]=new MySqlParameter("?JOBID",MySqlDbType.Int32) {Value = forjob2.JobId};
           return new MySQLHelper().ExecuteSql(sql, param) == 1;
       }

       public bool Add(Forecastjob2 forjob2)
       {
           const string sql =
               "insert into forecastjob2 (JOBID,CNOUTLOOK1,CNOUTLOOK2) values(?JOBID,?CNOUTLOOK1,?CNOUTLOOK2)";
           var param = new MySqlParameter[3];
           param[0] = new MySqlParameter("?CNOUTLOOK1", MySqlDbType.String) { Value = forjob2.CnoutLook1 };
           param[1] = new MySqlParameter("?CNOUTLOOK2", MySqlDbType.String) { Value = forjob2.CnoutLook2 };
           param[2] = new MySqlParameter("?JOBID", MySqlDbType.Int32) { Value = forjob2.JobId };
           return new MySQLHelper().ExecuteSql(sql, param) == 1;
       }

       public bool Delete(Forecastjob2 forjob2)
       {
           const string sql = "delete from forecastjob2 where FORECASTJOB2ID=?FORECASTJOB2ID";
           var param = new MySqlParameter[1];
           param[0] = new MySqlParameter("?FORECASTJOB2ID",MySqlDbType.Int32){Value = forjob2.ForecastJob2Id};
           return new MySQLHelper().ExecuteSql(sql, param) == 1;
       }
       #endregion
   }
}
