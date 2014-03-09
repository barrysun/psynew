﻿using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dal;

public partial class admin_Component_ForecastJob2List : System.Web.UI.Page
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
        string whereStr = TextBox1.Text;
        if (whereStr != null && whereStr != "")
        {
            whereStr = " where CNOUTLOOK1 like '%" + whereStr + "%' or CNOUTLOOK2 like '%" + whereStr + "%' ";
        }
        new Forecastjob2Dal().BindPager(GridView1, AspNetPager1, whereStr );
    }
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        bind();
    }
    protected void LinkButton1_Command(object sender, CommandEventArgs e)
    {
        string eqiid = e.CommandName.Trim();
        if (!string.IsNullOrEmpty(eqiid))
        {
            Response.Redirect("~/admin/ForecastJob2Update.aspx?forecastjob2id=" + eqiid);
        }

    }
    protected void LinkButton2_Command(object sender, CommandEventArgs e)
    {

    }
    /// <summary>
    /// 查询条件
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button1_Click(object sender, EventArgs e)
    {
        bind();
    }
}