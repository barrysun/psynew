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
   public  class EntranceDal
    {
       public void BindPager(GridView gv, AspNetPager pager, string whereStr)
       {
           var sql = @"
set @mycnt=0; 
select * from (
select *,(@mycnt := @mycnt + 1) as RowNum from entrance " + whereStr + @"
)as ex where RowNum>{0} and RowNum<={1}";
           sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
           pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(ID) from entrance " + whereStr));
           gv.DataSource = new MySQLHelper().GetDataTable(sql);
           gv.DataBind();
       }

       public bool Delete(int id)
       {
           const string sql = "delete from entrance where Id=?Id";
           var param = new MySqlParameter[1];
           param[0] = new MySqlParameter("?Id", MySqlDbType.Int32) {Value = id};
           return new MySQLHelper().ExecuteSql(sql, param) == 1;
       }
       public bool Update(Entrance entrance)
       {
           return new MySQLHelper().ExecuteSql(
               "update entrance set ENTRANCETYPE=?ENTRANCETYPE,CONTENT=?CONTENT,EDITTIME=now(),ISHOME=?ISHOME,entrance.ORDER=?ORDER,TITLE=?TITLE where ID=?ID", 
               new []
               {
                   new MySqlParameter("?ENTRANCETYPE", MySqlDbType.Int32) {Value = entrance.EntranceType},
                   new MySqlParameter("?CONTENT", MySqlDbType.String) {Value = entrance.Content},
                   new MySqlParameter("?ISHOME", MySqlDbType.Int32) {Value = entrance.IsHome},
                   new MySqlParameter("?ORDER", MySqlDbType.Int32) {Value = entrance.Order},
                   new MySqlParameter("?TITLE", MySqlDbType.String) {Value = entrance.Title},
                   new MySqlParameter("?ID", MySqlDbType.Int32) {Value = entrance.Id}
               }) == 1;
       }

       public bool Add(Entrance entrance)
       {
           return new MySQLHelper().ExecuteSql(
               "insert into entrance (ENTRANCETYPE,CONTENT,EDITTIME,ISHOME,entrance.ORDER,TITLE) values(?ENTRANCETYPE,?CONTENT,now(),?ISHOME,?ORDER,?TITLE)", 
               new []
               {
                   new MySqlParameter("?ENTRANCETYPE", MySqlDbType.Int32) {Value = entrance.EntranceType},
                   new MySqlParameter("?CONTENT", MySqlDbType.String) {Value = entrance.Content},
                   new MySqlParameter("?ISHOME", MySqlDbType.Int32) {Value = entrance.IsHome},
                   new MySqlParameter("?ORDER", MySqlDbType.Int32) {Value = entrance.Order},
                   new MySqlParameter("?TITLE", MySqlDbType.String) {Value = entrance.Title}
               }) == 1;
       }

       public DataTable getByWhereStr(string whereStr)
       {
           return new MySQLHelper().GetDataTable( "SELECT ID,ENTRANCETYPE,CONTENT,EDITTIME,entrance.ORDER,TITLE from entrance "+whereStr);
       }

       public void BindNewLists(DataList gv, AspNetPager pager, string whereStr)
       {
           var sql = @"
set @mycnt=0; 
select * from (
select entrance.*,ENTRANCETYPE as typetype,TITLE as NewTitle,(@mycnt := @mycnt + 1) as RowNum from entrance " + whereStr + @"
)as ex where RowNum>{0} and RowNum<={1}";
           sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
           pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(ID) from entrance " + whereStr));
           gv.DataSource = new MySQLHelper().GetDataTable(sql);
           gv.DataBind();
       }
    }
}
