using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_PreferentialUpdate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Discount discount = new Discount();
        discount.DiscountName = TextBox1.Text;
        discount.DiscountCount = float.Parse(TextBox2.Text.Trim());
        if (new DiscountDal().Add(discount))
        {
            Response.Redirect("~/admin/PreferentialList.aspx");
        }
        else
        { 
        
        
        }
    }
}