using Model;
using System;
using System.Collections.Generic;
using System.Data;

using System.Text;
using System.Web.UI.WebControls;
using Wuqi.Webdiyer;

namespace Dal
{
   public  class YlDal
    {
       public void BindPager(GridView gv, AspNetPager pager, string whereStr)
       {
           var sql = @"
set @mycnt=0; 
select * from (
select *,(@mycnt := @mycnt + 1) as RowNum from ylgl
)as yl where RowNum>{0} and RowNum<={1}";
           sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
           pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(ID) from ylgl"));
           gv.DataSource = new MySQLHelper().GetDataTable(sql);
           gv.DataBind();
       }

       /// <summary>
       /// yy 1 表示阳
       /// yy -1 表示阴
       /// </summary>
       /// <param name="yl"></param>
       /// <param name="xb"></param>
       /// <param name="yy"></param>
       /// <returns></returns>
       public Ylgl getByXb(Ylgl yl, int xb,int yy)
       {
           string sql = "";
           //xb = (xb == isrun(yl.Yyear)) ? xb : (-xb); 1996 男顺数 女逆数
           int bs = 1;

           if (yy==1)
           {
               if (xb == -1)
               {
                   bs = -1;
               }
               if (xb == 1)
               {
                   bs = 1;
               }
           }
           else {
               if (xb == 1)
               {
                   bs = -1;
               }

               if (xb == -1)
               {
                   bs = 1;
               }
           }

          
           switch (bs)
           {
               case 1: 
                   sql="select ID,YYEAR,YMONTH,YDAY,YDES,DTIME,CONCAT(CONCAT(CONCAT(CONCAT(YYEAR,'/'),YMONTH),'/'),YDAY) as d from ylgl where YMD >='"+yl.Yyear+"-"+yl.Ymonth+"-"+yl.Yday+" "+yl.Dtime+"' order by ID asc limit 1";
                   break;
               case -1:
                   sql = "select ID,YYEAR,YMONTH,YDAY,YDES,DTIME,CONCAT(CONCAT(CONCAT(CONCAT(YYEAR,'/'),YMONTH),'/'),YDAY) as d from ylgl where YMD <='" + yl.Yyear + "-" + yl.Ymonth + "-" + yl.Yday + " " + yl.Dtime + "' order by ID desc limit 1";
                   break;
           }
           DataTable dt = new MySQLHelper().GetDataTable(sql);
           Ylgl yl2 = new Ylgl();
           if (dt != null && dt.Rows.Count > 0)
           {
               yl2.Id = int.Parse(dt.Rows[0]["ID"].ToString());
               yl2.Yyear = int.Parse(dt.Rows[0]["YYEAR"].ToString());
               yl2.Yday = int.Parse(dt.Rows[0]["YDAY"].ToString());
               yl2.Ymonth = int.Parse(dt.Rows[0]["YMONTH"].ToString());
               yl2.Ydes = dt.Rows[0]["YDES"].ToString();
               yl2.Dtime = dt.Rows[0]["DTIME"].ToString();
               yl2.Ymd = dt.Rows[0]["d"].ToString();
           }
           return yl2;
       }
    }
}
