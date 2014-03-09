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
    public   class IchingLib3Dal
    {
        public void BindPager(GridView gv, AspNetPager pager, string whereStr)
        {
            string sql = @"
set @mycnt=0; 
select * from (
select *,(@mycnt := @mycnt + 1) as RowNum from ichinglib3
)as ichinglib where RowNum>{0} and RowNum<={1}";
            sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
            pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(ID) from ichinglib3"));
            gv.DataSource = new MySQLHelper().GetDataTable(sql);
            gv.DataBind();
        }

        public Ichinglib3  getByDay(int year, int month)
        {
            string sql = "select ID,YEAR,MONTH,FDG,FDZ from ichinglib3 where YEAR=" + year + " and MONTH=" + month;
            DataTable dt= new MySQLHelper().GetDataTable(sql);
            Ichinglib3 ic3 = new Ichinglib3();
            if (dt != null && dt.Rows.Count == 1)
            { 
                ic3.Id=int.Parse(dt.Rows[0]["ID"].ToString());
                ic3.Year = int.Parse(dt.Rows[0]["YEAR"].ToString());
                ic3.Month = int.Parse(dt.Rows[0]["MONTH"].ToString());
                ic3.Fdg = int.Parse(dt.Rows[0]["FDG"].ToString());
                ic3.Fdz = int.Parse(dt.Rows[0]["FDZ"].ToString());

               
            }
            return ic3;
        }


        #region AUD

        public Ichinglib3 GetById(string id)
        {
            const string sql = "select YEAR,MONTH,FDG,FDZ from ichinglib3 where ID=?ID";
            var param = new MySqlParameter[1];
            param[0]=new MySqlParameter("?ID",MySqlDbType.Int32){Value = id};
            DataTable dt = new MySQLHelper().GetDataTable(sql, param);
            if (dt != null && dt.Rows.Count > 0)
            {
                return new Ichinglib3()
                {
                    Id=int.Parse(dt.Rows[0]["ID"].ToString()),
                    Year = int.Parse(dt.Rows[0]["YEAR"].ToString()),
                    Month = int.Parse(dt.Rows[0]["MONTH"].ToString()),
                    Fdg = int.Parse(dt.Rows[0]["FDG"].ToString()),
                    Fdz=int.Parse(dt.Rows[0]["FDZ"].ToString())
                };
            }
            return null;
        }


        public bool Add(Ichinglib3 lib3)
        {
            const string sql = "insert into ichinglib3 (YEAR,MONTH,FDG,FDZ) values(?YEAR,?MONTH,?FDG,?FDZ)";
            var param = new MySqlParameter[4];
            param[0]=new MySqlParameter("?YEAR",MySqlDbType.Int32){Value = lib3.Year};
            param[1]=new MySqlParameter("?MONTH",MySqlDbType.Int32){Value = lib3.Month};
            param[2]=new MySqlParameter("?FDG",MySqlDbType.Int32){Value = lib3.Fdg};
            param[3]=new MySqlParameter("?FDZ",MySqlDbType.Int32){Value = lib3.Fdz};
            return new MySQLHelper().ExecuteSql(sql, param) == 1;
        }

        public bool Delete(Ichinglib3 lib3)
        {
            const string sql = "delete from ichinglib3 where ID=?ID";
            var param = new MySqlParameter[1];
            param[0]=new MySqlParameter("?ID",MySqlDbType.Int32){Value = lib3.Id};
            return new MySQLHelper().ExecuteSql(sql, param) == 1;
        }
        public bool Update(Ichinglib3 lib3)
        {
            const string sql = "update ichinglib3 set YEAR=?YEAR,MONTH=?MONTH,FDG=?FDG,FDZ=?FDZ where ID=?ID";
            var param = new MySqlParameter[5];
            param[0] = new MySqlParameter("?YEAR", MySqlDbType.Int32) { Value = lib3.Year };
            param[1] = new MySqlParameter("?MONTH", MySqlDbType.Int32) { Value = lib3.Month };
            param[2] = new MySqlParameter("?FDG", MySqlDbType.Int32) { Value = lib3.Fdg };
            param[3] = new MySqlParameter("?FDZ", MySqlDbType.Int32) { Value = lib3.Fdz };
            param[4]=new MySqlParameter("?ID",MySqlDbType.Int32){Value = lib3.Id};
            return new MySQLHelper().ExecuteSql(sql, param) == 1;
        }


        #endregion
    }
}
