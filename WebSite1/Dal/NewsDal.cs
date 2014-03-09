using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

using System.Text;
using System.Web.UI.WebControls;
using Wuqi.Webdiyer;

namespace Dal
{
   public  class NewsDal
    {

       public void BindPager(GridView gv, AspNetPager pager, string whereStr)
       {
           var sql = @"
set @mycnt=0; 
select * from (
select *,(@mycnt := @mycnt + 1) as RowNum from news
)as n where RowNum>{0} and RowNum<={1}";
           sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
           pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(Id) from news"));
           gv.DataSource = new MySQLHelper().GetDataTable(sql);
           gv.DataBind();
       
       }

       public void BindPager(DataList gv, AspNetPager pager, string whereStr)
       {
           var sql = @"
set @mycnt=0; 
select * from (
select *,0 as typetype ,(@mycnt := @mycnt + 1) as RowNum from news "+whereStr+@"
)as n where RowNum>{0} and RowNum<={1}";
           sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
           pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(Id) from news "+whereStr));
           gv.DataSource = new MySQLHelper().GetDataTable(sql);
           gv.DataBind();
       }

       public DataTable getNewsHome(string whereStr)
       {
           return new MySQLHelper().GetDataTable("select ID,NewTitle,EditTime,NewContent,NewType,PICUrl,NewOrder,IsHome from news "+whereStr);
       }

       public bool Add(New news)
       {
           return 1 == new MySQLHelper().ExecuteSql(
               "insert into news(NewTitle,EditTime,NewContent,NewType,PICUrl,NewOrder,IsHome) values(?NewTitle,now(),?NewContent,?NewType,?PICUrl,?NewOrder,?IsHome)", 
               new []
               {
                   new MySqlParameter("?NewTitle", MySqlDbType.String) {Value = news.NewTitle},
                   new MySqlParameter("?NewContent", MySqlDbType.String) {Value = news.NewContent},
                   new MySqlParameter("?NewType", MySqlDbType.Int32) {Value = news.NewType},
                   new MySqlParameter("?PICUrl", MySqlDbType.String) {Value = news.PICUrl},
                   new MySqlParameter("?NewOrder", MySqlDbType.Int32) {Value = news.NewOrder},
                   new MySqlParameter("?IsHome", MySqlDbType.Int32) {Value = news.IsHome}
               });
       }

       public bool Update(New news)
       {
          // string sql = "insert into news(NewTitle,EditTime,NewContent,NewType,PICUrl,NewOrder,IsHome) values(?NewTitle,now(),?NewContent,?NewType,?PICUrl,?NewOrder,?IsHome)";
           return 1 == new MySQLHelper().ExecuteSql(
               "update news set NewTitle=?NewTitle,EditTime=now(),NewContent=?NewContent,NewType=?NewType,PICUrl=?PICUrl,NewOrder=?NewOrder,IsHome=?IsHome where ID=?ID", 
               new []
               {
                   new MySqlParameter("?NewTitle", MySqlDbType.String) {Value = news.NewTitle},
                   new MySqlParameter("?NewContent", MySqlDbType.String) {Value = news.NewContent},
                   new MySqlParameter("?NewType", MySqlDbType.Int32) {Value = news.NewType},
                   new MySqlParameter("?PICUrl", MySqlDbType.String) {Value = news.PICUrl},
                   new MySqlParameter("?NewOrder", MySqlDbType.Int32) {Value = news.NewOrder},
                   new MySqlParameter("?IsHome", MySqlDbType.Int32) {Value = news.IsHome},
                   new MySqlParameter("?ID", MySqlDbType.Int32) {Value = news.Id}
               });
       }

       public bool Delete(int id)
       {
           return 1 == new MySQLHelper().ExecuteSql(
               "delete from news where ID=?ID", 
               new []
               {
                   new MySqlParameter("?ID", MySqlDbType.Int32) {Value = id}
               });
       }

       public DataTable getById(int id)
       {
           return new MySQLHelper().GetDataTable(
               "select ID,NewTitle,EditTime,NewContent,NewType,PICUrl,NewOrder,IsHome from news where ID=?ID", 
               new []
               {
                   new MySqlParameter("?ID", MySqlDbType.Int32) {Value = id}
               });
       }
    }
}
