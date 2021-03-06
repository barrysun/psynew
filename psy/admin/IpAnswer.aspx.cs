﻿using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dal;

public partial class admin_Answer_IpAnswer : System.Web.UI.Page
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
        new IpQuestionDal().BindPagerAnswer(GridView1, AspNetPager1, getWhereStr());
    }

    private string getWhereStr()
    {
        string where = TextBox1.Text.Trim();
        if (where != null && where != "")
        {
            if (DropDownList1.SelectedValue == "1")//用户ID
            {
                where = " `user`.USERID =" + where;

            }
            else if (DropDownList1.SelectedValue == "2")
            {
                where = " `user`.NAME like '%" + where + "%'";
            }
            
        }
        return where;
    }
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        bind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        bind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
       
        ExcelDown exceldown = new ExcelDown();
        exceldown.downExcel(Response, new IpQuestionDal().GetDataTable(getWhereStr()), "ipanswer" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "-" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second + "-" + DateTime.Now.Millisecond, Server.MapPath("~/Excel"));
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        ExcelDown exceldown = new ExcelDown();
        exceldown.downExcel(Response, new IpQuestionDal().getDataTable(), "iptitle" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "-" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second + "-" + DateTime.Now.Millisecond, Server.MapPath("~/Excel"));
    }
}