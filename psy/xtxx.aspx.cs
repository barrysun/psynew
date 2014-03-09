using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Data;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class myInfo : System.Web.UI.Page
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
        DataTable dt = new NUserDal().Query(" where Id=" + Session["Id"].ToString());
        if (dt != null && dt.Rows.Count == 1)
        {
            TextBox1.Text = dt.Rows[0]["RealName"].ToString();
            DropDownList3.SelectedValue = dt.Rows[0]["Gender"].ToString();
            TextBox3.Text = dt.Rows[0]["BorthDay"].ToString();
            DropDownList1.SelectedValue = (dt.Rows[0]["Borthtime"]!=null&&dt.Rows[0]["Borthtime"].ToString()!="")?dt.Rows[0]["Borthtime"].ToString().Split(':')[0]:"";
            DropDownList2.SelectedValue = (dt.Rows[0]["Borthtime"]!=null&&dt.Rows[0]["Borthtime"].ToString()!="")?dt.Rows[0]["Borthtime"].ToString().Split(':')[1]:"";
         

            if (dt.Rows[0]["BorthDay"].ToString() != null && dt.Rows[0]["BorthDay"].ToString() != "")
            {
                TextBox1.Enabled = false;
                DropDownList3.Enabled = false;
                TextBox3.Enabled = false;
                DropDownList1.Enabled = false;
                DropDownList2.Enabled = false;
            }

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

        if (TextBox1.Text == null || TextBox1.Text == "")
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("提交验证提示", "姓名不能为空！"));    
        }else if (TextBox3.Text == null || TextBox3.Text == "")
            {
             
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("提交验证提示", "出生年月日不能为空！")); 
            }
            else
            {

                NUser user = new NUser();
                user.RealName = TextBox1.Text;//真实姓名
                user.Gender = int.Parse(DropDownList3.SelectedValue);//性别
                user.BorthDay = TextBox3.Text;//出生年月日
                user.Borthtime = DropDownList1.SelectedValue + ":" + DropDownList2.SelectedValue + ":00";// TextBox4.Text;//出生时间
             
                user.Id = int.Parse(Session["Id"].ToString());
                if (new NUserDal().UpdateUserXTXX(user))
              {
                  Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("", "保存成功！"));
                  bind();
              }else
              {
                  Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("", "保存失败！")); 
              }
            }


    }
}