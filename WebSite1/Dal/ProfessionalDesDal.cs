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
  public   class ProfessionalDesDal
    {

      public void BindPager(GridView gv, AspNetPager pager, string whereStr)
      {
          var sql = @"
set @mycnt=0; 
select * from (
select *,(@mycnt := @mycnt + 1) as RowNum from professionalDes
)as adm where RowNum>{0} and RowNum<={1}";
          sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
          pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(Id) from professionalDes"));
          gv.DataSource = new MySQLHelper().GetDataTable(sql);
          gv.DataBind();
      }

      public void BindPager(Repeater gv, AspNetPager pager, string whereStr)
      {
          var sql = @"
set @mycnt=0; 
select * from (
select *,(@mycnt := @mycnt + 1) as RowNum from professionalDes "+whereStr+@"
)as adm where RowNum>{0} and RowNum<={1}";
          sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
          pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(Id) from professionalDes "+whereStr));
          gv.DataSource = new MySQLHelper().GetDataTable(sql);
          gv.DataBind();
      }

      public bool Add(ProfessionalDes prof)
      {
          return 1 == new MySQLHelper().ExecuteSql(
              "insert into professionalDes(TITLE1,TITLE2,TITLE3,DES,Work) values(?TITLE1,?TITLE2,?TITLE3,?DES,?Work) ", 
              new []
              {
                  new MySqlParameter("?TITLE1", MySqlDbType.String) {Value = prof.Title1},
                  new MySqlParameter("?TITLE2", MySqlDbType.String) {Value = prof.Title2},
                  new MySqlParameter("?TITLE3", MySqlDbType.String) {Value = prof.Title3},
                  new MySqlParameter("?DES", MySqlDbType.String) {Value = prof.Des},
                  new MySqlParameter("?Work", MySqlDbType.String) {Value = prof.Work}
              });
      }

      public bool Delete(int Id)
      {
          string sql = "delete from professionalDes where Id=?Id";
          MySqlParameter[] param = new MySqlParameter[1];
          param[0] = new MySqlParameter("?Id", MySqlDbType.Int32);
          param[0].Value = Id;
          if (1 == new MySQLHelper().ExecuteSql(sql, param))
          {
              return true;
           }
          return false;
      }

      public bool Update(ProfessionalDes prof)
      {
          return 1 == new MySQLHelper().ExecuteSql(
              "update professionalDes set TITLE1=?TITLE1,TITLE2=?TITLE2,TITLE3=?TIELE3,DES=?DES,Work=?Work where Id=?Id", 
              new []
              {
                  new MySqlParameter("?TITLE1", MySqlDbType.String) {Value = prof.Title1},
                  new MySqlParameter("?TTITLE2", MySqlDbType.String) {Value = prof.Title2},
                  new MySqlParameter("?TITLE3", MySqlDbType.String) {Value = prof.Title3},
                  new MySqlParameter("?DES", MySqlDbType.String) {Value = prof.Des},
                  new MySqlParameter("?Id", MySqlDbType.String) {Value = prof.Id},
                  new MySqlParameter("?Work", MySqlDbType.String) {Value = prof.Work}
              });
      }

      public DataTable Query(string whereStr)
      {
          return new MySQLHelper().GetDataTable("select * from professionalDes " + whereStr);
      }

      public DataTable getTitle1()
      {
          return new MySQLHelper().GetDataTable("select DISTINCT TITLE1 from professionalDes ");
      }

      public DataTable getTitle2(string Title1)
      {
          return new MySQLHelper().GetDataTable("select DISTINCT TITLE2 from professionalDes where TITLE1='" + Title1 + "'");
      }

      public DataTable getTitle3(string Title2)
      {
          return new MySQLHelper().GetDataTable("select DISTINCT TITLE3 from professionalDes where TITLE2='" + Title2 + "'");
      }
    }
}
