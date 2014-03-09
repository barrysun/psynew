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
    /// <summary>
    /// 社会职业类
    /// </summary>
   public  class CommunityDal
    {
       public void BindPager(GridView gv, AspNetPager pager, string whereStr)
       {
           var sql = @"
set @mycnt=0; 
select * from (
select *,(@mycnt := @mycnt + 1) as RowNum from community "+whereStr+@"
)as ex where RowNum>{0} and RowNum<={1}";
           sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
           pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(ID) from community "+whereStr));
           gv.DataSource = new MySQLHelper().GetDataTable(sql);
           gv.DataBind();
       }
       public bool Delete(int id)
       {
           var sql = "delete form community where ID=" + id;
           return 1 == new MySQLHelper().ExecuteSql(sql);
       }

       public bool Update(Community community)
       {
           const string sql = "update community set TITLE=?TITLE,CONTENT=?CONTENT,EDITTIME=now(),ISHOME=?ISHOME,community.ORDER=?ORDER where ID=?ID";
           var param = new MySqlParameter[5];
           param[0] = new MySqlParameter("?TITLE", MySqlDbType.String) {Value = community.Title};
           param[1] = new MySqlParameter("?ID", MySqlDbType.Int32) {Value = community.Id};
           param[2] = new MySqlParameter("?CONTENT", MySqlDbType.String) {Value = community.Content};
           param[3] = new MySqlParameter("?ISHOME", MySqlDbType.Int32) {Value = community.IsHome};
           param[4] = new MySqlParameter("?ORDER", MySqlDbType.Int32) {Value = community.Order};
           return new MySQLHelper().ExecuteSql(sql, param) == 1;
       }
       public bool Add(Community community)
       {
           const string sql = "insert into community(TITLE,community.TYPE,CONTENT,EDITTIME,ISHOME,community.ORDER) values(?TITLE,?TYPE,?CONENT,now(),?ISHOME,?ORDER)";
           var param = new MySqlParameter[5];
           param[0] = new MySqlParameter("?TITLE", MySqlDbType.String) {Value = community.Title};
           param[1] = new MySqlParameter("?TYPE", MySqlDbType.Int32) {Value = community.Type};
           param[2] = new MySqlParameter("?CONENT", MySqlDbType.String) {Value = community.Content};
           param[3] = new MySqlParameter("?ISHOME", MySqlDbType.Int32) {Value = community.IsHome};
           param[4] = new MySqlParameter("?ORDER", MySqlDbType.Int32) {Value = community.Order};
           return new MySQLHelper().ExecuteSql(sql, param) == 1;
       }

       public DataTable getByWhereStr(string whereStr)
       {
           var sql = "SELECT ID,TITLE,community.TYPE,CONTENT,EDITTIME,ISHOME,community.ORDER from community "+whereStr;
           return new MySQLHelper().GetDataTable(sql);
       
       }

       public void BindPager(DataList gv, AspNetPager pager, string whereStr)
       {
           var sql = @"
set @mycnt=0; 
select * from (
select *,TITLE as NewTitle,(case when community.TYPE = 1 then 4 else 5 end) as typetype,(@mycnt := @mycnt + 1) as RowNum from community " + whereStr + @"
)as ex where RowNum>{0} and RowNum<={1}";
           sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
           pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(ID) from community " + whereStr));
           gv.DataSource = new MySQLHelper().GetDataTable(sql);
           gv.DataBind();
       }

    }
}
