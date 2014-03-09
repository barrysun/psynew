using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dal;
using cn.cdu.edu.Psychology.iching.gxpk;
using cn.cdu.edu.Psychology.iching.hashmappk;

public partial class admin_EqiQuestionList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bind();
        }

    }

    public void bind() {
        string whereStr = TextBox1.Text.ToString();
        if (whereStr != null && whereStr != "")
        {
            whereStr = " where EQITITLE like '%" + whereStr + "%'";
        }
        else {
            whereStr = "";
        }

        EqiQuestionDal eqiQuestionDal = new EqiQuestionDal();
        eqiQuestionDal.BindPager(GridView1, AspNetPager1, whereStr);
    }
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        bind();
    }
 
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/admin/EqiQuestionUpdate.aspx");
    }
    
    protected void LinkButton1_Command(object sender, CommandEventArgs e)
    {
        string eqiid = e.CommandName.Trim();
        if (!string.IsNullOrEmpty(eqiid))
        {
            Response.Redirect("~/admin/EqiQuestionUpdate.aspx?eqiid=" + eqiid);
        }

    }
    protected void LinkButton2_Command(object sender, CommandEventArgs e)
    {

    }
    /// <summary>
    /// 查询
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button3_Click(object sender, EventArgs e)
    {
        bind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/admin/EqiQuestionUpdate.aspx");
    }
}