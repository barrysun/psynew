using System;
using System.Collections.Generic;

using System.Text;
using System.Web.UI.WebControls;
using Wuqi.Webdiyer;
using System.Data;

namespace Dal
{
  public   class ForecastReportComponentDal
    {
      public void BindPager(GridView gv, AspNetPager pager, string whereStr)
      {
          string sql = @"
set @mycnt=0; 
select * from (
select *,(@mycnt := @mycnt + 1) as RowNum from forecastreportcomponent "+whereStr+@"
)as component where RowNum>{0} and RowNum<={1}";
          sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
          pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(FORECASTREPCOMPID) from forecastreportcomponent "+whereStr));
          gv.DataSource = new MySQLHelper().GetDataTable(sql);
          gv.DataBind();
      }
      public DataTable GetById(string id)
      {
          string sql = "select * from forecastreportcomponent where FORECASTREPCOMPID=" + id;
          return new MySQLHelper().GetDataTable(sql);
      
      }

      public Dictionary<string, string> GetDictionarys()
      {
          Dictionary<string, string> dictions = new Dictionary<string, string>();
          DataTable dt = new MySQLHelper().GetDataTable("select * from forecastreportcomponent");
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

     

    }
}
