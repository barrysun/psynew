using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Dal;

public partial class admin_ForecastReportComponentUpdate : System.Web.UI.Page
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
        string forecastrepcompid = Request.QueryString["forecastrepcompid"].Trim();
        if (forecastrepcompid != null)
        {
            DataTable dt = new ForecastReportComponentDal().GetById(forecastrepcompid);
            if (dt != null && dt.Rows.Count > 0)
            {
                TextBox1.Text = dt.Rows[0]["YCNUM"].ToString();
                TextBox2.Text = dt.Rows[0]["VARIABLE"].ToString();
                TextBox3.Text = dt.Rows[0]["VARIABLEVALUE"].ToString();
                TextBox4.Text = dt.Rows[0]["REPORTCOMPONENT"].ToString();
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}