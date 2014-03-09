using System;
using System.Collections;
using System.Configuration;
using System.Data;

using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Model;
using System.Data.OleDb;
using System.IO;
using System.Data.SqlClient;
using System.Text;
using System.Security.Cryptography;
using Dal;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    /// <summary>
    /// 密码加密算法
    /// </summary>
    /// <param name="pwd"></param>
    /// <returns></returns>
    public string MD5(string pwd)
    {
        MD5 md5 = MD5CryptoServiceProvider.Create();
        byte[] buffer = Encoding.Unicode.GetBytes(pwd);
        byte[] bufferEnCode = md5.ComputeHash(buffer);
        string code = BitConverter.ToString(bufferEnCode);
        return code;
    }
    protected void BtnLogin_Click(object sender, EventArgs e)
    {
        string username = TxtID.Text.Trim();
        string password = TxtPwd.Text.Trim();


        if (RBtnAdmin.Checked)
        {
            int role = 3;
            if (new AdminUserDal().LoginAdmin(username, password, role))
            {
                Session["user"] = username;
                Session["role"] = role;
                Response.Redirect("Admin.aspx");
                //Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('旧密码错误')</script>");
            }
            else
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('密码错误')</script>");
        }

        if (RBtnTeacher.Checked)
        {
            int role = 1;
            if (new AdminUserDal().LoginAdmin(username,password,role))
            {
                Session["user"] = username;
                Session["role"] = role;
                Response.Redirect("Admin.aspx");
                //Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('旧密码错误')</script>");
            }
            else
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('密码错误')</script>");
        }

        if (RBtnStudent.Checked)
        {

            int role = 2;
            if (new AdminUserDal().LoginAdmin(username, password, role))
            {
                Session["user"] = username;
                Session["role"] = role;
                Response.Redirect("Admin.aspx");
                //Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('旧密码错误')</script>");
            }
            else
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('密码错误')</script>");
        }

       
    }
    protected void BtnReset_Click(object sender, EventArgs e)
    {
        TxtID.Text = "";
        TxtPwd.Text = "";
    }
    
}
