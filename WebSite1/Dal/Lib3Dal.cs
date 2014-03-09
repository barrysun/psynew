using System;
using System.Collections.Generic;

using System.Text;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using Wuqi.Webdiyer;
using System.Data;
using Model;

namespace Dal
{
   public  class Lib3Dal
    {
       public void BindPager(GridView gv, AspNetPager pager, string whereStr)
       {
           string sql = @"
set @mycnt=0; 
select * from (
select *,(@mycnt := @mycnt + 1) as RowNum from lib3 "+whereStr+@"
)as lib where RowNum>{0} and RowNum<={1}";
           sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
           pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(CNNUMBER) from lib3 "+whereStr));
           gv.DataSource = new MySQLHelper().GetDataTable(sql);
           gv.DataBind();
       }

       public DataTable GetById(string cnnumber)
       {
           string sql = "select * from lib3 where CNNUMBER=" + cnnumber;
           return new MySQLHelper().GetDataTable(sql);
       
       }

       public Lib3 Query(string cnnumber)
       {
           var sql = "select CNNUMBER,CNNAME,CNDES,CNWORK  from lib3 where CNNUMBER=" + cnnumber;
           var dt = new MySQLHelper().GetDataTable(sql);
           Lib3 lib3 = null;
           if (dt != null && dt.Rows.Count > 0)
           {
               lib3 = new Lib3
               {
                   Cnnumber = int.Parse(dt.Rows[0]["CNNUMBER"].ToString()),
                   Cnname = dt.Rows[0]["CNNAME"].ToString(),
                   Cndes = dt.Rows[0]["CNDES"].ToString(),
                   Cnwork = dt.Rows[0]["CNWORK"].ToString()
               };
           }
           return lib3;
       
       }

       public bool Add(Lib3 lib3)
       {
           const string sql = "insert into lib3 (CNNUMBER,CNNAME,CNDES,CNWORK)values(?CNNUMBER,?CNNAME,?CNDES,?CNWORK)";
           var param = new MySqlParameter[4];
           param[0] = new MySqlParameter("?CNNUMBER", MySqlDbType.Int32) { Value = lib3.Cnnumber };
           param[1] = new MySqlParameter("?CNNAME", MySqlDbType.String) { Value = lib3.Cnname };
           param[2] = new MySqlParameter("?CNDES", MySqlDbType.String) { Value = lib3.Cndes };
           param[3] = new MySqlParameter("?CNWORK", MySqlDbType.String) { Value = lib3.Cnwork };
           return new MySQLHelper().ExecuteSql(sql, param) == 1;
       }

       public bool Update(Lib3 lib3)
       {
           const string sql = "update lib3 set  CNNUMBER,CNNAME,CNDES,CNWORK where CNNUMBER=?CNNUMBER";
           var param = new MySqlParameter[4];
           param[0]=new MySqlParameter("?CNNUMBER",MySqlDbType.Int32){ Value = lib3.Cnnumber};
           param[1] = new MySqlParameter("?CNNAME",MySqlDbType.String){ Value = lib3.Cnname};
           param[2]=new MySqlParameter("?CNDES",MySqlDbType.String){Value = lib3.Cndes};
           param[3]=new MySqlParameter("?CNWORK",MySqlDbType.String){Value = lib3.Cnwork};
           return new MySQLHelper().ExecuteSql(sql,param)==1;
       }

       public bool Delete(Lib3 lib3)
       {
           const string sql = "delete from lib3 where CNNUMBER=?CNNUMBER";
           var param = new MySqlParameter[1];
           param[0]=new MySqlParameter("?CNNUMBER",MySqlDbType.Int32){ Value = lib3.Cnnumber};
           return new MySQLHelper().ExecuteSql(sql, param) == 1;
       }

    }
}
