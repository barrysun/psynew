using Dal;
using java.lang;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class talentback2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["Id"] == null || Session["Id"].ToString() == "")
                Response.Redirect("login.aspx");

            bindRepert2();
        }
    }

  
   
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        bindRepert2();
    }

    /// <summary>
    /// 查询 找工作
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button3_Click(object sender, EventArgs e)
    {
        bindRepert2();
    }

    public void bindRepert2()
    {
        string whereStr = " ";
        string txt = TextBox4.Text;
        switch (int.Parse(HiddenField6.Value))
        {
            case 0:
                //不限
                whereStr += "";

                break;
            case 1:
                //1000-2000
                whereStr += " and f.Gzfw='1000~2000元/月' ";
                break;
            case 2:
                //2000-3000
                whereStr += " and f.Gzfw='2000~3000元/月' ";
                break;
            case 3:
                //3000-5000
                whereStr += " and f.Gzfw='3000~5000元/月' ";
                break;
            case 4:
                //5000-
                whereStr += " and (f.Gzfw='5000~10000元/月' or f.Gzfw='10000以上元/月') ";
                break;
            case 5:
                //面议
                whereStr += " and f.Gzfw='面议' ";
                break;
            default:
                whereStr += "";
                break;
        }
        switch (int.Parse(HiddenField7.Value))
        {
            case 0:
                //不限
                whereStr += "";
                break;
            case 1:
                //全职
                whereStr += " and f.GongzuoXinzhi='全职' ";
                break;
            case 2:
                //兼职
                whereStr += " and f.GongzuoXinzhi='兼职' ";
                break;
            case 3:
                //实习
                whereStr += " and f.GongzuoXinzhi='实习' ";
                break;
            default:
                whereStr += " ";
                break;
        }
        switch (int.Parse(HiddenField8.Value))
        {
            case 0:
                whereStr += "";
                break;
            case 1:
                whereStr += " and (Xb='男' or Xb='不限') ";
                break;
            case 2:
                whereStr += " and (Xb='女' or Xb='不限') ";
                break;
            default:
                whereStr += "";
                break;
        }
        if (txt != null && txt != "")
        {
            whereStr = " and (Zhiwei like '%" + txt + "%' or f.Des like '%" + txt + "%' or c.GongName like '%" + txt + "%')";
        }

        new FirmInfoDal().BindPager1(Repeater2, AspNetPager1, whereStr);
    }

    public string zhaogongzuo()
    {
        string cssstr = "class=\"on\"";
        java.lang.StringBuilder str = new StringBuilder();
        int gxz = int.Parse(HiddenField6.Value);
        str.append(" <div class=\"row\">");
        str.append("                <span class=\"filterSpan\">薪资待遇：</span>");
        str.append("                <div class=\"aWrap\">");

        str.append("                <a " + (gxz == 0 ? cssstr : "") + " id=\"gxz0\"  href=\"javascript:setTypeGXZ('HiddenField6', '0');\">不限</a>");
        str.append("                <a " + (gxz == 1 ? cssstr : "") + " id=\"gxz1\"  href=\"javascript:setTypeGXZ('HiddenField6', '1');\">1000-1999</a>");
        str.append("                <a " + (gxz == 2 ? cssstr : "") + " id=\"gxz2\"  href=\"javascript:setTypeGXZ('HiddenField6', '2');\">2000-2999</a>");
        str.append("                <a " + (gxz == 3 ? cssstr : "") + " id=\"gxz3\"  href=\"javascript:setTypeGXZ('HiddenField6', '3');\">3000-4999</a>");
        str.append("                <a " + (gxz == 4 ? cssstr : "") + " id=\"gxz4\"  href=\"javascript:setTypeGXZ('HiddenField6', '4');\">5000以上</a>");
        str.append("                <a " + (gxz == 5 ? cssstr : "") + " id=\"gxz5\"  href=\"javascript:setTypeGXZ('HiddenField6', '5');\">面议</a>");
        str.append("                </div>");
        str.append("           </div>");
        str.append("           <div class=\"row\">");
        str.append("               <span class=\"filterSpan\">工作性质：</span>");
        str.append("               <div class=\"aWrap\">");
        int gxzhi = int.Parse(HiddenField7.Value);

        str.append("                <a  " + (gxzhi == 0 ? cssstr : "") + " id=\"gxzhi0\"  href=\"javascript:setTypeGXZHI('HiddenField7', '0');\">不限</a>");
        str.append("               <a  " + (gxzhi == 1 ? cssstr : "") + " id=\"gxzhi1\" href=\"javascript:setTypeGXZHI('HiddenField7', '1');\">全职</a>");
        str.append("               <a  " + (gxzhi == 2 ? cssstr : "") + " id=\"gxzhi2\" href=\"javascript:setTypeGXZHI('HiddenField7', '2');\">兼职</a>");
        str.append("               <a  " + (gxzhi == 3 ? cssstr : "") + " id=\"gxzhi3\"href=\"javascript:setTypeGXZHI('HiddenField7', '3');\">实习</a>");
        str.append("               </div>");
        str.append("           </div>");
        str.append("           <div class=\"row\">");
        str.append("               <span class=\"filterSpan\">性别要求：</span>");
        str.append("               <div class=\"aWrap\">");
        int gxb = int.Parse(HiddenField8.Value);

        str.append("              <a " + (gxb == 0 ? cssstr : "") + "  id=\"gxb0\"  href=\"javascript:setTypeGXB('HiddenField8', '0');\">不限</a>");
        str.append("              <a " + (gxb == 1 ? cssstr : "") + " id=\"gxb1\" href=\"javascript:setTypeGXB('HiddenField8', '1');\">男</a>");
        str.append("              <a " + (gxb == 2 ? cssstr : "") + " id=\"gxb2\" href=\"javascript:setTypeGXB('HiddenField8', '2');\">女</a>");
        str.append("               </div>");
        str.append("           </div>");

        return str.toString();
    }

}