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
   public  class FirmInfoDal
    {

       public void BindPager(Repeater gv, AspNetPager pager, string whereStr)
       {
           string sql = @"
set @mycnt=0; 
select * from (
select *,(@mycnt := @mycnt + 1) as RowNum from firmInfo
)as adm where RowNum>{0} and RowNum<={1}";
           sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
           pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(Id) from firmInfo"));
           gv.DataSource = new MySQLHelper().GetDataTable(sql);
           gv.DataBind();
       }

       public void BindPager2(Repeater gv, AspNetPager pager, string whereStr)
       {
           string sql = @"
set @mycnt=0; 
select * from (
select firmInfo.*,company.GongName as CompanyName,(@mycnt := @mycnt + 1) as RowNum from firmInfo,company where firmInfo.CompanyId=company.Id
)as adm where RowNum>{0} and RowNum<={1}";
           sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
           pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(Id) from firmInfo"));
           gv.DataSource = new MySQLHelper().GetDataTable(sql);
           gv.DataBind();
       }

       public bool Add(FirmInfo firm)
       {
           string sql = @"insert into firmInfo(CompanyId,Zhiwei,Xb,GongzuoXinzhi,Renshu,StartTime,EndTime,GongZuoDiDian,Xl,Jy,Gzfw,Des) values
(?CompanyId,?Zhiwei,?Xb,?GongzuoXinzhi,?Renshu,?StartTime,?EndTime,?GongZuoDiDian,?Xl,?Jy,?Gzfw,?Des)";
           MySqlParameter[] param=new MySqlParameter[12];
           param[0] = new MySqlParameter("?CompanyId", MySqlDbType.Int32);
           param[0].Value = firm.CompanyId;
           param[1] = new MySqlParameter("?Zhiwei", MySqlDbType.String);
           param[1].Value = firm.Zhiwei;
           param[2] = new MySqlParameter("?Xb", MySqlDbType.String);
           param[2].Value = firm.Xb;
           param[3] = new MySqlParameter("?GongzuoXinzhi", MySqlDbType.String);
           param[3].Value = firm.GongzuoXinzhi;
           param[4] = new MySqlParameter("?Renshu", MySqlDbType.String);
           param[4].Value = firm.Renshu;
           param[5] = new MySqlParameter("?StartTime", MySqlDbType.String);
           param[5].Value = firm.StartTime;
           param[6] = new MySqlParameter("?EndTime", MySqlDbType.String);
           param[6].Value = firm.EndTime;
           param[7] = new MySqlParameter("?GongZuoDiDian", MySqlDbType.String);
           param[7].Value = firm.GongZuoDiDian;
           param[8] = new MySqlParameter("?Xl", MySqlDbType.String);
           param[8].Value = firm.Xl;
           param[9] = new MySqlParameter("?Jy", MySqlDbType.String);
           param[9].Value = firm.Jy;
           param[10] = new MySqlParameter("?Gzfw", MySqlDbType.String);
           param[10].Value = firm.Gzfw;
           param[11] = new MySqlParameter("?Des", MySqlDbType.String);
           param[11].Value = firm.Des;
           if (new MySQLHelper().ExecuteSql(sql, param)==1)
           {
               return true;
           }
           return false;
       }

       public bool Delete(int Id)
       {
           string sql = "delete from firmInfo where Id=?Id";
           MySqlParameter[] param = new MySqlParameter[1];
           param[0] = new MySqlParameter("?Id", MySqlDbType.Int32);
           param[0].Value = Id;
           if (new MySQLHelper().ExecuteSql(sql, param) == 1)
           {
               return true;
           }
           return false;
       }

       public bool Update(FirmInfo firm)
       {
           string sql = @"update firmInfo set CompanyId=?CompanyId,Zhiwei=?Zhiwei,Xb=?Xb,GongzuoXinzhi=?GongzuoXinzhi,Renshu=?Renshu,StartTime=?StartTime,EndTime=?EndTime,GongZuoDiDian=?GongZuoDiDian,Xl=?Xl,Jy=?Jy,Gzfw=?Gzfw,Des=?Des where Id=?Id";
           MySqlParameter[] param = new MySqlParameter[13];
           param[0] = new MySqlParameter("?CompanyId", MySqlDbType.Int32);
           param[0].Value = firm.CompanyId;
           param[1] = new MySqlParameter("?Zhiwei", MySqlDbType.String);
           param[1].Value = firm.Zhiwei;
           param[2] = new MySqlParameter("?Xb", MySqlDbType.String);
           param[2].Value = firm.Xb;
           param[3] = new MySqlParameter("?GongzuoXinzhi", MySqlDbType.String);
           param[3].Value = firm.GongzuoXinzhi;
           param[4] = new MySqlParameter("?Renshu", MySqlDbType.String);
           param[4].Value = firm.Renshu;
           param[5] = new MySqlParameter("?StartTime", MySqlDbType.String);
           param[5].Value = firm.StartTime;
           param[6] = new MySqlParameter("?EndTime", MySqlDbType.String);
           param[6].Value = firm.EndTime;
           param[7] = new MySqlParameter("?GongZuoDiDian", MySqlDbType.String);
           param[7].Value = firm.GongZuoDiDian;
           param[8] = new MySqlParameter("?Xl", MySqlDbType.String);
           param[8].Value = firm.Xl;
           param[9] = new MySqlParameter("?Jy", MySqlDbType.String);
           param[9].Value = firm.Jy;
           param[10] = new MySqlParameter("?Gzfw", MySqlDbType.String);
           param[10].Value = firm.Gzfw;
           param[11] = new MySqlParameter("?Des", MySqlDbType.String);
           param[11].Value = firm.Des;
           param[12] = new MySqlParameter("?Id", MySqlDbType.Int32);
           param[12].Value = firm.Id;
           if (new MySQLHelper().ExecuteSql(sql, param) == 1)
           {
               return true;
           }
           return false;
       }
       public DataTable Query(string whereStr)
       {
           string sql = "select * from firminfo " + whereStr;
           return new MySQLHelper().GetDataTable(sql);
       }

       public void BindPager1(Repeater gv, AspNetPager pager, string whereStr)
       {
           string sql = @"
set @mycnt=0; 
select * from (
select f.*,c.GongName,(@mycnt := @mycnt + 1) as RowNum from firmInfo f,company c where c.Id = f.CompanyId "+whereStr+@"
)as job where RowNum>{0} and RowNum<={1}";
           sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
           pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(*) from firmInfo,company where company.Id=firmInfo.companyId"));
           gv.DataSource = new MySQLHelper().GetDataTable(sql);
           gv.DataBind();
       }

       public DataTable getById(int id)
       {
           string sql = "select f.*,c.* from firminfo f,company c where f.Id=" + id + " and c.id=f.CompanyId";
           return new MySQLHelper().GetDataTable(sql);
       }
   
   }
}
