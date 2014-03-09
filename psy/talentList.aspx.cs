using Dal;
using java.lang;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class talentList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bindRepert1();
            bindRepert2();
        }

    }

    public string bindnav()
    {
        return Nav.NavStr();
    }

    public void bindRepert1()
    {
        string whereStr = " where 1=1 ";
        string txt = TextBox3.Text;
        switch (int.Parse(HiddenField1.Value))//期望薪资
        {
            case 0:
                //不限制
                whereStr += " ";
                break;
            case 1:
                //1000-2000
                whereStr += " and QiWangXinZi='1000~2000元/月' ";
                break;
            case 2:
                //2000-3000
                whereStr += " and QiWangXinZi='2000~3000元/月' ";
                break;
            case 3: 
                //3000-5000
                whereStr += " and QiWangXinZi='3000~5000元/月' ";
                break;
            case 4: 
                //5000-
                whereStr += " and (QiWangXinZi='5000~10000元/月' or QiWangXinZi='10000以上元/月' ) ";
                break;
            case 5:
                //面议
                whereStr += " and QiWangXinZi='面议' ";
                break;

            default: break;
        }
        switch (int.Parse(HiddenField2.Value))//工作性质
        {
            case 0:
                //不限
                whereStr += "";
                break;
            case 1: 
                //全职
                whereStr += " and QiWangGangWeiXinzhi='全职' ";
                break;
            case 2:
                //兼职
                whereStr += " and QiWangGangWeiXinzhi='兼职' ";
                break;
            case 3:
                whereStr += " and QiWangGangWeiXinzhi='实习' ";
                //实习
                break;
            default:

                break ;
        }

        switch (int.Parse(HiddenField3.Value))//最高学历
        { 
            case 0:
                //不限
                
                break;
            case 1:
                //中专
                whereStr += " and Xl='中专' ";
                break;
            case 2:
                //职高
                whereStr += " and ( Xl='中技') ";
                break;
            case 3:
                //高中
                whereStr += " and Xl='高中' ";
                break;
            case 4:
                //大专
                whereStr += " and Xl='大专' ";
                break;
            case 5:
                //本科
                whereStr += " and Xl='本科' ";
                break;
            case 6:
                //硕士以上
                whereStr += " and (Xl='本科' or Xl='博士' or Xl='博士后')  ";
                break;
            default:
                    break;
        }
        switch (int.Parse(HiddenField4.Value))//工作经验
        {
            case 0:
                //不限制
                break;
            case 1: 
                //在校生
                whereStr += " and Jy='应届毕业生' ";
                break;
            case 2:
                whereStr += " and Jy='应届毕业生' ";
                //应届毕业生
                break;
            case 3:
                whereStr += " and (Jy='1年以下' or Jy='1-3年') ";
                //1-2年
                break;
            case 4:
                //3-5年
                whereStr += " and Jy='3-5年' ";
                break;
                //5年以上
             
            case 5:
                whereStr += " and (Jy='5-10年' or Jy='10年以上') ";
                break;
            default:
                
                break;

        }
        switch (int.Parse(HiddenField5.Value))//目前状态
        {
            case 0:
                //不限制
                whereStr += "";
                break;
            case 1: 
                //目前我正在找工作
                whereStr += "and (ZhuangTai='我目前处于离职状态,可立即上岗' or ZhuangTai='应届毕业生') ";
                break;
            case 2: 
                //我暂时不想工作
                whereStr += "and ZhuangTai='目前暂无跳槽打算' ";
                break;
            case 3:
                //在职，暂时不想找工作
                whereStr += "and ZhuangTai='目前暂无跳槽打算' ";
                break;
            case 4:
                //在职，如果有好工作可以考虑
                whereStr += "and ZhuangTai='我对现有工作还算满意,如有更好的工作' ";
                break;
            case 5: break;
        }
        if (txt != null && txt != "")
        {
            whereStr += " and (TeChang like '%" + txt + "%' or JiaoYu like '%" + txt + "%' or HuiJiang like '%" + txt + "%' or Zhengshu like '%" + txt + "%' or PeiXun like '%"+txt+"%' or GongZuoJinli like '%"+txt+"%' or GerenNengLi like '"+txt+"' or GongZuoGangWei like '%"+txt+"%' or QiWangGangwei like '%"+txt+"%' or RealName like '%"+txt+"%' or JianLiName like '%"+txt+"%' ) ";
        }
        new JobsDal().BindPager(Repeater1, AspNetPager1, whereStr);
    }

    public void bindRepert2()
    {
        string whereStr = " ";
        string txt = TextBox4.Text;
        switch(int.Parse(HiddenField6.Value))
        {
            case 0:
                //不限
                whereStr+="";

                break;
            case 1:
                //1000-2000
                 whereStr+=" and f.Gzfw='1000~2000元/月' ";
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
                whereStr+="";
                break;
        }
        switch(int.Parse(HiddenField7.Value))
        {
            case 0:
                //不限
                whereStr+="";
                break;
            case 1:
                //全职
                whereStr+=" and f.GongzuoXinzhi='全职' ";
                break;
            case 2:
                //兼职
                 whereStr+=" and f.GongzuoXinzhi='兼职' ";
                break;
            case 3:
                //实习
                whereStr+=" and f.GongzuoXinzhi='实习' ";
                break;
            default:
                whereStr+=" ";
                break;
        }
        switch(int.Parse(HiddenField8.Value))
        {
            case 0:
                whereStr+="";
                break;
            case 1:
                whereStr += " and (Xb='男' or Xb='不限') ";
                break;
            case 2:
                whereStr += " and (Xb='女' or Xb='不限') ";
                break;
            default:
                whereStr+="";
                break;
        }
        if (txt != null && txt != "")
        {
            whereStr = " and (Zhiwei like '%" + txt + "%' or f.Des like '%" + txt + "%' or c.GongName like '%"+txt+"%')";
        }

        new FirmInfoDal().BindPager1(Repeater2, AspNetPager1, whereStr);
    }

    public string bindHeader()
    {
        string cssstr = "class=\"current\"";
        int divn=int.Parse(HiddenField9.Value);
        StringBuilder str = new StringBuilder();
         str.append("<li "+(divn==0?cssstr:"")+" onclick=\"javascript:setDiv('HiddenField9','0');\"><a href=\"javascript:;\">找人才</a></li>");
         str.append("  <li " + (divn == 1 ? cssstr : "") + " onclick=\"javascript:setDiv('HiddenField9','1');\"><a href=\"javascript:;\">找工作</a></li>");
         return str.toString();
    }

    public string divHide(string n)
    { 
      return int.Parse(n)==int.Parse(HiddenField9.Value.Trim()) ? "class=\"hide\"":"";
    }


    public string zhaogongzuo()
    {
        string cssstr = "class=\"on\"";
        StringBuilder str = new StringBuilder();
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


    public string tiaojian()
    {

        StringBuilder str = new StringBuilder();
        string cssstr = "class=\"on\"";

        str.append("             <div class=\"row\">");
        str.append("                 <span class=\"filterSpan\">薪资范围：</span>");
         str.append("                <div class=\"aWrap\">");
         int xz = int.Parse(HiddenField1.Value);
         str.append("                    <a " + (xz == 0 ? cssstr : "") + " id=\"xz0\" href=\"javascript:setType('HiddenField1', '0');\">不限</a>");
         str.append("                    <a " + (xz == 1 ? cssstr : "") + " id=\"xz1\" href=\"javascript:setType('HiddenField1', '1');\">1000-1999</a>");
         str.append("                    <a " + (xz == 2 ? cssstr : "") + " id=\"xz2\" href=\"javascript:setType('HiddenField1', '2');\">2000-2999</a>");
         str.append("                    <a " + (xz == 3 ? cssstr : "") + " id=\"xz3\" href=\"javascript:setType('HiddenField1', '3');\">3000-4999</a>");
         str.append("                    <a " + (xz == 4 ? cssstr : "") + " id=\"xz4\" href=\"javascript:setType('HiddenField1', '4');\">5000以上</a>");
         str.append("                    <a " + (xz == 5 ? cssstr : "") + " id=\"xz5\" href=\"javascript:setType('HiddenField1', '5');\">面议</a>");
        str.append("                 </div>");
        str.append("             </div>");
        str.append("             <div class=\"row\">");
        str.append("                 <span class=\"filterSpan\">工作性质：</span>");
        int xzhi = int.Parse(HiddenField2.Value);
        str.append("                 <div class=\"aWrap\">");
        str.append("                     <a " + (xzhi == 0 ? cssstr : "") + " id=\"xzhi0\"   href=\"javascript:setTypeXZ('HiddenField2', '0');\">不限</a>");
        str.append("                     <a " + (xzhi == 1 ? cssstr : "") + "   id=\"xzhi1\" href=\"javascript:setTypeXZ('HiddenField2', '1');\" >全职</a>");
        str.append("                     <a " + (xzhi == 2 ? cssstr : "") + "  id=\"xzhi2\" href=\"javascript:setTypeXZ('HiddenField2', '2');\" >兼职</a>");
        str.append("                     <a " + (xzhi == 3 ? cssstr : "") + "   id=\"xzhi3\" href=\"javascript:setTypeXZ('HiddenField2', '3');\" >实习</a>");
        str.append("                 </div>");
        str.append("             </div>");
        str.append("             <div class=\"row\">");
        str.append("                 <span class=\"filterSpan\">最高学历：</span>");
       str.append("                  <div class=\"aWrap\">");
       int xl = int.Parse(HiddenField3.Value);
       str.append("                 <a " + (xl == 0 ? cssstr : "") + " id=\"xl0\"  href=\"javascript:setTypeXL('HiddenField3', '0');\" >不限</a>");
       str.append("                 <a " + (xl == 1 ? cssstr : "") + " id=\"xl1\"  href=\"javascript:setTypeXL('HiddenField3', '1');\">中专</a>");
       str.append("                 <a " + (xl == 2 ? cssstr : "") + " id=\"xl2\"  href=\"javascript:setTypeXL('HiddenField3', '2');\">职高</a>");
       str.append("                 <a " + (xl == 3 ? cssstr : "") + " id=\"xl3\"  href=\"javascript:setTypeXL('HiddenField3', '3');\">高中</a>");
       str.append("                 <a " + (xl == 4 ? cssstr : "") + " id=\"xl4\"  href=\"javascript:setTypeXL('HiddenField3', '4');\">大专</a>");
       str.append("                  <a " + (xl == 5 ? cssstr : "") + " id=\"xl5\"  href=\"javascript:setTypeXL('HiddenField3', '5');\">本科</a>");
       str.append("                  <a " + (xl == 6 ? cssstr : "") + " id=\"xl6\"  href=\"javascript:setTypeXL('HiddenField3', '6');\">硕士以上</a>");
      str.append("                   </div>");
       str.append("              </div>");
       str.append("              <div class=\"row\">");
       str.append("                  <span class=\"filterSpan\">工作经验：</span>");
       int jy = int.Parse(HiddenField4.Value);

      str.append("                   <div class=\"aWrap\">");
      str.append("                   <a " + (jy == 0 ? cssstr : "") + " id=\"jy0\"  href=\"javascript:setTypeJY('HiddenField4', '0');\">不限</a>");
      str.append("                   <a " + (jy == 1 ? cssstr : "") + "  id=\"jy1\"  href=\"javascript:setTypeJY('HiddenField4', '1');\">在校学生</a>");
      str.append("                   <a " + (jy == 2 ? cssstr : "") + "  id=\"jy2\"  href=\"javascript:setTypeJY('HiddenField4', '2');\">应届毕业生</a>");
      str.append("                   <a " + (jy == 3 ? cssstr : "") + "  id=\"jy3\"  href=\"javascript:setTypeJY('HiddenField4', '3');\">1-2年</a>");
      str.append("                   <a " + (jy == 4 ? cssstr : "") + "  id=\"jy4\"  href=\"javascript:setTypeJY('HiddenField4', '4');\">3-5年</a>");
      str.append("                   <a " + (jy == 5 ? cssstr : "") + "  id=\"jy5\"  href=\"javascript:setTypeJY('HiddenField4', '5');\">5年以上</a>");
      str.append("                   </div>");
      str.append("               </div>");
      str.append("               <div class=\"row\">");
      str.append("                   <span class=\"filterSpan\">目前状态：</span>");
     str.append("                    <div class=\"aWrap\">");
     int zt = int.Parse(HiddenField5.Value);
     str.append("                     <a " + (zt == 0 ? cssstr : "") + "  id=\"zt0\"   href=\"javascript:setTypeZT('HiddenField5', '0');\">不限</a>");
     str.append("                    <a " + (zt == 1 ? cssstr : "") + " id=\"zt1\"   href=\"javascript:setTypeZT('HiddenField5', '1');\">目前我正在找工作</a>");
     str.append("                    <a " + (zt == 2 ? cssstr : "") + " id=\"zt2\"   href=\"javascript:setTypeZT('HiddenField5', '2');\">我暂时不想工作</a>");
     str.append("                    <a " + (zt == 3 ? cssstr : "") + " id=\"zt3\"   href=\"javascript:setTypeZT('HiddenField5', '3');\">在职，暂时不想找工作</a>");
     str.append("                    <a " + (zt == 4 ? cssstr : "") + " id=\"zt4\"  href=\"javascript:setTypeZT('HiddenField5', '4');\">在职，如果有好工作可以考虑</a>");
     str.append("                    </div>");
     str.append("                </div>");
        return str.toString();
    }

    /// <summary>
    /// 快速登陆
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button1_Click(object sender, EventArgs e)
    {
        string UserName = TextBox1.Text;
        string Password = TextBox2.Text;
        //  int role = 0;//1是企业
        //2是个人用户

        DataTable dt = new NUserDal().Login(UserName, Password);
        if (dt != null && dt.Rows.Count == 1)
        {

            Session["Role"] = 2 + "";
            Session["UserName"] = UserName;
            Session["Password"] = Password;
            Session["Id"] = dt.Rows[0]["Id"].ToString();
            Response.Redirect("myTest.aspx");
        }

        DataTable dt2 = new CompanyDal().Login(UserName, Password);
        if (dt2 != null && dt2.Rows.Count == 1)
        {

            Session["Role"] = 1 + "";
            Session["UserName"] = UserName;
            Session["Password"] = Password;
            Session["Id"] = dt2.Rows[0]["Id"].ToString();
            Response.Redirect("firmInfo.aspx");
        }
        Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("", "登陆失败，请检查用户名密码是否有误！", "error"));

    }

    /// <summary>
    /// 查询 找人才
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button2_Click(object sender, EventArgs e)
    {
        bindRepert1();
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
    /// <summary>
    /// 分页
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {

    }
    /// <summary>
    /// 分页 找人才
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void AspNetPager2_PageChanged(object sender, EventArgs e)
    {

    }
}