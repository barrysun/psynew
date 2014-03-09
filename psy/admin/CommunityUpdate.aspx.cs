using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Data;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_CommunityUpdate : System.Web.UI.Page
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
            DataTable dt = new CommunityDal().getByWhereStr(" where Id=" + Request.QueryString["id"]);
            if (dt != null && dt.Rows.Count > 0)
            {
                FCKeditor1.Value = dt.Rows[0]["CONTENT"].ToString();
                TextBox1.Text = dt.Rows[0]["TITLE"].ToString();
                TextBox2.Text = dt.Rows[0]["ORDER"].ToString();
                DropDownList1.SelectedValue = dt.Rows[0]["ISHOME"].ToString();
            }
          

        }
    
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Community comm=new Community();
        comm.Content=FCKeditor1.Value;
        comm.Title=TextBox1.Text;
        comm.Order = int.Parse(TextBox2.Text);
        comm.Type=int.Parse(Request.QueryString["type"]);
        comm.IsHome=int.Parse(DropDownList1.SelectedValue);
        if (Request.QueryString["id"] != null && Request.QueryString["id"].ToString() != "")
        {
            comm.Id = int.Parse(Request.QueryString["id"]);
            if (new CommunityDal().Update(comm))
            {
                FCKeditor1.Value = "";
                TextBox1.Text = "";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('修改成功！');window.location.href='CommunityList.aspx?type=" + Request.QueryString["type"] + "';</script>");

            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('修改失败！');</script>");
            }

        }
        else {
            if (new CommunityDal().Add(comm))
            {
                FCKeditor1.Value = "";
                TextBox1.Text = "";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('添加成功！');window.location.href='CommunityList.aspx?type=" + Request.QueryString["type"] + "';</script>");

            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('添加失败！');</script>");
            }
        
        }
       
    }
}