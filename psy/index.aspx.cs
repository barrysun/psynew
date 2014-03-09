
using Dal;
using java.lang;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
 
    /// <summary>
    /// 六大板块
    /// 六大咨询板块
    /// </summary>
    /// <returns></returns>
    public string bindldbk()
    {
        DataTable dt = new ServiceDesDal().getListTopX();
        StringBuilder str = new StringBuilder();
        if(dt!=null&&dt.Rows.Count>0)
        {
        str.append(" <div class=\"tBoxW\">");
    	str.append("<div class=\"tBox borderC\">");
        str.append("	<h3 class=\"titComm bold14\"><span class=\"tit\">"+dt.Rows[0]["Title"]+"</span></h3>");
        str.append("    <div class=\"tbCont tbCont1\">");
        str.append("    	" + dt.Rows[0]["Des"]);
        str.append("    </div>");
        str.append("    <div class=\"tbBtn\"><a class=\"bold14\" href=\"" + dt.Rows[0]["InUrl"] + "\" target=\"_blank\" >详细了解</a></div>");
        str.append("</div>");
        str.append("<div class=\"tBox borderC\">");
        str.append("	<h3 class=\"titComm bold14\"><span class=\"tit\">" + dt.Rows[1]["Title"] + "</span></h3>");
        str.append("    <div class=\"tbCont tbCont2\">");
        str.append("    	" + dt.Rows[1]["Des"]);
        str.append("    </div>");
        str.append("    <div class=\"tbBtn\"><a class=\"bold14\" href=\"" + dt.Rows[1]["InUrl"] + "\" target=\"_blank\" >详细了解</a></div>");
        str.append("</div>");
        str.append("<div class=\"tBox borderC\">");
        str.append("	<h3 class=\"titComm bold14\"><span class=\"tit\">" + dt.Rows[2]["Title"] + "</span></h3>");
        str.append("    <div class=\"tbCont tbCont3\">");
        str.append("    	" + dt.Rows[2]["Des"]);
        str.append("    </div>");
        str.append("    <div class=\"tbBtn\"><a class=\"bold14\" href=\"" + dt.Rows[2]["InUrl"] + "\" target=\"_blank\" >详细了解</a></div>");
        str.append("</div>");
        str.append("<div class=\"tBox borderC\">");
        str.append("	<h3 class=\"titComm bold14\"><span class=\"tit\">" + dt.Rows[3]["Title"] + "</span></h3>");
        str.append("    <div class=\"tbCont tbCont4\">");
        str.append("    	" + dt.Rows[3]["Des"]);
        str.append("    </div>");
        str.append("    <div class=\"tbBtn\"><a class=\"bold14\" href=\"" + dt.Rows[3]["InUrl"] + "\" target=\"_blank\" >进入咨询</a></div>");
        str.append("</div>");
        str.append("<div class=\"tBox borderC\">");
        str.append("	<h3 class=\"titComm bold14\"><span  class=\"tit\">" + dt.Rows[4]["Title"] + "</span></h3>");
        str.append("    <div class=\"tbCont tbCont5\">");
        str.append("    	"+dt.Rows[4]["Des"]);
       str.append("     </div>");
       str.append("    <div class=\"tbBtn\"><a class=\"bold14\" href=\"" + dt.Rows[4]["InUrl"] + " \" target=\"_blank\" >进入服务</a></div>");
        str.append("</div>");
       str.append(" <div class=\"tBox borderC\">");
       str.append(" 	<h3 class=\"titComm bold14\"><span class=\"tit\">" + dt.Rows[5]["Title"] + "</span></h3>");
       str.append("     <div class=\"tbCont tbCont6\">");
       str.append("     	"+dt.Rows[5]["Des"]);
       str.append("     </div>");
       str.append("    <div class=\"tbBtn\"><a class=\"bold14\" href=\"" + dt.Rows[5]["InUrl"] + "\" target=\"_blank\" >进入服务</a></div>");
        str.append("</div>");
       str.append(" </div>");
        
        }
       
           

        return str.toString();
    }

    /// <summary>
    /// 绑定导航栏
    /// </summary>
    /// <returns></returns>
    public string bindnav()
    {
        return Nav.NavStr();
    }

    /// <summary>
    /// 新闻
    /// </summary>
    /// <returns></returns>
    public string bindNews()
    {
        DataTable dt = new NewsDal().getNewsHome(" limit 0,8");
        StringBuilder str = new StringBuilder();
        if (dt != null && dt.Rows.Count > 0)
        {
            DataTable dt2 = new NewsDal().getNewsHome(" where PICUrl is not null and PICUrl !=''  order by Id limit 0,2");

           str.append("<ul class=\"newList clearfix\">");
           str.append("     	<li class=\"newLi1\">");
           str.append("         	<a class=\"dyImg fl\" href=\"newsListDet.aspx?id=" + dt2.Rows[0]["Id"] + "\">");
           str.append("             	<img src=\"newpic/"+dt2.Rows[0]["PICUrl"]+"\" width=\"117\" height=\"75\" /> ");
           str.append("             </a>");
           str.append("             <div class=\"newDet fr\">");
           str.append("             	<a href=\"newsListDet.aspx?id=" + dt2.Rows[0]["Id"] + "\" class=\"newTit\">" + dt2.Rows[0]["NewTitle"] + "</a>");
           str.append("                 <div class=\"newInfo\">"+dt2.Rows[0]["NewContent"]+"</div>");
           str.append("             </div>");
           str.append("         </li>");
           str.append("         <li  class=\"newLi1\">");
           str.append("         	<a class=\"dyImg fl\" href=\"newsListDet.aspx?id=" + dt2.Rows[1]["Id"] + "\">");
           str.append("             	<img src=\"newpic/"+dt2.Rows[1]["PICUrl"]+"\" width=\"117\" height=\"75\" /> ");
           str.append("             </a>");
           str.append("             <div class=\"newDet fr\">");
           str.append("             	<a href=\"newsListDet.aspx?id=" + dt2.Rows[1]["Id"] + "\" class=\"newTit\">" + dt2.Rows[1]["NewTitle"] + "</a>");
           str.append("                 <div class=\"newInfo\">" + dt2.Rows[1]["NewContent"] + "</div>");
           str.append("             </div>");
           str.append("         </li>");

           for (int i = 0; i < dt.Rows.Count; i++)
           {
               string title=dt.Rows[i]["NewTitle"].ToString();

               str.append("         <li>");
               str.append("         	<a class=\"newTit2\" href=\"newsListDet.aspx?id="+dt.Rows[i]["Id"]+"\">"+(title.Length>=19?title.Substring(0,19):title)+"</a>");
               str.append("             <span class=\"times\">["+(dt.Rows[i]["EditTime"].ToString().Split(' ')[0])+"]</span>");
               str.append("         </li>");
           }

           str.append("     </ul>");
        }
        return str.toString();
    }
    /// <summary>
    /// 高考类
    /// </summary>
    /// <returns></returns>
    public string gkl()
    {
        StringBuilder str=new StringBuilder();
        str.append(" <dl class=\"dlBox\">");
        str.append("             <dt class=\"clearfix\">");
        str.append("                 <span class=\"fl\">高考志愿填报</span>");
        str.append("                <a class=\"fr\" href=\"newList.aspx?type=1\">more</a>");
        str.append("             </dt>");
        DataTable dt = new EntranceDal().getByWhereStr(" where ENTRANCETYPE=1 order by EDITTIME DESC limit 0,6 ");
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            str.append("             <dd class=\"clearfix\">");
            str.append("             	<a href=\"newsListDet.aspx?type=1&id=" + dt.Rows[i]["Id"] + "\">" + dt.Rows[i]["TITLE"] + "</a>");
            str.append("             </dd>");
        }
        str.append("         </dl>");
        str.append("         <dl class=\"dlBox\">");
        str.append("             <dt class=\"clearfix\">");
        str.append("                 <span class=\"fl\">心里减压</span>");
        str.append("                 <a class=\"fr\" href=\"newList.aspx?type=2\">more</a>");
        str.append("             </dt>");
        DataTable dt2 = new EntranceDal().getByWhereStr(" where ENTRANCETYPE=2 order by EDITTIME DESC limit 0,6 ");
        for (int i = 0; i < dt2.Rows.Count; i++)
        {
            str.append("             <dd class=\"clearfix\">");
            str.append("             	<a href=\"newsListDet.aspx?type=2&id=" + dt.Rows[i]["Id"] + "\">" + dt2.Rows[i]["TITLE"] + "</a>");
            str.append("             </dd>");
        }
        str.append("         </dl>");
        str.append("         <dl class=\"dlBox\">");
        str.append("             <dt class=\"clearfix\">");
        str.append("                 <span class=\"fl\">常用心理学</span>");
        str.append("                 <a class=\"fr\" href=\"newList.aspx?type=3\">more</a>");
        str.append("             </dt>");
        DataTable dt3 = new EntranceDal().getByWhereStr(" where ENTRANCETYPE=3 order by EDITTIME DESC limit 0,6 ");
        for (int i = 0; i < dt3.Rows.Count; i++)
        {
            str.append("             <dd class=\"clearfix\">");
            str.append("             	<a href=\"newsListDet.aspx?type=3&id=" + dt.Rows[i]["Id"] + "\">" + dt3.Rows[i]["TITLE"] + "</a>");
            str.append("              </dd>");
        }
        str.append("          </dl>");
        str.append("         <dl class=\"dlBox\">");
        str.append("             <dt class=\"clearfix\">");
        str.append("                 <span class=\"fl\">大学专业介绍</span>");
        str.append("                 <a class=\"fr\" href=\"specialty.aspx\">more</a>");
        str.append("             </dt>");
        DataTable dt4 = new ProfessionalDesDal().Query(" limit 0,6 ");
        for (int i = 0; i < dt4.Rows.Count; i++)
        {
            str.append("             <dd class=\"clearfix\">");
            str.append("             	<a href=\"specialty.aspx\">" + dt4.Rows[i]["TITLE3"] + "</a>");
            str.append("             </dd>");
        }

        //str.append("             <dd class=\"clearfix\">");
        //str.append("             	<a href=\"#\">高考志愿填报成功案例</a>");
        //str.append("             </dd>");
        //str.append("             <dd class=\"clearfix\">");
        //str.append("             	<a href=\"#\">高考志愿填报成功案例</a>");
        //str.append("             </dd>");
        //str.append("             <dd class=\"clearfix\">");
        //str.append("             	<a href=\"#\">高考志愿填报成功案例</a>");
        //str.append("             </dd>");
        //str.append("             <dd class=\"clearfix\">");
        //str.append("             	<a href=\"#\">高考志愿填报成功案例</a>");
        // str.append("            </dd>");
        //str.append("             <dd class=\"clearfix\">");
        //str.append("             	<a href=\"#\">高考志愿填报成功案例</a>");
        //str.append("             </dd>");
        str.append("         </dl>");
        return str.toString();
    }
    /// <summary>
    /// 社会职业类
    /// </summary>
    /// <returns></returns>
    public string shzyl()
    {
        StringBuilder str=new StringBuilder();
        str.append("<dl class=\"dlBox\">");
        str.append("            <dt class=\"clearfix\">");
        str.append("               <span class=\"fl\">应聘面试</span>");
        str.append("               <a class=\"fr\" href=\"newList.aspx?type=4\">more</a>");
        str.append("           </dt>");
        DataTable dt = new CommunityDal().getByWhereStr(" where community.TYPE=1 order by EDITTIME DESC limit 1,6 ");

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            str.append("          <dd class=\"clearfix\">");
            str.append("         	<a href=\"newsListDet.aspx?type=4&id="+dt.Rows[i]["Id"]+"\">"+dt.Rows[i]["TITLE"]+"</a>");
            str.append("         </dd>");
        }
       
     
        str.append("   </dl>");
        str.append("   <dl class=\"dlBox\">");
        str.append("       <dt class=\"clearfix\">");
        str.append("          <span class=\"fl\">职业介绍</span>");
        str.append("          <a class=\"fr\" href=\"newList.aspx?type=5\">more</a>");
        str.append("      </dt>");
        DataTable dt2 = new CommunityDal().getByWhereStr(" where community.TYPE=2 order by EDITTIME DESC limit 1,6");
        for (int i = 0; i < dt2.Rows.Count; i++)
        {
            str.append("      <dd class=\"clearfix\">");
            str.append("      	<a href=\"newsListDet.aspx?type=5&id=" + dt2.Rows[i]["Id"] + "\">" + dt2.Rows[i]["TITLE"] + "</a>");
            str.append("      </dd>");
        }
       
    
       str.append(" </dl>");
        return str.toString();
    }
    /// <summary>
    /// 招聘信息
    /// </summary>
    /// <returns></returns>
    public string zpxx()
    {
        StringBuilder str=new StringBuilder();

          str.append("<dd class=\"clearfix\">");
          str.append("              <a class=\"fl\" href=\"\">兼职暗访员</a>");
          str.append("              <a class=\"fr\" href=\"\">成都金控人力资源管理有限公司</a>");
          str.append("          </dd>");
          str.append("          <dd class=\"clearfix\">");
          str.append("              <a class=\"fl\" href=\"\">兼职暗访员</a>");
          str.append("              <a class=\"fr\" href=\"\">成都金控人力资源管理有限公司</a>");
          str.append("          </dd>");
          str.append("          <dd class=\"clearfix\">");
          str.append("              <a class=\"fl\" href=\"\">兼职暗访员</a>");
          str.append("               <a class=\"fr\" href=\"\">成都金控人力资源管理有限公司</a>");
          str.append("          </dd>");
          str.append("          <dd class=\"clearfix\">");
          str.append("              <a class=\"fl\" href=\"\">兼职暗访员</a>");
          str.append("              <a class=\"fr\" href=\"\">成都金控人力资源管理有限公司</a>");
          str.append("          </dd>");
          str.append("          <dd class=\"clearfix\">");
          str.append("              <a class=\"fl\" href=\"\">兼职暗访员</a>");
          str.append("              <a class=\"fr\" href=\"\">成都金控人力资源管理有限公司</a>");
          str.append("          </dd>");
          str.append("          <dd class=\"clearfix\">");
          str.append("              <a class=\"fl\" href=\"\">兼职暗访员</a>");
          str.append("              <a class=\"fr\" href=\"\">成都金控人力资源管理有限公司</a>");
          str.append("          </dd>");
          str.append("          <dd class=\"clearfix\">");
          str.append("              <a class=\"fl\" href=\"\">兼职暗访员</a>");
          str.append("              <a class=\"fr\" href=\"\">成都金控人力资源管理有限公司</a>");
          str.append("          </dd>");
        return str.toString();
    }
    /// <summary>
    /// 求职信息
    /// </summary>
    /// <returns></returns>
    public string qzxx()
    {
        StringBuilder str=new StringBuilder();
         str.append("<dd class=\"ddJob clearfix\">");
         str.append("              <a href=\"talentList.aspx\" class=\"cf\">");
          str.append("                <img src=\"images/9.jpg\">");
          str.append("                <span class=\"pName\">张三</span>");
          str.append("                <span>金融管理</span>");
          str.append("              </a>");
          str.append("          </dd>");
          str.append("          <dd class=\"ddJob clearfix\">");
          str.append("              <a href=\"talentList.aspx\" class=\"cf\">");
          str.append("                <img src=\"images/9.jpg\">");
          str.append("                <span class=\"pName\">张三</span>");
          str.append("                <span>金融管理</span>");
          str.append("              </a>");
          str.append("          </dd>");
          str.append("          <dd class=\"ddJob clearfix\">");
          str.append("              <a href=\"talentList.aspx\" class=\"cf\">");
          str.append("                <img src=\"images/9.jpg\">");
          str.append("                <span class=\"pName\">张三</span>");
          str.append("                <span>金融管理</span>");
          str.append("              </a>");
          str.append("          </dd>");
        return str.toString();
    }
    /// <summary>
    /// 专家团队
    /// </summary>
    /// <returns></returns>
    public string zjtd()
    {
        StringBuilder str=new StringBuilder();
        DataTable dt = new ExpertDal().getByWhereStr(" order by expert.order limit 0,3 ");
        for (int i = 0; i < 3; i++)
        {
            str.append("<li class=\"clearfix\">");
            str.append("            	<div class=\"expertImg fl\">");
            str.append("                    <a href=\"exportList.aspx\">");
            str.append("                        <img src=\"\" />");
            str.append("                    </a>");
            str.append("                </div>");
            str.append("                <div class=\"expertInfo fr\">");
            str.append("                	<p class=\"exTit\"><a href=\"exportList.aspx\">" + dt.Rows[i]["EXPERTNAME"] + "</a></p>");
            str.append("                    <p class=\"exJob\">"+(int.Parse(dt.Rows[i]["TYPE"].ToString())==1?"易经专家":"心理学专家")+"</p>");
            str.append("                    <p>"+dt.Rows[i]["EXPERTDES"]+"</p>");
            str.append("                </div>");
            str.append("            </li>");
        }
        return str.toString();
    }

    /// <summary>
    /// 会员服务
    /// </summary>
    /// <returns></returns>
    public string hyfw()
    {
        StringBuilder str=new StringBuilder();
        str.append("<div class=\"\"></div>");
        str.append("        <ul class=\"vip\">");

     DataTable dt=  new EntranceDal().getByWhereStr( " where ENTRANCETYPE=6 limit 0,5");
     for (int i = 0; i < dt.Rows.Count; i++)
     {
         str.append("        	<li><a href=\"newsListDet.aspx?type=6&id="+dt.Rows[i]["Id"]+"\">"+dt.Rows[i]["TITLE"]+"</a></li>");
     }
        str.append("        </ul>");
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

                Session["Role"] = 2;
             
                Session["UserName"]= UserName;
                Session["Password"]= Password;
                Session["Id"]=dt.Rows[0]["Id"].ToString();
                //string st = str;
                Response.Redirect("myTest.aspx?Id="+dt.Rows[0]["Id"].ToString()+"&Role="+2);
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
       
    
}