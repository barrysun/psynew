using System;
using System.Collections.Generic;

using System.Text;
using System.Web.UI.WebControls;
using Wuqi.Webdiyer;
using Model;
using MySql.Data.MySqlClient;

namespace Dal
{
   public  class AdminUserDal
    {
       public void BindPager(GridView gv, AspNetPager pager, string whereStr)
       {
       var sql = @"
set @mycnt=0; 
select * from (
select *,(@mycnt := @mycnt + 1) as RowNum from admin
)as adm where RowNum>{0} and RowNum<={1}";
           sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
           pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(ADMINID) from admin"));
           gv.DataSource = new MySQLHelper().GetDataTable(sql);
           gv.DataBind();
       }

       public bool LoginAdmin(string userName, string password,int role)
       {
           const string sql = "select count(*) from admin where admin.NAME=?userName and PASSWORD=?password and POWERID=?role";
           var param = new MySqlParameter[3];
           param[0] = new MySqlParameter("?userName", MySqlDbType.String);
           param[0].Value = userName;
           param[1] = new MySqlParameter("?password", MySqlDbType.String);
           param[1].Value = password;
           param[2] = new MySqlParameter("?role", MySqlDbType.Int32);
           param[2].Value = role;
           return new MySQLHelper().GetDataTable(sql, param).Rows.Count == 1;
       }

       public bool Add(Admin admin)
       {
           return false;
       }
       public bool Update(Admin admin)
       {
           return false;
       }
       public bool Delete(int id)
       {
           return false; 
       }
    }
}
