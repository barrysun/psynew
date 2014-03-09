using Dal;
using Model;
using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_NewsUpdate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //添加
    protected void Button1_Click(object sender, EventArgs e)
    {
        add();
    }

    public bool add()
    {
        New news = new New();
        news.NewTitle = TextBox1.Text.Trim();
        news.NewType =  0;//TextBox2.Text.Trim();
        news.PICUrl="";
        if(FileUpload1.HasFile)
        {
          FileUpload1.SaveAs(Server.MapPath("~/newpic/")+FileUpload1.FileName);
             news.PICUrl = FileUpload1.FileName;
        }
       
        news.IsHome = 1;
        news.NewContent = FCKeditor1.Value;
        return new NewsDal().Add(news);
    
    }
}