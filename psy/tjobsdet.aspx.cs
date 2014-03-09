using Dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class tjobsdet : System.Web.UI.Page
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
        if (Request.QueryString["Id"] != null && Request.QueryString["Id"].ToString() != "")
        {
            FirmInfoDal dal = new FirmInfoDal();
            DataTable dt=dal.getById(int.Parse(Request.QueryString["Id"].ToString()));


            Label1.Text = dt.Rows[0]["Zhiwei"].ToString();//职位名称
            Label2.Text =  dt.Rows[0]["Gzfw"].ToString();//期望薪资
            Label3.Text = dt.Rows[0]["GongZuoDiDian"].ToString();//工作地点
            Label4.Text = dt.Rows[0]["Jy"].ToString();//工作经验
            Label5.Text = dt.Rows[0]["Xl"].ToString();//最低学历
            Label6.Text = dt.Rows[0]["GongZuoXinzhi"].ToString();//工作性质
            Label7.Text = dt.Rows[0]["Renshu"].ToString();//招聘人数

            Label8.Text = dt.Rows[0]["StartTime"].ToString();//招聘有效期
            Label9.Text = dt.Rows[0]["EndTime"].ToString();//招聘有效期
            Label10.Text = dt.Rows[0]["Des"].ToString();//职位描述
            Label11.Text = dt.Rows[0]["Des1"].ToString();;//公司描述
            Label12.Text = dt.Rows[0]["GongName"].ToString();//职位名称
            Label13.Text = dt.Rows[0]["Zhiwei"].ToString();//公司
            Label14.Text=dt.Rows[0]["QiyeXinzhi"].ToString();//公司性质
            Label15.Text = dt.Rows[0]["SuoshuHangye"].ToString();//公式行业
            Label16.Text = dt.Rows[0]["Guimo"].ToString();//公式规模

        }
    }

   
}