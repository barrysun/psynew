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
    /// 专家团队
    /// </summary>
   public  class ExpertDal
    {
       public void BindPager(GridView gv, AspNetPager pager, string whereStr)
       {
           string sql = @"
set @mycnt=0; 
select * from (
select *,(@mycnt := @mycnt + 1) as RowNum from expert
)as ex where RowNum>{0} and RowNum<={1}";
           sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
           pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(ID) from expert"));
           gv.DataSource = new MySQLHelper().GetDataTable(sql);
           gv.DataBind();
       }

       public bool Add(Expert expert)
       {
           string sql = "insert into expert(EXPERTNAME,EXPERTPHOTE,EXPERTDES,expert.ORDER,expert.TYPE) values (?EXPERTNAME,?EXPERTPHOTE,?EXPERTDES,?ORDER,?TYPE)";
           MySqlParameter[] param = new MySqlParameter[5];
           param[0] = new MySqlParameter("?EXPERTNAME", MySqlDbType.String);
           param[0].Value = expert.ExpertName;
           param[1] = new MySqlParameter("?EXPERTPHOTE", MySqlDbType.String);
           param[1].Value = expert.ExpertPhoto;
           param[2] = new MySqlParameter("?EXPERTDES", MySqlDbType.String);
           param[2].Value = expert.ExpertDes;
           param[3] = new MySqlParameter("?ORDER", MySqlDbType.Int32);
           param[3].Value = expert.Order;
           param[4] = new MySqlParameter("?TYPE", MySqlDbType.Int32);
           param[4].Value = expert.ExpertType;
           if (1 == new MySQLHelper().ExecuteSql(sql, param))
               return true;
           return false;
       }

       public bool Update(Expert expert)
       {

           return false;
       }
       public bool Delete(int id)
       {
           return false;
       }

       public DataTable getById(int id)
       {
           string sql = "select * from expert";
           return new MySQLHelper().GetDataTable(sql);
       }

       public DataTable getByWhereStr(string whereStr)
       {
           string sql = "select *,(case when expert.TYPE=2 then '心理学专家' else '易经专家' end) as TYPENAME from expert  "+whereStr;
           return new MySQLHelper().GetDataTable(sql);
       }


    }
}
