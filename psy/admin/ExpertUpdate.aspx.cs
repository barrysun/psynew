using Dal;
using Model;
using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_ExpertUpdate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// 添加
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button1_Click(object sender, EventArgs e)
    {
        var ex = new Expert
        {
            ExpertName = TextBox1.Text.Trim(),
            ExpertPhoto = "",
            ExpertDes = TextBox2.Text,
            ExpertType = int.Parse(DropDownList1.SelectedValue),
            Order = string.IsNullOrEmpty(TextBox3.Text) ? 0 : int.Parse(TextBox3.Text.Trim())
        };

        var exdal = new ExpertDal();
        if (exdal.Add(ex))
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('添加成功！');window.location.href='ExpertList.aspx';</script>");

        }
        else 
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('添加失败！');</script>");
        }

    }
}