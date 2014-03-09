using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

using System.Text;

namespace Dal
{
   public  class CompanyDal
    {

       public bool Register(Company company)
       {
           const string sql = "insert into company (LoginName,Password) Values (?LoginName,?Password)";
           var param = new MySqlParameter[2];
           param[0] = new MySqlParameter("?LoginName", MySqlDbType.String) {Value = company.LoginName};
           param[1] = new MySqlParameter("?Password", MySqlDbType.String) {Value = company.Password};
           return 1 == new MySQLHelper().ExecuteSql(sql, param);
       }

       public bool UpdatePassword(Company company)
       {
           const string sql = "update company set Password=?Password where Id=?Id";
           var param = new MySqlParameter[2];
           param[0] = new MySqlParameter("?Id", MySqlDbType.Int32) {Value = company.Id};
           param[1] = new MySqlParameter("?Password", MySqlDbType.String) {Value = company.Password};
           return 1 == new MySQLHelper().ExecuteSql(sql, param);
       }

       public DataTable Login(string loginName, string Password)
       {
           var param = new MySqlParameter[2];
           param[0] = new MySqlParameter("?LoginName", MySqlDbType.String) {Value = loginName};
           param[1] = new MySqlParameter("?Password", MySqlDbType.String) {Value = Password};
           const  string sql = "select * from company where Password=?Password And LoginName=?LoginName";

           return new MySQLHelper().GetDataTable(sql,param);
       }

       public bool UpdateFirmInfo(Company company)
       {
          const string sql = @"update company set GongName=?GongName,QiyeXinzhi=?QiyeXinzhi,SuoshuHangye=?SuoshuHangye,Guimo=?Guimo,Zhucezijin=?Zhucezijin,
LianxiRen=?LianxiRen,qq=?qq,Phone=?Phone,Email=?Email,GongSiWww=?GongSiWww,Des=?Des where Id=?Id";
           var param = new MySqlParameter[12];
           param[0] = new MySqlParameter("?GongName", MySqlDbType.String) {Value = company.GongName};
           param[1] = new MySqlParameter("?QiyeXinzhi", MySqlDbType.String) {Value = company.QiyeXinzhi};
           param[2] = new MySqlParameter("?SuoshuHangye", MySqlDbType.String) {Value = company.SuoshuHangye};
           param[3] = new MySqlParameter("?Guimo", MySqlDbType.String) {Value = company.Guimo};
           param[4] = new MySqlParameter("?Zhucezijin", MySqlDbType.String) {Value = company.Zhucezijin};
           param[5] = new MySqlParameter("?LianxiRen", MySqlDbType.String) {Value = company.LianxiRen};
           param[6] = new MySqlParameter("?qq", MySqlDbType.String) {Value = company.qq};
           param[7] = new MySqlParameter("?Phone", MySqlDbType.String) {Value = company.Phone};
           param[8] = new MySqlParameter("?Email", MySqlDbType.String) {Value = company.Email};
           param[9] = new MySqlParameter("?GongSiWww", MySqlDbType.String) {Value = company.GongSiWww};
           param[10] = new MySqlParameter("?Des", MySqlDbType.String) {Value = company.Des};
           param[11] = new MySqlParameter("?Id", MySqlDbType.Int32) {Value = company.Id};
           return 1 == new MySQLHelper().ExecuteSql(sql, param);
       }


       public DataTable Query(int id)
       {
           return new MySQLHelper().GetDataTable("select * from company where Id=" + id);
       }
   
   }
}
