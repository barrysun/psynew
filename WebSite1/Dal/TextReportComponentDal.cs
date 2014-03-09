using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Text;
using System.Web.UI.WebControls;
using Model;
using MySql.Data.MySqlClient;
using Wuqi.Webdiyer;
using System.Data;

namespace Dal
{
   public  class TextReportComponentDal
    {
       public void BindPager(GridView gv, AspNetPager pager, string whereStr)
       {
           string sql = @"
set @mycnt=0; 
select * from (
select *,(@mycnt := @mycnt + 1) as RowNum from textreportcomponent "+whereStr+@"
)as component where RowNum>{0} and RowNum<={1}";
           sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
           pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(TEXTRECOMID) from textreportcomponent "+whereStr));
           gv.DataSource = new MySQLHelper().GetDataTable(sql);
           gv.DataBind();
       }
       public DataTable GetById(string  textrecomid)
       {
           return new MySQLHelper().GetDataTable("select * from textreportcomponent where TEXTRECOMID=" + textrecomid);
       
       }
       public Dictionary<string, string> GetDictionarys()
       {
           Dictionary<string, string> dictions = new Dictionary<string, string>();
           DataTable dt = new MySQLHelper().GetDataTable("select * from textreportcomponent");
           if (dt != null && dt.Rows.Count > 0)
           {
               for (int i = 0; i < dt.Rows.Count; i++)
               {
                   dictions.Add(dt.Rows[i]["VARIABLE"] + "_" + ((int)double.Parse(dt.Rows[i]["VARIABLEVALUE"].ToString())), dt.Rows[i]["REPORTCOMPONENT"].ToString());
               }
           }
           return dictions;
       }

       public bool Upate(TextReportComponent textReportComponent)
       {
           const string sql = "update textreportcomponent set CSNUM=?CSNUM,VARIABLE=?VARIABLE,VARIABLEVALUE=?VARIABLEVALUE,REPORTCOMPONENT=?REPORTCOMPONENT where TEXTRECOMID=?TEXTRECOMID";
           var param = new MySqlParameter[5];
           param[0] = new MySqlParameter("?CSNUM",MySqlDbType.Int32){Value = textReportComponent.CsNum};
           param[1] = new MySqlParameter("?VARIABLE",MySqlDbType.String){Value = textReportComponent.Variable};
           param[2] = new MySqlParameter("?VARIABLEVALUE",MySqlDbType.Int32){Value = textReportComponent.VariableValue};
           param[3] = new MySqlParameter("?REPORTCOMPONENT",MySqlDbType.String){Value = textReportComponent.ReportComPonent};
           param[4] = new MySqlParameter("?TEXTRECOMID",MySqlDbType.Int32){Value = textReportComponent.TextRecomId};
           return new MySQLHelper().ExecuteSql(sql, param) == 1;
       }

       public bool Delete(TextReportComponent textReportComponent)
       {
           const string sql = "delete from  textreportcomponent  where TEXTRECOMID=?TEXTRECOMID";
           var param = new MySqlParameter[1];
           param[0] = new MySqlParameter("?TEXTRECOMID", MySqlDbType.Int32) { Value = textReportComponent.TextRecomId };
           return new MySQLHelper().ExecuteSql(sql, param) == 1;
       }

       public bool Add(TextReportComponent textReportComponent)
       {
           const string sql = "insert into  textreportcomponent( CSNUM,VARIABLE,VARIABLEVALUE,REPORTCOMPONENT)values (?CSNUM,?VARIABLE,?VARIABLEVALUE,?REPORTCOMPONENT)";
           var param = new MySqlParameter[4];
           param[0] = new MySqlParameter("?CSNUM", MySqlDbType.Int32) { Value = textReportComponent.CsNum };
           param[1] = new MySqlParameter("?VARIABLE", MySqlDbType.String) { Value = textReportComponent.Variable };
           param[2] = new MySqlParameter("?VARIABLEVALUE", MySqlDbType.Int32) { Value = textReportComponent.VariableValue };
           param[3] = new MySqlParameter("?REPORTCOMPONENT", MySqlDbType.String) { Value = textReportComponent.ReportComPonent };
         
           return new MySQLHelper().ExecuteSql(sql, param) == 1;
           
       }


       public void Test()
       {
           Dictionary<string, string> dic = GetDictionarys();
       }
    }
}
