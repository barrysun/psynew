using System;
using System.Collections.Generic;

using System.Text;
using System.Web.UI.WebControls;
using Wuqi.Webdiyer;
using Model;
using System.Data;

namespace Dal
{
   public  class MatchReportComponentDal
    {
       public void BindPager(GridView gv, AspNetPager pager, string whereStr)
       {
           string sql = @"
set @mycnt=0; 
select * from (
select *,(@mycnt := @mycnt + 1) as RowNum from matchreportcomponent "+whereStr+@"
)as component where RowNum>{0} and RowNum<={1}";
           sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
           pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(MATCHREPCOMPID) from matchreportcomponent "+whereStr));
           gv.DataSource = new MySQLHelper().GetDataTable(sql);
           gv.DataBind();
       }

       public bool Save(MatchReportComponent matchReportComponent)
       {
           return false;
       
       }

       public Dictionary<string, string> GetDictionarys()
       {
           Dictionary<string, string> dictions = new Dictionary<string, string>();
           DataTable dt = new MySQLHelper().GetDataTable("select * from matchreportcomponent");
           if (dt != null && dt.Rows.Count > 0)
           {
               for (int i = 0; i < dt.Rows.Count; i++)
               {
                   dictions.Add(dt.Rows[i]["VARIABLE"] + "_" + dt.Rows[i]["VARIABLEVALUE"], dt.Rows[i]["REPORTCOMPONENT"].ToString());
               }
           }
           return dictions;
       }

       public void Test()
       {
           Dictionary<string, string> dic = GetDictionarys();

       }

       public bool Add(MatchReportComponent matchRep)
       {
           return false;
       }

       public bool Update(MatchReportComponent matchRep)
       {
           return false;
       }

       public bool Delete(MatchReportComponent matchRep)
       {
           return false;
       }


    }
}
