using Model;
using System;
using System.Collections.Generic;
using System.Data;

using System.Text;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using Wuqi.Webdiyer;

namespace Dal
{
   public  class IchingLib1Dal
    {
       public void BindPager(GridView gv, AspNetPager pager, string whereStr)
       {
           string sql = @"
set @mycnt=0; 
select * from (
select *,(@mycnt := @mycnt + 1) as RowNum from ichinglib1
)as ichinglib where RowNum>{0} and RowNum<={1}";
           sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
           pager.RecordCount = Num();
           gv.DataSource = new MySQLHelper().GetDataTable(sql);
           gv.DataBind();
       }

       private int Num() { 
         return int.Parse(new MySQLHelper().ExecuteValue("select count(ID) from ichinglib1"));
       
       }

       public Ichinglib1 getNgAndNz(string bornday,string datatime)
       {
           Ichinglib1 ic1 = new Ichinglib1();
           string sql = "select ID,DATE,TIME,NG,NZ from ichinglib1  ";
           DataTable dt = new MySQLHelper().GetDataTable(sql);
           for (int i = 0; i < dt.Rows.Count; i++)
           {
               string day1 = dt.Rows[i]["DATE"].ToString();
               string time1 = dt.Rows[i]["TIME"].ToString();

               string day2 = "";
               string time2 = "";
               if (i == dt.Rows.Count - 1)
               {
                   day2 = dt.Rows[i]["DATE"].ToString();
                   time2 = dt.Rows[i]["TIME"].ToString();
               }
               else
               {
                   day2 = dt.Rows[i + 1]["DATE"].ToString();
                   time2 = dt.Rows[i + 1]["TIME"].ToString();
               }
               if (new IchingLib2Dal().dateCompare(bornday + " " + datatime, day1 + " " + time1, day2 + " " + time2))
               {
                   //ic2
                   ic1.Id = int.Parse(dt.Rows[i]["ID"].ToString());
                   ic1.Date = dt.Rows[i]["DATE"].ToString();
                   ic1.Time = dt.Rows[i]["TIME"].ToString();
                   ic1.Ng = int.Parse(dt.Rows[i]["NG"].ToString());
                   ic1.Nz = int.Parse(dt.Rows[i]["NZ"].ToString());
               }
           }
           return ic1;

       
       }


       public Ichinglib1 GetById(string id)
       {
           string sql = "select ID,DATE,TIME,NG,NZ from ichinglib1 where ID= " + id;
           DataTable dt = new MySQLHelper().GetDataTable(sql);
           if (dt != null && dt.Rows.Count > 0)
           {
               return new Ichinglib1()
               {
                   Id=int.Parse(dt.Rows[0]["ID"].ToString()),
                   Date = dt.Rows[0]["DATE"].ToString(),
                   Time = dt.Rows[0]["TIME"].ToString(),
                   Ng = int.Parse(dt.Rows[0]["NG"].ToString()),
                   Nz=int.Parse(dt.Rows[0]["NZ"].ToString())
               };
           }
           return null;
       }

       #region AUD

       public bool Add(Ichinglib1 lib1)
       {
           const string sql = "insert into ichinglib1 (DATE,TIME,NG,NZ) values(?DATE,?TIME,?NG,?NZ)";
           var param = new MySqlParameter[4];
           param[0]=new MySqlParameter("?DATE",MySqlDbType.String){Value = lib1.Date};
           param[1]=new MySqlParameter("?TIME",MySqlDbType.String){Value = lib1.Time};
           param[2]=new MySqlParameter("?NG",MySqlDbType.Int32){Value = lib1.Ng};
           param[3]=new MySqlParameter("?NZ",MySqlDbType.Int32){Value = lib1.Nz};
           return new MySQLHelper().ExecuteSql(sql, param) == 1;
       }

       public bool Delete(Ichinglib1 lib1)
       {
           const string sql = "delete from ichinglib1 where ID=?ID";
           var param = new MySqlParameter[1];
           param[0]=new MySqlParameter("?ID",MySqlDbType.Int32){Value = lib1.Id};
           return new MySQLHelper().ExecuteSql(sql, param) == 1;
       }

       public bool Update(Ichinglib1 lib1)
       {
           const string sql = "update ichinglib1 set DATE=?DATE,TIME=?TIME,NG=?NG,NZ=?NZ where ID=?ID";
           var param = new MySqlParameter[5];
           param[0] = new MySqlParameter("?DATE", MySqlDbType.String) { Value = lib1.Date };
           param[1] = new MySqlParameter("?TIME", MySqlDbType.String) { Value = lib1.Time };
           param[2] = new MySqlParameter("?NG", MySqlDbType.Int32) { Value = lib1.Ng };
           param[3] = new MySqlParameter("?NZ", MySqlDbType.Int32) { Value = lib1.Nz };
           param[4]=new MySqlParameter("?ID",MySqlDbType.Int32){Value = lib1.Id};
           return new MySQLHelper().ExecuteSql(sql, param) == 1;
       }
       #endregion
    }
}
