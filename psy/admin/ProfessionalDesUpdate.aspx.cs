using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_ProfessionalDesUpdate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    /// <summary>
    /// 添加
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button1_Click(object sender, EventArgs e)
    {
        ProfessionalDes pro = new ProfessionalDes();
        pro.Title1 = TextBox1.Text;
        pro.Title2 = TextBox2.Text;
        pro.Title3 = TextBox3.Text;
        pro.Des = FCKeditor1.Value;
        pro.Work = TextBox4.Text;
        if (new ProfessionalDesDal().Add(pro))
        {
            Response.Redirect("~/admin/ProfessionalDesList.aspx");
        }
        else
        { 
          
        }
    }
}