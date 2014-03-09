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
   public  class Lib5Dal
    {
       public void BindPager(GridView gv, AspNetPager pager, string whereStr)
       {
           string sql = @"
set @mycnt=0; 
select * from (
select LIBFIVEDETAILID,(case when LIBFIVETYPEID=1 then '子库5' when LIBFIVETYPEID=2 then '子库6' when LIBFIVETYPEID=3 then '子库7' when LIBFIVETYPEID=4 then '子库8' when LIBFIVETYPEID=5 then '子库9' when LIBFIVETYPEID=6 then '子库10' end ) as LIBTYPE,MARK,LIBNAME,DESCRIPTION,(@mycnt := @mycnt + 1) as RowNum from libfivedetail "+whereStr+@"
)as lib where RowNum>{0} and RowNum<={1}";
           sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
           pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(LIBFIVEDETAILID) from libfivedetail "+whereStr));
           gv.DataSource = new MySQLHelper().GetDataTable(sql);
           gv.DataBind();
       }


       public string getDes(string mark)
       {
           string sql = "select LIBFIVEDETAILID,LIBFIVETYPEID,MARK,LIBNAME,DESCRIPTION from libfivedetail where MARK='" + mark + "'";
           DataTable dt = new MySQLHelper().GetDataTable(sql);
           if (dt != null && dt.Rows.Count > 0)
           {
               return dt.Rows[0]["DESCRIPTION"].ToString();
           }
           else
               return "";
       
       }

       public List<Lib5> queryLib10Id(string whereStr)
       { 
         string sql="select MARK,LIBNAME,DESCRIPTION from libfivedetail where MARK in ("+whereStr+")";
         List<Lib5> lib5s = new List<Lib5>();
         DataTable dt = new MySQLHelper().GetDataTable(sql);
         if (dt != null && dt.Rows.Count > 0)
         {
             for (int i = 0; i < dt.Rows.Count; i++)
             {
                 Lib5 lib5 = new Lib5();
                 lib5.Mark = dt.Rows[i]["MARK"].ToString();
                 lib5.LibName = dt.Rows[i]["LIBNAME"].ToString();
                 lib5.DescripTion = dt.Rows[i]["DESCRIPTION"].ToString();
                 lib5s.Add(lib5);
             }
         }
         return lib5s;
          
       }

       public Lib5 GetById(string lib5Id)
       {
           var dt = new MySQLHelper().GetDataTable("select LIBFIVEDETALID,LIBFIVETYPEID,MARK,LIBNAME,DESCRIPTION from libfivedetail where LIBFIVEDETAILID= "+lib5Id);
           if (dt != null && dt.Rows.Count > 0)
           {
                 return new Lib5()
                 {
                   Mark = dt.Rows[0]["MARK"].ToString(),
                   LibName = dt.Rows[0]["LIBNAME"].ToString(),
                   DescripTion = dt.Rows[0]["DESCRIPTION"].ToString(),
                   LibFiveDetailId = int.Parse(dt.Rows[0]["LIBFIVEDETALID"].ToString()),
                   LibFiveTypeId = int.Parse(dt.Rows[0]["LIBFIVETYPEID"].ToString())
                 };
               }
           
           return null;
       }

       public bool Add(Lib5 lib5)
       {
           return new MySQLHelper().ExecuteSql(
              "insert into libfivedetail(LIBFIVETYPEID,MARK,LIBNAME,DESCRIPTION) values(?LIBFIVETYPEID,?MARK,?LIBNAME,?DESCRIPTION)" , 
              new []
              {
                  new MySqlParameter("?LIBFIVETYPEID", MySqlDbType.Int32) {Value = lib5.LibFiveTypeId},
                  new MySqlParameter("?MARK", MySqlDbType.String) {Value = lib5.Mark},
                  new MySqlParameter("?LIBNAME", MySqlDbType.String) {Value = lib5.LibName},
                  new MySqlParameter("?DESCRIPTION", MySqlDbType.String) {Value = lib5.DescripTion}
              }) == 1;
       }

       public bool Delete(Lib5 lib5)
       {
           return new MySQLHelper().ExecuteSql(
               "delete from libfivedetail where LIBFIVEDEAILID=?LIBFIVEDEAILID", 
               new[]
               {
                   new MySqlParameter("?LIBFIVEDEAILID", MySqlDbType.Int32) {Value = lib5.LibFiveDetailId}
               }) == 1;
       }

       public bool Update(Lib5 lib5)
       {
           return new MySQLHelper().ExecuteSql(
               " update libfivedetail set LIBFIVETYPEID=?LIBFIVETYPEID,MARK=?MARK,LIBNAME=?LIBNAME,DESCRIPTION=?DESCRIPTION where LIBFIVEDETAILID=?LIBFIVEDETAILID", 
               new []
               {
                   new MySqlParameter("?LIBFIVETYPEID", MySqlDbType.Int32) {Value = lib5.LibFiveTypeId},
                   new MySqlParameter("?MARK", MySqlDbType.String) {Value = lib5.Mark},
                   new MySqlParameter("?LIBNAME", MySqlDbType.String) {Value = lib5.LibName},
                   new MySqlParameter("?DESCRIPTION", MySqlDbType.String) {Value = lib5.DescripTion},
                   new MySqlParameter("?LIBFIVEDETAILID", MySqlDbType.Int32) {Value = lib5.LibFiveDetailId}
               }) == 1;
       }
    }
}
