using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_ChanPingUpdate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    /// <summary>
    /// 产品
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button1_Click(object sender, EventArgs e)
    {
        Changping chanp = new Changping();
        chanp.ChangpingName = TextBox1.Text.Trim();
        chanp.Des = TextBox2.Text.Trim();
        chanp.Unitprice = float.Parse(TextBox3.Text.Trim());
        chanp.UserCompy = int.Parse(DropDownList1.SelectedValue);
        if (new ChangpingDal().Add(chanp))
        {
            Response.Redirect("~/admin/ChanPingList.aspx");

        }
        else
        { 
        
        }
    }
}