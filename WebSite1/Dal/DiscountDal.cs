using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using Wuqi.Webdiyer;

namespace Dal
{
    /// <summary>
    /// 折扣
    /// </summary>
   public  class DiscountDal
    {

       public void BindPager(GridView gv, AspNetPager pager, string whereStr)
       {
           var sql = @"
set @mycnt=0; 
select * from (
select *,(@mycnt := @mycnt + 1) as RowNum from discount
)as adm where RowNum>{0} and RowNum<={1}";
           sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
           pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(Id) from discount"));
           gv.DataSource = new MySQLHelper().GetDataTable(sql);
           gv.DataBind();
       }

       public bool Add(Discount discount)
       {
           const string sql = "insert into discount(DiscountName,DiscountCount) values (?DiscountName,?DiscountCount)";
           var param=new MySqlParameter[2];
           param[0]=new MySqlParameter("?DiscountName",MySqlDbType.String) {Value = discount.DiscountName};
           param[1]=new MySqlParameter("?DiscountCount",MySqlDbType.Float) {Value = discount.DiscountCount};
           return new MySQLHelper().ExecuteSql(sql, param)==1;
       }

       public bool Update(Discount discount)
       {
           const string sql = "update discount set DiscountName=?DiscountName,DiscountCount=?DiscountCount where Id=?Id";
           var param = new MySqlParameter[3];
           param[0] = new MySqlParameter("?DiscountName", MySqlDbType.String) {Value = discount.DiscountName};
           param[1] = new MySqlParameter("?DiscountCount", MySqlDbType.Float) {Value = discount.DiscountCount};
           param[2] = new MySqlParameter("?Id", MySqlDbType.Float) {Value = discount.Id};
           return new MySQLHelper().ExecuteSql(sql, param) == 1;
       }

       public DataTable Query(string whereStr)
       {
           return new MySQLHelper().GetDataTable("select * from Discount "+whereStr);
       }
    }

    /// <summary>
    /// 产品
    /// </summary>
   public class ChangpingDal
   {

       public void BindPager(GridView gv, AspNetPager pager, string whereStr)
       {
           var sql = @"
set @mycnt=0; 
select * from (
select *,(@mycnt := @mycnt + 1) as RowNum from chanping
)as adm where RowNum>{0} and RowNum<={1}";
           sql = string.Format(sql, (pager.CurrentPageIndex - 1) * pager.PageSize, (pager.CurrentPageIndex - 1) * pager.PageSize + pager.PageSize);
           pager.RecordCount = int.Parse(new MySQLHelper().ExecuteValue("select count(Id) from chanping"));
           gv.DataSource = new MySQLHelper().GetDataTable(sql);
           gv.DataBind();
       }
       public bool Add(Changping chanp)
       {
           const string sql = "insert chanping(CHANPING,DES,Unitprice,UserCompy) values(?CHANPING,?DES,?Unitprice,?UserCompy)";
           var param = new MySqlParameter[4];
           param[0] = new MySqlParameter("?CHANPING", MySqlDbType.String) {Value = chanp.ChangpingName};
           param[1] = new MySqlParameter("?DES", MySqlDbType.String) {Value = chanp.Des};
           param[2] = new MySqlParameter("?Unitprice", MySqlDbType.Float) {Value = chanp.Unitprice};
           param[3] = new MySqlParameter("?UserCompy", MySqlDbType.Int32) {Value = chanp.UserCompy};
           return new MySQLHelper().ExecuteSql(sql, param) == 1;
       }

       public bool Update(Changping chanp)
       {
           return new MySQLHelper().ExecuteSql(
               "update chanping set CHANPING=?CHANPING,DES=?DES,Unitprice=?Unitprice,UserCompy=?UserCompy where Id=?Id",
               new[]{
               new MySqlParameter("?CHANPING", MySqlDbType.String) {Value = chanp.ChangpingName},
               new MySqlParameter("?DES", MySqlDbType.String) {Value = chanp.Des},
               new MySqlParameter("?Unitprice", MySqlDbType.Float) {Value = chanp.Unitprice},
               new MySqlParameter("?UserCompy", MySqlDbType.Int32) {Value = chanp.UserCompy},
               new MySqlParameter("?Id", MySqlDbType.Int32) {Value = chanp.Id}
           }) == 1;
       }

       public DataTable Query(string whereStr)
       {
           return new MySQLHelper().GetDataTable("select * from chanping " + whereStr);
       }
   
   }
    /// <summary>
    /// 购物车
    /// </summary>
   public class ShoppingCarDal
   {

       public bool Add(ShoppingCar car)
       {
           return new MySQLHelper().ExecuteSql(
               "insert shoppingcar (UserId,Changping) values(?UserId,?Changping)", 
               new []
               {
                   new MySqlParameter("?UserId", MySqlDbType.Int32) {Value = car.UserId},
                   new MySqlParameter("Changping", MySqlDbType.Int32) {Value = car.Changping}
               }) == 1;
       }

       public bool Update(ShoppingCar car)
       {
           return false;
       }
       public bool Delete(ShoppingCar car)
       {
           const string sql = "delete from shoppingcar where Id=?Id";
           var param = new MySqlParameter[1];
           param[0] = new MySqlParameter("?Id", MySqlDbType.Int32) {Value = car.Id};
           return new MySQLHelper().ExecuteSql(sql, param) == 1;
       }

       public DataTable Query(string whereStr)
       {
           return new MySQLHelper().GetDataTable("select sc.*,cp.*,(case when IsPay=1 then '已付' else '未支付' end) as pay,(case when UseCount<=0 then '服务完成' else '使用中...' end ) as UserPay from shoppingcar sc,chanping cp where cp.Id=sc.Changping " + whereStr);
       }


       public void Update(string sql) {

           new MySQLHelper().ExecuteSql(sql);
       }
   }
}
