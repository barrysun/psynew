using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Data;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class firmInfo1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["Id"] == null || Session["Id"].ToString() == "")
                Response.Redirect("login.aspx");
            Bind();
        }
    }

    public void Bind()
    {
        DataTable dt = new CompanyDal().Query(int.Parse(Session["Id"].ToString()));
        if(dt!=null&&dt.Rows.Count==1)
        {
            TextBox1.Text = dt.Rows[0]["GongName"].ToString();
            DropDownList1.SelectedValue = dt.Rows[0]["QiyeXinzhi"].ToString();
            TextBox2.Text = dt.Rows[0]["TongXindizhi"].ToString();
            DropDownList2.SelectedValue = dt.Rows[0]["Guimo"].ToString();
            TextBox3.Text = dt.Rows[0]["Zhucezijin"].ToString();
            TextBox4.Text = dt.Rows[0]["LianxiRen"].ToString();
            TextBox5.Text = dt.Rows[0]["qq"].ToString();
            TextBox6.Text = dt.Rows[0]["Phone"].ToString();
            TextBox7.Text = dt.Rows[0]["Email"].ToString();
            TextBox8.Text = dt.Rows[0]["GongSiWww"].ToString();
            TextBox9.Text = dt.Rows[0]["Des"].ToString();

        }
    
    }
    /// <summary>
    /// 确认
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Session["Id"] == null || Session["Id"].ToString() == "")
            Response.Redirect("login.aspx");

        string gongsiName = TextBox1.Text;
        string qiyexingzhi = DropDownList1.SelectedValue;
       // string suoshuhanye=
        string tongxindizhi = TextBox2.Text;
        string guimo = DropDownList2.SelectedValue;
        string zhucezijin = TextBox3.Text;
        string lianxiren = TextBox4.Text;
        string qq = TextBox5.Text;
        string phone = TextBox6.Text;
        string Email = TextBox7.Text;
        string gongsiwww = TextBox8.Text;
        string des = TextBox9.Text;
        Company company = new Company();
        company.GongName = gongsiName;
        company.QiyeXinzhi = qiyexingzhi;
        company.SuoshuHangye = "";
        company.TongXindizhi = tongxindizhi;
        company.Guimo = guimo;
        company.Zhucezijin = zhucezijin;
        company.LianxiRen = lianxiren;
        company.qq = qq;
        company.Phone = phone;
        company.Email = Email;
        company.GongSiWww = gongsiwww;
        company.Des = des;
        company.Id = int.Parse(Session["Id"].ToString());
        if (new CompanyDal().UpdateFirmInfo(company))
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("", "保存成功！"));
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("", "保存失败！"));
        }
    }
}