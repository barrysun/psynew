using System;
using System.Collections.Generic;

using System.Text;
using System.Web.UI.WebControls;
using Wuqi.Webdiyer;
using Model;
using MySql.Data.MySqlClient;
using System.Data;
namespace Dal
{
   public  class Forecastjob1Dal
    {

       public void BindPager(GridView gv, AspNetPager pager, string whereStr)
       {
           string sql = @"
set @mycnt=0; 
select * from (
select *,(@mycnt := @mycnt + 1) as RowNum from forecastjob1 "+whereStr+@"
)as component where RowNum>{0} and RowNum<={1}";
           sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
           pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(FORECASTJOB1ID) from forecastjob1 "+whereStr));
           gv.DataSource = new MySQLHelper().GetDataTable(sql);
           gv.DataBind();
       }
       #region AUD
       public bool Add(ForecastJob1 forecastJob1)
       {
          const  string sql = "insert into forecastjob1(CNMISSMAJOR,JOBID,CNMAJOR1,CNMAJOR2,CNMAJOR3) values(?CNMISSMAJOR,?JOBID,?CNMAJOR1,?CNMAJOR2,?CNMAJOR3)";
           var param=new MySqlParameter[5];
           param[0]=new MySqlParameter("?CNMISSMAJOR",MySqlDbType.Int32) {Value = forecastJob1.CnmissMajor};
           param[1]=new MySqlParameter("?JOBID",MySqlDbType.Int32) {Value = forecastJob1.JobId};
           param[2]=new MySqlParameter("?CNMAJOR1",MySqlDbType.String) {Value = forecastJob1.Cnmajor1};
           param[3]=new MySqlParameter("?CNMAJOR2",MySqlDbType.String) {Value = forecastJob1.Cnmajor2};
           param[4]=new MySqlParameter("?CNMAJOR3",MySqlDbType.String) {Value = forecastJob1.Cnmajor3};
           return 1 == new MySQLHelper().ExecuteSql(sql, param);
       }

       public bool Update(ForecastJob1 forecastJob1)
       {
           const string sql = "update forecastjob1 set CNMAJOR1=?CNMAJOR1,CNMAJOR2=?CNMAJOR2,CNMAJOR3=?CNMAJOR3 where JOBID=?JOBID";
           var param = new MySqlParameter[4];
           param[0] = new MySqlParameter("?CNMAJOR1",MySqlDbType.String){Value = forecastJob1.Cnmajor1};
           param[1] = new MySqlParameter("?CNMAJOR2",MySqlDbType.String){ Value = forecastJob1.Cnmajor2};
           param[2] = new MySqlParameter("?CNMAJOR3",MySqlDbType.String){Value = forecastJob1.Cnmajor3};
           param[3] = new MySqlParameter("?JOBID",MySqlDbType.String){ Value = forecastJob1.JobId};

           return new MySQLHelper().ExecuteSql(sql, param) == 1;

       }

       public bool Delete(int id)
       {
           const string sql = "delete from forecastjob1 where FORECASTJOB1ID=?FORECASTJOB1ID";
           var param = new MySqlParameter[1];
           param[0] = new MySqlParameter("?FORECASTJOB1ID",MySqlDbType.Int32){Value = id};
           return new MySQLHelper().ExecuteSql(sql, param) == 1; 
       }
       #endregion

       public ForecastJob1 Query(string jobid)
       {
           string sql = "select FORECASTJOB1ID, CNMISSMAJOR,JOBID,CNMAJOR1,CNMAJOR2,CNMAJOR3 from forecastjob1  where JOBID=" + jobid;
           ForecastJob1 forjob1 = null;
           DataTable dt = new MySQLHelper().GetDataTable(sql);
           if (dt != null && dt.Rows.Count > 0)
           {
               forjob1 = new ForecastJob1();
               forjob1.ForecastJob1Id = int.Parse(dt.Rows[0]["FORECASTJOB1ID"].ToString());
               forjob1.CnmissMajor = int.Parse(dt.Rows[0]["CNMISSMAJOR"].ToString());
               forjob1.JobId = int.Parse(dt.Rows[0]["JOBID"].ToString());
               forjob1.Cnmajor1 = dt.Rows[0]["CNMAJOR1"].ToString();
               forjob1.Cnmajor2 = dt.Rows[0]["CNMAJOR2"].ToString();
               forjob1.Cnmajor3 = dt.Rows[0]["CNMAJOR3"].ToString();
           }
           return forjob1;

       }
    }
}
