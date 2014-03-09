using System;
using System.Collections.Generic;
using System.Data;

using System.Text;
using System.Web.UI.WebControls;
using Wuqi.Webdiyer;

namespace Dal
{
   public  class UserDal
    {
       public void BindPager(GridView gv, AspNetPager pager, string whereStr)
       {
           var sql = @"
set @mycnt=0; 
select * from (
select *,(@mycnt := @mycnt + 1) as RowNum from user
)as u where RowNum>{0} and RowNum<={1}";
           sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
           pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(USERID) from user"));
           gv.DataSource = new MySQLHelper().GetDataTable(sql);
           gv.DataBind();
       }

       public DataTable getById(int userId)
       {
           return new MySQLHelper().GetDataTable("select USERID,BORNTIME,BORNDAY,GENDER from user where USERID=" + userId);

       }

       public DataTable getAnswerOrder(int userId)
       {
           return new MySQLHelper().GetDataTable("select IPORDER,WILORDER,EQIORDER from nuser where Id=" + userId);
       }

       public void updateAnswerOrder(string order, string ordername,int userId)
       {
           new MySQLHelper().ExecuteSql("update nuser set " + ordername + "='" + order + "' where Id=" + userId);
       }



    }
}
