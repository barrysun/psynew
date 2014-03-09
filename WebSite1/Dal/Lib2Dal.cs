using System;
using System.Collections.Generic;

using System.Text;
using System.Web.UI.WebControls;
using Wuqi.Webdiyer;
using System.Data;
using Model;
using MySql.Data.MySqlClient;

namespace Dal
{
   public  class Lib2Dal
    {
       public void BindPager(GridView gv, AspNetPager pager, string whereStr)
       {
           string sql = @"
set @mycnt=0; 
select * from (
select *,(@mycnt := @mycnt + 1) as RowNum from lib2profession "+whereStr+@"
)as lib where RowNum>{0} and RowNum<={1}";
           sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
           pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(NUMBER) from lib2profession "+whereStr));
           gv.DataSource = new MySQLHelper().GetDataTable(sql);
           gv.DataBind();
       }

       public DataTable GetById(string number)
       {
           string sql = "select * from lib2profession where NUMBER=" + number;
           return new MySQLHelper().GetDataTable(sql);
       
       }

       public Lib2Profession Query(string number)
       {
           string sql = "select NUMBER,Lib2NAME,DESCRIPTION from lib2profession where NUMBER='" + ((int)double.Parse(number)) + "'";
           DataTable dt = new MySQLHelper().GetDataTable(sql);
           Lib2Profession lib2 =null;
           if (dt != null && dt.Rows.Count > 0)
           {
               lib2 = new Lib2Profession();
               lib2.Number = dt.Rows[0]["NUMBER"].ToString();
               lib2.Lib2Name = dt.Rows[0]["Lib2NAME"].ToString();
               lib2.DEScription = dt.Rows[0]["DESCRIPTION"].ToString();
           }

           return lib2;
       }

       public bool Add(Lib2Profession lib2)
       {
           const string sql = "insert into lib2profession(NUMBER,Lib2NAME,DESCRIPTION) values(?NUMBER,?Lib2NAME,?DESCRIPTION)";
           var param = new MySqlParameter[3];
           param[0] = new MySqlParameter("?NUMBER", MySqlDbType.String) {Value = lib2.Number};
           param[1] = new MySqlParameter("?Lib2NAME", MySqlDbType.String) {Value = lib2.Lib2Name};
           param[2] = new MySqlParameter("?DESCRIPTION", MySqlDbType.String) {Value = lib2.DEScription};
           return new MySQLHelper().ExecuteSql(sql, param) == 1;
       }

       public bool Update(Lib2Profession lib2)
       {
           const string sql = "update lib2profession set Lib2NAME=?Lib2NAME,DESCRIPTION=?DESCRIPTION where NUMBER=?NUMBER";
           var param = new MySqlParameter[3];
           param[0] = new MySqlParameter("?NUMBER", MySqlDbType.String) {Value = lib2.Number};
           param[1] = new MySqlParameter("?Lib2NAME", MySqlDbType.String) {Value = lib2.Lib2Name};
           param[2] = new MySqlParameter("?DESCRIPTION", MySqlDbType.String) {Value = lib2.DEScription};
           return new MySQLHelper().ExecuteSql(sql, param) == 1;
       }

       public bool Delete(Lib2Profession lib2)
       {
           const string sql = "delete from lib2profession where NUMBER=?NUMBER";
           var param = new MySqlParameter[3];
           param[0] = new MySqlParameter("?NUMBER",MySqlDbType.String){ Value =lib2.Number};
           return new MySQLHelper().ExecuteSql(sql, param) == 1;
       }


    }
}
