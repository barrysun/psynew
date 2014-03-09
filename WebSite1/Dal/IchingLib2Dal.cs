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
   public  class IchingLib2Dal
    {
        public void BindPager(GridView gv, AspNetPager pager, string whereStr)
        {
            string sql = @"
set @mycnt=0; 
select * from (
select *,(@mycnt := @mycnt + 1) as RowNum from ichinglib2
)as ichinglib where RowNum>{0} and RowNum<={1}";
            sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
            pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(ID) from ichinglib2"));
            gv.DataSource = new MySQLHelper().GetDataTable(sql);
            gv.DataBind();
        }



        public Ichinglib2 YgAndYz(string bornday, string datatime)
        {
            Ichinglib2 ic2 = new Ichinglib2();
            string sql = "select ID,DATE,TIME,YG,YZ from ichinglib2";
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
                else {
                    day2 = dt.Rows[i+1]["DATE"].ToString();
                    time2 = dt.Rows[i+1]["TIME"].ToString();
                }
                if (dateCompare(bornday.Trim() + " " + datatime.Trim(), day1.Trim() + " " + time1.Trim(), day2.Trim() + " " + time2.Trim()))
                {
                  //ic2
                    ic2.Id = int.Parse(dt.Rows[i]["ID"].ToString());
                    ic2.Date = dt.Rows[i]["DATE"].ToString();
                    ic2.Time = dt.Rows[i]["TIME"].ToString();
                    ic2.Yg = int.Parse(dt.Rows[i]["YG"].ToString());
                    ic2.Yz=int.Parse(dt.Rows[i]["YZ"].ToString());
                }
            }
            return ic2;
        }

        public bool dateCompare(string day, string day1, string day2)
        {
            DateTime da = DateTime.Parse(day);
            DateTime da1 = DateTime.Parse(day1);

            DateTime da2 = new DateTime();
            try
            {
                da2 = DateTime.Parse(day2);
            }
            catch (Exception e)
            { 
            
            
            }
            if ((DateTime.Compare(da, da1) >= 0) && (DateTime.Compare(da, da2) < 0))
            {
                return true;
            }
            return false;
        }

        #region AUD

       public Ichinglib2 GetById(string id)
       {
           const string sql = "select ID,DATE,TIME,YG,YZ where ID=?ID";
           var param = new MySqlParameter[1];
           param[0]=new MySqlParameter("?ID",MySqlDbType.Int32){Value = id};
           DataTable dt = new MySQLHelper().GetDataTable(sql, param);
           if (dt != null && dt.Rows.Count > 0)
           {
               return new Ichinglib2()
               {
                   Id=int.Parse(dt.Rows[0]["ID"].ToString()),
                   Date = dt.Rows[0]["DATE"].ToString(),
                   Time = dt.Rows[0]["TIME"].ToString(),
                   Yg=int.Parse(dt.Rows[0]["YG"].ToString()),
                   Yz=int.Parse(dt.Rows[0]["YZ"].ToString())
               };
           }
           return null;
       }


        public bool Update(Ichinglib2 lib2)
        {
            const string sql = "update ichinglib2 set DATE=?DATE,TIME=?TIME,YG=?YG,YZ=?YZ where ID=?ID";
            var param = new MySqlParameter[5];
            param[0]=new MySqlParameter("?DATE",MySqlDbType.String){Value = lib2.Date};
            param[1]=new MySqlParameter("?TIME",MySqlDbType.String){Value = lib2.Time};
            param[2]=new MySqlParameter("?YG",MySqlDbType.Int32){Value = lib2.Yg};
            param[3]=new MySqlParameter("?YZ",MySqlDbType.Int32){Value = lib2.Yz};
            param[4]=new MySqlParameter("?ID",MySqlDbType.Int32){Value = lib2.Id};
            return new MySQLHelper().ExecuteSql(sql, param)==1;
        }

        public bool Delete(Ichinglib2 lib2)
        {
            const string sql = "delete ichinglib2 where ID=?ID";
            var param = new MySqlParameter[1];
            param[0] = new MySqlParameter("?ID", MySqlDbType.Int32) { Value = lib2.Id };
            return new MySQLHelper().ExecuteSql(sql, param) == 1;
        }
        public bool Add(Ichinglib2 lib2)
        {
            const string sql = "insert into ichinglib2 ( DATE,TIME,YG,YZ) values(?DATE,?TIME,?YG,?YZ) ";
            var param = new MySqlParameter[4];
            param[0] = new MySqlParameter("?DATE", MySqlDbType.String) { Value = lib2.Date };
            param[1] = new MySqlParameter("?TIME", MySqlDbType.String) { Value = lib2.Time };
            param[2] = new MySqlParameter("?YG", MySqlDbType.Int32) { Value = lib2.Yg };
            param[3] = new MySqlParameter("?YZ", MySqlDbType.Int32) { Value = lib2.Yz };
           
            return new MySQLHelper().ExecuteSql(sql, param) == 1;
        }
        #endregion
    }
}
