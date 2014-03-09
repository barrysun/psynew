using Model;
using System;
using System.Collections.Generic;
using System.Data;

using System.Text;
using System.Web.UI.WebControls;
using Wuqi.Webdiyer;

namespace Dal
{
   public  class IchingLib4Dal
    {
       public void BindPager(GridView gv, AspNetPager pager, string whereStr)
       {
           var sql = @"
set @mycnt=0; 
select * from (
select *,(@mycnt := @mycnt + 1) as RowNum from ichinglib4
)as ichinglib where RowNum>{0} and RowNum<={1}";
           sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
           pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(ID) from ichinglib4"));
           gv.DataSource = new MySQLHelper().GetDataTable(sql);
           gv.DataBind();
       }

       public Ichinglib4 getSgSz(string btime, string RG)
       {
           int index = 0;
           int btimeint=int.Parse(btime.Split(':')[0]);
           switch (btimeint)
           { 
               case 23:
               case 0:
                   index = 0;
                   break;
               case 1:
               case 2:
                   index = 1;
                   break;
               case 3:
               case 4:
                   index = 2;
                   break;
               case 5:
               case 6:
                   index = 3;
                   break;
               case 7:
               case 8:
                   index = 4;
                   break;
               case 9:
               case 10:
                   index = 5;
                   break;
               case 11:
               case 12:
                   index = 6;
                   break;
               case 13:
               case 14:
                   index = 7;
                   break;
               case 15:
               case 16:
                   index = 8;
                   break;
               case 17:
               case 18:
                   index = 9;
                   break;
               case 19:
               case 20:
                   index = 10;
                   break;
               case 21:
               case 22:
                   index = 11;
                   break;
           }
           string sql = "select ID,REMAINDER,TIME,SG,SZ from ichinglib4 where REMAINDER="+RG+" order by ID";
           DataTable dt = new MySQLHelper().GetDataTable(sql);
           int i = 0;
           Ichinglib4 ic4 = new Ichinglib4();
               for(int x=0;x<dt.Rows.Count;x++)
               {
                   if (i == index)
                   {
                       ic4.Id = int.Parse(dt.Rows[x]["ID"].ToString());
                       ic4.Remainder = int.Parse(dt.Rows[x]["REMAINDER"].ToString());
                       ic4.Time = dt.Rows[x]["TIME"].ToString();
                       ic4.Sg = int.Parse(dt.Rows[x]["SG"].ToString());
                       ic4.Sz = int.Parse(dt.Rows[x]["SZ"].ToString());

                   }
                   i++;
               }

               return ic4;
       
       }

       #region ACUD

       public bool Add(Ichinglib4 lib4)
       {
           return false;
       }

       public bool Update(Ichinglib4 lib4)
       {
           return false;
       }

       public bool Delete(Ichinglib4 lib4)
       {
           return false;

       }

       public Ichinglib4 GetById(string id)
       {
           return null;
       }

       #endregion
    }
}
