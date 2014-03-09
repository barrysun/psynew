using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

using System.Text;

namespace Dal
{
  public   class DesDal
    {
      public string GetDes(int id)
      {
          var sql = "select * from des where ID="+id;
          var dt = new MySQLHelper().GetDataTable(sql);
          return (dt != null && dt.Rows.Count > 0) ? dt.Rows[0]["DES"].ToString() : "";
      }

      public bool Update(Desction des)
      {
          const string sql = "update des set DES=?DES where ID=?ID";
          var param = new MySqlParameter[2];
          param[0] = new MySqlParameter("?DES", MySqlDbType.String) {Value = des.Des};
          param[1] = new MySqlParameter("?ID", MySqlDbType.Int32) {Value = des.Id};
          return 1==new MySQLHelper().ExecuteSql(sql,param);
      }
    }
}
