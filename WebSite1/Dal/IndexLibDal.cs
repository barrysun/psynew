using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Web.UI.WebControls;
using Wuqi.Webdiyer;

namespace Dal
{
   public  class IndexLibDal
    {
       public void BindPager(GridView gv, AspNetPager pager, string whereStr)
       {
           string sql = @"
set @mycnt=0; 
select * from (
select *,(@mycnt := @mycnt + 1) as RowNum from indexlib "+whereStr+@"
)as r where RowNum>{0} and RowNum<={1}";
           sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
           pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(CNNUMBER) from indexlib " + whereStr));
           gv.DataSource = new MySQLHelper().GetDataTable(sql);
           gv.DataBind();
       }

       public IndexLib Query(string jobid)
       { 
           string sql="select CNNUMBER,CNNAME,LIB2,LIB3,CN_duty1,CN_duty2,CN_duty3,CN_salary1,CN_salary2 from indexlib where CNNUMBER='"+((int)double.Parse(jobid))+"'";
           DataTable dt = new MySQLHelper().GetDataTable(sql);
           IndexLib indexlib = null;
           if (dt != null && dt.Rows.Count > 0)
           {
               indexlib = new IndexLib();
               indexlib.CNNumber = dt.Rows[0]["CNNUMBER"].ToString();
               indexlib.CNName = dt.Rows[0]["CNNAME"].ToString();
               indexlib.Lib2 = int.Parse(dt.Rows[0]["LIB2"].ToString());
               indexlib.Lib3 = int.Parse(dt.Rows[0]["LIB3"].ToString());
               indexlib.CN_duty1 = dt.Rows[0]["CN_duty1"].ToString();
               indexlib.CN_duty2 = dt.Rows[0]["CN_duty2"].ToString();
               indexlib.CN_duty3 = dt.Rows[0]["CN_duty3"].ToString();
               indexlib.CN_salary1 = dt.Rows[0]["CN_salary1"].ToString();
               indexlib.CN_salary2 = dt.Rows[0]["CN_salary2"].ToString();
           }
           return indexlib;
       }

       /// <summary>
       /// 得到所有的JOBID的ORDERSORT
       /// </summary>
       /// <returns></returns>
       public string[] getJOBIDByOrder()
       {
           string sql = "select JOBID,ORDERSORT from jobidzywx";
           string[] x=null;
           DataTable dt = new MySQLHelper().GetDataTable(sql);
           if (dt != null && dt.Rows.Count > 0)
           {
               x = new string[dt.Rows.Count];
              for (int i = 0; i < dt.Rows.Count; i++)
              {
                  x[i] = dt.Rows[i]["JOBID"] + "," + dt.Rows[i]["ORDERSORT"];
              }
           }
           return x;
       }
       /// <summary>
       /// 
       /// /*
       /// WXMATCH = (new JobIdZywxBeanDaoImpl()).getValueByORDERAndZYWX((int)MATCHST[i - 1][1], CYWX);
       /// */
       /// </summary>
       /// <returns></returns>

       public string[] getValueByORDERAndZYWX() {
           DataTable dt = new MySQLHelper().GetDataTable("select JOBIDZYWXID,ORDERSORT,JOBID,ZYWX1,ZYWX2,ZYWX3,ZYWX4,ZYWX5 from jobidzywx");
           string[] re = null;
           if (dt != null && dt.Rows.Count > 0)
           {
               re = new string[dt.Rows.Count];
               for (int i = 0; i < dt.Rows.Count; i++)
               {
                   re[i] = dt.Rows[i]["ORDERSORT"] + "," + dt.Rows[i]["JOBID"] + "," + dt.Rows[i]["ZYWX1"] + "," + dt.Rows[i]["ZYWX2"] + "," + dt.Rows[i]["ZYWX3"] + "," + dt.Rows[i]["ZYWX4"] + "," + dt.Rows[i]["ZYWX5"];
               }
           }
           return re;
       }

       public bool Add(IndexLib indexLib)
       {
           return false;
       }

       public bool Update(IndexLib indexlib)
       {
           return false;
       }

       public bool Delete(IndexLib indexlib)
       {
           return false;
       }
    }
}
