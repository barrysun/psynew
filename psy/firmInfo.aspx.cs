using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Data;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class firmInfo : System.Web.UI.Page
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
        if (Session["Id"] != null && Session["Id"].ToString() != "")
        {
            DataTable dt = new FirmInfoDal().Query(" where Id=" + Session["Id"]);
            if (dt != null && dt.Rows.Count == 1)
            {
                TextBox1.Text = dt.Rows[0]["ZhiWei"].ToString();
                DropDownList4.SelectedValue = dt.Rows[0]["Xb"].ToString();
                DropDownList5.SelectedValue = dt.Rows[0]["GongzuoXinzhi"].ToString();
                TextBox2.Text = dt.Rows[0]["Renshu"].ToString();
                TextBox3.Text = dt.Rows[0]["StartTime"].ToString();
                TextBox4.Text = dt.Rows[0]["EndTime"].ToString();
                TextBox5.Text = dt.Rows[0]["GongZuoDiDian"].ToString();
                DropDownList1.SelectedValue = dt.Rows[0]["Xl"].ToString();
                DropDownList2.SelectedValue = dt.Rows[0]["Jy"].ToString();
                DropDownList3.SelectedValue = dt.Rows[0]["Gzfw"].ToString();
                TextBox6.Text = dt.Rows[0]["Des"].ToString();
            
            }
        }
    }
    /// <summary>
    /// 发布
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button1_Click(object sender, EventArgs e)
    {
        //Response.Cookies["User"]
        if (Session["Id"] == null || Session["Id"].ToString() == "")
            Response.Redirect("login.aspx");

        string zhiwei = TextBox1.Text;//职位
        string xb = DropDownList4.SelectedValue;//性别
        string gongzuoxizhi = DropDownList5.SelectedValue;//工作性质
        string zhoping = TextBox2.Text;//人数
        string startTime = TextBox3.Text;//开始时间
        string endtime = TextBox4.Text;//结束时间
        string gongzuodidian = TextBox5.Text;//工作地点
        string xl = DropDownList1.SelectedValue;//学历
        string jy = DropDownList2.SelectedValue;//经验
        string gzfw = DropDownList3.SelectedValue;//工资范围
        string des = TextBox6.Text;//描述
        var firm = new FirmInfo
        {
            Zhiwei = zhiwei,
            Xb = xb,
            GongzuoXinzhi = gongzuoxizhi,
            Renshu = zhoping,
            StartTime = startTime,
            EndTime = endtime,
            GongZuoDiDian = gongzuodidian,
            Xl = xl,
            Jy = jy,
            Gzfw = gzfw,
            Des = des,
            CompanyId = int.Parse(Session["Id"].ToString().Trim())
        };
        if (Request.QueryString["Id"] != null)
        {
            firm.Id = int.Parse(Request.QueryString["id"].ToString().Trim());
            if (new FirmInfoDal().Update(firm))
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("", "修改成功！"));
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("", "修改失败！"));
            }
        }
        else
        {
            if (new FirmInfoDal().Add(firm))
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("", "添加成功！"));

            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("", "添加失败！"));
            }
        
        }
       



    }
}