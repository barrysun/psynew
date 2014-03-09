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
        DataTable dt = new NUserDal().Query(" where Id=" + Session["Id"]);
        if (dt != null && dt.Rows.Count == 1)
        {
            TextBox1.Text = dt.Rows[0]["RealName"].ToString();
            DropDownList3.SelectedValue = dt.Rows[0]["Gender"].ToString();
            TextBox3.Text = dt.Rows[0]["BorthDay"].ToString();
            DropDownList1.SelectedValue = (dt.Rows[0]["Borthtime"]!=null&&dt.Rows[0]["Borthtime"].ToString()!="")?dt.Rows[0]["Borthtime"].ToString().Split(':')[0]:"";
            DropDownList2.SelectedValue = (dt.Rows[0]["Borthtime"]!=null&&dt.Rows[0]["Borthtime"].ToString()!="")?dt.Rows[0]["Borthtime"].ToString().Split(':')[1]:"";
            TextBox5.Text = dt.Rows[0]["Dizhi"].ToString();
            TextBox6.Text = dt.Rows[0]["Huiji"].ToString();
            TextBox7.Text = dt.Rows[0]["HunYin"].ToString();
            TextBox8.Text = dt.Rows[0]["Hight"].ToString();
            TextBox9.Text = dt.Rows[0]["Father"].ToString();
            TextBox10.Text = dt.Rows[0]["FatherPhone"].ToString();
            TextBox11.Text = dt.Rows[0]["Phone"].ToString();
            TextBox12.Text = dt.Rows[0]["Email"].ToString();
            TextBox13.Text = dt.Rows[0]["Qq"].ToString();
            TextBox14.Text = dt.Rows[0]["Boke"].ToString();
            TextBox15.Text = dt.Rows[0]["UserNumber"].ToString();

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
                user.Dizhi = TextBox5.Text;//通信地址
                user.Huiji = TextBox6.Text;//户籍
                user.HunYin = TextBox7.Text;//婚姻
                user.Hight = TextBox8.Text;//身高
                user.Father = TextBox9.Text;//父母
                user.FatherPhone = TextBox10.Text;//父母电话
                user.Phone = TextBox11.Text;//电话
                user.Email = TextBox12.Text;//邮箱
                user.Qq = TextBox13.Text;//qq
                user.Boke = TextBox14.Text;//博客
                user.UserNumber = TextBox15.Text;//身份证号
                user.Id = int.Parse(Session["Id"].ToString());
              if(new NUserDal().UpdateUserInfo(user))
              {
                  Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("", "保存成功！")); 
              }else
              {
                  Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("", "保存失败！")); 
              }
            }


    }
}