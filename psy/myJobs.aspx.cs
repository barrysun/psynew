using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Data;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class myJobs : System.Web.UI.Page
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
        if (Request.QueryString["Id"] == null || Request.QueryString["Id"].ToString() == "")
        {
            return;
        }

        DataTable dt = new JobsDal().Query(" where Id=" + Request.QueryString["Id"]);
        if (dt != null && dt.Rows.Count == 1)
        {
            TextBox1.Text = dt.Rows[0]["JianLiName"].ToString();
            TextBox2.Text = dt.Rows[0]["RealName"].ToString();
            DropDownList4.SelectedValue = dt.Rows[0]["Xb"].ToString();
            TextBox3.Text = dt.Rows[0]["BorthDay"].ToString();
            TextBox4.Text = dt.Rows[0]["Hight"].ToString();
            DropDownList3.SelectedValue = dt.Rows[0]["BorthDay"].ToString();
            DropDownList2.SelectedValue = dt.Rows[0]["Jy"].ToString();
            DropDownList1.SelectedValue = dt.Rows[0]["Xl"].ToString();
            TextBox11.Text = dt.Rows[0]["Tc"].ToString();
            TextBox5.Text = dt.Rows[0]["Huji"].ToString();
            TextBox6.Text = dt.Rows[0]["Phone"].ToString();
            TextBox7.Text = dt.Rows[0]["Email"].ToString();
            TextBox8.Text = dt.Rows[0]["QQ"].ToString();
            TextBox9.Text = dt.Rows[0]["DiZhi"].ToString();
            TextBox10.Text = dt.Rows[0]["BoKe"].ToString();
        }


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Session["Id"] == null || Session["Id"].ToString() == "")
            Response.Redirect("login.aspx");

        int id = new JobsDal().getId(int.Parse(Session["Id"].ToString()));  
        string JianLiName = TextBox1.Text;
        string RealName = TextBox2.Text;
        string Xb = DropDownList4.SelectedValue;
        string BorthDay = TextBox3.Text;
        string Hight = TextBox4.Text;
        string HunYin = DropDownList3.SelectedValue;
        string Jy = DropDownList2.SelectedValue;
        string Xl = DropDownList1.SelectedValue;
        string Tc = TextBox11.Text;
        string Huji = TextBox5.Text;
        string Phone = TextBox6.Text;
        string Email = TextBox7.Text;
        string QQ = TextBox8.Text;
        string DiZhi = TextBox9.Text;
        string BoKe = TextBox10.Text;
        Jobs job = new Jobs();
        job.JianLiName = JianLiName;
        job.RealName = RealName;
        job.Id = id;
        job.Xb = Xb;
        job.BorthDay = BorthDay;
        job.Hight = Hight;
        job.HunYin = HunYin;
        job.Jy = Jy;
        job.Tc = Tc;
        job.Huji = Huji;
        job.Phone = Phone;
        job.Email = Email;
        job.QQ = QQ;
        job.DiZhi = DiZhi;
        job.BoKe = BoKe;

        if (new JobsDal().UpdateJob(job))
        {

           // Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("", "保存失败！"));
            Response.Redirect("myJobs1.aspx?Id="+id);
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("", "保存失败！"));
        }

       
    }
}