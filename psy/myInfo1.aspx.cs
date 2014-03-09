using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Data;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class myInfo1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["Id"] == null || Session["Id"].ToString() == "")
                Response.Redirect("login.aspx");
            bind();
        }
    }

    public void bind()
    {
        DataTable dt = new NUserDal().Query(" where Id=" + Session["Id"]);
        if (dt != null && dt.Rows.Count == 1)
        {
            TextBox1.Text = dt.Rows[0]["Muqian"].ToString();
            DropDownList1.SelectedValue = dt.Rows[0]["Gread"].ToString();
            TextBox2.Text = dt.Rows[0]["Class"].ToString();
            DropDownList2.SelectedValue = dt.Rows[0]["Gaozhongbiye"].ToString();
            DropDownList4.SelectedValue = dt.Rows[0]["Sort"].ToString();
            TextBox4.Text = dt.Rows[0]["Sort2"].ToString();
            RadioButton1.Checked = dt.Rows[0]["Aoshai"].ToString().Equals("是");
            RadioButton2.Checked = !dt.Rows[0]["Aoshai"].ToString().Equals("是");
            TextBox6.Text = dt.Rows[0]["Yishu"].ToString();
            TextBox7.Text = dt.Rows[0]["Tiyu"].ToString();
            TextBox8.Text = dt.Rows[0]["Qita"].ToString();
            DropDownList3.SelectedValue = dt.Rows[0]["IsZhongdian"].ToString();
        }

    }
    /// <summary>
    /// 保存
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Session["Id"] == null || Session["Id"].ToString() == "")
            Response.Redirect("login.aspx");

        NUser user = new NUser();
        user.Muqian = TextBox1.Text;
        user.Gread = DropDownList1.SelectedValue;
        user.Class = TextBox2.Text;
        user.Gaozhongbiye = DropDownList2.Text;
        user.Sort = DropDownList4.SelectedValue;
        user.Sort2 = TextBox4.Text;
        user.Aoshai = RadioButton1.Checked ? "是" : "否";
        user.Yishu = TextBox6.Text;
        user.Tiyu = TextBox7.Text;
        user.Qita = TextBox8.Text;
        user.IsZhongdian = DropDownList3.SelectedValue;
        user.Id = int.Parse(Session["Id"].ToString());

        if (new NUserDal().UpdateUserInfo1(user))
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("", "保存成功！"));
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("", "保存失败！"));
        }


    }
}