using cn.cdu.edu.Psychology.utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Web.UI.WebControls;
using Wuqi.Webdiyer;

namespace Dal
{
    /// <summary>
    /// 测试预测匹配报告
    /// </summary>
   public  class RepostDal
   {
       #region
       public void TestBindPager(GridView gv, AspNetPager pager, string whereStr)
       {
           string sql = @"
set @mycnt=0; 
select * from (
select REPORTID,USERID,TESTREPORTVALUE1,TESTPARAMS,TESTTIME,TESTREPORTVALUE2,(@mycnt := @mycnt + 1) as RowNum from report
)as r where RowNum>{0} and RowNum<={1}";
           sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
           pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(REPORTID) from report"));
           gv.DataSource = new MySQLHelper().GetDataTable(sql);
           gv.DataBind();
       }

       public void ForBindPager(GridView gv, AspNetPager pager, string whereStr)
       {
           string sql = @"
set @mycnt=0; 
select * from (
select REPORTID,USERID,FORECASTTIME,FORECASTREPORTVALUE1,FORECASTREPORTVALUE2,FORECASTREPORTPARAM,(@mycnt := @mycnt + 1) as RowNum from report
)as r where RowNum>{0} and RowNum<={1}";
           sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
           pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(REPORTID) from report"));
           gv.DataSource = new MySQLHelper().GetDataTable(sql);
           gv.DataBind();

       }

       public void MatchBindPager(GridView gv, AspNetPager pager, string whereStr)
       {
           string sql = @"
set @mycnt=0; 
select * from (
select *,(@mycnt := @mycnt + 1) as RowNum from matchreport
)as r where RowNum>{0} and RowNum<={1}";
           sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
           pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(ID) from matchreport"));
           gv.DataSource = new MySQLHelper().GetDataTable(sql);
           gv.DataBind();
       }

       public DataTable getTestTable(string whereStr)
       {
           string sql = "select REPORTID,USERID,TESTPARAMS,TESTREPORTVALUE1,TESTREPORTVALUE2,TESTTIME from report ";
           DataTable dt = new MySQLHelper().GetDataTable(sql);
           DataTable dt2 = new DataTable();
           dt2.Columns.Add("REPORTID");
           dt2.Columns.Add("USERID");

           dt2.Columns.Add("INSTFST");
           dt2.Columns.Add("INSTSEC");
           dt2.Columns.Add("INSTTRD");
           dt2.Columns.Add("VALFST");
           dt2.Columns.Add("VALSEC");
           dt2.Columns.Add("VALTRD");
           dt2.Columns.Add("INSTRP");
           dt2.Columns.Add("WARNRP");
           dt2.Columns.Add("IPSUM");
           dt2.Columns.Add("EQIEM_");
           dt2.Columns.Add("EQIES99_");
           dt2.Columns.Add("EQIFL_");
           dt2.Columns.Add("EQIIC99_");
           dt2.Columns.Add("EQIIN99_");
           dt2.Columns.Add("EQIOP_");
           dt2.Columns.Add("EQIPS_");
           dt2.Columns.Add("EQIRE_");
           dt2.Columns.Add("EQIRT_");
           dt2.Columns.Add("EQISA_");
           dt2.Columns.Add("EQIST99_");
           dt2.Columns.Add("NEOA2_");
           dt2.Columns.Add("NEOA3_");
           dt2.Columns.Add("NEOA4_");
           dt2.Columns.Add("NEOA6_");
           dt2.Columns.Add("NEOC2_");
           dt2.Columns.Add("NEOC3_");
           dt2.Columns.Add("NEOC4_");
           dt2.Columns.Add("NEOC5_");
           dt2.Columns.Add("NEOC6_");
           dt2.Columns.Add("NEOE1_");
           dt2.Columns.Add("NEOE299_");
           dt2.Columns.Add("NEOE399_");
           dt2.Columns.Add("NEOE4_");
           dt2.Columns.Add("NEON4_");
          
           dt2.Columns.Add("NEOO4_");
           dt2.Columns.Add("NEOO5_");
           dt2.Columns.Add("EQIEMRP");
           dt2.Columns.Add("EQIESRP");
           dt2.Columns.Add("EQIFLRP");
           dt2.Columns.Add("EQIICRP");
           dt2.Columns.Add("EQIINRP");
           dt2.Columns.Add("EQIOPRP");
           dt2.Columns.Add("EQIPSRP");
           dt2.Columns.Add("EQIRERP");
           dt2.Columns.Add("EQIRTRP");
           dt2.Columns.Add("EQISARP");
           dt2.Columns.Add("EQISTRP");
           dt2.Columns.Add("NEOA2RP");
           dt2.Columns.Add("NEOA3RP");
           dt2.Columns.Add("NEOO4RP");
           dt2.Columns.Add("NEOA6RP");
           dt2.Columns.Add("NEOC2RP");
           dt2.Columns.Add("NEOC3RP");
           dt2.Columns.Add("NEOC4RP");
           dt2.Columns.Add("NEOC5RP");
           dt2.Columns.Add("NEOC6RP");
           dt2.Columns.Add("NEOE1RP");
           dt2.Columns.Add("NEOE2RP");
           dt2.Columns.Add("NEOE3RP");
           dt2.Columns.Add("NEOE4RP");
           dt2.Columns.Add("NEON4RP");
           dt2.Columns.Add("NEOA4RP");
           dt2.Columns.Add("NEOO5RP");
           dt2.Columns.Add("DATETIME_");



           
           if (dt != null && dt.Rows.Count > 0)
           {
               for (int i = 0; i < dt.Rows.Count; i++)
               {
                   DataRow dr = dt2.NewRow();
                   dr["REPORTID"]=dt.Rows[i]["REPORTID"];
                   dr["USERID"]=dt.Rows[i]["USERID"];
                   string paramstr = dt.Rows[i]["TESTPARAMS"].ToString();
                   string[] ansArray = paramstr.Split(',');
        

                   string value1 = dt.Rows[i]["TESTREPORTVALUE1"].ToString();
                   string[] valArray = value1.Split(',');

                   dr["EQIOPRP"] = valArray[0].Split('=')[1];
                   dr["VALSEC"] = valArray[1].Split('=')[1];
                   dr["INSTFST"] = valArray[2].Split('=')[1];
                   dr["NEOC5RP"] = valArray[3].Split('=')[1];
                   dr["NEOC4RP"] = valArray[4].Split('=')[1];
                   dr["VALTRD"] = valArray[5].Split('=')[1];
                   dr["VALFST"] = valArray[6].Split('=')[1];
                   dr["NEOC2RP"] = valArray[7].Split('=')[1];
                   dr["EQIINRP"] = valArray[8].Split('=')[1];
                   dr["NEOO5RP"] = valArray[9].Split('=')[1];
                   dr["EQIESRP"] = valArray[10].Split('=')[1];
                   dr["EQIRERP"] = valArray[11].Split('=')[1];
                   dr["EQIEMRP"] = valArray[12].Split('=')[1];
                   dr["WARNRP"] = valArray[13].Split('=')[1];
                   dr["INSTTRD"] = valArray[14].Split('=')[1];
                   dr["NEOC6RP"] = valArray[15].Split('=')[1];
                   dr["NEOA6RP"] = valArray[16].Split('=')[1];
                   dr["EQIRTRP"] = valArray[17].Split('=')[1];
                   dr["EQISARP"] = valArray[18].Split('=')[1];
                   dr["NEOA2RP"] = valArray[19].Split('=')[1];
                   dr["NEOA3RP"] = valArray[20].Split('=')[1];
                   dr["EQISTRP"] = valArray[21].Split('=')[1];
                   dr["NEOO4RP"] = valArray[22].Split('=')[1];
                   dr["EQIFLRP"] = valArray[23].Split('=')[1];
                   dr["EQIPSRP"] = valArray[24].Split('=')[1];
                   dr["EQIICRP"] = valArray[25].Split('=')[1];
                   dr["NEOC3RP"] = valArray[26].Split('=')[1];
                   dr["NEOE4RP"] = valArray[27].Split('=')[1];
                   dr["NEOE1RP"] = valArray[28].Split('=')[1];
                   dr["INSTSEC"] = valArray[29].Split('=')[1];
                   dr["IPSUM"] = valArray[30].Split('=')[1];
                   dr["INSTRP"] = valArray[31].Split('=')[1];
                   dr["NEOA4RP"] = valArray[32].Split('=')[1];
                   dr["NEON4RP"] = valArray[33].Split('=')[1];
                   dr["NEOE3RP"] = valArray[34].Split('=')[1];
                   dr["NEOE2RP"] = valArray[35].Split('=')[1];
                   string value2 = dt.Rows[i]["TESTREPORTVALUE2"].ToString();
                   string[] val2Array = value2.Split(',');



                   dr["NEOO5_"] = val2Array[0].Split('=')[1];
                   dr["NEOA2_"] = val2Array[1].Split('=')[1];
                   dr["NEOA3_"] = val2Array[2].Split('=')[1];
                   dr["EQIRT_"] = val2Array[3].Split('=')[1];
                   dr["NEOO4_"] = val2Array[4].Split('=')[1];
                   dr["NEOA4_"] = val2Array[5].Split('=')[1];
                   dr["NEOC3_"] = val2Array[6].Split('=')[1];
                   dr["NEOA6_"] = val2Array[7].Split('=')[1];
                   dr["NEOC4_"] = val2Array[8].Split('=')[1];
                   dr["NEOC5_"] = val2Array[9].Split('=')[1];
                   dr["NEOC6_"] = val2Array[10].Split('=')[1];
                   dr["NEOC2_"] = val2Array[11].Split('=')[1];
                   dr["EQIRE_"] = val2Array[12].Split('=')[1];
                   dr["EQIPS_"] = val2Array[13].Split('=')[1];
                   dr["NEOE399_"] = val2Array[14].Split('=')[1];
                   dr["EQIST99_"] = val2Array[15].Split('=')[1];
                   dr["EQIOP_"] = val2Array[16].Split('=')[1];
                   dr["EQIFL_"] = val2Array[17].Split('=')[1];
                   dr["NEOE299_"] = val2Array[18].Split('=')[1];
                   dr["NEON4_"] = val2Array[19].Split('=')[1];
                   dr["NEOE4_"] = val2Array[20].Split('=')[1];
                   dr["NEOE1_"] = val2Array[21].Split('=')[1];
                   dr["EQIIN99_"] = val2Array[22].Split('=')[1];
                   dr["EQISA_"] = val2Array[23].Split('=')[1];
                   dr["EQIES99_"] = val2Array[24].Split('=')[1];
                   dr["EQIIC99_"] = val2Array[25].Split('=')[1];
                   dr["EQIEM_"] = val2Array[26].Split('=')[1];
                   dr["DATETIME_"] = dt.Rows[i]["TESTTIME"];

                   dt2.Rows.Add(dr);
               }
              
           }

           return dt2;
       }

       public DataTable getTestImportTable(string whereStr)
       {
           string sql = "select REPORTID,USERID,TESTPARAMS,TESTREPORTVALUE1,TESTREPORTVALUE2,TESTTIME from report ";
           DataTable dt = new MySQLHelper().GetDataTable(sql);
           DataTable dt2 = new DataTable();
           dt2.Columns.Add("REPORTID");
           dt2.Columns.Add("USERID");
           dt2.Columns.Add("IP1");
           dt2.Columns.Add("IP2");
           dt2.Columns.Add("IP3");
           dt2.Columns.Add("IP4");
           dt2.Columns.Add("IP5");
           dt2.Columns.Add("IP6");
           dt2.Columns.Add("WIL1");
           dt2.Columns.Add("WIL2");
           dt2.Columns.Add("WIL3");
           dt2.Columns.Add("WIL4");
           dt2.Columns.Add("WIL5");
           dt2.Columns.Add("WIL6");
           dt2.Columns.Add("EQIAS");
           dt2.Columns.Add("EQIEM");
           dt2.Columns.Add("EQIES");
           dt2.Columns.Add("EQIIC");
           dt2.Columns.Add("EQIIN");
           dt2.Columns.Add("EQIFL");
           // dt2.Columns.Add("EQIIC");
           //dt2.Columns.Add("EQIIN");
           dt2.Columns.Add("EQIIR");
           dt2.Columns.Add("EQIOP");
           dt2.Columns.Add("EQIPS");
           dt2.Columns.Add("EQIRE");
           dt2.Columns.Add("EQIRT");
           dt2.Columns.Add("EQISA");
           dt2.Columns.Add("EQIST");
           dt2.Columns.Add("EQINI");
           dt2.Columns.Add("EQIPI");
           dt2.Columns.Add("EQIZZ");
           dt2.Columns.Add("NEOA2");
           dt2.Columns.Add("NEOA3");
           dt2.Columns.Add("NEOA4");
           dt2.Columns.Add("NEOA6");
           dt2.Columns.Add("NEOC1");
           dt2.Columns.Add("NEOC2");
           dt2.Columns.Add("NEOC3");
           dt2.Columns.Add("NEOC4");
           dt2.Columns.Add("NEOC5");
           dt2.Columns.Add("NEOC6");
           dt2.Columns.Add("NEOE1");
           dt2.Columns.Add("NEOE2");
           dt2.Columns.Add("NEOE3");
           dt2.Columns.Add("NEOE4");
           dt2.Columns.Add("NEON2");
           dt2.Columns.Add("NEON4");
           dt2.Columns.Add("NEON5");
           dt2.Columns.Add("NEON6");
           dt2.Columns.Add("NEOO3");
           dt2.Columns.Add("NEOO4");
           dt2.Columns.Add("NEOO5");
           dt2.Columns.Add("DATETIME_");




           if (dt != null && dt.Rows.Count > 0)
           {
               for (int i = 0; i < dt.Rows.Count; i++)
               {
                   DataRow dr = dt2.NewRow();
                   dr["REPORTID"] = dt.Rows[i]["REPORTID"];
                   dr["USERID"] = dt.Rows[i]["USERID"];
                   string paramstr = dt.Rows[i]["TESTPARAMS"].ToString();
                   string[] ansArray = paramstr.Split(',');
                   dr["IP1"] = ansArray[0].Split('=')[1];
                   dr["IP2"] = ansArray[1].Split('=')[1];
                   dr["IP3"] = ansArray[2].Split('=')[1];
                   dr["IP4"] = ansArray[3].Split('=')[1];
                   dr["IP5"] = ansArray[4].Split('=')[1];
                   dr["IP6"] = ansArray[5].Split('=')[1];
                   dr["WIL1"] = ansArray[6].Split('=')[1];
                   dr["WIL2"] = ansArray[7].Split('=')[1];
                   dr["WIL3"] = ansArray[8].Split('=')[1];
                   dr["WIL4"] = ansArray[9].Split('=')[1];
                   dr["WIL5"] = ansArray[10].Split('=')[1];
                   dr["WIL6"] = ansArray[11].Split('=')[1];
                   dr["EQIAS"] = ansArray[12].Split('=')[1];
                   dr["EQIEM"] = ansArray[13].Split('=')[1];
                   dr["EQIES"] = ansArray[14].Split('=')[1];
                   //dr["EQIIC"] = ansArray[15].Split('=')[1];
                   //dr["EQIIN"] = ansArray[16].Split('=')[1];
                   dr["EQIFL"] = ansArray[15].Split('=')[1];
                   dr["EQIIC"] = ansArray[16].Split('=')[1];
                   dr["EQIIN"] = ansArray[17].Split('=')[1];
                   dr["EQIIR"] = ansArray[18].Split('=')[1];
                   dr["EQIOP"] = ansArray[19].Split('=')[1];
                   dr["EQIPS"] = ansArray[20].Split('=')[1];
                   dr["EQIRE"] = ansArray[21].Split('=')[1];
                   dr["EQIRT"] = ansArray[22].Split('=')[1];
                   dr["EQISA"] = ansArray[23].Split('=')[1];
                   dr["EQIST"] = ansArray[24].Split('=')[1];
                   dr["EQINI"] = ansArray[25].Split('=')[1];
                   dr["EQIPI"] = ansArray[26].Split('=')[1];
                   dr["EQIZZ"] = ansArray[27].Split('=')[1];
                   dr["NEOA2"] = ansArray[28].Split('=')[1];
                   dr["NEOA3"] = ansArray[29].Split('=')[1];
                   dr["NEOA4"] = ansArray[30].Split('=')[1];
                   dr["NEOA6"] = ansArray[31].Split('=')[1];
                   dr["NEOC1"] = ansArray[32].Split('=')[1];
                   dr["NEOC2"] = ansArray[33].Split('=')[1];
                   dr["NEOC3"] = ansArray[34].Split('=')[1];
                   dr["NEOC4"] = ansArray[35].Split('=')[1];
                   dr["NEOC5"] = ansArray[36].Split('=')[1];
                   dr["NEOC6"] = ansArray[37].Split('=')[1];
                   dr["NEOE1"] = ansArray[38].Split('=')[1];
                   dr["NEOE2"] = ansArray[39].Split('=')[1];
                   dr["NEOE3"] = ansArray[40].Split('=')[1];
                   dr["NEOE4"] = ansArray[41].Split('=')[1];
                   dr["NEON2"] = ansArray[42].Split('=')[1];
                   dr["NEON4"] = ansArray[43].Split('=')[1];
                   dr["NEON5"] = ansArray[44].Split('=')[1];
                   dr["NEON6"] = ansArray[45].Split('=')[1];
                   dr["NEOO3"] = ansArray[46].Split('=')[1];
                   dr["NEOO4"] = ansArray[47].Split('=')[1];
                   dr["NEOO5"] = ansArray[48].Split('=')[1];


                   string value1 = dt.Rows[i]["TESTREPORTVALUE1"].ToString();
                   string[] valArray = value1.Split(',');

                  
                   string value2 = dt.Rows[i]["TESTREPORTVALUE2"].ToString();
                   string[] val2Array = value2.Split(',');
                   dr["DATETIME_"] = dt.Rows[i]["TESTTIME"];

                   dt2.Rows.Add(dr);
               }

           }

           return dt2;
       
       
       }
       public DataTable getForTable(string whereStr)
       {
           string sql = "SELECT REPORTID,USERID,FORECASTTIME,FORECASTREPORTVALUE1,FORECASTREPORTVALUE2,FORECASTREPORTPARAM from report ";
           DataTable dt = new MySQLHelper().GetDataTable(sql);
           DataTable dt2 = new DataTable();
           dt2.Columns.Add("ID");
           dt2.Columns.Add("USERID");
           dt2.Columns.Add("FORECASTTIME");

           dt2.Columns.Add("SKL01F");
           dt2.Columns.Add("SKL11F");


           //dt2.Columns.Add("SYL06F");
           //dt2.Columns.Add("MATCHFST");
           //dt2.Columns.Add("SYL05RP");
           //dt2.Columns.Add("SYL10RP");
           //dt2.Columns.Add("SKL19F");
           //dt2.Columns.Add("SYL08F");
           //dt2.Columns.Add("SYL06RP");
           //dt2.Columns.Add("SKL11F");
           //dt2.Columns.Add("SYL04F");
           //dt2.Columns.Add("SYL02F");
           //dt2.Columns.Add("SKL21F");
           //dt2.Columns.Add("SYL12F");
           //dt2.Columns.Add("SYL11F");
           //dt2.Columns.Add("SYL09RP");
           //dt2.Columns.Add("SKL19RP");
           //dt2.Columns.Add("SKL30F");
           //dt2.Columns.Add("SYL15F");
           //dt2.Columns.Add("SYL01F");
           //dt2.Columns.Add("SKL21RP");
           
           //dt2.Columns.Add("ORDERFST");
           //dt2.Columns.Add("SYL14RP");
           //dt2.Columns.Add("SYL11RP");
           //dt2.Columns.Add("SYL15RP");
           //dt2.Columns.Add("SYL07RP");
           //dt2.Columns.Add("ORDERSEC");
           //dt2.Columns.Add("SYL16RP");
           //dt2.Columns.Add("SYL07F");
           //dt2.Columns.Add("SKL01RP");
           //dt2.Columns.Add("SYL12RP");
           //dt2.Columns.Add("SYL03RP");
           //dt2.Columns.Add("SYL09F");
           //dt2.Columns.Add("SYL13RP");
           //dt2.Columns.Add("SYL03F");
           //dt2.Columns.Add("SYL13F");
           //dt2.Columns.Add("SYL08RP");
           //dt2.Columns.Add("SYL05F");
           //dt2.Columns.Add("SKL30RP");
           //dt2.Columns.Add("IDSEC");
           //dt2.Columns.Add("SYL16F");
           //dt2.Columns.Add("SYL10F");
           //dt2.Columns.Add("SYL14F");
           //dt2.Columns.Add("MATCHSEC");
           
           //dt2.Columns.Add("SYL02RP");
           //dt2.Columns.Add("SYL01RP");
           //dt2.Columns.Add("IDFST");
           //dt2.Columns.Add("SYL04RP");

           //dt2.Columns.Add("WXMISSMTC");
           //dt2.Columns.Add("WXMISSORD");
           //dt2.Columns.Add("IDMAX");
           //dt2.Columns.Add(" MATCHMAX");

           //dt2.Columns.Add("SKL01F");
           //dt2.Columns.Add("SKL11F");
           dt2.Columns.Add("SKL19F");
           dt2.Columns.Add("SKL21F");
           dt2.Columns.Add("SKL30F");
           dt2.Columns.Add("SYL01F");
           dt2.Columns.Add("SYL02F");
           dt2.Columns.Add("SYL03F");
           dt2.Columns.Add("SYL04F");
           dt2.Columns.Add("SYL05F");
           dt2.Columns.Add("SYL06F");
           dt2.Columns.Add("SYL07F");
           dt2.Columns.Add("SYL08F");
           dt2.Columns.Add("SYL09F");
           dt2.Columns.Add("SYL10F");
           dt2.Columns.Add("SYL11F");
           dt2.Columns.Add("SYL12F");
           dt2.Columns.Add("SYL13F");
           dt2.Columns.Add("SYL14F");
           dt2.Columns.Add("SYL15F");
           dt2.Columns.Add("SYL16F");
           dt2.Columns.Add("MATCHFST");
           dt2.Columns.Add("ORDERFST");
           dt2.Columns.Add("IDFST");
           dt2.Columns.Add("MATCHSEC");
           dt2.Columns.Add("ORDERSEC");
           dt2.Columns.Add("IDSEC");
           dt2.Columns.Add("MATCHMAX");
           dt2.Columns.Add("IDMAX");
           dt2.Columns.Add("SKL01RP");
           dt2.Columns.Add("SKL11RP");
           dt2.Columns.Add("SKL19RP");
           dt2.Columns.Add("SKL21RP");
           dt2.Columns.Add("SKL30RP");
           dt2.Columns.Add("SYL01RP");
           dt2.Columns.Add("SYL02RP");
           dt2.Columns.Add("SYL03RP");
           dt2.Columns.Add("SYL04RP");
           dt2.Columns.Add("SYL05RP");
           dt2.Columns.Add("SYL06RP");
           dt2.Columns.Add("SYL07RP");
           dt2.Columns.Add("SYL08RP");
           dt2.Columns.Add("SYL09RP");
           dt2.Columns.Add("SYL10RP");
           dt2.Columns.Add("SYL11RP");
           dt2.Columns.Add("SYL12RP");
           dt2.Columns.Add("SYL13RP");
           dt2.Columns.Add("SYL14RP");
           dt2.Columns.Add("SYL15RP");
           dt2.Columns.Add("SYL16RP");
           dt2.Columns.Add("SYL17RP");
           dt2.Columns.Add("WXMISSMTC");
           dt2.Columns.Add("WXMISSORD");
    





           if (dt != null && dt.Rows.Count > 0)
           {
               for (int i = 0; i < dt.Rows.Count; i++)
               {
                   DataRow dr = dt2.NewRow();
                   dr["ID"] = dt.Rows[i]["REPORTID"];
                   dr["USERID"]=dt.Rows[i]["USERID"];
                   dr["FORECASTTIME"] = dt.Rows[i]["FORECASTTIME"];
                   string val1 = dt.Rows[i]["FORECASTREPORTVALUE1"].ToString().Trim();
                   if(!string.IsNullOrEmpty(val1))
                   {
                      string[] val1Array=val1.Split(',');
                      dr["SYL06F"] = val1Array[0].Split('=')[1];
                      dr["MATCHFST"] = val1Array[1].Split('=')[1];
                      dr["SYL05RP"] = val1Array[2].Split('=')[1];
                      dr["SYL10RP"] = val1Array[3].Split('=')[1];
                      dr["SKL19F"] = val1Array[4].Split('=')[1];
                      dr["SYL08F"] = val1Array[5].Split('=')[1];
                      dr["SYL06RP"] = val1Array[6].Split('=')[1];
                      dr["SKL11F"] = val1Array[7].Split('=')[1];
                      dr["SYL04F"] = val1Array[8].Split('=')[1];
                      dr["SYL02F"] = val1Array[9].Split('=')[1];
                      dr["SKL21F"] = val1Array[10].Split('=')[1];
                      dr["SYL12F"] = val1Array[11].Split('=')[1];
                      dr["SYL11F"] = val1Array[12].Split('=')[1];
                      dr["SYL09RP"] = val1Array[13].Split('=')[1];
                      dr["SKL19RP"] = val1Array[14].Split('=')[1];
                      dr["SKL30F"] = val1Array[15].Split('=')[1];
                      dr["SYL15F"] = val1Array[16].Split('=')[1];
                      dr["SYL01F"] = val1Array[17].Split('=')[1];
                      dr["SKL21RP"] = val1Array[18].Split('=')[1];
                      dr["SKL01F"] = val1Array[19].Split('=')[1];
                      dr["ORDERFST"] = val1Array[20].Split('=')[1];
                      dr["SYL14RP"] = val1Array[21].Split('=')[1];
                      dr["SYL11RP"] = val1Array[22].Split('=')[1];
                      dr["SYL15RP"] = val1Array[23].Split('=')[1];
                      dr["SYL07RP"] = val1Array[24].Split('=')[1];
                      dr["ORDERSEC"] = val1Array[25].Split('=')[1];
                      dr["SYL16RP"] = val1Array[26].Split('=')[1];
                      dr["SYL07F"] = val1Array[27].Split('=')[1];
                      dr["SKL01RP"] = val1Array[28].Split('=')[1];
                      dr["SYL12RP"] = val1Array[29].Split('=')[1];
                      dr["SYL03RP"] = val1Array[30].Split('=')[1];
                      dr["SYL09F"] = val1Array[31].Split('=')[1];
                      dr["SYL13RP"] = val1Array[32].Split('=')[1];
                      dr["SYL03F"] = val1Array[33].Split('=')[1];
                      dr["SYL13F"] = val1Array[34].Split('=')[1];
                      dr["SYL08RP"] = val1Array[35].Split('=')[1];
                      dr["SYL05F"] = val1Array[36].Split('=')[1];
                      dr["SKL30RP"] = val1Array[37].Split('=')[1];
                      dr["IDSEC"] = val1Array[38].Split('=')[1];
                      dr["SYL16F"] = val1Array[39].Split('=')[1];
                      dr["SYL10F"] = val1Array[40].Split('=')[1];
                      dr["SYL14F"] = val1Array[41].Split('=')[1];
                      dr["MATCHSEC"] = val1Array[42].Split('=')[1];
                      dr["SKL11RP"] = val1Array[43].Split('=')[1];
                      dr["SYL02RP"] = val1Array[44].Split('=')[1];
                      dr["SYL01RP"] = val1Array[45].Split('=')[1];
                      dr["IDFST"] = val1Array[46].Split('=')[1];
                      dr["SYL04RP"] = val1Array[47].Split('=')[1];

                   }
                   string val2 = dt.Rows[i]["FORECASTREPORTVALUE2"].ToString().Trim();
                   if (!string.IsNullOrEmpty(val2))
                   {
                       string[] val2Array = val2.Split(',');

                       dr["WXMISSMTC"]=val2Array[0].Split('=')[1];
                       dr["WXMISSORD"]=val2Array[1].Split('=')[1];
                       dr["IDMAX"]=val2Array[2].Split('=')[1];
                       dr["MATCHMAX"] = val2Array[3].Split('=')[1];
                   }
                   

                   dt2.Rows.Add(dr);
               
               }
           
           }
           return dt2;
       }

       public DataTable getMatchTable(string whereStr)
       {
           string sql = "select ID,USERID,JOBID,MATCHVALUE1,MATCHVALUE2,MATCHTIME from matchreport ";
           DataTable dt = new MySQLHelper().GetDataTable(sql);
           DataTable dt2 = new DataTable();

           dt2.Columns.Add("USERID");
           dt2.Columns.Add("JOBID");
           dt2.Columns.Add("ID");
           dt2.Columns.Add("MATCHTIME");

           dt2.Columns.Add("SKL01MCH");
           dt2.Columns.Add("SKL11MCH");
           dt2.Columns.Add("SKL19MCH");
           dt2.Columns.Add("SKL21MCH");
           dt2.Columns.Add("SKL30MCH");
           dt2.Columns.Add("SYL01MCH");
           dt2.Columns.Add("SYL02MCH");
           dt2.Columns.Add("SYL03MCH");
           dt2.Columns.Add("SYL04MCH");
           dt2.Columns.Add("SYL05MCH");
           dt2.Columns.Add("SYL06MCH");
           dt2.Columns.Add("SYL07MCH");
           dt2.Columns.Add("SYL08MCH");
           dt2.Columns.Add("SYL09MCH");
           dt2.Columns.Add("SYL10MCH");
           dt2.Columns.Add("SYL11MCH");

           dt2.Columns.Add("SYL12MCH");
           dt2.Columns.Add("SYL13MCH");
           dt2.Columns.Add("SYL14MCH");
           dt2.Columns.Add("SYL15MCH");
           dt2.Columns.Add("SYL16MCH");
           dt2.Columns.Add("MATCHRP");
           dt2.Columns.Add("INSTMATCH");
           dt2.Columns.Add("VALMATCH");
           
           dt2.Columns.Add("MATCH");
           dt2.Columns.Add("MATCHTT");
           dt2.Columns.Add("MISMATCHTT");
           dt2.Columns.Add("MATCHCOUNT");
           dt2.Columns.Add("MISMATCHCOUNT");
           if (dt != null && dt.Rows.Count > 0)
           {
               for (int i = 0; i < dt.Rows.Count; i++)
               {
                   DataRow dr = dt2.NewRow();
                   dr["USERID"] = dt.Rows[i]["USERID"];
                   dr["JOBID"] = dt.Rows[i]["JOBID"];
                   dr["ID"] = dt.Rows[i]["ID"];
                   dr["MATCHTIME"] = dt.Rows[i]["MATCHTIME"];
                   string matchvalue1 = dt.Rows[i]["MATCHVALUE1"].ToString();
                   if (!string.IsNullOrEmpty(matchvalue1))
                   {
                       string[] val1Array = matchvalue1.Split(',');
                       dr["SKL19MCH"] = val1Array[0].Split('=')[1];
                       dr["SYL12MCH"] = val1Array[1].Split('=')[1];
                       dr["SKL01MCH"] = val1Array[2].Split('=')[1];
                       dr["INSTMATCH"] = val1Array[3].Split('=')[1];
                       dr["SYL02MCH"] = val1Array[4].Split('=')[1];
                       dr["SKL11MCH"] = val1Array[5].Split('=')[1];
                       dr["SYL16MCH"] = val1Array[6].Split('=')[1];
                       dr["SYL05MCH"] = val1Array[7].Split('=')[1];
                       dr["VALMATCH"] = val1Array[8].Split('=')[1];
                       dr["MATCHRP"] = val1Array[9].Split('=')[1];
                       dr["SYL15MCH"] = val1Array[10].Split('=')[1];
                       dr["SYL10MCH"] = val1Array[11].Split('=')[1];
                       dr["SYL09MCH"] = val1Array[12].Split('=')[1];
                       dr["SYL08MCH"] = val1Array[13].Split('=')[1];
                       dr["SYL01MCH"] = val1Array[14].Split('=')[1];
                       dr["SYL13MCH"] = val1Array[15].Split('=')[1];
                       dr["SKL21MCH"] = val1Array[16].Split('=')[1];
                       dr["SYL06MCH"] = val1Array[17].Split('=')[1];
                       dr["SYL04MCH"] = val1Array[18].Split('=')[1];
                       dr["SYL14MCH"] = val1Array[19].Split('=')[1];
                       dr["SKL30MCH"] = val1Array[20].Split('=')[1];
                       dr["SYL11MCH"] = val1Array[21].Split('=')[1];
                       dr["SYL03MCH"] = val1Array[22].Split('=')[1];
                       dr["SYL07MCH"] = val1Array[23].Split('=')[1];
                       
                   }
                   string matchvalue2 = dt.Rows[i]["MATCHVALUE2"].ToString();
                   if (!string.IsNullOrEmpty(matchvalue2))
                   {
                       string[] val2Array = matchvalue2.Split(',');
                       dr["MATCH"]=val2Array[0].Split('=')[1];
                       dr["MATCHCOUNT"]=val2Array[1].Split('=')[1];
                        dr["MISMATCHCOUNT"]=val2Array[2].Split('=')[1];
                        dr["MATCHTT"]=val2Array[3].Split('=')[1];
                        dr["MISMATCHTT"] = val2Array[4].Split('=')[1];
                   }


                   dt2.Rows.Add(dr);
               }
           }
           return dt2;
        }
       #endregion
       //显示三大报告的内容
       public Dictionary<string, string> TextReportView(int userid)
       {
           Dictionary<string, string> dic =new TextReportComponentDal().GetDictionarys();
           Dictionary<string, string> rdic = new Dictionary<string, string>();
          
           string sql="select TESTREPORTVALUE1,TESTREPORTVALUE2 from report WHERE USERID="+userid;
           DataTable dt=new MySQLHelper().GetDataTable(sql);
           if(dt!=null&&dt.Rows.Count>0)
           {
              string testValue1=dt.Rows[0]["TESTREPORTVALUE1"].ToString();
              string testValue2=dt.Rows[0]["TESTREPORTVALUE2"].ToString();
              #region
              if (testValue1!=null&&testValue2!="")
              {
                  string[] arrTestValue1=testValue1.Substring(1,testValue1.Length-2).Split(',');
                  for(int i=0;i<arrTestValue1.Length;i++)
                  {
                    if(arrTestValue1[i].Split('=')[0].Trim().Equals("NEOC2RP"))
                    {
                        rdic.Add("NEOC2", !dic.ContainsKey("NEOC2RP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1])))? "" : dic["NEOC2RP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                    }
                    if (arrTestValue1[i].Split('=')[0].Trim().Equals("NEOC3RP"))
                    {
                        rdic.Add("NEOC3", !dic.ContainsKey("NEOC3RP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1])))? "" : dic["NEOC3RP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                    }
                    if (arrTestValue1[i].Split('=')[0].Trim().Equals("EQIINRP"))
                    {
                        rdic.Add("EQIIN", !dic.ContainsKey("EQIINRP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))) ? "" : dic["EQIINRP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                    }
                    if (arrTestValue1[i].Split('=')[0].Trim().Equals("NEOA4RP"))
                    {
                        rdic.Add("NEOA4", !dic.ContainsKey("NEOA4RP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1])))?"":dic["NEOA4RP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                    }
                    if (arrTestValue1[i].Split('=')[0].Trim().Equals("NEOE3RP"))
                    {
                        rdic.Add("NEOE3", !dic.ContainsKey("NEOE3RP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))) ? "" : dic["NEOE3RP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                    }
                    if (arrTestValue1[i].Split('=')[0].Trim().Equals("EQIPSRP"))
                    {
                        rdic.Add("EQIPS", !dic.ContainsKey("EQIPSRP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))) ? "" : dic["EQIPSRP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                    }
                    if (arrTestValue1[i].Split('=')[0].Trim().Equals("EQIRTRP"))
                    {
                        rdic.Add("EQIRT", !dic.ContainsKey("EQIRTRP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))) ? "" : dic["EQIRTRP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                    }
                    if (arrTestValue1[i].Split('=')[0].Trim().Equals("EQIFLRP"))
                    {
                        rdic.Add("EQIFL", !dic.ContainsKey("EQIFLRP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))) ? "" : dic["EQIFLRP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                    }
                    if (arrTestValue1[i].Split('=')[0].Trim().Equals("EQISARP"))
                    {
                        rdic.Add("EQISA", !dic.ContainsKey("EQISARP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1])))?"":dic["EQISARP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                    }
                    if (arrTestValue1[i].Split('=')[0].Trim().Equals("NEOC4RP"))
                    {
                        rdic.Add("NEOC4", !dic.ContainsKey("NEOC4RP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1])))? "" : dic["NEOC4RP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                    }
                    if (arrTestValue1[i].Split('=')[0].Trim().Equals("NEOE4RP"))
                    {
                        rdic.Add("NEOE4", !dic.ContainsKey("NEOE4RP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))) ? "" : dic["NEOE4RP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                    }
                    if (arrTestValue1[i].Split('=')[0].Trim().Equals("NEOC5RP"))
                    {
                        rdic.Add("NEOC5", !dic.ContainsKey("NEOC5RP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))) ? "" : dic["NEOC5RP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                    }
                    if (arrTestValue1[i].Split('=')[0].Trim().Equals("EQIOPRP"))
                    {
                        rdic.Add("EQIOP", !dic.ContainsKey("EQIOPRP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1])))? "" : dic["EQIOPRP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                    }
                    if (arrTestValue1[i].Split('=')[0].Trim().Equals("EQIICRP"))
                    {
                        rdic.Add("EQIIC", !dic.ContainsKey("EQIICRP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))) ? "" : dic["EQIICRP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                    }
                    if (arrTestValue1[i].Split('=')[0].Trim().Equals("NEOC6RP"))
                    {
                        rdic.Add("NEOC6", !dic.ContainsKey("NEOC6RP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))) ? "" : dic["NEOC6RP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                    }
                    if (arrTestValue1[i].Split('=')[0].Trim().Equals("EQISTRP"))
                    {
                        rdic.Add("EQIST", !dic.ContainsKey("EQISTRP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))) ? "" : dic["EQISTRP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                    }
                    if (arrTestValue1[i].Split('=')[0].Trim().Equals("NEOO5RP"))
                    {
                        rdic.Add("NEOO5", !dic.ContainsKey("NEOO5RP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))) ? "" : dic["NEOO5RP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                    }
                    if (arrTestValue1[i].Split('=')[0].Trim().Equals("NEOO4RP"))
                    {
                        rdic.Add("NEOO4", !dic.ContainsKey("NEOO4RP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))) ? "" : dic["NEOO4RP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                    }
                    if (arrTestValue1[i].Split('=')[0].Trim().Equals("EQIESRP"))
                    {
                        rdic.Add("EQIES", !dic.ContainsKey("EQIESRP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))) ? "" : dic["EQIESRP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                    }
                    if (arrTestValue1[i].Split('=')[0].Trim().Equals("NEOA2RP"))
                    {
                        rdic.Add("NEOA2", !dic.ContainsKey("NEOA2RP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))) ? "" : dic["NEOA2RP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                    }
                    if (arrTestValue1[i].Split('=')[0].Trim().Equals("NEOA3RP"))
                    {
                        rdic.Add("NEOA3", !dic.ContainsKey("NEOA3RP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))) ? "" : dic["NEOA3RP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                    }
                    if (arrTestValue1[i].Split('=')[0].Trim().Equals("NEOA6RP"))
                    {
                        rdic.Add("NEOA6", !dic.ContainsKey("NEOA6RP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))) ? "" : dic["NEOA6RP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                    }
                    if (arrTestValue1[i].Split('=')[0].Trim().Equals("NEOE1RP"))
                    {
                        rdic.Add("NEOE1", !dic.ContainsKey("NEOE1RP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))) ? "" : dic["NEOE1RP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                    }
                    if (arrTestValue1[i].Split('=')[0].Trim().Equals("EQIEMRP"))
                    {
                        rdic.Add("EQIEM", !dic.ContainsKey("EQIEMRP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))) ? "" : dic["EQIEMRP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                    }
                    if (arrTestValue1[i].Split('=')[0].Trim().Equals("EQIRERP"))
                    {
                        rdic.Add("EQIRE", !dic.ContainsKey("EQIRERP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))) ? "" : dic["EQIRERP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                    }
                    if (arrTestValue1[i].Split('=')[0].Trim().Equals("NEOE2RP"))
                    {
                        rdic.Add("NEOE2", !dic.ContainsKey("NEOE2RP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))) ? "" : dic["NEOE2RP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                    }
                    if (arrTestValue1[i].Split('=')[0].Trim().Equals("NEON4RP"))
                    {
                        rdic.Add("NEON4", !dic.ContainsKey("NEON4RP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))) ? "" : dic["NEON4RP_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                    }

                      //
                    if (arrTestValue1[i].Split('=')[0].Trim().Equals("INSTFST"))
                    {
                        rdic.Add("INSTFST", !dic.ContainsKey("INSTFST_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))) ? "" : dic["INSTFST_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                    }
                    if (arrTestValue1[i].Split('=')[0].Trim().Equals("INSTSEC"))
                    {
                        rdic.Add("INSTSEC", !dic.ContainsKey("INSTSEC_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))) ? "" : dic["INSTSEC_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                    }
                    if (arrTestValue1[i].Split('=')[0].Trim().Equals("INSTTRD"))
                    {
                        rdic.Add("INSTTRD", !dic.ContainsKey("INSTTRD_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))) ? "" : dic["INSTTRD_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                    }
                    if (arrTestValue1[i].Split('=')[0].Trim().Equals("VALFST"))
                    {
                        rdic.Add("VALFST", !dic.ContainsKey("VALFST_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))) ? "" : dic["VALFST_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                    }
                    if (arrTestValue1[i].Split('=')[0].Trim().Equals("VALSEC"))
                    {
                        rdic.Add("VALSEC", !dic.ContainsKey("VALSEC_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))) ? "" : dic["VALSEC_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                    }
                    if (arrTestValue1[i].Split('=')[0].Trim().Equals("VALTRD"))
                    {
                        rdic.Add("VALTRD", !dic.ContainsKey("VALTRD_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))) ? "" : dic["VALTRD_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                    }

                  }
              }
              #endregion

               
           }
           return rdic;
       }
    
       public Dictionary<string, string> ForReportView(int userid)
       {
           Dictionary<string, string> dic = new ForecastReportComponentDal().GetDictionarys();
           Dictionary<string, string> tdic = new TextReportComponentDal().GetDictionarys();
           Dictionary<string, string> rdic = new Dictionary<string, string>();
           string sql = "select TESTREPORTVALUE1,FORECASTREPORTVALUE1 from report WHERE USERID=" + userid;
           DataTable dt = new MySQLHelper().GetDataTable(sql);
           if (dt != null && dt.Rows.Count > 0)
           {
               string testValue1 = dt.Rows[0]["TESTREPORTVALUE1"].ToString();
               string forcastValue1 = dt.Rows[0]["FORECASTREPORTVALUE1"].ToString();
               if (testValue1 != null && forcastValue1 != "")
               {
                   string[] arrTestValue1 = testValue1.Substring(1, testValue1.Length - 2).Split(',');
                   string[] arrForcastValue1 = forcastValue1.Substring(1, forcastValue1.Length - 2).Split(',');
                   for (int i = 0; i < arrTestValue1.Length; i++)
                   {

                       if (arrTestValue1[i].Split('=')[0].Trim().Equals("INSTFST"))
                       {
                           rdic.Add("INSTFST", !tdic.ContainsKey("INSTFST_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))) ? "" : tdic["INSTFST_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                       }
                       if (arrTestValue1[i].Split('=')[0].Trim().Equals("INSTTRD"))
                       {
                           rdic.Add("INSTTRD", !tdic.ContainsKey("INSTTRD_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))) ? "" : tdic["INSTTRD_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                       }
                       if (arrTestValue1[i].Split('=')[0].Trim().Equals("VALFST"))
                       {
                           rdic.Add("VALFST", !tdic.ContainsKey("VALFST_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))) ? "" : tdic["VALFST_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                       }
                       if (arrTestValue1[i].Split('=')[0].Trim().Equals("VALSEC"))
                       {
                           rdic.Add("VALSEC", !tdic.ContainsKey("VALSEC_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))) ? "" : tdic["VALSEC_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                       }
                       if (arrTestValue1[i].Split('=')[0].Trim().Equals("VALTRD"))
                       {
                           rdic.Add("VALTRD", !tdic.ContainsKey("VALTRD_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))) ? "" : tdic["VALTRD_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                       }
                       if (arrTestValue1[i].Split('=')[0].Trim().Equals("INSTSEC"))
                       {
                           rdic.Add("INSTSEC", !tdic.ContainsKey("INSTSEC_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))) ? "" : tdic["INSTSEC_" + ((int)double.Parse(arrTestValue1[i].Split('=')[1]))]);
                       }
                   }
                   for (int i = 0; i < arrForcastValue1.Length; i++)
                   {
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SKL01F"))
                       {
                           rdic.Add("SKL01F", !dic.ContainsKey("SKL01F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SKL01F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SKL11F"))
                       {
                           rdic.Add("SKL11F", !dic.ContainsKey("SKL11F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SKL11F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SKL19F"))
                       {
                           rdic.Add("SKL19F", !dic.ContainsKey("SKL19F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SKL19F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SKL21F"))
                       {
                           rdic.Add("SKL21F", !dic.ContainsKey("SKL21F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SKL21F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SKL30F"))
                       {
                           rdic.Add("SKL30F", !dic.ContainsKey("SKL30F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SKL30F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SYL01F"))
                       {
                           rdic.Add("SYL01F", !dic.ContainsKey("SYL01F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SYL01F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SYL02F"))
                       {
                           rdic.Add("SYL02F", !dic.ContainsKey("SYL02F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SYL02F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SYL03F"))
                       {
                           rdic.Add("SYL03F", !dic.ContainsKey("SYL03F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SYL03F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SYL04F"))
                       {
                           rdic.Add("SYL04F", !dic.ContainsKey("SYL04F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SYL04F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SYL05F"))
                       {
                           rdic.Add("SYL05F", !dic.ContainsKey("SYL05F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SYL05F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SYL06F"))
                       {
                           rdic.Add("SYL06F", !dic.ContainsKey("SYL06F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SYL06F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SYL07F"))
                       {
                           rdic.Add("SYL07F", !dic.ContainsKey("SYL07F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SYL07F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SYL08F"))
                       {
                           rdic.Add("SYL08F", !dic.ContainsKey("SYL08F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SYL08F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SYL09F"))
                       {
                           rdic.Add("SYL09F", !dic.ContainsKey("SYL09F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SYL09F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SYL10F"))
                       {
                           rdic.Add("SYL10F", !dic.ContainsKey("SYL10F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SYL10F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SYL11F"))
                       {
                           rdic.Add("SYL11F", !dic.ContainsKey("SYL11F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SYL11F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SYL12F"))
                       {
                           rdic.Add("SYL12F", !dic.ContainsKey("SYL12F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SYL12F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SYL13F"))
                       {
                           rdic.Add("SYL13F", !dic.ContainsKey("SYL13F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SYL13F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SYL14F"))
                       {
                           rdic.Add("SYL14F", !dic.ContainsKey("SYL14F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SYL14F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SYL15F"))
                       {
                           rdic.Add("SYL15F", !dic.ContainsKey("SYL15F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SYL15F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SYL16F"))
                       {
                           rdic.Add("SYL16F", !dic.ContainsKey("SYL16F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SYL16F_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SKL01RP"))
                       {
                           rdic.Add("SKL01RP", !dic.ContainsKey("SKL01RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SKL01RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                           //
                           rdic.Add("SKL01RPDes", new Lib5Dal().getDes("SKL01"));
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SKL11RP"))
                       {
                           rdic.Add("SKL11RP", !dic.ContainsKey("SKL11RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SKL11RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                           rdic.Add("SKL11RPDes", new Lib5Dal().getDes("SKL11"));
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SKL19RP"))
                       {
                           rdic.Add("SKL19RP", !dic.ContainsKey("SKL19RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SKL19RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                           rdic.Add("SKL19RPDes", new Lib5Dal().getDes("SKL19"));
                       }

                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SKL21RP"))
                       {
                           rdic.Add("SKL21RP", !dic.ContainsKey("SKL21RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SKL21RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                           rdic.Add("SKL21RPDes", new Lib5Dal().getDes("SKL21"));
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SKL30RP"))
                       {
                           rdic.Add("SKL30RP", !dic.ContainsKey("SKL30RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SKL30RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                           rdic.Add("SKL30RPDes", new Lib5Dal().getDes("SKL30"));
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SYL01RP"))
                       {
                           rdic.Add("SYL01RP", !dic.ContainsKey("SYL01RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SYL01RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                           rdic.Add("SYL01RPDes", new Lib5Dal().getDes("SYL01"));
                       }
                       //if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SYL01RP"))
                       //{
                       //    rdic.Add("SYL01RP", !dic.ContainsKey("SYL01RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SYL01RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                       //    rdic.Add("SYL01RPDes", new Lib5Dal().getDes("SYL01"));
                       //}

                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SYL02RP"))
                       {
                           rdic.Add("SYL02RP", !dic.ContainsKey("SYL02RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SYL02RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                           rdic.Add("SYL02RPDes", new Lib5Dal().getDes("SYL02"));
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SYL03RP"))
                       {
                           rdic.Add("SYL03RP", !dic.ContainsKey("SYL03RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SYL03RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                           rdic.Add("SYL03RPDes", new Lib5Dal().getDes("SYL03"));
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SYL04RP"))
                       {
                           rdic.Add("SYL04RP", !dic.ContainsKey("SYL04RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SYL04RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                           rdic.Add("SYL04RPDes", new Lib5Dal().getDes("SYL04"));
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SYL05RP"))
                       {
                           rdic.Add("SYL05RP", !dic.ContainsKey("SYL05RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SYL05RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                           rdic.Add("SYL05RPDes", new Lib5Dal().getDes("SYL05"));
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SYL06RP"))
                       {
                           rdic.Add("SYL06RP", !dic.ContainsKey("SYL06RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SYL06RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                           rdic.Add("SYL06RPDes", new Lib5Dal().getDes("SYL06"));
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SYL07RP"))
                       {
                           rdic.Add("SYL07RP", !dic.ContainsKey("SYL07RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SYL07RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                           rdic.Add("SYL07RPDes", new Lib5Dal().getDes("SYL07"));
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SYL08RP"))
                       {
                           rdic.Add("SYL08RP", !dic.ContainsKey("SYL08RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SYL08RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                           rdic.Add("SYL08RPDes", new Lib5Dal().getDes("SYL08"));
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SYL09RP"))
                       {
                           rdic.Add("SYL09RP", !dic.ContainsKey("SYL09RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SYL09RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                           rdic.Add("SYL09RPDes", new Lib5Dal().getDes("SYL09"));
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SYL10RP"))
                       {
                           rdic.Add("SYL10RP", !dic.ContainsKey("SYL10RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SYL10RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                           rdic.Add("SYL10RPDes", new Lib5Dal().getDes("SYL10"));
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SYL11RP"))
                       {
                           rdic.Add("SYL11RP", !dic.ContainsKey("SYL11RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SYL11RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                           rdic.Add("SYL11RPDes", new Lib5Dal().getDes("SYL11"));
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SYL12RP"))
                       {
                           rdic.Add("SYL12RP", !dic.ContainsKey("SYL12RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SYL12RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                           rdic.Add("SYL12RPDes", new Lib5Dal().getDes("SYL12"));
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SYL13RP"))
                       {
                           rdic.Add("SYL13RP", !dic.ContainsKey("SYL13RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SYL13RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                           rdic.Add("SYL13RPDes", new Lib5Dal().getDes("SYL13"));
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SYL14RP"))
                       {
                           rdic.Add("SYL14RP", !dic.ContainsKey("SYL14RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SYL14RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                           rdic.Add("SYL14RPDes", new Lib5Dal().getDes("SYL14"));
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SYL15RP"))
                       {
                           rdic.Add("SYL15RP", !dic.ContainsKey("SYL15RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SYL15RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                           rdic.Add("SYL15RPDes", new Lib5Dal().getDes("SYL15"));
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("SYL16RP"))
                       {
                           rdic.Add("SYL16RP", !dic.ContainsKey("SYL16RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))) ? "" : dic["SYL16RP_" + ((int)double.Parse(arrForcastValue1[i].Split('=')[1]))]);
                           rdic.Add("SYL16RPDes", new Lib5Dal().getDes("SYL16"));
                       }

                       //======这两个是属性
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("IDFST"))
                       {
                           rdic.Add("IDFST",  ((int)double.Parse(arrForcastValue1[i].Split('=')[1])).ToString());
                       }
                       if (arrForcastValue1[i].Split('=')[0].Trim().Equals("IDSEC"))
                       {
                           rdic.Add("IDSEC", ((int)double.Parse(arrForcastValue1[i].Split('=')[1])).ToString());
                       }
                   }
               }
           
           }
           return rdic;
       }

       public Dictionary<string, string> MatchReportView(int repertId)
       {
           Dictionary<string, string> dic = new MatchReportComponentDal().GetDictionarys();
           Dictionary<string, string> rdic = new Dictionary<string, string>();
           string sql = "select MATCHVALUE1,MATCHVALUE2 from matchreport WHERE Id=" + repertId;
           DataTable dt = new MySQLHelper().GetDataTable(sql);
           if (dt != null && dt.Rows.Count > 0)
           {
               string matchValue1 = dt.Rows[0]["MATCHVALUE1"].ToString();
               string matchValue2 = dt.Rows[0]["MATCHVALUE2"].ToString();
               if (matchValue1 != null && matchValue1 != "")
               {
                   string[] arrMatchValue1 = matchValue1.Substring(1, matchValue1.Length - 2).Split(',');
                   for (int i = 0; i < arrMatchValue1.Length; i++)
                   {
                       if (arrMatchValue1[i].Split('=')[0].Trim().Equals("MATCHRP"))
                       {
                           rdic.Add("MATCHRPDes", !dic.ContainsKey("MATCHRP_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))) ? "" : dic["MATCHRP_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))]);
                           rdic.Add("MATCHRPVal", arrMatchValue1[i].Split('=')[1].Trim());
                       }
                       if (arrMatchValue1[i].Split('=')[0].Trim().Equals("SKL01MCH"))
                       {
                           rdic.Add("SKL01RPDes", !dic.ContainsKey("SKL01MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))) ? "" : dic["SKL01MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))]);
                           rdic.Add("SKL01MCHVal", arrMatchValue1[i].Split('=')[1].Trim());
                       }
                       if (arrMatchValue1[i].Split('=')[0].Trim().Equals("SYL05MCH"))
                       {
                           rdic.Add("SYL05RPDes", !dic.ContainsKey("SYL05MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))) ? "" : dic["SYL05MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))]);
                           rdic.Add("SYL05MCHVal", arrMatchValue1[i].Split('=')[1].Trim());
                       }
                       if (arrMatchValue1[i].Split('=')[0].Trim().Equals("SYL10MCH"))
                       {
                           rdic.Add("SYL10RPDes", !dic.ContainsKey("SYL10MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))) ? "" : dic["SYL10MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))]);
                           rdic.Add("SYL10MCHVal", arrMatchValue1[i].Split('=')[1].Trim());
                       }
                       if (arrMatchValue1[i].Split('=')[0].Trim().Equals("SYL12MCH"))
                       {
                           rdic.Add("SYL12RPDes", !dic.ContainsKey("SYL12MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))) ? "" : dic["SYL12MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))]);
                           rdic.Add("SYL12MCHVal", arrMatchValue1[i].Split('=')[1].Trim());
                       }
                       if (arrMatchValue1[i].Split('=')[0].Trim().Equals("INSTMATCH"))
                       {
                           rdic.Add("INSTMATCHDes", !dic.ContainsKey("INSTMATCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))) ? "" : dic["INSTMATCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))]);
                           rdic.Add("INSTMATCHVal", arrMatchValue1[i].Split('=')[1].Trim());
                       }
                       if (arrMatchValue1[i].Split('=')[0].Trim().Equals("SYL03MCH"))
                       {
                           rdic.Add("SYL03RPDes", !dic.ContainsKey("SYL03MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))) ? "" : dic["SYL03MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))]);
                           rdic.Add("SYL03MCHVal", arrMatchValue1[i].Split('=')[1].Trim());
                       }
                       if (arrMatchValue1[i].Split('=')[0].Trim().Equals("SYL06MCH"))
                       {
                           rdic.Add("SYL06RPDes", !dic.ContainsKey("SYL06MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))) ? "" : dic["SYL06MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))]);
                           rdic.Add("SYL06MCHVal", arrMatchValue1[i].Split('=')[1].Trim());
                       }
                       if (arrMatchValue1[i].Split('=')[0].Trim().Equals("VALMATCH"))
                       {
                           //============
                           rdic.Add("VALMATCH", !dic.ContainsKey("VALMATCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))) ? "" : dic["VALMATCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))]);
                          
                           rdic.Add("VALMATCHDes", new Lib5Dal().getDes("VAL"));
                           rdic.Add("VALMATCHVal", arrMatchValue1[i].Split('=')[1].Trim());
                       }
                       if (arrMatchValue1[i].Split('=')[0].Trim().Equals("MATCHRP"))
                       {
                           //============
                           rdic.Add("MATCHRP", !dic.ContainsKey("MATCHRP_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))) ? "" : dic["MATCHRP_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))]);

                         //  rdic.Add("VALMATCHDes", new Lib5Dal().getDes("VAL"));
                          // rdic.Add("VALMATCHVal", arrMatchValue1[i].Split('=')[1].Trim());
                       }
                       if (arrMatchValue1[i].Split('=')[0].Trim().Equals("SYL08MCH"))
                       {
                           rdic.Add("SYL08RPDes", !dic.ContainsKey("SYL08MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))) ? "" : dic["SYL08MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))]);
                           rdic.Add("SYL08MCHVal", arrMatchValue1[i].Split('=')[1].Trim());
                       }
                       if (arrMatchValue1[i].Split('=')[0].Trim().Equals("SKL30MCH"))
                       {
                           rdic.Add("SKL30RPDes", !dic.ContainsKey("SKL30MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))) ? "" : dic["SKL30MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))]);
                           rdic.Add("SKL30MCHVal", arrMatchValue1[i].Split('=')[1].Trim());
                       }
                       if (arrMatchValue1[i].Split('=')[0].Trim().Equals("SYL09MCH"))
                       {
                           rdic.Add("SYL09RPDes", !dic.ContainsKey("SYL09MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))) ? "" : dic["SYL09MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))]);
                           rdic.Add("SYL09MCHVal", arrMatchValue1[i].Split('=')[1].Trim());
                       }
                       if (arrMatchValue1[i].Split('=')[0].Trim().Equals("SKL19MCH"))
                       {
                           rdic.Add("SKL19RPDes", !dic.ContainsKey("SKL19MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))) ? "" : dic["SKL19MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))]);
                           rdic.Add("SKL19MCHVal", arrMatchValue1[i].Split('=')[1].Trim());
                       }
                       if (arrMatchValue1[i].Split('=')[0].Trim().Equals("SKL21MCH"))
                       {
                           rdic.Add("SKL21RPDes", !dic.ContainsKey("SKL21MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))) ? "" : dic["SKL21MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))]);
                           rdic.Add("SKL21MCHVal", arrMatchValue1[i].Split('=')[1].Trim());
                       }
                       if (arrMatchValue1[i].Split('=')[0].Trim().Equals("SKL11MCH"))
                       {
                           rdic.Add("SKL11RPDes", !dic.ContainsKey("SKL11MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))) ? "" : dic["SKL11MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))]);
                           rdic.Add("SKL11MCHVal", arrMatchValue1[i].Split('=')[1].Trim());
                       }
                       if (arrMatchValue1[i].Split('=')[0].Trim().Equals("SYL14MCH"))
                       {
                           rdic.Add("SYL14RPDes", !dic.ContainsKey("SYL14MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))) ? "" : dic["SYL14MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))]);
                           rdic.Add("SYL14MCHVal", arrMatchValue1[i].Split('=')[1].Trim());
                       }
                       if (arrMatchValue1[i].Split('=')[0].Trim().Equals("SYL11MCH"))
                       {
                           rdic.Add("SYL11RPDes", !dic.ContainsKey("SYL11MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))) ? "" : dic["SYL11MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))]);
                           rdic.Add("SYL11MCHVal", arrMatchValue1[i].Split('=')[1].Trim());
                       }
                       if (arrMatchValue1[i].Split('=')[0].Trim().Equals("SYL13MCH"))
                       {
                           rdic.Add("SYL13RPDes", !dic.ContainsKey("SYL13MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))) ? "" : dic["SYL13MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))]);
                           rdic.Add("SYL13MCHVal", arrMatchValue1[i].Split('=')[1].Trim());
                       }
                       if (arrMatchValue1[i].Split('=')[0].Trim().Equals("SYL15MCH"))
                       {
                           rdic.Add("SYL15RPDes", !dic.ContainsKey("SYL15MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))) ? "" : dic["SYL15MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))]);
                           rdic.Add("SYL15MCHVal", arrMatchValue1[i].Split('=')[1].Trim());
                       }
                       if (arrMatchValue1[i].Split('=')[0].Trim().Equals("SYL02MCH"))
                       {
                           rdic.Add("SYL02RPDes", !dic.ContainsKey("SYL02MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))) ? "" : dic["SYL02MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))]);
                           rdic.Add("SYL02MCHVal", arrMatchValue1[i].Split('=')[1].Trim());
                       }
                       if (arrMatchValue1[i].Split('=')[0].Trim().Equals("SYL07MCH"))
                       {
                           rdic.Add("SYL07RPDes", !dic.ContainsKey("SYL07MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))) ? "" : dic["SYL07MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))]);
                           rdic.Add("SYL07MCHVal", arrMatchValue1[i].Split('=')[1].Trim());
                       }
                       if (arrMatchValue1[i].Split('=')[0].Trim().Equals("SYL16MCH"))
                       {
                           rdic.Add("SYL16RPDes", !dic.ContainsKey("SYL16MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))) ? "" : dic["SYL16MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))]);
                           rdic.Add("SYL16MCHVal", arrMatchValue1[i].Split('=')[1].Trim());
                       }
                       if (arrMatchValue1[i].Split('=')[0].Trim().Equals("SYL01MCH"))
                       {
                           rdic.Add("SYL01RPDes", !dic.ContainsKey("SYL01MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))) ? "" : dic["SYL01MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))]);
                           rdic.Add("SYL01MCHVal", arrMatchValue1[i].Split('=')[1].Trim());
                       }
                       if (arrMatchValue1[i].Split('=')[0].Trim().Equals("SYL04MCH"))
                       {
                           rdic.Add("SYL04RPDes", !dic.ContainsKey("SYL04MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))) ? "" : dic["SYL04MCH_" + ((int)double.Parse(arrMatchValue1[i].Split('=')[1]))]);
                           rdic.Add("SYL04MCHVal", arrMatchValue1[i].Split('=')[1].Trim());
                       }
                   
                   }
               }
           
           }
           return rdic;
       }

       public DataTable Query(int userId)
       {
           var sql = "select m.ID,TITLE,m.JobId,MATCHTIME from matchreport m ,jobview where jobview.JOBID=m.JOBID and m.UserId=" + userId;
           return new MySQLHelper().GetDataTable(sql);
       }

       public int count(int UserId)
       {
           string sql = "select count(*) from report where USERID=" + UserId;
           return int.Parse(new MySQLHelper().ExecuteValue(sql));
       
       }


       public void Test()
       {
           //getTestTable("");
           //getMatchTable("");
           //getForTable("");
          // TextReportView(45);
         //  ForReportView(234);
           //MatchReportView(234);
         //  new Calculate().TestResult(48);
         //  new Calculate().ForResult(47, "");
           new Calculate().MatchResult(46, "40025");
       }

    }

    public class Calculate
    {
      public void TestResult(int userId)
      {
          string sql = "select sum(i.score) as SCORE,q.iptype,i.ipid from ( select DISTINCT * from ipanswer ) i,iptestquestions q where userid="+userId+" and i.ipid=q.ipid GROUP BY q.IPTYPE  order by q.iptype ";
          MySqlParameter[] param = new MySqlParameter[1];
          param[0] = new MySqlParameter("?UserId", MySqlDbType.Int32);
          param[0].Value = userId;

          DataTable dt = new MySQLHelper().GetDataTable(sql);
          double IP1 = 0;
          double IP2 = 0;
          double IP3 = 0;
          double IP4 = 0;
          double IP5 = 0;
          double IP6 = 0;
          for (int i = 0; i < dt.Rows.Count; i++)
          {
              string iptype = dt.Rows[i]["iptype"].ToString();
              if (iptype == "IP1")
              {
                  IP1 += double.Parse(dt.Rows[i]["SCORE"].ToString());
              }
              else if (iptype=="IP2")
              {
                  IP2 += double.Parse(dt.Rows[i]["SCORE"].ToString());
              }
              else if (iptype=="IP3")
              {
                  IP3 += double.Parse(dt.Rows[i]["SCORE"].ToString());
              }
              else if (iptype=="IP4")
              {
                  IP4 += double.Parse(dt.Rows[i]["SCORE"].ToString());
              }
              else if (iptype=="IP5")
              {
                  IP5 += double.Parse(dt.Rows[i]["SCORE"].ToString());
              }
              else if (iptype=="IP6")
              {
                  IP6 += double.Parse(dt.Rows[i]["SCORE"].ToString());
              }

          }

          //2.计算WIL1~WIL6值
          double WIL1 = 0;
          double WIL2 = 0;
          double WIL3 = 0;
          double WIL4 = 0;
          double WIL5 = 0;
          double WIL6 = 0;
          sql = "select sum(w.score) as SCORE,q.WILTYPE from ( select DISTINCT * from wilanswer ) w ,wiltestquestions q WHERE w.USERID=?UserId and w.WILID=q.WILID  GROUP BY q.WILTYPE ORDER BY q.WILTYPE";
          DataTable dt1 = new MySQLHelper().GetDataTable(sql, param);
          for (int i = 0; i < dt1.Rows.Count; i++)
          {
              if (dt1.Rows[i]["WILTYPE"].ToString()=="WIL1")
              {
                  WIL1 += double.Parse(dt1.Rows[i]["SCORE"].ToString());
              }
              else if (dt1.Rows[i]["WILTYPE"].ToString() == "WIL2")
              {
                  WIL2 += double.Parse(dt1.Rows[i]["SCORE"].ToString());
              }
              else if (dt1.Rows[i]["WILTYPE"].ToString() == "WIL3")
              {
                  WIL3 += double.Parse(dt1.Rows[i]["SCORE"].ToString());
              }
              else if (dt1.Rows[i]["WILTYPE"].ToString() == "WIL4")
              {
                  WIL4 += double.Parse(dt1.Rows[i]["SCORE"].ToString());
              }
              else if (dt1.Rows[i]["WILTYPE"].ToString() == "WIL5")
              {
                  WIL5 += double.Parse(dt1.Rows[i]["SCORE"].ToString());
              }
              else if (dt1.Rows[i]["WILTYPE"].ToString() == "WIL6")
              {
                  WIL6 += double.Parse(dt1.Rows[i]["SCORE"].ToString());
              }
          }

          double EQIAS = 0;
          double EQIEM = 0;
          double EQIES = 0;
          double EQIFL = 0;
          double EQIIC = 0;
          double EQIIN = 0;
          double EQIIR = 0;

          double EQIOP = 0;
          double EQIPS = 0;
          double EQIRE = 0;
          double EQIRT = 0;
          double EQISA = 0;
          double EQIST = 0;

          double EQINI = 0;
          double EQIPI = 0;
          double EQIZZ = 0;

          double NEOA2 = 0;
          double NEOA3 = 0;
          double NEOA4 = 0;
          double NEOA6 = 0;

          double NEOC1 = 0;
          double NEOC2 = 0;
          double NEOC3 = 0;
          double NEOC4 = 0;
          double NEOC5 = 0;
          double NEOC6 = 0;

          double NEOE1 = 0;
          double NEOE2 = 0;
          double NEOE3 = 0;
          double NEOE4 = 0;

          double NEON2 = 0;
          double NEON4 = 0;
          double NEON5 = 0;
          double NEON6 = 0;

          double NEOO3 = 0;
          double NEOO4 = 0;
          double NEOO5 = 0;
          sql = "select sum(e.score) as SCORE,q.EQITYPE from ( select DISTINCT * from eqianswer ) e,eqitestquestions q where userid="+userId+" and e.EQIID=q.EQIID group by q.EQITYPE order by q.eqitype";
          dt = new MySQLHelper().GetDataTable(sql);

          for (int i = 0; i < dt.Rows.Count; i++)
          {
              string eqitype = dt.Rows[i]["EQITYPE"].ToString();
              double score = double.Parse(dt.Rows[i]["SCORE"].ToString());
              //第一行
              if (eqitype == "EQIAS")
              {
                  EQIAS += score;
              }
              else if (eqitype == "EQIEM")
              {
                  EQIEM += score;
              }
              else if (eqitype == "EQIES")
              {
                  EQIES += score;
              }
              else if (eqitype == "EQIFL")
              {
                  EQIFL += score;
              }
              else if (eqitype == "EQIIC")
              {
                  EQIIC += score;
              }
              else if (eqitype == "EQIIN")
              {
                  EQIIN += score;
              }
              else if (eqitype == "EQIIR")
              {
                  EQIIR += score;
              }
              //第二行

              if (eqitype == "EQIOP")
              {
                  EQIOP += score;
              }
              else if (eqitype == "EQIPS")
              {
                  EQIPS += score;
              }
              else if (eqitype == "EQIRE")
              {
                  EQIRE += score;
              }
              else if (eqitype == "EQIRT")
              {
                  EQIRT += score;
              }
              else if (eqitype == "EQISA")
              {
                  EQISA += score;
              }
              else if (eqitype == "EQIST")
              {
                  EQIST += score;
              }

              //第三行
              if (eqitype == "EQINI") {
                  EQINI += score;
              }
              else if (eqitype == "EQIPI")
              {
                  EQIPI += score;
              }
              else if (eqitype == "EQIZZ")
              {
                  EQIZZ += score;
              }
              //第四行
              if (eqitype == "NEOA2")
              {
                  NEOA2 += score;
              }
              else if (eqitype == "NEOA3")
              {
                  NEOA3 += score;
              }
              else if (eqitype == "NEOA4")
              {
                  NEOA4 += score;
              }
              else if (eqitype == "NEOA6")
              {
                  NEOA6 += score;
              }
              //第五行
              if (eqitype == "NEOC1")
              {
                  NEOC1 += score;
              }
              else if (eqitype == "NEOC2")
              {
                  NEOC2 += score;
              }
              else if (eqitype == "NEOC3")
              {
                  NEOC3 += score;
              }
              else if (eqitype == "NEOC4")
              {
                  NEOC4 += score;
              }
              else if (eqitype == "NEOC5")
              {
                  NEOC5 += score;
              }
              else if (eqitype == "NEOC6")
              {
                  NEOC6 += score;
              }
              //第六行
              if (eqitype == "NEOE1")
              {
                  NEOE1 += score;
              }
              else if (eqitype == "NEOE2")
              {
                  NEOE2 += score;
              }
              else if (eqitype == "NEOE3")
              {
                  NEOE3 += score;
              }
              else if (eqitype == "NEOE4")
              {
                  NEOE4 += score;
              }
              //第七行
              if (eqitype == "NEON2")
              {
                  NEON2 += score;
              }
              else if (eqitype == "NEON4")
              {
                  NEON4 += score;
              }
              else if (eqitype == "NEON5")
              {
                  NEON5 += score;
              }
              else if (eqitype == "NEON6")
              {
                  NEON6 += score;
              }
              //第八行
              if (eqitype == "NEOO3")
              {
                  NEOO3 += score;
              }
              else if (eqitype == "NEOO4")
              {
                  NEOO4 += score;
              }
              else if (eqitype == "NEOO5")
              {
                  NEOO5 += score;
              }
          }
          EvaluationForecastMatchFunction e = new EvaluationForecastMatchFunction();
         string[] str=e.evaluationFunction(IP1, IP2, IP3, IP4, IP5, IP6, WIL1, WIL2, WIL3, WIL4, WIL5, WIL6, EQIAS, EQIEM, EQIES, EQIFL, EQIIC, EQIIN, EQIIR, EQIOP, EQIPS, EQIRE, EQIRT, EQISA, EQIST, EQINI, EQIPI, EQIZZ, NEOA2, NEOA3, NEOA4, NEOA6, NEOC1, NEOC2, NEOC3, NEOC4, NEOC5, NEOC6, NEOE1, NEOE2, NEOE3, NEOE4, NEON2, NEON4, NEON5, NEON6, NEOO3, NEOO4, NEOO5);
        
          string paramStr =
          "IP1=" + IP1 + ", IP2=" + IP2 + ", IP3=" + IP3 + ", IP4=" + IP4 + ", IP5=" + IP5 + ", IP6=" + IP6 +
          ", WIL1=" + WIL1 + ", WIL2=" + WIL2 + ", WIL3=" + WIL3 + ", WIL4=" + WIL4 + ", WIL5=" + WIL5 +
          ", WIL6=" + WIL6 + ", EQIAS=" + EQIAS + ", EQIEM=" + EQIEM + ", EQIES=" + EQIES + ", EQIFL=" + EQIFL + ", EQIIC=" + EQIIC + ", EQIIN=" + EQIIN + ", EQIIR=" + EQIIR +
          ", EQIOP=" + EQIOP + ", EQIPS=" + EQIPS + ", EQIRE=" + EQIRE + ", EQIRT=" + EQIRT + ", EQISA=" + EQISA + ", EQIST=" + EQIST + ", EQINI=" + EQINI + ", EQIPI=" + EQIPI + ", EQIZZ=" + EQIZZ + ", NEOA2=" + NEOA2 +
          ", NEOA3=" + NEOA3 + ", NEOA4=" + NEOA4 + ", NEOA6=" + NEOA6 + ", NEOC1=" + NEOC1 + ", NEOC2=" + NEOC2 + ", NEOC3=" + NEOC3 + ", NEOC4=" + NEOC4 + ", NEOC5=" + NEOC5 + ", NEOC6=" + NEOC6 + ", NEOE1=" + NEOE1 + ", NEOE2=" + NEOE2 + ", NEOE3=" + NEOE3 + ", NEOE4=" + NEOE4 + ", NEON2=" + NEON2 + ", NEON4=" + NEON4 + ", NEON5=" + NEON5 + ", NEON6=" + NEON6 + ", NEOO3=" + NEOO3 + ", NEOO4=" + NEOO4 + ", NEOO5=" + NEOO5;
         //存入到数据库中
          string sqlx = "insert into report (USERID,TESTPARAMS,TESTREPORTVALUE1,TESTREPORTVALUE2,TESTTIME) values (" + userId + ",'" + paramStr + "','" + mov(str[0]) + "','" + mov(str[1]) + "',now())";
          new MySQLHelper().ExecuteSql(sqlx);
          string x = paramStr;
      }

      public void ForResult(int userId,string inputstr)
      {

          EvaluationForecastMatchFunction function = new EvaluationForecastMatchFunction();
          double IP1 = 0, IP2 = 0, IP3 = 0, IP4 = 0, IP5 = 0, IP6 = 0, WIL1 = 0, WIL2 = 0, WIL3 = 0, WIL4 = 0, WIL5 = 0, WIL6 = 0, EQIAS = 0, EQIEM = 0, EQIES = 0, EQIFL = 0, EQIIC = 0, EQIIN = 0, EQIIR = 0, EQIOP = 0, EQIPS = 0, EQIRE = 0, EQIRT = 0, EQISA = 0, EQIST = 0, EQINI = 0, EQIPI = 0, EQIZZ = 0, NEOA2 = 0, NEOA3 = 0, NEOA4 = 0, NEOA6 = 0, NEOC1 = 0, NEOC2 = 0, NEOC3 = 0, NEOC4 = 0, NEOC5 = 0, NEOC6 = 0, NEOE1 = 0, NEOE2 = 0, NEOE3 = 0, NEOE4 = 0, NEON2 = 0, NEON4 = 0, NEON5 = 0, NEON6 = 0, NEOO3 = 0, NEOO4 = 0, NEOO5 = 0;
          Dictionary<string, string> ipdic = new IpQuestionDal().getAnswerAndType(userId);
          Dictionary<string, string> eqidic = new EqiQuestionDal().getAnswerAndType(userId);
          Dictionary<string, string> wildic = new WilQuestionDal().getTypeAndAnswer(userId);
          //易经部分结果
          double INSTFST = 0, INSTSEC = 0, INSTTRD = 0, VALFST = 0, VALSEC = 0, VALTRD = 0;
          //ip
          IP1 = double.Parse(ipdic["IP1"]);
          IP2 = double.Parse(ipdic["IP2"]);
          IP3 = double.Parse(ipdic["IP3"]);
          IP4 = double.Parse(ipdic["IP4"]);
          IP5 = double.Parse(ipdic["IP5"]);
          IP6 = double.Parse(ipdic["IP6"]);
          //wil
          WIL1 = double.Parse(wildic["WIL1"]);
          WIL2 = double.Parse(wildic["WIL2"]);
          WIL3 = double.Parse(wildic["WIL3"]);
          WIL4 = double.Parse(wildic["WIL4"]);
          WIL5 = double.Parse(wildic["WIL5"]);
          //eqi
          EQIAS = double.Parse(eqidic["EQIAS"]);
          WIL6 = double.Parse(wildic["WIL6"]);
          EQIEM = double.Parse(eqidic["EQIEM"]);
          EQIES = double.Parse(eqidic["EQIES"]);
          EQIFL = double.Parse(eqidic["EQIFL"]);
          EQIIC = double.Parse(eqidic["EQIIC"]);
          EQIIN = double.Parse(eqidic["EQIIN"]);
          EQIIR = double.Parse(eqidic["EQIIR"]);
          EQIOP = double.Parse(eqidic["EQIOP"]);
          EQIPS = double.Parse(eqidic["EQIPS"]);
          EQIRE = double.Parse(eqidic["EQIRE"]);
          EQIRT = double.Parse(eqidic["EQIRT"]);
          EQISA = double.Parse(eqidic["EQISA"]);
          EQIST = double.Parse(eqidic["EQIST"]);
          EQINI = double.Parse(eqidic["EQINI"]);
          EQIPI = double.Parse(eqidic["EQIPI"]);
          EQIZZ = double.Parse(eqidic["EQIZZ"]);
          NEOA2 = double.Parse(eqidic["NEOA2"]);
          NEOA3 = double.Parse(eqidic["NEOA3"]);
          NEOA4 = double.Parse(eqidic["NEOA4"]);
          NEOA6 = double.Parse(eqidic["NEOA6"]);
          NEOC1 = double.Parse(eqidic["NEOC1"]);
          NEOC2 = double.Parse(eqidic["NEOC2"]);
          NEOC3 = double.Parse(eqidic["NEOC3"]);
          NEOC4 = double.Parse(eqidic["NEOC4"]);
          NEOC5 = double.Parse(eqidic["NEOC5"]);
          NEOC6 = double.Parse(eqidic["NEOC6"]);

          NEOE1 = double.Parse(eqidic["NEOE1"]);
          NEOE2 = double.Parse(eqidic["NEOE2"]);
          NEOE3 = double.Parse(eqidic["NEOE3"]);
          NEOE4 = double.Parse(eqidic["NEOE4"]);
          NEON2 = double.Parse(eqidic["NEON2"]);
          NEON4 = double.Parse(eqidic["NEON4"]);
          NEON5 = double.Parse(eqidic["NEON5"]);
          NEON6 = double.Parse(eqidic["NEON6"]);
          NEOO3 = double.Parse(eqidic["NEOO3"]);
          NEOO4 = double.Parse(eqidic["NEOO4"]);
          NEOO5 = double.Parse(eqidic["NEOO5"]);

          string str = getTextValue1(userId);
          if (!string.IsNullOrEmpty(str))
          {
              str = str.Substring(1, str.Length - 1);
                string[] arrStr=str.Split(',');
              for(int j=0;j<arrStr.Length;j++)
              {
                  if (arrStr[j].Split('=')[0].Trim().Equals("INSTFST"))
                  {
                      INSTFST = double.Parse(arrStr[j].Split('=')[1]);
					}
                  if (arrStr[j].Split('=')[0].Trim().Equals("INSTSEC"))
                  {
                      INSTSEC = double.Parse(arrStr[j].Split('=')[1]);
					}
                  if (arrStr[j].Split('=')[0].Trim().Equals("INSTTRD"))
                  {
                      INSTTRD = double.Parse(arrStr[j].Split('=')[1]);
					}
                  if (arrStr[j].Split('=')[0].Trim().Equals("VALFST"))
                  {
                      VALFST = double.Parse(arrStr[j].Split('=')[1]);
					}
                  if (arrStr[j].Split('=')[0].Trim().Equals("VALSEC"))
                  {
                      VALSEC = double.Parse(arrStr[j].Split('=')[1]);
					}
                  if (arrStr[j].Split('=')[0].Trim().Equals("VALTRD"))
                  {
                      VALTRD = double.Parse(arrStr[j].Split('=')[1]);
					}
              }
          }
          //查询数据库得到职业的列表
          double[] INST1R, INST2I, INST3A, INST4S, INST5E, INST6C, VAL1A, VAL2I, VAL3C, VAL4R, VAL5S, VAL6W, SYL01B, SYL02B, SYL03B, SYL04B, SYL05B, SYL06B, SYL07B, SYL08B, SYL09B, SYL10B, SYL11B, SYL12B, SYL13B, SYL14B, SYL15B, SYL16B, SKL01B, SKL11B, SKL19B, SKL21B, SKL30B;
          AllLibDal alldao = new AllLibDal();
          INST1R = alldao.getJobIDList("INST1R");
          INST2I = alldao.getJobIDList("INST2I");
          INST3A = alldao.getJobIDList("INST3A");
          INST4S = alldao.getJobIDList("INST4S");
          INST5E = alldao.getJobIDList("INST5E");
          INST6C = alldao.getJobIDList("INST6C");
          VAL1A = alldao.getJobIDList("VAL1A");

          VAL2I = alldao.getJobIDList("VAL2I");
          VAL3C = alldao.getJobIDList("VAL3C");
          VAL4R = alldao.getJobIDList("VAL4R");
          VAL5S = alldao.getJobIDList("VAL5S");
          VAL6W = alldao.getJobIDList("VAL6W");

          JobMapBinaryDal dao = new JobMapBinaryDal();

          SYL01B = dao.getJobIDList("SYL01B");
          SYL02B = dao.getJobIDList("SYL02B");
          SYL03B = dao.getJobIDList("SYL03B");
          SYL04B = dao.getJobIDList("SYL04B");
          SYL05B = dao.getJobIDList("SYL05B");
          SYL06B = dao.getJobIDList("SYL06B");
          SYL07B = dao.getJobIDList("SYL07B");
          SYL08B = dao.getJobIDList("SYL08B");
          SYL09B = dao.getJobIDList("SYL09B");
          SYL10B = dao.getJobIDList("SYL10B");
          SYL11B = dao.getJobIDList("SYL11B");
          SYL12B = dao.getJobIDList("SYL12B");
          SYL13B = dao.getJobIDList("SYL13B");
          SYL14B = dao.getJobIDList("SYL14B");
          SYL15B = dao.getJobIDList("SYL15B");
          SYL16B = dao.getJobIDList("SYL16B");
          SKL01B = dao.getJobIDList("SKL01B");
          SKL11B = dao.getJobIDList("SKL11B");
          SKL19B = dao.getJobIDList("SKL19B");
          SKL21B = dao.getJobIDList("SKL21B");
          SKL30B = dao.getJobIDList("SKL30B");

            double[] SKL01_1=alldao.getJobIDList("SKL01_1");
            double[] SKL11_1=alldao.getJobIDList("SKL11_1");
            double[] SKL19_1=alldao.getJobIDList("SKL19_1");
            double[] SKL21_1=alldao.getJobIDList("SKL21_1");
            double[] SKL30_1=alldao.getJobIDList("SKL30_1");
            double[]  SYL01=alldao.getJobIDList("SYL01");
            double[] SYL02=alldao.getJobIDList("SYL02");
            double[]  SYL03=alldao.getJobIDList("SYL03");
			double[] SYL04=alldao.getJobIDList("SYL04");
            double[] SYL05=alldao.getJobIDList("SYL05");
            double[] SYL06=alldao.getJobIDList("SYL06");
            double[] SYL07=alldao.getJobIDList("SYL07");
            double[] SYL08=alldao.getJobIDList("SYL08");
            double[] SYL09=alldao.getJobIDList("SYL09");
            double[] SYL10=alldao.getJobIDList("SYL10");
            double[] SYL11=alldao.getJobIDList("SYL11");
            double[] SYL12=alldao.getJobIDList("SYL12");
            double[] SYL13=alldao.getJobIDList("SYL13");
		    double[] SYL14=alldao.getJobIDList("SYL14");
            double[] SYL15=alldao.getJobIDList("SYL15");
            double[] SYL16=alldao.getJobIDList("SYL16");
          double[] SKL01 = alldao.getJobIDList("SKL01_2");
          double[] SKL11 = alldao.getJobIDList("SKL11_2");
          double[] SKL19 = alldao.getJobIDList("SKL19_2");
          double[] SKL21 = alldao.getJobIDList("SKL21_2");
          double[] SKL30 = alldao.getJobIDList("SKL30_2");

            string[] jobs=new IndexLibDal().getJOBIDByOrder();
            string[] jobwxs = new IndexLibDal().getValueByORDERAndZYWX();
             int ZYWX = (int)double.Parse(getZYWX(userId));
             int CYWX=(int)double.Parse(getCYWX(userId));
             int RGWX = (int)double.Parse(getRGWX(userId));

          string[] strs = function.forecastFunction(IP1, IP2, IP3, IP4, IP5, IP6, WIL1, WIL2, WIL3, WIL4, WIL5, WIL6, EQIAS, EQIEM, EQIES, EQIFL, EQIIC, EQIIN, EQIIR, EQIOP, EQIPS, EQIRE, EQIRT, EQISA, EQIST, NEOA2, NEOA3, NEOA4, NEOA6, NEOC1, NEOC2, NEOC3, NEOC4, NEOC5, NEOC6, NEOE1, NEOE2, NEOE3, NEOE4, NEON2, NEON4, NEON5, NEON6, NEOO3, NEOO4, NEOO5, INSTFST, INSTSEC, INSTTRD, VALFST, VALSEC,
                     VALTRD, null, INST1R, INST2I, INST3A, INST4S, INST5E, INST6C, VAL1A, VAL2I, VAL3C, VAL4R, VAL5S, VAL6W, SYL01B, SYL02B, SYL03B, SYL04B, SYL05B, SYL06B, SYL07B, SYL08B, SYL09B, SYL10B, SYL11B, SYL12B, SYL13B, SYL14B, SYL15B, SYL16B, SKL01B, SKL11B, SKL19B, SKL21B, SKL30B,
                     ZYWX, CYWX, RGWX,
                     SKL01_1,
                     SKL11_1, SKL19_1, SKL21_1, SKL30_1, SYL01, SYL02, SYL03, SYL04, SYL05, SYL06, SYL07, SYL08, SYL09, SYL10, SYL11, SYL12, SYL13,
                     SYL14, SYL15, SYL16,SKL01,SKL11,SKL19,SKL21,SKL30, jobs, jobwxs
                     );
          strs[0] = mov(strs[0].Replace(':', '='));
          strs[1] = mov(strs[1].Replace(':', '='));

          string sql = "update report set FORECASTTIME=now(),FORECASTREPORTVALUE1='" + strs[0] + "',FORECASTREPORTVALUE2='" + strs[1] + "' where USERID=" + userId;
          new MySQLHelper().ExecuteSql(sql);

          string[] xx = strs;
      }

      public void MatchResult(int userId, string JobNum)
      {
         // int reportID = getReportIDByUserID(userID);

          EvaluationForecastMatchFunction function = new EvaluationForecastMatchFunction();
          double INSTFST = 0, INSTSEC = 0, INSTTRD = 0, VALFST = 0, VALSEC = 0, VALTRD = 0,
                  SKL01F = 0, SKL11F = 0, SKL19F = 0, SKL21F = 0, SKL30F = 0, SYL01F = 0,
                  SYL02F = 0, SYL03F = 0, SYL04F = 0, SYL05F = 0, SYL06F = 0, SYL07F = 0,
                  SYL08F = 0, SYL09F = 0, SYL10F = 0, SYL11F = 0, SYL12F = 0, SYL13F = 0,
                  SYL14F = 0, SYL15F = 0, SYL16F = 0,
                  INST1R = 0, INST2I = 0, INST3A = 0, INST4S = 0, INST5E = 0, INST6C = 0, VAL1A = 0, VAL2I = 0, VAL3C = 0, VAL4R = 0, VAL5S = 0, VAL6W = 0, SYL01B = 0, SYL02B = 0, SYL03B = 0, SYL04B = 0, SYL05B = 0, SYL06B = 0, SYL07B = 0, SYL08B = 0, SYL09B = 0, SYL10B = 0, SYL11B = 0, SYL12B = 0, SYL13B = 0, SYL14B = 0, SYL15B = 0, SYL16B = 0, SKL01B = 0, SKL11B = 0, SKL19B = 0, SKL21B = 0, SKL30B = 0;
       //   bool re = false;
          String forecastStr = getForcastValue1(userId);
          String testValue1 = getTextValue1(userId);


          if (testValue1 != null && testValue1 != "")
          {
              String[] testArr = testValue1.Substring(1, testValue1.Length - 1).Split(',');
              for (int i = 0; i < testArr.Length; i++)
              {
                  if (testArr[i].Split('=')[0].Trim().Equals("INSTFST"))
                  {
                      INSTFST = double.Parse(testArr[i].Split('=')[1].Trim());
                      continue;
                  }
                  //INSTSEC
                  if (testArr[i].Split('=')[0].Trim().Equals("INSTSEC"))
                  {
                      INSTSEC = double.Parse(testArr[i].Split('=')[1].Trim());
                      continue;
                  }
                  //INSTTRD, 
                  if (testArr[i].Split('=')[0].Trim().Equals("INSTTRD"))
                  {
                      INSTTRD = double.Parse(testArr[i].Split('=')[1].Trim());
                      continue;
                  }
                  //				VALFST,
                  if (testArr[i].Split('=')[0].Trim().Equals("VALFST"))
                  {
                      VALFST = double.Parse(testArr[i].Split('=')[1].Trim());
                      continue;
                  }
                  //				VALSEC, //=================
                  if (testArr[i].Split('=')[0].Trim().Equals("VALSEC"))
                  {
                      VALSEC = double.Parse(testArr[i].Split('=')[1].Trim());
                      continue;
                  }
                  //				VALTRD, 
                  if (testArr[i].Split('=')[0].Trim().Equals("VALTRD"))
                  {
                      VALTRD = double.Parse(testArr[i].Split('=')[1].Trim());
                      continue;
                  }
              }

          }


          if (forecastStr != null && forecastStr != "")
          {
              forecastStr = forecastStr.Substring(1, forecastStr.Length - 1);
              String[] forcastArr = forecastStr.Split(',');
              for (int i = 0; i < forcastArr.Length; i++)
              {
                  //			SKL01RP, 
                  if (forcastArr[i].Split('=')[0].Trim().Equals("SKL01F"))
                  {
                      SKL01F = double.Parse(forcastArr[i].Split('=')[1].Trim());
                      continue;
                  }
                  //			SKL11RP,
                  if (forcastArr[i].Split('=')[0].Trim().Equals("SKL11F"))
                  {
                      SKL11F = double.Parse(forcastArr[i].Split('=')[1].Trim());
                      continue;
                  }
                  //			SKL19RP, 
                  if (forcastArr[i].Split('=')[0].Trim().Equals("SKL19F"))
                  {
                      SKL19F = double.Parse(forcastArr[i].Split('=')[1].Trim());
                      continue;
                  }
                  //			SKL21RP,
                  if (forcastArr[i].Split('=')[0].Trim().Equals("SKL21F"))
                  {
                      SKL21F = double.Parse(forcastArr[i].Split('=')[1].Trim());
                      continue;
                  }
                  //			SKL30RP,
                  if (forcastArr[i].Split('=')[0].Trim().Equals("SKL30F"))
                  {
                      SKL30F = double.Parse(forcastArr[i].Split('=')[1].Trim());
                      continue;
                  }
                  //			SYL01RP,
                  if (forcastArr[i].Split('=')[0].Trim().Equals("SYL01F"))
                  {
                      SYL01F = double.Parse(forcastArr[i].Split('=')[1].Trim());
                      continue;
                  }
                  //			SYL02RP,
                  if (forcastArr[i].Split('=')[0].Trim().Equals("SYL02F"))
                  {
                      SYL02F = double.Parse(forcastArr[i].Split('=')[1].Trim());
                      continue;
                  }
                  //			SYL03RP,
                  if (forcastArr[i].Split('=')[0].Trim().Equals("SYL03F"))
                  {
                      SYL03F = double.Parse(forcastArr[i].Split('=')[1].Trim());
                      continue;
                  }
                  if (forcastArr[i].Split('=')[0].Trim().Equals("SYL04F"))
                  {
                      SYL04F = double.Parse(forcastArr[i].Split('=')[1].Trim());
                      continue;
                  }
                  //			SYL04RP, 
                  if (forcastArr[i].Split('=')[0].Trim().Equals("VALFST"))
                  {
                      VALFST = double.Parse(forcastArr[i].Split('=')[1].Trim());
                      continue;
                  }
                  //			SYL05RP,
                  if (forcastArr[i].Split('=')[0].Trim().Equals("SYL05F"))
                  {
                      SYL05F = double.Parse(forcastArr[i].Split('=')[1].Trim());
                      continue;
                  }
                  //			SYL06RP,
                  if (forcastArr[i].Split('=')[0].Trim().Equals("SYL06F"))
                  {
                      SYL06F = double.Parse(forcastArr[i].Split('=')[1].Trim());
                      continue;
                  }
                  //			SYL07RP, 
                  if (forcastArr[i].Split('=')[0].Trim().Equals("SYL07F"))
                  {
                      SYL07F = double.Parse(forcastArr[i].Split('=')[1].Trim());
                      continue;
                  }
                  //			SYL08RP,
                  if (forcastArr[i].Split('=')[0].Trim().Equals("SYL08F"))
                  {
                      SYL08F = double.Parse(forcastArr[i].Split('=')[1].Trim());
                      continue;
                  }
                  //			SYL09RP, 
                  if (forcastArr[i].Split('=')[0].Trim().Equals("SYL09F"))
                  {
                      SYL09F = double.Parse(forcastArr[i].Split('=')[1].Trim());
                      continue;
                  }
                  //			SYL10RP,
                  if (forcastArr[i].Split('=')[0].Trim().Equals("SYL10F"))
                  {
                      SYL10F = double.Parse(forcastArr[i].Split('=')[1].Trim());
                      continue;
                  }
                  //			SYL11RP,
                  if (forcastArr[i].Split('=')[0].Trim().Equals("SYL11F"))
                  {
                      SYL11F = double.Parse(forcastArr[i].Split('=')[1].Trim());
                      continue;
                  }
                  //			SYL12RP,
                  if (forcastArr[i].Split('=')[0].Trim().Equals("SYL12F"))
                  {
                      SYL12F = double.Parse(forcastArr[i].Split('=')[1].Trim());
                      continue;
                  }
                  //			SYL13RP,
                  if (forcastArr[i].Split('=')[0].Trim().Equals("SYL13F"))
                  {
                      SYL13F = double.Parse(forcastArr[i].Split('=')[1].Trim());
                      continue;
                  }
                  //			SYL14RP, 
                  if (forcastArr[i].Split('=')[0].Trim().Equals("SYL14F"))
                  {
                      SYL14F = double.Parse(forcastArr[i].Split('=')[1].Trim());
                      continue;
                  }
                  //			SYL15RP,
                  if (forcastArr[i].Split('=')[0].Trim().Equals("SYL15F"))
                  {
                      SYL15F = double.Parse(forcastArr[i].Split('=')[1].Trim());
                      continue;
                  }
                  //			SYL16RP,
                  if (forcastArr[i].Split('=')[0].Trim().Equals("SYL16F"))
                  {
                      SYL16F = double.Parse(forcastArr[i].Split('=')[1].Trim());
                      continue;
                  }
              }
             

              AllLibDal dal = new AllLibDal();
              DataTable dt1=dal.getByID(JobNum);
              INST1R = double.Parse(dt1.Rows[0]["INST1R"].ToString().Trim());
              INST2I = double.Parse(dt1.Rows[0]["INST2I"].ToString().Trim());
              INST3A = double.Parse(dt1.Rows[0]["INST3A"].ToString().Trim());
              INST4S = double.Parse(dt1.Rows[0]["INST4S"].ToString().Trim());
              INST5E = double.Parse(dt1.Rows[0]["INST5E"].ToString().Trim());
              INST6C = double.Parse(dt1.Rows[0]["INST6C"].ToString().Trim());
              VAL1A = double.Parse(dt1.Rows[0]["VAL1A"].ToString().Trim());
              VAL2I = double.Parse(dt1.Rows[0]["VAL2I"].ToString().Trim());
              VAL3C = double.Parse(dt1.Rows[0]["VAL3C"].ToString().Trim());
              VAL4R = double.Parse(dt1.Rows[0]["VAL4R"].ToString().Trim());
              VAL5S = double.Parse(dt1.Rows[0]["VAL5S"].ToString().Trim());
              VAL6W = double.Parse(dt1.Rows[0]["VAL6W"].ToString().Trim());

              //==========================从职业表中查询出来根据JOBID
            


              

              JobMapBinaryDal jobmap = new JobMapBinaryDal();
              DataTable jobmapdt = jobmap.getByJobId(JobNum);
              //	System.out.println("mmmmmmmmmmmmmmmmmmmmmm="+jobID);
              SYL01B = double.Parse(jobmapdt.Rows[0]["SYL01B"].ToString().Trim());
              SYL02B = double.Parse(jobmapdt.Rows[0]["SYL02B"].ToString().Trim());
              SYL03B = double.Parse(jobmapdt.Rows[0]["SYL03B"].ToString().Trim());
              SYL04B = double.Parse(jobmapdt.Rows[0]["SYL04B"].ToString().Trim());
              SYL05B = double.Parse(jobmapdt.Rows[0]["SYL05B"].ToString().Trim());
              SYL06B = double.Parse(jobmapdt.Rows[0]["SYL06B"].ToString().Trim());
              SYL07B = double.Parse(jobmapdt.Rows[0]["SYL07B"].ToString().Trim());
              SYL08B = double.Parse(jobmapdt.Rows[0]["SYL08B"].ToString().Trim());
              SYL09B = double.Parse(jobmapdt.Rows[0]["SYL09B"].ToString().Trim());
              SYL10B = double.Parse(jobmapdt.Rows[0]["SYL10B"].ToString().Trim());
              SYL11B = double.Parse(jobmapdt.Rows[0]["SYL11B"].ToString().Trim());
              SYL12B = double.Parse(jobmapdt.Rows[0]["SYL12B"].ToString().Trim());
              SYL13B = double.Parse(jobmapdt.Rows[0]["SYL13B"].ToString().Trim());
              SYL14B = double.Parse(jobmapdt.Rows[0]["SYL14B"].ToString().Trim());
              SYL15B = double.Parse(jobmapdt.Rows[0]["SYL15B"].ToString().Trim());
              SYL16B = double.Parse(jobmapdt.Rows[0]["SYL16B"].ToString().Trim());
              SKL01B = double.Parse(jobmapdt.Rows[0]["SKL01B"].ToString().Trim());
              SKL11B = double.Parse(jobmapdt.Rows[0]["SKL11B"].ToString().Trim());
              SKL19B = double.Parse(jobmapdt.Rows[0]["SKL19B"].ToString().Trim());
              SKL21B = double.Parse(jobmapdt.Rows[0]["SKL21B"].ToString().Trim());
              SKL30B = double.Parse(jobmapdt.Rows[0]["SKL30B"].ToString().Trim());
              
              double SKL01_1 = dal.getJobIDList2("SKL01_1", JobNum);
              double SKL11_1 = dal.getJobIDList2("SKL11_1", JobNum);
              double SKL19_1 = dal.getJobIDList2("SKL19_1", JobNum);
              double SKL21_1 = dal.getJobIDList2("SKL21_1", JobNum);
              double SKL30_1 = dal.getJobIDList2("SKL30_1", JobNum);
              double SKL01_2 = dal.getJobIDList2("SKL01_2", JobNum);
              double SKL11_2 = dal.getJobIDList2("SKL11_2", JobNum);
              double SKL19_2 = dal.getJobIDList2("SKL19_2", JobNum);
              double SKL21_2 = dal.getJobIDList2("SKL21_2", JobNum);
              double SKL30_2 = dal.getJobIDList2("SKL30_2", JobNum);
              double SYL01 = dal.getJobIDList2("SYL01", JobNum);
              double SYL02 = dal.getJobIDList2("SYL02", JobNum);
              double SYL03 = dal.getJobIDList2("SYL03", JobNum);
              double SYL04 = dal.getJobIDList2("SYL04", JobNum);
              double SYL05 = dal.getJobIDList2("SYL05", JobNum);
              double SYL06 = dal.getJobIDList2("SYL06", JobNum);
              double SYL07 = dal.getJobIDList2("SYL07", JobNum);
              double SYL08 = dal.getJobIDList2("SYL08", JobNum);
              double SYL09 = dal.getJobIDList2("SYL09", JobNum);
              double SYL10 = dal.getJobIDList2("SYL10", JobNum);
              double SYL11 = dal.getJobIDList2("SYL11", JobNum);
              double SYL12 = dal.getJobIDList2("SYL12", JobNum);
              double SYL13 = dal.getJobIDList2("SYL13", JobNum);
              double SYL14 = dal.getJobIDList2("SYL14", JobNum);
              double SYL15 = dal.getJobIDList2("SYL15", JobNum);
              double SYL16 = dal.getJobIDList2("SYL16", JobNum);

              //	System.out.println("INSTFST="+INSTFST+", INSTSEC="+INSTSEC+", INSTTRD="+INSTTRD+", VALFST="+VALFST+", VALSEC="+VALSEC+", VALTRD="+VALTRD+", SKL01RP="+SKL01RP+", SKL11RP="+SKL11RP+", SKL19RP="+SKL19RP+", SKL21RP="+SKL21RP+", SKL30RP="+SKL30RP+", SYL01RP="+SYL01RP+", SYL02RP="+SYL02RP+", SYL03RP="+SYL03RP+", SYL04RP="+SYL04RP+", SYL05RP="+SYL05RP+", SYL06RP="+SYL06RP+", SYL07RP="+SYL07RP+", SYL08RP="+SYL08RP+", SYL09RP="+SYL09RP+", SYL10RP="+SYL10RP+", SYL11RP="+SYL11RP+", SYL12RP="+SYL12RP+", SYL13RP="+SYL13RP+", SYL14RP="+SYL14RP+", SYL15RP="+SYL15RP+", SYL16RP="+SYL16RP+", INST1R="+INST1R+", INST2I="+INST2I+", INST3A="+INST3A+", INST4S="+INST4S+", INST5E="+INST5E+", INST6C="+INST6C+", VAL1A="+VAL1A+", VAL2I="+VAL2I+", VAL3C="+VAL3C+", VAL4R="+VAL4R+", VAL5S="+VAL5S+", VAL6W="+VAL6W+", SYL01B="+SYL01B+", SYL02B="+SYL02B+", SYL03B="+SYL03B+", SYL04B="+SYL04B+", SYL05B="+SYL05B+", SYL06B="+SYL06B+", SYL07B="+SYL07B+", SYL08B="+SYL08B+", SYL09B="+SYL09B+", SYL10B="+SYL10B+", SYL11B="+SYL11B+", SYL12B="+SYL12B+", SYL13B="+SYL13B+", SYL14B="+SYL14B+", SYL15B="+SYL15B+", SYL16B="+SYL16B+", SKL01B="+SKL01B+", SKL11B="+SKL11B+", SKL19B="+SKL19B+", SKL21B="+SKL21B+", SKL30B="+SKL30B+"");
              string[] list = function.matchFunction(JobNum, INSTFST, INSTSEC, INSTTRD, VALFST, VALSEC, VALTRD,
                      SKL01F, SKL11F, SKL19F, SKL21F, SKL30F, SYL01F,
                      SYL02F, SYL03F, SYL04F, SYL05F, SYL06F, SYL07F,
                      SYL08F, SYL09F, SYL10F, SYL11F, SYL12F, SYL13F,
                      SYL14F, SYL15F, SYL16F,
                      INST1R, INST2I, INST3A,
                      INST4S, INST5E, INST6C, VAL1A, VAL2I, VAL3C, VAL4R, VAL5S, VAL6W, SYL01B, SYL02B, SYL03B, SYL04B, SYL05B, SYL06B, SYL07B, SYL08B, SYL09B, SYL10B, SYL11B, SYL12B, SYL13B, SYL14B, SYL15B, SYL16B, SKL01B, SKL11B, SKL19B, SKL21B,
                      SKL30B,
                       SKL01_1, SKL11_1, SKL19_1, SKL21_1, SKL30_1, SKL01_2, SKL11_2, SKL19_2, SKL21_2, SKL30_2, SYL01, SYL02,
			 SYL03, SYL04, SYL05, SYL06, SYL07, SYL08, SYL09, SYL10, SYL11, SYL12, SYL13, SYL14, SYL15, SYL16);

              string sql = "insert into matchreport(USERID,JOBID,MATCHVALUE1,MATCHVALUE2,MATCHTIME) values (" + userId + "," + JobNum + ",'" + mov(list[0]) + "','" + mov(list[1]) + "',now())";
              new MySQLHelper().ExecuteSql(sql);
              string[] listxx = list;
          }
      }

        /**
         * 去掉字符串中的“{” 和“}”
         * */
      private static string mov(string str)
      {
          return str.Replace('}', ' ').Replace('{', ' ');
      }

      #region


      private string getZYWX(int userID)
      {
         // string sql = "select YS_1 from ichingresult  where RNUMBER='" + userID + "'";
          var sql = "select ds_1 from ichingresult  where RNUMBER='" + userID + "'";
          var dt = new MySQLHelper().GetDataTable(sql);
          string str = null;
          if (dt != null && dt.Rows.Count > 0)
          {
              var xx = dt.Rows[0]["ds_1"].ToString().Trim();
              if (xx.Equals("金"))
              {
                  str = "1";
              }
              else if (xx.Equals("木"))
              {
                  str = "2";
              }
              else if (xx.Equals("水"))
              {
                  str = "3";
              }
              else if (xx.Equals("火"))
              {
                  str = "4";
              }
              else if (xx.Equals("土"))
              {
                  str = "5";
              }
          }
          return str;
      }

      private string getCYWX(int userID)
      {
         // string sql = "select YS_2 from ichingresult  where RNUMBER='" + userID + "'";
          string sql = "select ds_2 from ichingresult  where RNUMBER='" + userID + "'";
          DataTable dt = new MySQLHelper().GetDataTable(sql);
          string str = null;
          if (dt != null && dt.Rows.Count > 0)
          {
              string xx = dt.Rows[0]["ds_2"].ToString().Trim();
              if (xx.Equals("金"))
              {
                  str = "1";
              }
              else if (xx.Equals("木"))
              {
                  str = "2";
              }
              else if (xx.Equals("水"))
              {
                  str = "3";
              }
              else if (xx.Equals("火"))
              {
                  str = "4";
              }
              else if (xx.Equals("土"))
              {
                  str = "5";
              }
          }
          return str;

      }
      private string getRGWX(int userID) {
          string sql = "select RG from ichingresult  where RNUMBER=" + userID + "";
          DataTable dt = new MySQLHelper().GetDataTable(sql);
          string str = null;
          if (dt != null && dt.Rows.Count > 0)
          {
              string xx = dt.Rows[0]["RG"].ToString().Trim();
              if (xx.Equals("甲"))
              {
                  str = "2";
              }
              else if (xx.Equals("乙"))
              {
                  str = "2";
              }
              else if (xx.Equals("丙"))
              {
                  str = "4";
              }
              else if (xx.Equals("丁"))
              {
                  str = "4";
              }
              else if (xx.Equals("戊"))
              {
                  str = "5";
              }
              else if (xx.Equals("己"))
              {
                  str = "5";
              }
              else if (xx.Equals("庚"))
              {
                  str = "1";
              }
              else if (xx.Equals("辛"))
              {
                  str = "1";
              }
              else if (xx.Equals("壬"))
              {
                  str = "3";
              }
              else if (xx.Equals("癸"))
              {
                  str = "3";
              }
          }
          return str;
      }

      private string getForcastValue1(int userId)
      {
          string sql = "select FORECASTREPORTVALUE1 FROM report where USERID=" + userId;
          DataTable dt = new MySQLHelper().GetDataTable(sql);
          return dt.Rows[0]["FORECASTREPORTVALUE1"].ToString();
      }
      private string getTextValue1(int userId)
      {
          string sql = "select TESTREPORTVALUE1 FROM report where USERID=" + userId;
          DataTable dt = new MySQLHelper().GetDataTable(sql);
          return dt.Rows[0]["TESTREPORTVALUE1"].ToString();
      }

      #endregion

    }
}
