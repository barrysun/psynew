using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class myPay1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            
            bind();
            bindMoney();
        }
    }

   

    public void bindMoney()
    {
        DataTable dt = new ShoppingCarDal().Query("  and sc.IsPay is NULL and UserId="+Session["Id"]);
        float x = 0;
        if (Repeater1.Items.Count > 0)
            for (int i = 0; i < Repeater1.Items.Count; i++)
            {
                string zk = ((DropDownList)Repeater1.Items[i].FindControl("DropDownList1")).SelectedValue;
                string price = dt.Rows[i]["Unitprice"].ToString().Trim();
                string count = ((TextBox)Repeater1.Items[i].FindControl("TextBox1")).Text;
                x += float.Parse(zk) * float.Parse(price)*float.Parse(count);
                ((Label)Repeater1.Items[i].FindControl("Label2")).Text = (float.Parse(zk) * float.Parse(price) * float.Parse(count)).ToString();
            }
        Label1.Text = x + "";
    }

    public void bind()
    {
        DataTable dt = new ShoppingCarDal().Query("  and sc.IsPay is NULL and UserId=" + Session["Id"]);
        Repeater1.DataSource = dt;
        Repeater1.DataBind();
       

    }
    protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        DropDownList drop = (DropDownList)(e.Item.FindControl("DropDownList1"));
        drop.DataSource = new DiscountDal().Query(" ");
        drop.DataValueField = "DiscountCount";
        drop.DataTextField = "DiscountName";
        drop.DataBind();

    }
    protected void Repeater1_DataBinding(object sender, EventArgs e)
    {
    
    }
    /// <summary>
    /// 删除
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void LinkButton1_Command(object sender, CommandEventArgs e)
    {
        int id=int.Parse(e.CommandName);
        ShoppingCar sop= new ShoppingCar();
        sop.Id=id;
        if (new ShoppingCarDal().Delete(sop))
        {
            bind();
            bindMoney();
        }
        else
        { 
        
        }
        
    }
 
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        bindMoney();
    }
    /// <summary>
    /// 支付
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button2_Click(object sender, EventArgs e)
    {
        string selec = DropDownList2.SelectedValue;
        ShoppingCar sop = new ShoppingCar();
        DataTable dt = new ShoppingCarDal().Query("  and sc.IsPay is NULL and UserId=" + Session["Id"]);
        if (dt == null && dt.Rows.Count <= 0)
            return;
        string sql = "";
        if (Repeater1.Items.Count > 0)
            for (int i = 0; i < Repeater1.Items.Count; i++)
            {
                string zk = ((DropDownList)Repeater1.Items[i].FindControl("DropDownList1")).SelectedValue;
                string count = ((TextBox)Repeater1.Items[i].FindControl("TextBox1")).Text;
             
                string price = dt.Rows[i]["Unitprice"].ToString().Trim();
                int discount = 2;
                if (selec == "1")
                {
                    //支付宝
                    discount = 1;
                }
                else
                {
                    //线下支付
                }
                float x = float.Parse(zk) * float.Parse(price)*float.Parse(count);
                sql = "update shoppingcar set ChangpingCount=" + count + ",Money=" + x + ",UseCount="+count+",Discount=" + zk + ",IsPay=0,ShoppingTime=now() where Id=" + dt.Rows[i]["Id"];
               
                new ShoppingCarDal().Update(sql);
               
            }

        bind();
        bindMoney();
       
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        bindMoney();
    }
}