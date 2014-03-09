using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

using System.Text;

namespace Dal
{
   public  class ServiceDesDal
    {
       public DataTable getDataTable()
       {
           return new MySQLHelper().GetDataTable("select ID,Title,Des,InUrl,servicedes.Order from servicedes");
       }

       public bool Update(ServiceDes ser)
       {
           return 1==new MySQLHelper().ExecuteSql(
               "update servicedes set Title=?Title,Des=?Des,InUrl=?InUrl where ID=?ID",
               new []
               {
                   new MySqlParameter("?ID", MySqlDbType.Int32) {Value = ser.Id},
                   new MySqlParameter("?Title", MySqlDbType.String) {Value = ser.Title},
                   new MySqlParameter("?Des", MySqlDbType.String) {Value = ser.Des},
                   new MySqlParameter("?InUrl", MySqlDbType.String) {Value = ser.InUrl}
               }); 
       }
       public DataTable getById(int id)
       {
           return new MySQLHelper().GetDataTable(
               "select ID,Title,Des,InUrl,servicedes.Order from servicedes where ID=?ID", 
               new []
               {
                   new MySqlParameter("?ID", MySqlDbType.Int32) {Value = id}
               });
       }

       public DataTable getListTopX()
       {
           return new MySQLHelper().GetDataTable("select ID,Title,Des,InUrl,servicedes.Order from servicedes order by servicedes.Order");
       }

       public void Test()
       {
           DataTable dt = getById(0);
           int i = dt.Rows.Count;
       }
    }
}
