using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class myPay : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["Role"] == null)
            {
                Response.Redirect("login.aspx");
            }
            bind();
           
        }
    }

    public void bind()
    {
      //1是企业

        //2是个人用户
        int role = int.Parse(Session["Role"].ToString());
        
        DataTable dt = new ChangpingDal().Query(" where UserCompy="+role);
        Repeater1.DataSource = dt;
        Repeater1.DataBind();
    
    }
    protected void LinkButton1_Command(object sender, CommandEventArgs e)
    {
        int UserId = int.Parse(Session["Id"].ToString());
        int shanpingId = int.Parse(e.CommandName);
        ShoppingCar shoppingCar = new ShoppingCar();
        shoppingCar.UserId = UserId;
        shoppingCar.Changping = shanpingId;
        ShoppingCarDal dal = new ShoppingCarDal();
        if (dal.Add(shoppingCar))
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("", "已经加入到购物车！"));
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("", "加入失败！"));
        }
    }
}