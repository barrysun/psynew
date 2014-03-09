using Dal;
using Model;
using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_EntranceUpdate : System.Web.UI.Page
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
     
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Entrance entrance = new Entrance();
        entrance.Title = TextBox1.Text;
        entrance.Content = FCKeditor1.Value;
        entrance.IsHome = int.Parse(DropDownList1.SelectedValue);
        entrance.Order = int.Parse(TextBox2.Text);
        entrance.EntranceType = int.Parse(Request.QueryString["type"]);
        if (new EntranceDal().Add(entrance))
        {
            FCKeditor1.Value = "";
            TextBox1.Text = "";
            TextBox2.Text = "";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('添加成功！');window.location.href='EntranceList.aspx?type=" + Request.QueryString["type"] + "';</script>");

        }
        else
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('添加失败！');</script>");
        }
    }
}