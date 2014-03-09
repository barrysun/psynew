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
  public   class NUserDal
    {
      public void BindPager(GridView gv, AspNetPager pager, string whereStr)
      {
          const string str = "Enabled = \"false\"";
          const string str1 = "Enabled = \"true\"";
          var sql = @"
set @mycnt=0; 
select * from (
select *,(case when Isiching=1 then '" + str + "' else '" + str1 + @"' end ) as IchEn,(case when IsTest=1 then '" + str + "' else '" + str1 + @"' end ) as ItstEn,(case when IsFor=1 then '" + str + "' else '" + str1 + @"' end ) as IMacEn,(@mycnt := @mycnt + 1) as RowNum from nuser "+whereStr+@" order by Id DESC
)as u where RowNum>{0} and RowNum<={1}";
          sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
          pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(Id) from nuser "+whereStr));
          gv.DataSource = new MySQLHelper().GetDataTable(sql);
          gv.DataBind();
      }

      public bool Register(NUser user)
      {
          return 1==new MySQLHelper().ExecuteSql(
              "insert into nuser (LoginName,Password) values(?LoginName,?Password)", 
              new []
              {
                  new MySqlParameter("?LoginName", MySqlDbType.String) {Value = user.LoginName},
                  new MySqlParameter("?Password", MySqlDbType.String) {Value = user.Password}
              });
      }

      public bool UpdateUserXTXX(NUser user)
      {
          return 1 == new MySQLHelper().ExecuteSql(
              @"update  nuser set RealName=?RealName,Gender=?Gender,BorthDay=?BorthDay,Borthtime=?Borthtime
          where Id=?Id ",
              new []
              {
                 new MySqlParameter("?RealName", MySqlDbType.String) {Value = user.RealName},
                 new MySqlParameter("?Gender", MySqlDbType.Int32) {Value = user.Gender},
                 new MySqlParameter("?BorthDay", MySqlDbType.String) {Value = user.BorthDay},
                 new MySqlParameter("?Borthtime", MySqlDbType.String) {Value = user.Borthtime},
                 new MySqlParameter("?Id", MySqlDbType.String) {Value = user.Id}
              });
      }


      public bool UpdateUserInfo(NUser user)
      {
          return 1 == new MySQLHelper().ExecuteSql(
              @"update  nuser set RealName=?RealName,Gender=?Gender,BorthDay=?BorthDay,Borthtime=?Borthtime,
         Dizhi=?Dizhi,Huiji=?Huiji,HunYin=?HunYin,Hight=?Hight,Father=?Father,
          FatherPhone=?FatherPhone,Phone=?Phone,Email=?Email,Qq=?Qq,Boke=?Boke,UserNumber=?userNumber where Id=?Id", 
                new []
                {
                    new MySqlParameter("?RealName", MySqlDbType.String) {Value = user.RealName},
                    new MySqlParameter("?Gender", MySqlDbType.Int32) {Value = user.Gender},
                    new MySqlParameter("?BorthDay", MySqlDbType.String) {Value = user.BorthDay},
                    new MySqlParameter("?Borthtime", MySqlDbType.String) {Value = user.Borthtime},
                    new MySqlParameter("?Dizhi", MySqlDbType.String) {Value = user.Dizhi},
                    new MySqlParameter("?Huiji", MySqlDbType.String) {Value = user.Huiji},
                    new MySqlParameter("?HunYin", MySqlDbType.String) {Value = user.HunYin},
                    new MySqlParameter("?Hight", MySqlDbType.String) {Value = user.Hight},
                    new MySqlParameter("?Father", MySqlDbType.String) {Value = user.Father},
                    new MySqlParameter("?FatherPhone", MySqlDbType.String) {Value = user.FatherPhone},
                    new MySqlParameter("?Phone", MySqlDbType.String) {Value = user.Phone},
                    new MySqlParameter("?Email", MySqlDbType.String) {Value = user.Email},
                    new MySqlParameter("?Qq", MySqlDbType.String) {Value = user.Qq},
                    new MySqlParameter("?Boke", MySqlDbType.String) {Value = user.Boke},
                    new MySqlParameter("?userNumber", MySqlDbType.String) {Value = user.UserNumber},
                    new MySqlParameter("?Id", MySqlDbType.String) {Value = user.Id}
                });
      }

      public bool UpdateUserInfo1(NUser user)
      {
          return 1 == new MySQLHelper().ExecuteSql(
              @"update nuser set Muqian=?Muqian,Gread=?Gread,Class=?Class,Gaozhongbiye=?Gaozhongbiye,Sort=?Sort,Sort2=?Sort2,
Aoshai=?Aoshai,Yishu=?Yishu,Tiyu=?Tiyu,Qita=?Qita,IsZhongdian=?IsZhongdian
where Id=?Id", 
         new []
         {
           new MySqlParameter("?Muqian", MySqlDbType.String) {Value = user.Muqian},
           new MySqlParameter("?Gread", MySqlDbType.String) {Value = user.Gread},
           new MySqlParameter("?Class", MySqlDbType.String) {Value = user.Class},
           new MySqlParameter("?Gaozhongbiye", MySqlDbType.String) {Value = user.Gaozhongbiye},
           new MySqlParameter("?Sort", MySqlDbType.String) {Value = user.Sort},
           new MySqlParameter("?Sort2", MySqlDbType.String) {Value = user.Sort2},
           new MySqlParameter("?Aoshai", MySqlDbType.String) {Value = user.Aoshai},
           new MySqlParameter("?Yishu", MySqlDbType.String) {Value = user.Yishu},
           new MySqlParameter("?Tiyu", MySqlDbType.String) {Value = user.Tiyu},
           new MySqlParameter("?Qita", MySqlDbType.String) {Value = user.Qita},
           new MySqlParameter("?IsZhongdian", MySqlDbType.String) {Value = user.IsZhongdian},
           new MySqlParameter("?Id", MySqlDbType.Int32) {Value = user.Id}
         });
      }

      public bool UpdateUserInfo2(NUser user)
      {
          return 1==new MySQLHelper().ExecuteSql(
              "update nuser set Danwei=?Danwei,Zhiwu=?Zhiwu,Xinzi=?Xinzi,Zuogongzuo=?Zuogongzuo,GongZuo=?GongZuo where Id=?Id",
              new []
              {
                  new MySqlParameter("?Danwei", MySqlDbType.String) {Value = user.Danwei},
                  new MySqlParameter("?Zhiwu", MySqlDbType.String) {Value = user.Zhiwu},
                  new MySqlParameter("?Xinzi", MySqlDbType.String) {Value = user.Xinzi},
                  new MySqlParameter("?Zuogongzuo", MySqlDbType.String) {Value = user.Zuogongzuo},
                  new MySqlParameter("?GongZuo", MySqlDbType.String) {Value = user.GongZuo},
                  new MySqlParameter("?Id", MySqlDbType.Int32) {Value = user.Id}
              });
      }

      public DataTable Login(string LoginName,string Password)
      {
          return new MySQLHelper().GetDataTable(
              "select * from nuser where LoginName=?LoginName And Password=?Password",
              new []
              {
                  new MySqlParameter("?LoginName", MySqlDbType.String) {Value = LoginName},
                  new MySqlParameter("?Password", MySqlDbType.String) {Value = Password}
              }); ;
      }

      public bool UpdatePassword(NUser user)
      {
          return 1 == new MySQLHelper().ExecuteSql(
              "update nuser set Password=?Password where Id=?Id", 
              new []
              {
                  new MySqlParameter("?Password", MySqlDbType.String) {Value = user.Password},
                  new MySqlParameter("?Id", MySqlDbType.Int32) {Value = user.Id}
              });
      }

      public bool UpdateUserInfo3(NUser user)
      {
          return 1 == new MySQLHelper().ExecuteSql(
              "update nuser set ShuKan=?ShuKan,XiangMu=?XiangMu,YongYu=?YongYu,Peixun=?Peixun where Id=?Id", 
              new []
              {
                  new MySqlParameter("?ShuKan", MySqlDbType.String) {Value = user.ShuKan},
                  new MySqlParameter("?XiangMu", MySqlDbType.String) {Value = user.XiangMu},
                  new MySqlParameter("?YongYu", MySqlDbType.String) {Value = user.YongYu},
                  new MySqlParameter("?Peixun", MySqlDbType.String) {Value = user.Peixun},
                  new MySqlParameter("?Id", MySqlDbType.Int32) {Value = user.Id}
              });
      }

      public DataTable Query(string whereStr)
      {
          return new MySQLHelper().GetDataTable("select * from nuser " + whereStr);
      }

      public bool IsHas(string LoginName)
      {
          int userCount = 0;
          MySqlParameter[] param = new MySqlParameter[1];
          param[0] = new MySqlParameter("?LoginName", MySqlDbType.String);
          param[0].Value = LoginName;
          userCount = int.Parse(new MySQLHelper().ExecuteValue("select count(*) from nuser where LoginName=?LoginName",param));
          userCount += int.Parse(new MySQLHelper().ExecuteValue("select count(*) from company where LoginName=?LoginName", param));
          if (userCount > 0)
              return false;
          return true;
      }

    
  
  }
}
