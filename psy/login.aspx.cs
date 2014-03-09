using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Data;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public string bindnav()
    {
        return Nav.NavStr();
    }
    /// <summary>
    /// 登陆
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button2_Click(object sender, EventArgs e)
    {
        string UserName = TextBox2.Text;
        string Password = TextBox1.Text;
        int role = 1;//1是企业
        
        //2是个人用户
        if (RadioButton1.Checked)
        {
            role = 2;
        }
     
        if (role == 2)
        {
            DataTable dt=new NUserDal().Login(UserName,Password);
            if (dt != null && dt.Rows.Count == 1)
            {

                Session["Role"] = role + "";
                Session["UserName"] = UserName;
                Session["Password"] = Password;
                Session["Id"] = dt.Rows[0]["Id"].ToString();

                Response.Redirect("myTest.aspx");
            }
        }
        else if(role==1) {
            DataTable dt = new CompanyDal().Login(UserName, Password);
            if (dt != null && dt.Rows.Count == 1)
            {

                Session["Role"] = role + "";
                Session["UserName"] = UserName;
                Session["Password"] = Password;
                Session["Id"] = dt.Rows[0]["Id"].ToString();
                
                Response.Redirect("firmInfo.aspx");
            }
            
        }
        Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("", "登陆失败，请检查用户名密码是否有误！","error"));
       
    }
    /// <summary>
    /// 注册
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button1_Click(object sender, EventArgs e)
    {
        string UserName = TextBox3.Text.Trim();
        string Email = TextBox4.Text.Trim();
        string Password = TextBox5.Text.Trim();
        string CPassword = TextBox6.Text.Trim();

        int role = 1;//表示企业
        if (RadioButton3.Checked)
        {
            role = 1;
        }
        else if (RadioButton4.Checked)
        {
            role = 2;
        }


        if (new NUserDal().IsHas(UserName.Trim()))
        {
            switch (role)
            {
                case 1:
                    {
                        Company company = new Company();
                        company.LoginName = UserName;
                        company.Password = Password;
                        if (new CompanyDal().Register(company))
                        {
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("", "注册成功"));

                        }
                        else
                        {
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("", "注册失败","error"));
                        }

                    }
                    break;
                case 2:
                    {
                        NUser user = new NUser();
                        user.LoginName = UserName;
                        user.Password = Password;
                        if (new NUserDal().Register(user))
                        {
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("", "注册成功"));
                        }
                        else
                        {

                            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("", "注册失败","error"));
                        }
                    }
                    break;
            }

        }
        else 
        {


            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("用户名已经被注册！", "请重新填写用户名！","error"));
        }

  
      //  Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("注册操作", "注册失败"));
    }
}