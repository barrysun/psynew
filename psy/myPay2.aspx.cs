using Dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class myPay2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bind();
        }
    }

    public void bind()
    { 
       ShoppingCarDal Dal=new ShoppingCarDal();
       DataTable dt = Dal.Query("  and sc.IsPay is Not NULL and UserId=" + Session["Id"]);
       Repeater1.DataSource = dt;
       Repeater1.DataBind();
        
    
    }
}