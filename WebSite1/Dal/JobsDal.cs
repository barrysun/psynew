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
   public class JobsDal
    {
      

       public bool UpdateJob(Jobs job)
       {
           string sql = @"update jobs set JianLiName=?JianLiName,RealName=?RealName,Xb=?Xb,BorthDay=?BorthDay,Hight=?Hight,HunYin=?HunYin,Jy=?Jy,Xl=?Xl,Tc=?Tc,Huji=?Huiji,
Phone=?Phone,Email=?Email,QQ=?QQ,DiZhi=?DiZhi,BoKe=?BoKe where Id=?Id";
           MySqlParameter[] param = new MySqlParameter[16];
           param[0] = new MySqlParameter("?JianLiName", MySqlDbType.String);
           param[0].Value = job.JianLiName;
           param[1] = new MySqlParameter("?RealName", MySqlDbType.String);
           param[1].Value = job.RealName;
           param[2] = new MySqlParameter("?Xb", MySqlDbType.String);
           param[2].Value = job.Xb;
           param[3] = new MySqlParameter("?BorthDay",MySqlDbType.String);
           param[3].Value  = job.BorthDay;
           param[4] = new MySqlParameter("?Hight", MySqlDbType.String);
           param[4].Value = job.Hight;
           param[5] = new MySqlParameter("?HunYin", MySqlDbType.String);
           param[5].Value = job.HunYin;
           param[6] = new MySqlParameter("?Jy", MySqlDbType.String);

           param[6].Value = job.Jy;
           param[7] = new MySqlParameter("?Xl", MySqlDbType.String);
           param[7].Value = job.Xl;
           param[8] = new MySqlParameter("?Tc", MySqlDbType.String);
           param[8].Value = job.Tc;
           param[9] = new MySqlParameter("?Huiji", MySqlDbType.String);
           param[9].Value = job.Huji;
           param[10] = new MySqlParameter("?Phone", MySqlDbType.String);
           param[10].Value = job.Phone;
           param[11] = new MySqlParameter("?Email", MySqlDbType.String);
           param[11].Value = job.Email;
           param[12] = new MySqlParameter("?QQ", MySqlDbType.String);
           param[12].Value = job.QQ;
           param[13] = new MySqlParameter("?DiZhi", MySqlDbType.String);
           param[13].Value = job.DiZhi;
           param[14] = new MySqlParameter("?BoKe", MySqlDbType.String);
           param[14].Value = job.BoKe;
           param[15] = new MySqlParameter("?Id", MySqlDbType.Int32);
           param[15].Value = job.Id;

           if (new MySQLHelper().ExecuteSql(sql, param) == 1)
           {
               return true;
           }

           return false;
       }

       public bool UpdateJob1(Jobs job)
       {
           string sql = @"update jobs set QiWangGongZuo=?QiWangGongZuo,QiWangXinZi=?QiWangXinZi,
QiWangGangWeiXinzhi=?QiWangGangWeiXinzhi,QiWangGangwei=?QiWangGangwei,GongZuoGangWei=?GongZuoGangWei,ZhuangTai=?ZhuangTai where Id=?Id";
           MySqlParameter[] param = new MySqlParameter[7];
           param[0] = new MySqlParameter("?QiWangGongZuo", MySqlDbType.String);
           param[0].Value = job.QiWangGongZuo;
           param[1] = new MySqlParameter("?QiWangXinZi", MySqlDbType.String);
           param[1].Value = job.QiWangXinZi;
           param[2] = new MySqlParameter("?QiWangGangWeiXinzhi", MySqlDbType.String);
           param[2].Value = job.QiWangGangWeiXinzhi;
           param[3] = new MySqlParameter("?QiWangGangwei", MySqlDbType.String);
           param[3].Value = job.QiWangGangwei;
           param[4] = new MySqlParameter("?GongZuoGangWei", MySqlDbType.String);
           param[4].Value = job.QiWangGangwei;
           param[5] = new MySqlParameter("?ZhuangTai", MySqlDbType.String);
           param[5].Value = job.ZhuangTai;
           param[6] = new MySqlParameter("?Id", MySqlDbType.Int32);
           param[6].Value = job.Id;
           if (new MySQLHelper().ExecuteSql(sql, param) == 1)
           {
               return true;
           }
           return false;
       }
       public bool UpdateJob2(Jobs job)
       {
           string sql = "update jobs set TeChang=?TeChang where Id=?Id";
           MySqlParameter[] param = new MySqlParameter[2];
           param[0] = new MySqlParameter("?TeChang", MySqlDbType.String);
           param[0].Value = job.TeChang;
           param[1] = new MySqlParameter("?Id", MySqlDbType.Int32);
           param[1].Value = job.Id;
           if (new MySQLHelper().ExecuteSql(sql, param) == 1)
           {
               return true;
           }
           return false;
       }
       public bool UpdateJob3(Jobs job)
       {
           string sql = "update jobs set JiaoYu=?JiaoYu,HuiJiang=?HuiJiang,Zhengshu=?Zhengshu,PeiXun=?PeiXun,GongZuoJinli=?GongZuoJinli where Id=?Id";
           MySqlParameter[] param = new MySqlParameter[6];
           param[0] = new MySqlParameter("?JiaoYu", MySqlDbType.String);
           param[0].Value = job.JiaoYu;
           param[1] = new MySqlParameter("?HuiJiang", MySqlDbType.String);
           param[1].Value = job.HuiJiang;
           param[2] = new MySqlParameter("?Zhengshu", MySqlDbType.String);
           param[2].Value = job.Zhengshu;
           param[3] = new MySqlParameter("?PeiXun", MySqlDbType.String);
           param[3].Value = job.PeiXun;
           param[4] = new MySqlParameter("?GongZuoJinli", MySqlDbType.String);
           param[4].Value = job.GongZuoJinli;
           param[5] = new MySqlParameter("?Id", MySqlDbType.Int32);
           param[5].Value = job.Id;
           if (new MySQLHelper().ExecuteSql(sql, param) == 1)
           {
               return true;
           }
           return false;
       }

       public bool UpdateJob4(Jobs job)
       {
           string sql = "update jobs set GerenNengLi=?GerenNengLi where Id=?Id";
           MySqlParameter[] param = new MySqlParameter[2];
           param[0] = new MySqlParameter("?GerenNengLi", MySqlDbType.String);
           param[0].Value = job.GerenNengLi;
           param[1] = new MySqlParameter("?Id", MySqlDbType.Int32);
           param[1].Value = job.Id;


           if (new MySQLHelper().ExecuteSql(sql, param) == 1)
           {
               return true;
           }
           return false;
       }

       public bool UpdateJob5(Jobs job)
       {
           string sql = "";
           MySqlParameter[] param = new MySqlParameter[7];

           if (new MySQLHelper().ExecuteSql(sql, param) == 1)
           {
               return true;
           }
           return false;
       }

       public DataTable Query(string whereStr)
       {
           return new MySQLHelper().GetDataTable("select * from jobs " + whereStr);
       }


       public void BindPager(Repeater gv, AspNetPager pager, string whereStr)
       {
           string sql = @"
set @mycnt=0; 
select * from (
select *,(@mycnt := @mycnt + 1) as RowNum from jobs "+whereStr+@"
)as job where RowNum>{0} and RowNum<={1}";
           sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
           pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(ID) from jobs "+whereStr));
           gv.DataSource = new MySQLHelper().GetDataTable(sql);
           gv.DataBind();
       }


       public int getId(int UserId)
       {
           string sql = " insert into jobs (UserId,InsertTime) values(" + UserId + ",now());select max(id) as m from jobs";
           return int.Parse(new MySQLHelper().GetDataTable(sql).Rows[0]["m"].ToString());
       }
   }
}
