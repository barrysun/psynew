using cn.cdu.edu.Psychology.iching.functionpk;
using cn.cdu.edu.Psychology.iching.basepk;
using Model;
using System;
using System.Collections.Generic;
using System.Data;

using System.Text;
using System.Web.UI.WebControls;
using Wuqi.Webdiyer;
using MySql.Data.MySqlClient;
using cn.cdu.edu.Psychology.iching.hashmappk;

namespace Dal
{
  public  class IchingResultDal
    {
      public void BindPager(GridView gv, AspNetPager pager, string whereStr)
      {
          string sql = @"
set @mycnt=0; 
select * from (
select *,(@mycnt := @mycnt + 1) as RowNum from ichingresult
)as icresult where RowNum>{0} and RowNum<={1}";
          sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
          pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(ID) from ichingresult"));
          gv.DataSource = new MySQLHelper().GetDataTable(sql);
          gv.DataBind();
      }
      public DataTable getDataTable(string whereStr)
      {
          DataTable dt = new DataTable();
          dt.Columns.Add("序号");
          dt.Columns.Add("用户序号");
          dt.Columns.Add("性别");
          dt.Columns.Add("出生时间");
          dt.Columns.Add("天干");
          dt.Columns.Add("地支");
          dt.Columns.Add("身旺分值");
          dt.Columns.Add("身弱分值");
          dt.Columns.Add("从格");
          dt.Columns.Add("原神1");
          dt.Columns.Add("原神2");
          dt.Columns.Add("原神3");
          dt.Columns.Add("原神1分值");
          dt.Columns.Add("原神2分值");
          dt.Columns.Add("原神3分值");
      
       

          dt.Columns.Add("基准原神");

          dt.Columns.Add("大运方阵1");
          dt.Columns.Add("大运方阵2");
          dt.Columns.Add("大运方阵3");
          dt.Columns.Add("大运方阵4");
          dt.Columns.Add("大运方阵5");
          dt.Columns.Add("大运方阵6");
          dt.Columns.Add("大运方阵7");
          dt.Columns.Add("大运方阵8");

          dt.Columns.Add("大神1");
          dt.Columns.Add("大神2");
          dt.Columns.Add("大神3");

          dt.Columns.Add("大神1分值");
          dt.Columns.Add("大神2分值");
          dt.Columns.Add("大神3分值");

          dt.Columns.Add("第2步原神和");
          dt.Columns.Add("第3步原神和");
          dt.Columns.Add("第4步原神和");
          dt.Columns.Add("第5步原神和");
          dt.Columns.Add("第6步原神和");

          dt.Columns.Add("第2步系数");
          dt.Columns.Add("第3步系数");
          dt.Columns.Add("第4步系数");
          dt.Columns.Add("第5步系数");
          dt.Columns.Add("第6步系数");

          dt.Columns.Add("大运系数");
          dt.Columns.Add("易经字段");
          
         


          

          string sql = "select * from ichingresult ";
          DataTable dt2 = new MySQLHelper().GetDataTable(sql);

          foreach (DataRow dr in dt2.Rows)
          {
              DataRow dr1 = dt.NewRow();
              dr1["序号"] = dr["ID"];
              dr1["用户序号"] = dr["RNUMBER"];
              dr1["性别"] = dr["XB"];
              dr1["出生时间"] = dr["BIRTHDAY"];
              dr1["天干"] = dr["NG"];
              dr1["地支"] = dr["NZ"];
              dr1["身旺分值"] = dr["SWX"];
              dr1["身弱分值"] = dr["SRX"];
              dr1["从格"] = dr["CG"];
              dr1["原神1"] = dr["YS_1"];
              dr1["原神2"] = dr["YS_2"];
              dr1["原神3"] = dr["YS_3"];
              dr1["原神1分值"] = dr["YS_1Score"];
              dr1["原神2分值"] = dr["YS_2Score"];
              dr1["原神3分值"] = dr["YS_3Score"];
              dr1["大运方阵1"] = dr["dyfz_1"];
              dr1["大运方阵2"] = dr["dyfz_2"];
              dr1["大运方阵3"] = dr["dyfz_3"];
              dr1["大运方阵4"] = dr["dyfz_4"];
              dr1["大运方阵5"] = dr["dyfz_5"];
              dr1["大运方阵6"] = dr["dyfz_6"];
              dr1["大运方阵7"] = dr["dyfz_7"];
              dr1["大运方阵8"] = dr["dyfz_8"];
              dr1["大神1"] = dr["ds_1"];
              dr1["大神2"] = dr["ds_2"];
              dr1["大神3"] = dr["ds_3"];
              dr1["大神1分值"] = dr["ds1Score"];
              dr1["大神2分值"] = dr["ds2Score"];
              dr1["大神3分值"] = dr["ds3Score"];
              dr1["第2步原神和"] = dr["step_ys_h_2"];
              dr1["第3步原神和"] = dr["step_ys_h_3"];
              dr1["第4步原神和"] = dr["step_ys_h_4"];
              dr1["第5步原神和"] = dr["step_ys_h_5"];
              dr1["第6步原神和"] = dr["step_ys_h_6"];

              dr1["第2步系数"] = dr["step_ds_h_2"];
              dr1["第3步系数"] = dr["step_ds_h_3"];
              dr1["第4步系数"] = dr["step_ds_h_4"];
              dr1["第5步系数"] = dr["step_ds_h_5"];
              dr1["第6步系数"] = dr["step_ds_h_6"];
              dr1["大运系数"] = dr["dsxs"];
              dr1["易经字段"] = dr["yxzd_1"];
              dr1["基准原神"] = dr["jzys"];
              dt.Rows.Add(dr1);
          
          }


          return dt;
      }

      public int count(int userId)
      { 
         string sql="select count(*) from ichingresult where RNUMBER="+userId;
         return int.Parse(new MySQLHelper().ExecuteValue(sql));
        

      }

      /// <summary>
      /// 易经算法
      /// </summary>
      public void yjsf(int userId)
      {
          int year=0;
          int month=0;
          int day=0;
          int xb=0;
          string datatime="";
          string bornday="";
          DataTable dt = new NUserDal().Query(" where Id="+userId);
          if (dt != null && dt.Rows.Count == 1)
          {
              bornday = dt.Rows[0]["BorthDay"].ToString().Trim();
              string[] bor = bornday.Split('-');
              year = int.Parse(bor[0]);
              month = int.Parse(bor[1]);
              day = int.Parse(bor[2]);
              datatime = dt.Rows[0]["Borthtime"].ToString().Trim();
              xb = int.Parse(dt.Rows[0]["Gender"].ToString()) == 1 ? 1 : -1;
          }

          Ichinglib1 ic1 = new IchingLib1Dal().getNgAndNz(bornday,datatime);
          int NG = ic1.Ng;
          int NZ = ic1.Nz;

          Ichinglib2 ic2 = new IchingLib2Dal().YgAndYz(bornday, datatime);
          double YG=ic2.Yg;
          double YZ=ic2.Yz;
          Ichinglib3 ic3=new IchingLib3Dal().getByDay(year,month);
          int FDG=ic3.Fdg;
          int FDZ=ic3.Fdz;
          double DD=day;
          double ADG=(FDG-1)+(DD%10);
          double ADZ=(FDZ-1)+(DD%12);

          double ADGR=ADG%10;
          double ADZR=ADZ%12;

          double RG,RZ;
          RG=ADGR==0?10:ADGR;
          RZ=ADZR==0?12:ADZR;

          Ichinglib4 ic4=new IchingLib4Dal().getSgSz(datatime,(int)RG+"");
          double SG=ic4.Sg;
          double SZ=ic4.Sz;

          IchingBase b = new IchingBase((int)NG, (int)NZ, (int)YG, (int)YZ, (int)RG, (int)RZ, (int)SG, (int)SZ);
          function f = new function(b);
          f.step_1();
          f.ys1 = f.ys_1;
          f.ys2 = f.ys_2;
          f.ys3 = f.ys_3;
          //
          Ylgl yl1=new Ylgl();
          yl1.Yyear = year;
          yl1.Ymonth = month;
          yl1.Yday = day;
          yl1.Dtime = datatime;

          int yy = NG % 2 == 0 ? -1 : 1;
          Ylgl yl = new YlDal().getByXb(yl1, xb,yy);
          f.func(yl1.Yyear,yl1.Ymonth,yl1.Yday,xb,yl.Yyear,yl.Ymonth,yl.Yday);
          IchingResult icr = new IchingResult();
          icr.Xb = xb;
          icr.Rnumber = userId;
          icr.Birthday = bornday +" "+ datatime+":00";
          icr.Ys_1 = f.ys1;
          icr.Ys_2 = f.ys2;
          icr.Ys_3 = f.ys3;
          icr.Ys_1Score = f.ys1ys.ToString();
          icr.Ys_2Score = f.ys2ys.ToString();
          icr.Ys_3Score = f.ys3ys.ToString();

          icr.ys_h_1 = f.ys1ys.ToString();
          icr.ys_h_2 = f.ys2ys.ToString();
          icr.ys_h_3 = f.ys3ys.ToString();

          icr.Ng = b.mz[0][0];
          icr.Nz = b.mz[1][0];

          icr.Yg = b.mz[0][1];
          icr.Yz = b.mz[1][1];

          icr.Rg = b.mz[0][2];
          icr.Rz = b.mz[1][2];

          icr.Sg = b.mz[0][3];
          icr.Sz = b.mz[1][3];
          //处理
          icr.Ng = b.mz[0][0] + ";" + b.mz[0][1] + ";" + b.mz[0][2] + ";" + b.mz[0][3];
          icr.Nz = b.mz[1][0] + ";" + b.mz[1][1] + ";" + b.mz[1][2] + ";" + b.mz[1][3];



          icr.ds_1 = f.ds1;
          icr.ds_2 = f.ds2;
          icr.ds_3 = f.ds3;


          icr.dsxs = f.dsxp.ToString();//大运系数均值
          icr.jzys = f.jzys.ToString();

          icr.step_ys_h_2 = f.fbys[1].ToString();
          icr.step_ys_h_3 = f.fbys[2].ToString();
          icr.step_ys_h_4 = f.fbys[3].ToString();
          icr.step_ys_h_5 = f.fbys[4].ToString();
          icr.step_ys_h_6 = f.fbys[5].ToString();

          icr.ds1Score = f.ds1sc.ToString();
          icr.ds2Score = f.ds2sc.ToString();
          icr.ds3Score = f.ds3sc.ToString();
          CTGCDZMAP ctg = new CTGCDZMAP();


          //大运方阵
          icr.dyfz_1 = "天干：" + f.dyfzArray[0][0] + "|地支：" + f.dyfzArray[1][0] + "|藏天干："+ctg.ctgmap.get(f.dyfzArray[1][0])+"|"+f.dyfzArray[3][0]+"|"+f.dyfzArray[4][0];
          icr.dyfz_2 = "天干：" + f.dyfzArray[0][1] + "|地支：" + f.dyfzArray[1][1] + "|藏天干：" + ctg.ctgmap.get(f.dyfzArray[1][1]) + "|" + f.dyfzArray[3][1] + "|" + f.dyfzArray[4][1];
          icr.dyfz_3 = "天干：" + f.dyfzArray[0][2] + "|地支：" + f.dyfzArray[1][2] + "|藏天干：" + ctg.ctgmap.get(f.dyfzArray[1][2]) + "|" + f.dyfzArray[3][2] + "|" + f.dyfzArray[4][2];
          icr.dyfz_4 = "天干：" + f.dyfzArray[0][3] + "|地支：" + f.dyfzArray[1][3] + "|藏天干：" + ctg.ctgmap.get(f.dyfzArray[1][3]) + "|" + f.dyfzArray[3][3] + "|" + f.dyfzArray[4][3];
          icr.dyfz_5 = "天干：" + f.dyfzArray[0][4] + "|地支：" + f.dyfzArray[1][4] + "|藏天干：" + ctg.ctgmap.get(f.dyfzArray[1][4]) + "|" + f.dyfzArray[3][4] + "|" + f.dyfzArray[4][4];
          icr.dyfz_6 = "天干：" + f.dyfzArray[0][5] + "|地支：" + f.dyfzArray[1][5] + "|藏天干：" + ctg.ctgmap.get(f.dyfzArray[1][5]) + "|" + f.dyfzArray[3][5] + "|" + f.dyfzArray[4][5];
          icr.dyfz_7 = "天干：" + f.dyfzArray[0][6] + "|地支：" + f.dyfzArray[1][6] + "|藏天干：" + ctg.ctgmap.get(f.dyfzArray[1][6]) + "|" + f.dyfzArray[3][6] + "|" + f.dyfzArray[4][6];
          icr.dyfz_8 = "天干：" + f.dyfzArray[0][7] + "|地支：" + f.dyfzArray[1][7] + "|藏天干：" + ctg.ctgmap.get(f.dyfzArray[1][7]) + "|" + f.dyfzArray[3][7] + "|" + f.dyfzArray[4][7];
          string cg = "";
          double swx = 0.0, srx = 0.0;
          if (f.fz >= 120)
          {
              swx = f.fz;
          }
          else if (f.fz > 0.0 && f.fz < 120)
          {
              srx = f.fz;
          }
          else {
              cg = "从格";
          }
          icr.Cg = cg;
          icr.Swx = swx.ToString();
          icr.Srx = srx.ToString();

          icr.step_ds_h_2 = f.dsx[1].ToString();
          icr.step_ds_h_3 = f.dsx[2].ToString();
          icr.step_ds_h_4 = f.dsx[3].ToString();
          icr.step_ds_h_5 = f.dsx[4].ToString();
          icr.step_ds_h_6 = f.dsx[5].ToString();


          string rgwx = "";
          TGCDZMAP tg = new TGCDZMAP();
          string  rgwxInt=tg.tgmap.get(b.mz[0][2]).ToString().Trim();

          switch (rgwxInt)
          {
              case "金": rgwx = "金命固稳，经风历雨。"; break;
              case "木": rgwx = "木命静谧，润物生发。"; break;
              case "水": rgwx = "水命无形，四通八达。"; break;
              case "火": rgwx = "火命热烈，发散天下。"; break;
              case "土": rgwx = "土命厚重，波澜不惊。"; break;

          }
          rgwx = rgwx + "纵有好命附身，仍需后天努力，知晓大运节点，顺应多变人生。先天信息表明，" + f.mjdes + f.zydes;
          icr.yxzd_1 = rgwx;
          icr.yxzd_3 = f.mjdes;
          icr.yxzd_4 = f.zydes;
          add(icr);
      }

      public void add(IchingResult icr)
      {
          string sql = "insert into ichingresult (RNUMBER,XB,BIRTHDAY,NG,NZ,YG,YZ,RG,RZ,SG,SZ,SWX,SRX,CG,YS_1,YS_2,YS_3,YS_1Score,YS_2Score,YS_3Score,dyfz_1,dyfz_2,dyfz_3,dyfz_4,dyfz_5,dyfz_6,dyfz_7,dyfz_8,ys_h_1,ys_h_2,ys_h_3,ds_1,ds_2,ds_3,step_ys_h_2,step_ys_h_3,step_ys_h_4,step_ys_h_5,step_ys_h_6,dsxs,yxzd_1,yxzd_3,yxzd_4,jzys,ds1Score,ds2Score,ds3Score,step_ds_h_2,step_ds_h_3,step_ds_h_4,step_ds_h_5,step_ds_h_6) values (?RNUMBER,?XB,?BIRTHDAY,?NG,?NZ,?YG,?YZ,?RG,?RZ,?SG,?SZ,?SWX,?SRX,?CG,?YS_1,?YS_2,?YS_3,?YS_1Score,?YS_2Score,?YS_3Score,?dyfz_1,?dyfz_2,?dyfz_3,?dyfz_4,?dyfz_5,?dyfz_6,?dyfz_7,?dyfz_8,?ys_h_1,?ys_h_2,?ys_h_3,?ds_1,?ds_2,?ds_3,?step_ys_h_2,?step_ys_h_3,?step_ys_h_4,?step_ys_h_5,?step_ys_h_6,?dsxs,?yxzd_1,?yxzd_3,?yxzd_4,?jzys,?ds1Score,?ds2Score,?ds3Score,?step_ds_h_2,?step_ds_h_3,?step_ds_h_4,?step_ds_h_5,?step_ds_h_6)";
          MySqlParameter[] param = new MySqlParameter[52];
          param[0] = new MySqlParameter("?RNUMBER", MySqlDbType.Int32);
          param[0].Value = icr.Rnumber;
          param[1] = new MySqlParameter("?XB", MySqlDbType.Int32);
          param[1].Value = icr.Xb;
          param[2] = new MySqlParameter("?BIRTHDAY", MySqlDbType.String);
          param[2].Value = icr.Birthday;
          param[3] = new MySqlParameter("?NG", MySqlDbType.String);
          param[3].Value = icr.Ng;
          param[4] = new MySqlParameter("?NZ", MySqlDbType.String);
          param[4].Value = icr.Nz;
          param[5] = new MySqlParameter("?YG", MySqlDbType.String);
          param[5].Value = icr.Yg;
          param[6] = new MySqlParameter("?YZ", MySqlDbType.String);
          param[6].Value = icr.Yz;
          param[7] = new MySqlParameter("?RG", MySqlDbType.String);
          param[7].Value = icr.Rg;
          param[8] = new MySqlParameter("?RZ", MySqlDbType.String);
          param[8].Value = icr.Rz;
          param[9] = new MySqlParameter("?SG", MySqlDbType.String);
          param[9].Value = icr.Sg;
      
          param[10] = new MySqlParameter("?SZ", MySqlDbType.String);
          param[10].Value = icr.Sz;
          param[11] = new MySqlParameter("?SWX", MySqlDbType.String);
          param[11].Value = icr.Swx;
          param[12] = new MySqlParameter("?SRX", MySqlDbType.String);
          param[12].Value = icr.Srx;
          param[13] = new MySqlParameter("?CG", MySqlDbType.String);
          param[13].Value = icr.Cg;
          param[14] = new MySqlParameter("?YS_1", MySqlDbType.String);
          param[14].Value = icr.Ys_1;
          param[15] = new MySqlParameter("?YS_2", MySqlDbType.String);
          param[15].Value = icr.Ys_2;
          param[16] = new MySqlParameter("?YS_3", MySqlDbType.String);
          param[16].Value = icr.Ys_3;
          param[17] = new MySqlParameter("?YS_1Score", MySqlDbType.String);
          param[17].Value = icr.Ys_1Score;
          param[18] = new MySqlParameter("?YS_2Score", MySqlDbType.String);
          param[18].Value = icr.Ys_2Score;
          param[19] = new MySqlParameter("?YS_3Score", MySqlDbType.String);
          param[19].Value = icr.Ys_3Score;
          param[20] = new MySqlParameter("?dyfz_1", MySqlDbType.String);
          param[20].Value = icr.dyfz_1;
          param[21] = new MySqlParameter("?dyfz_2", MySqlDbType.String);
          param[21].Value=icr.dyfz_2;
          param[22] = new MySqlParameter("?dyfz_3", MySqlDbType.String);
          param[22].Value = icr.dyfz_3;
          param[23] = new MySqlParameter("?dyfz_4", MySqlDbType.String);
          param[23].Value = icr.dyfz_4;
          param[24] = new MySqlParameter("?dyfz_5", MySqlDbType.String);
          param[24].Value = icr.dyfz_5;
          param[25] = new MySqlParameter("?dyfz_6", MySqlDbType.String);
          param[25].Value = icr.dyfz_6;
          param[26] = new MySqlParameter("?dyfz_7", MySqlDbType.String);
          param[26].Value = icr.dyfz_7;
          param[27] = new MySqlParameter("?dyfz_8", MySqlDbType.String);
          param[27].Value = icr.dyfz_8;
          param[28] = new MySqlParameter("?ys_h_1", MySqlDbType.String);
          param[28].Value = icr.ys_h_1;
          param[29] = new MySqlParameter("?ys_h_2", MySqlDbType.String);
          param[29].Value = icr.ys_h_2;
          param[30] = new MySqlParameter("?ys_h_3", MySqlDbType.String);
          param[30].Value = icr.ys_h_3;
          param[31] = new MySqlParameter("?ds_1", MySqlDbType.String);
          param[31].Value = icr.ds_1;

          param[32] = new MySqlParameter("?ds_2", MySqlDbType.String);
          param[32].Value = icr.ds_2;
          param[33] = new MySqlParameter("?ds_3", MySqlDbType.String);
          param[33].Value = icr.ds_3;
          param[34] = new MySqlParameter("?step_ys_h_2", MySqlDbType.String);
          param[34].Value = icr.step_ys_h_2;
          param[35] = new MySqlParameter("?step_ys_h_3", MySqlDbType.String);
          param[35].Value = icr.step_ys_h_3;
          param[36] = new MySqlParameter("?step_ys_h_4", MySqlDbType.String);
          param[36].Value = icr.step_ys_h_4;
          param[37] = new MySqlParameter("?step_ys_h_5", MySqlDbType.String);
          param[37].Value = icr.step_ys_h_5;

          param[38] = new MySqlParameter("?step_ys_h_6", MySqlDbType.String);
          param[38].Value = icr.step_ys_h_6;

          param[39] = new MySqlParameter("?dsxs", MySqlDbType.String);
          param[39].Value = icr.dsxs;
          param[40] = new MySqlParameter("?yxzd_1", MySqlDbType.String);
          param[40].Value = icr.yxzd_1;
          param[41] = new MySqlParameter("?yxzd_3", MySqlDbType.String);
          param[41].Value = icr.yxzd_3;
          param[42] = new MySqlParameter("?yxzd_4", MySqlDbType.String);
          param[42].Value = icr.yxzd_4;

          param[43] = new MySqlParameter("?jzys", MySqlDbType.String);
          param[43].Value = icr.jzys;
          param[44] = new MySqlParameter("?ds1Score", MySqlDbType.String);
          param[44].Value = icr.ds1Score;
          param[45] = new MySqlParameter("?ds2Score", MySqlDbType.String);
          param[45].Value = icr.ds2Score;
          param[46] = new MySqlParameter("?ds3Score", MySqlDbType.String);
          param[46].Value = icr.ds3Score;

          param[47] = new MySqlParameter("step_ds_h_2", MySqlDbType.String);
          param[47].Value = icr.step_ds_h_2;
          param[48] = new MySqlParameter("step_ds_h_3", MySqlDbType.String);
          param[48].Value = icr.step_ds_h_3;
          param[49] = new MySqlParameter("step_ds_h_4", MySqlDbType.String);
          param[49].Value = icr.step_ds_h_4;
          param[50] = new MySqlParameter("step_ds_h_5", MySqlDbType.String);
          param[50].Value = icr.step_ds_h_5;
          param[51] = new MySqlParameter("step_ds_h_6", MySqlDbType.String);
          param[51].Value = icr.step_ds_h_6;

          new MySQLHelper().ExecuteSql(sql, param);
      }

      public void exesql(string sql)
      {
          new MySQLHelper().ExecuteSql(sql);
      }
      public void Test()
      {
          yjsf(52);
          //for (int i = 373; i < 396; i++)
          //{
          //    yjsf(i);
          //}

        //  yjsf(378);
        //  yjsf(384);
         // yjsf(379);

          //string datatime = "23:30";
          //string bornday = "1948-12-17";
          //int year = 1948;
          //int month = 12;
          //int day = 17;
          //int xb = 1;
          //// IchingBase b = new IchingBase((int)NG, (int)NZ, (int)YG, (int)YZ, (int)RG, (int)RZ, (int)SG, (int)SZ);
          //IchingBase b = new IchingBase();
          //b.mz[0][0] = "戊";
          //b.mz[1][0] = "子";

          //b.mz[0][1] = "甲";
          //b.mz[1][1] = "子";

          //b.mz[0][2] = "丙";
          //b.mz[1][2] = "子";

          //b.mz[0][3] = "戊";
          //b.mz[1][3] = "子";


          //int userId = 1313;

          //================================

          //string datatime = "14:00";
          //string bornday = "1948-1-6";
          //int year = 1948;
          //int month = 1;
          //int day = 6;
          //int xb = 1;
          //// IchingBase b = new IchingBase((int)NG, (int)NZ, (int)YG, (int)YZ, (int)RG, (int)RZ, (int)SG, (int)SZ);
          //IchingBase b = new IchingBase();
          //b.mz[0][0] = "丁";
          //b.mz[1][0] = "亥";

          //b.mz[0][1] = "壬";
          //b.mz[1][1] = "子";

          //b.mz[0][2] = "庚";
          //b.mz[1][2] = "寅";

          //b.mz[0][3] = "癸";
          //b.mz[1][3] = "未";


          //int userId = 1314;


          //string datatime = "22:00";
          //string bornday = "1948-1-6";
          //int year = 1948;
          //int month = 1;
          //int day = 6;
          //int xb = -1;
          //IchingBase b = new IchingBase((int)NG, (int)NZ, (int)YG, (int)YZ, (int)RG, (int)RZ, (int)SG, (int)SZ);
          //IchingBase b = new IchingBase();
          //b.mz[0][0] = "丁";
          //b.mz[1][0] = "亥";

          //b.mz[0][1] = "癸";
          //b.mz[1][1] = "丑";

          //b.mz[0][2] = "庚";
          //b.mz[1][2] = "寅";

          //b.mz[0][3] = "丁";
          //b.mz[1][3] = "亥";


          //int userId = 1315;
          //string datatime = "12:00";
          //string bornday = "1971-8-6";
          //int year = 1971;
          //int month = 8;
          //int day = 6;
          //int xb = -1;
          //// IchingBase b = new IchingBase((int)NG, (int)NZ, (int)YG, (int)YZ, (int)RG, (int)RZ, (int)SG, (int)SZ);
          //IchingBase b = new IchingBase();
          //b.mz[0][0] = "辛";
          //b.mz[1][0] = "亥";

          //b.mz[0][1] = "乙";
          //b.mz[1][1] = "未";

          //b.mz[0][2] = "癸";
          //b.mz[1][2] = "亥";

          //b.mz[0][3] = "戊";
          //b.mz[1][3] = "午";


          //int userId = 1310;
//====================================

          //string datatime = "17:30";
          //string bornday = "1950-9-13";
          //int year = 1950;
          //int month = 9;
          //int day = 13;
          //int xb = 1;
          //// IchingBase b = new IchingBase((int)NG, (int)NZ, (int)YG, (int)YZ, (int)RG, (int)RZ, (int)SG, (int)SZ);
          //IchingBase b = new IchingBase();
          //b.mz[0][0] = "庚";
          //b.mz[1][0] = "寅";

          //b.mz[0][1] = "乙";
          //b.mz[1][1] = "酉";

          //b.mz[0][2] = "辛";
          //b.mz[1][2] = "亥";

          //b.mz[0][3] = "丁";
          //b.mz[1][3] = "酉";


          //int userId = 1311;
          //////====================================

          //function f = new function(b);
          //f.step_1();
          //f.ys1 = f.ys_1;
          //f.ys2 = f.ys_2;
          //f.ys3 = f.ys_3;
          ////
          //Ylgl yl1 = new Ylgl();
          //yl1.Yyear = year;
          //yl1.Ymonth = month;
          //yl1.Yday = day;
          //yl1.Dtime = datatime;
          //Ylgl yl = new YlDal().getByXb(yl1, xb);
          //f.func(yl1.Yyear, yl1.Ymonth, yl1.Yday, xb, yl.Yyear, yl.Ymonth, yl.Yday);

          //IchingResult icr = new IchingResult();
          //icr.Xb = xb;
          //icr.Rnumber = userId;
          //icr.Birthday = bornday + " " + datatime + ":00";
          //icr.Ys_1 = f.ys1;
          //icr.Ys_2 = f.ys2;
          //icr.Ys_3 = f.ys3;
          //icr.Ys_1Score = f.ys1ys.ToString();
          //icr.Ys_2Score = f.ys2ys.ToString();
          //icr.Ys_3Score = f.ys3ys.ToString();

          //icr.ys_h_1 = f.ys1ys.ToString();
          //icr.ys_h_2 = f.ys2ys.ToString();
          //icr.ys_h_3 = f.ys3ys.ToString();

          //icr.Ng = b.mz[0][0];
          //icr.Nz = b.mz[1][0];

          //icr.Yg = b.mz[0][1];
          //icr.Yz = b.mz[1][1];

          //icr.Rg = b.mz[0][2];
          //icr.Rz = b.mz[1][2];

          //icr.Sg = b.mz[0][3];
          //icr.Sz = b.mz[1][3];
          ////处理
          //icr.Ng = b.mz[0][0] + ";" + b.mz[0][1] + ";" + b.mz[0][2] + ";" + b.mz[0][3];
          //icr.Nz = b.mz[1][0] + ";" + b.mz[1][1] + ";" + b.mz[1][2] + ";" + b.mz[1][3];



          //icr.ds_1 = f.ds1;
          //icr.ds_2 = f.ds2;
          //icr.ds_3 = f.ds3;


          //icr.dsxs = f.dsxp.ToString();//大运系数均值
          //icr.jzys = f.jzys.ToString();

          //icr.step_ys_h_2 = f.fbys[1].ToString();
          //icr.step_ys_h_3 = f.fbys[2].ToString();
          //icr.step_ys_h_4 = f.fbys[3].ToString();
          //icr.step_ys_h_5 = f.fbys[4].ToString();
          //icr.step_ys_h_6 = f.fbys[5].ToString();

          //icr.ds1Score = f.ds1sc.ToString();
          //icr.ds2Score = f.ds2sc.ToString();
          //icr.ds3Score = f.ds3sc.ToString();
          //CTGCDZMAP ctg = new CTGCDZMAP();


          ////大运方阵
          //icr.dyfz_1 = "天干：" + f.dyfzArray[0][0] + "|地支：" + f.dyfzArray[1][0] + "|藏天干：" + ctg.ctgmap.get(f.dyfzArray[1][0]) + "|" + f.dyfzArray[3][0] + "|" + f.dyfzArray[4][0];
          //icr.dyfz_2 = "天干：" + f.dyfzArray[0][1] + "|地支：" + f.dyfzArray[1][1] + "|藏天干：" + ctg.ctgmap.get(f.dyfzArray[1][1]) + "|" + f.dyfzArray[3][1] + "|" + f.dyfzArray[4][1];
          //icr.dyfz_3 = "天干：" + f.dyfzArray[0][2] + "|地支：" + f.dyfzArray[1][2] + "|藏天干：" + ctg.ctgmap.get(f.dyfzArray[1][2]) + "|" + f.dyfzArray[3][2] + "|" + f.dyfzArray[4][2];
          //icr.dyfz_4 = "天干：" + f.dyfzArray[0][3] + "|地支：" + f.dyfzArray[1][3] + "|藏天干：" + ctg.ctgmap.get(f.dyfzArray[1][3]) + "|" + f.dyfzArray[3][3] + "|" + f.dyfzArray[4][3];
          //icr.dyfz_5 = "天干：" + f.dyfzArray[0][4] + "|地支：" + f.dyfzArray[1][4] + "|藏天干：" + ctg.ctgmap.get(f.dyfzArray[1][4]) + "|" + f.dyfzArray[3][4] + "|" + f.dyfzArray[4][4];
          //icr.dyfz_6 = "天干：" + f.dyfzArray[0][5] + "|地支：" + f.dyfzArray[1][5] + "|藏天干：" + ctg.ctgmap.get(f.dyfzArray[1][5]) + "|" + f.dyfzArray[3][5] + "|" + f.dyfzArray[4][5];
          //icr.dyfz_7 = "天干：" + f.dyfzArray[0][6] + "|地支：" + f.dyfzArray[1][6] + "|藏天干：" + ctg.ctgmap.get(f.dyfzArray[1][6]) + "|" + f.dyfzArray[3][6] + "|" + f.dyfzArray[4][6];
          //icr.dyfz_8 = "天干：" + f.dyfzArray[0][7] + "|地支：" + f.dyfzArray[1][7] + "|藏天干：" + ctg.ctgmap.get(f.dyfzArray[1][7]) + "|" + f.dyfzArray[3][7] + "|" + f.dyfzArray[4][7];
          //string cg = "";
          //double swx = 0.0, srx = 0.0;
          //if (f.fz >= 120)
          //{
          //    swx = f.fz;
          //}
          //else if (f.fz > 0.0 && f.fz < 120)
          //{
          //    srx = f.fz;
          //}
          //else
          //{
          //    cg = "从格";
          //}
          //icr.Cg = cg;
          //icr.Swx = swx.ToString();
          //icr.Srx = srx.ToString();

          //icr.step_ds_h_2 = f.dsx[1].ToString();
          //icr.step_ds_h_3 = f.dsx[2].ToString();
          //icr.step_ds_h_4 = f.dsx[3].ToString();
          //icr.step_ds_h_5 = f.dsx[4].ToString();
          //icr.step_ds_h_6 = f.dsx[5].ToString();


          //string rgwx = "";
          //TGCDZMAP tg = new TGCDZMAP();
          //string rgwxInt = tg.tgmap.get(b.mz[0][2]).ToString().Trim();

          //switch (rgwxInt)
          //{
          //    case "金": rgwx = "金命固稳，经风历雨。"; break;
          //    case "木": rgwx = "木命静谧，润物生发。"; break;
          //    case "水": rgwx = "水命无形，四通八达。"; break;
          //    case "火": rgwx = "火命热烈，发散天下。"; break;
          //    case "土": rgwx = "土命厚重，波澜不惊。"; break;

          //}
          //rgwx = rgwx + "纵有好命附身，仍需后天努力，知晓大运节点，顺应多变人生。先天信息表明，" + f.mjdes + f.zydes;
          //icr.yxzd_1 = rgwx;
          //icr.yxzd_3 = f.mjdes;
          //icr.yxzd_4 = f.zydes;
          //add(icr);

        
      }
  }
}
