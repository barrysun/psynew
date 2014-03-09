using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Data;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class myJobs1 : System.Web.UI.Page
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
        DataTable dt = new JobsDal().Query(" where Id=" +Request.QueryString["Id"]);
        if (dt != null && dt.Rows.Count == 1)
        {
            TextBox1.Text = dt.Rows[0]["QiWangGongZuo"].ToString();
            DropDownList3.SelectedValue = dt.Rows[0]["QiWangXinZi"].ToString();
            DropDownList5.SelectedValue = dt.Rows[0]["QiWangGangWeiXinzhi"].ToString();
            TextBox2.Text = dt.Rows[0]["QiWangGangwei"].ToString();
            TextBox3.Text = dt.Rows[0]["GongZuoGangWei"].ToString();
            RadioButtonList1.SelectedValue = dt.Rows[0]["ZhuangTai"].ToString();
        }
    }
    /// <summary>
    /// 下一步
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Session["Id"] == null || Session["Id"].ToString() == "")
            Response.Redirect("login.aspx");

        string QiWangGongZuo = TextBox1.Text;
        string QiWangXinZi = DropDownList3.SelectedValue;
        string QiWangGangWeiXinzhi = DropDownList5.SelectedValue;
        string QiWangGangwei = TextBox2.Text;
        string GongZuoGangWei = TextBox3.Text;
        string ZhuangTai = RadioButtonList1.SelectedValue.ToString().Trim();
        Jobs job = new Jobs();
        job.QiWangGongZuo = QiWangGongZuo;
        job.QiWangXinZi = QiWangXinZi;
        job.QiWangGangWeiXinzhi = QiWangGangWeiXinzhi;
        job.QiWangGangwei = QiWangGangwei;
        job.GongZuoGangWei = GongZuoGangWei;
        job.ZhuangTai = ZhuangTai;
        job.Id = int.Parse(Request.QueryString["Id"].ToString());

        if (new JobsDal().UpdateJob1(job))
        {

            Response.Redirect("myJobs2.aspx?Id="+Request.QueryString["Id"]);
        }
        else 
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("", "保存失败！"));
        }

    }
    /// <summary>
    /// 上一步
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("myJobs.aspx?Id="+Request.QueryString["Id"]);
    }
}