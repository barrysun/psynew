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
   public  class Lib4Dal
    {
       public void BindPager(GridView gv, AspNetPager pager, string whereStr)
       {
           string sql = @"
set @mycnt=0; 
select * from (
select *,(@mycnt := @mycnt + 1) as RowNum from lib4 "+whereStr+@"
)as lib where RowNum>{0} and RowNum<={1}";
           sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
           pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(ID) from lib4 "+whereStr));
           gv.DataSource = new MySQLHelper().GetDataTable(sql);
           gv.DataBind();
       }

       public List<Lib4> Query(string number)
       {
           string sql = "select ID,PARENTID,CNUMBER,CNNAME,SCORE,ISNODE from lib4 where  CNUMBER ="+number+"";
           DataTable dt = new MySQLHelper().GetDataTable(sql);
           List<Lib4> lib4s = new List<Lib4>();
           if (dt != null && dt.Rows.Count > 0)
           {
               Lib4 lib4 = new Lib4();
               lib4.Id = int.Parse(dt.Rows[0]["ID"].ToString());
               lib4.ParentId = int.Parse(dt.Rows[0]["PARENTID"].ToString());
               lib4.Cnumber = int.Parse(dt.Rows[0]["CNUMBER"].ToString());
               lib4.Cnname = dt.Rows[0]["CNNAME"].ToString();
               lib4.Score = double.Parse(dt.Rows[0]["SCORE"].ToString());
              // lib4.IsNode = int.Parse(dt.Rows[0]["ISNODE"].ToString());
               lib4s.Add(lib4);
           }
           return lib4s;
       }

       public string[] QueryBigSmallByParentId(string number)
       {
           var dt = new MySQLHelper().GetDataTable("select min(x.SCORE) as m,max(x.SCORE) as m2 from (select * from lib4 where  PARENTID =" + number + " and SCORE!=-1) x");
           return new []
           {
               dt.Rows[0]["m"].ToString(),
               dt.Rows[0]["m2"].ToString()
           };
       }

       public Lib4 GetById(string id)
       {
           var dt = new MySQLHelper().GetDataTable("select ID,PARENTID,CNUMBER,CNNAME,SCORE,ISNODE from lib4 where  id =" + id + "");
           return (dt != null && dt.Rows.Count > 0)
               ? new Lib4()
               {
                   Id = int.Parse(dt.Rows[0]["ID"].ToString()),
                   ParentId = int.Parse(dt.Rows[0]["PARENTID"].ToString()),
                   Cnumber = int.Parse(dt.Rows[0]["CNUMBER"].ToString()),
                   Cnname = dt.Rows[0]["CNNAME"].ToString(),
                   Score = double.Parse(dt.Rows[0]["SCORE"].ToString()),
                   IsNode = int.Parse(dt.Rows[0]["ISNODE"].ToString())
               }
               : null;
       }

       public bool Add(Lib4 lib4)
       {
           return new MySQLHelper().ExecuteSql(
               "insert lib4 (PARENTID,CNUMBER,CNNAME,SCORE,ISNODE) vlaues(?PARENTID,?CNUMBER,?CNNAME,?SCORE,?ISNODE)",
               new []
               {
                    new MySqlParameter("?PARENTID", MySqlDbType.Int32) {Value = lib4.ParentId},
                    new MySqlParameter("?CNUMVER", MySqlDbType.String) {Value = lib4.Cnumber},
                    new MySqlParameter("?CNNAME", MySqlDbType.String) {Value = lib4.Cnname},
                    new MySqlParameter("?SCORE", MySqlDbType.Float) {Value = lib4.Score},
                    new MySqlParameter("?ISNODE", MySqlDbType.Int32) {Value = lib4.IsNode}

               }) == 1;
       }

       public bool Delete(Lib4 lib4)
       {
           return new MySQLHelper().ExecuteSql(
               "delete from  lib4 where ID=?ID ", 
               new []
               {
                   new MySqlParameter("?ID",MySqlDbType.Int32) {Value = lib4.Id}
               }) == 1;
       }

       public bool Update(Lib4 lib4)
       {
           return new MySQLHelper().ExecuteSql(
               "update lib4 set PARENTID=?PARENTID,CNUMBER=?CNUMBER,CNNAME=?CNNAME,SCORE=?SCORE,ISNODE=?ISNODE where ID=?ID",
               new []
               {
                   new MySqlParameter("?PARENTID", MySqlDbType.Int32) {Value = lib4.ParentId},
                   new MySqlParameter("?CNUMVER", MySqlDbType.String) {Value = lib4.Cnumber},
                   new MySqlParameter("?CNNAME", MySqlDbType.String) {Value = lib4.Cnname},
                   new MySqlParameter("?SCORE", MySqlDbType.Float) {Value = lib4.Score},
                   new MySqlParameter("?ISNODE", MySqlDbType.Int32) {Value = lib4.IsNode},
                   new MySqlParameter("?ISNODE", MySqlDbType.Int32) {Value = lib4.IsNode}
               }) == 1;
       }
    }
}
