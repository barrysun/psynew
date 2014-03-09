using System;
using System.Collections.Generic;

using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

namespace Dal
{
   public  class MySQLHelper
    {
       public MySqlConnection Con()
       {
           // MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
           // var con = new MySqlConnection("Database='mingzhijy';Data Source='localhost';User Id='root';Password='sun123';charset='utf8';pooling=true;Allow User Variables=True");
             MySqlConnection con = new MySqlConnection("Database='mingzhijy';Data Source='localhost';User Id='mingzhijy';Password='r2u3r3w';charset='utf8';pooling=true;Allow User Variables=True");
           return con;
       }

       /// <summary>
       /// 执行无返回值的sql语句，如果成功返回 1 ，否则失败 
       /// </summary>
       /// <param name="sql">带集聚函数SQl语句</param>
       /// <returns>返回-1失败</returns> 
       public int ExecuteSql(string sql)
       {
           MySqlConnection con = Con();
           MySqlCommand com = new MySqlCommand(sql, con);

           try
           {
               con.Open();
               com.ExecuteNonQuery();
               return 1;
           }
           catch (SqlException e)
           {
               throw new Exception(e.Message);
           }
           finally
           {
               com.Dispose();//释放资源
               con.Close();
           }
       }

       /// <summary>
       /// 执行无返回值的sql语句，如果成功返回 1，否则失败 ，带参数
       /// </summary>
       /// <param name="sql">带集聚函数SQl语句</param>
       /// <returns>返回-1失败</returns> 
       public int ExecuteSql(string sql, MySqlParameter[] p)
       {
           MySqlConnection con = Con();

           MySqlCommand com = new MySqlCommand(sql, con);
           for (int i = 0; i < p.Length; i++)
           {
               if (p[i].Value == null)
               {
                   p[i].Value = "";
               }
               com.Parameters.Add(p[i]);
           }

           try
           {
               con.Open();
               com.ExecuteNonQuery();
               return 1;
           }
           catch (SqlException e)
           {
               throw new Exception(e.Message);
           }
           finally
           {
               com.Parameters.Clear();
               com.Dispose();//释放资源
               con.Close();
           }

       }

       /// <summary>
       /// 执行多条无返回值的sql语句，如果成功返回 1，否则失败 
       /// </summary>
       /// <param name="sql">带集聚函数SQl语句</param>
       /// <returns>返回1成功</returns> 
       public int ExecuteSqls(string[] sql)
       {
           MySqlConnection con = Con();

           MySqlCommand com = new MySqlCommand();
           int i = sql.Length;
           con.Open();
           MySqlTransaction tran = con.BeginTransaction();
           try
           {
               com.Connection = con;
               com.Transaction = tran;
               foreach (string str in sql)
               {
                   com.CommandText = str;
                   com.ExecuteNonQuery();
               }
               tran.Commit();
               return 1;
           }
           catch (SqlException e)
           {
               tran.Rollback();
               throw new Exception(e.Message);
           }
           finally
           {
               com.Dispose();
               con.Close();
           }
       }

       /// <summary>
       /// 执行多条无返回值的sql语句，如果成功返回 影响条数，否则失败返回-1，带参数
       /// </summary>
       /// <param name="sql">带集聚函数SQl语句</param>
       /// <returns>返回-1失败</returns> 
       public int ExecuteSqls(string[] sql, SqlParameter[] p)
       {
           MySqlConnection con = Con();

           MySqlCommand com = new MySqlCommand();
           int i = sql.Length;
           int j = p.Length;
           for (int k = 0; k < j; k++)
           {
               com.Parameters.Add(p[k]);
           }
           con.Open();
           MySqlTransaction tran = con.BeginTransaction();
           try
           {
               com.Connection = con;
               com.Transaction = tran;
               foreach (string str in sql)
               {
                   com.CommandText = str;
                   com.ExecuteNonQuery();

               }
               tran.Commit();
               return 1;
           }
           catch (SqlException e)
           {
               tran.Rollback();
               throw new Exception(e.Message);
           }
           finally
           {
               com.Parameters.Clear();
               com.Dispose();
               con.Close();
           }
       }

       /// <summary>
       /// 执行无返回值的 存储过程，如果成功返回 影响条数，否则失败返回-1
       /// </summary>
       /// <param name="sql">带集聚函数SQl语句</param>
       /// <returns>返回-1失败</returns> 
       public int ExecuteProc(string proc)
       {
           MySqlConnection con = Con();
           MySqlCommand com = new MySqlCommand(proc, con);

           com.CommandType = CommandType.StoredProcedure;

           try
           {
               con.Open();
               com.ExecuteNonQuery();
               return 1;
           }
           catch (Exception ex)
           {
               throw ex;
           }
           finally
           {
               con.Close();
           }
       }
       /// <summary>
       /// 执行无返回值的 存储过程，如果成功返回 影响条数，否则失败返回-1，带参数
       /// </summary>
       /// <param name="sql">带集聚函数SQl语句</param>
       /// <returns>返回-1失败</returns> 
       public int ExecuteProc(string proc, SqlParameter[] p)
       {
           MySqlConnection con = Con();
           MySqlCommand com = new MySqlCommand(proc, con);
           com.CommandType = CommandType.StoredProcedure;
           for (int i = 0; i < p.Length; i++)
           {
               com.Parameters.Add(p[i]);
           }

           try
           {
               con.Open();
               com.ExecuteNonQuery();
               return 1;
           }
           catch (Exception ex)
           {
               throw ex;
           }
           finally
           {
               con.Close();
               com.Parameters.Clear();
               com.Dispose();//释放资源
           }
       }

       /// <summary>
       /// 执行多条无返回值的存储过程，如果成功返回 1，否则失败 
       /// </summary>
       /// <param name="sql">不带参数存储过程组</param>
       /// <returns>返回1成功</returns> 
       public int ExecuteProces(string[] procs)
       {
           MySqlConnection con = Con();

           MySqlCommand com = new MySqlCommand();
           int i = procs.Length;
           con.Open();
           MySqlTransaction tran = con.BeginTransaction();
           try
           {
               com.Connection = con;
               com.Transaction = tran;
               foreach (string str in procs)
               {
                   com.CommandType = CommandType.StoredProcedure;
                   com.CommandText = str;
                   com.ExecuteNonQuery();
               }
               tran.Commit();
               return 1;
           }
           catch (SqlException e)
           {
               tran.Rollback();
               throw new Exception(e.Message);
           }
           finally
           {
               com.Dispose();
               con.Close();
           }
       }

       /// <summary>   
       /// 执行多条无返回值的sql语句，如果成功返回 影响条数，否则失败返回-1，带参数
       /// </summary>
       /// <param name="sql">带集聚函数SQl语句</param>
       /// <returns>返回-1失败</returns> 
       public int ExecuteProces(string[] procs, SqlParameter[] p)
       {
           MySqlConnection con = Con();

           MySqlCommand com = new MySqlCommand();
           int i = procs.Length;
           int j = p.Length;
           for (int k = 0; k < j; k++)
           {
               com.Parameters.Add(p[k]);
           }
           con.Open();
           MySqlTransaction tran = con.BeginTransaction();
           try
           {
               com.Connection = con;
               com.Transaction = tran;
               foreach (string str in procs)
               {
                   com.CommandType = CommandType.StoredProcedure;
                   com.CommandText = str;
                   com.ExecuteNonQuery();

               }
               tran.Commit();
               return 1;
           }
           catch (SqlException e)
           {
               tran.Rollback();
               throw new Exception(e.Message);
           }
           finally
           {
               com.Parameters.Clear();
               com.Dispose();
               con.Close();
           }
       }

       /// <summary>
       /// 无参数利用SQL语句获得数据表
       /// </summary>
       /// <param name="strSql">SQL语句</param>
       /// <returns>数据表</returns>
       public DataTable GetDataTable(string sql)
       {
           DataTable dt = new DataTable();
           {
               MySqlDataAdapter da = new MySqlDataAdapter(sql, Con());
               da.Fill(dt);
           }
           return dt;
       }

       /// <summary>
       ///ExecuteValue(string sql) 是为基类的 一个方法 可以提供sql命令执行并  成功 返回非空值
       /// </summary>

       public string ExecuteValue(string sql)
       {
           MySqlConnection con = Con();
           MySqlCommand com = new MySqlCommand(sql, con);

           try
           {
               con.Open();
               object ob = com.ExecuteScalar();
               if (ob != null)
                   return ob.ToString();
               else
                   return null;
           }
           catch (SqlException e)
           {
               throw new Exception(e.Message);
           }
           finally
           {
               com.Dispose();//释放资源
               con.Close();
           }

       }
       /// <summary>
       ///ExecuteValue(string sql) 带参数重载
       /// </summary>

       public string ExecuteValue(string sql, MySqlParameter[] p)
       {
           MySqlConnection con = Con();
           MySqlCommand com = new MySqlCommand(sql, con);

           for (int i = 0; i < p.Length; i++)
           {
               com.Parameters.Add(p[i]);
           }
           try
           {
               con.Open();
               object ob = com.ExecuteScalar();
               if (ob != null)
                   return ob.ToString();
               else
                   return null;
           }
           catch (SqlException e)
           {
               throw new Exception(e.Message);
           }
           finally
           {
               com.Parameters.Clear();
               com.Dispose();//释放资源
               con.Close();
           }

       }

       /// <summary>
       /// 有参数利用SQL语句获得数据表
       /// </summary>
       /// <param name="strSql">SQL语句</param>
       /// <param name="param">参数数组</param>
       /// <returns>数据表</returns>
       public DataTable GetDataTable(string sql, MySqlParameter[] param)
       {
           DataTable dt = new DataTable();
           MySqlConnection con = Con();
           MySqlCommand cmd = new MySqlCommand(sql, con);
           for (int i = 0; i < param.Length; i++)
           {
               cmd.Parameters.Add(param[i]);
           }
           MySqlDataAdapter da = new MySqlDataAdapter(cmd);
           da.Fill(dt);
           return dt;
       }
    }
}
