using Dal;
using Model;
using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_DesUpdate : System.Web.UI.Page
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
        if (Request.QueryString["id"] != null && Request.QueryString["id"].ToString() != "")
        {
            switch (int.Parse(Request.QueryString["id"].ToString()))
            {
                case 1:
                    Label1.Text = "职业测评专栏";
                   FCKeditor1.Value= new DesDal().GetDes(int.Parse(Request.QueryString["id"]));
                    break;
                case 2:
                    Label1.Text = "职业培训";
                    FCKeditor1.Value = new DesDal().GetDes(int.Parse(Request.QueryString["id"]));
                    break;
                case 3:
                    Label1.Text = "人生规划研究中心";
                    FCKeditor1.Value = new DesDal().GetDes(int.Parse(Request.QueryString["id"]));
                    break;
                case 4:
                    Label1.Text="关于我们";
                    FCKeditor1.Value = new DesDal().GetDes(int.Parse(Request.QueryString["id"]));
                    break;
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
        Desction des = new Desction();
        des.Id = int.Parse(Request.QueryString["id"]);
        des.Des = FCKeditor1.Value;
        if (new DesDal().Update(des))
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('修改成功！');</script>");
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('修改失败！');</script>");
        }


    }
}