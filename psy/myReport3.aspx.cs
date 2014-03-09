using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class myReport3 : System.Web.UI.Page
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
        //string sql = "select * from nuser where Id=" + Session["Id"];
        //string s=new MySQLHelper().GetDataTable(sql).Rows[0]["McCount"].ToString();
        //if (!(s != null&&s.ToString()!=""&&int.Parse(s)>0
        //    ))
        //{
        //    Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('你没有购买该服务请联系管理员！亲');window.location='myTest.aspx'; </script>");
        //    // Response.Redirect("myTest.aspx");
        //    return;
        //}
       DataTable dt= new RepostDal().Query(int.Parse(Session["Id"].ToString()));
       Repeater1.DataSource = dt;
       Repeater1.DataBind();

    
    }

    /// <summary>
    /// 匹配
    /// 1.首先判断是否有次数可用，如果没有则提示没有次数
    /// 2.如果有次数可以使用，查看是否匹配过，
    /// 3.如果匹配过则提示不能再次匹配
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button1_Click(object sender, EventArgs e)
    {
        string sql = "select * from nuser where Id=" + Session["Id"];
        int s = int.Parse(new MySQLHelper().GetDataTable(sql).Rows[0]["McCount"].ToString());
        if (s == 0) {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("", "你的匹配次数已经用完，请联系管理员，亲！"));
            return;
        }
        string title = TextBox1.Text.Trim();
        JobViewDal jbv = new JobViewDal();
        DataTable dt = jbv.getJobIdByTitle(title);
        if (dt != null && dt.Rows.Count > 0)
        {
            int jobid = int.Parse(dt.Rows[0]["JOBID"].ToString().Trim());
            new Calculate().MatchResult(int.Parse(Session["Id"].ToString()),jobid+"");
            bind();
            new MySQLHelper().ExecuteSql("update nuser set McCount=" + (s - 1) + " where Id=" + Session["Id"]);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("完成操作", "匹配成功！你还有" + (s - 1) + "次匹配机会！"));
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "" + new Dialog().Message("完成操作", "没有你填的专业"));
        }
    }

    public string jobview()
    { 
        StringBuilder str=new StringBuilder();

        StringBuilder str1 = new StringBuilder();
        JobViewDal jbv1 = new JobViewDal();
        DataTable dt = jbv1.getbyNode(0);
        str.Append("<div class=\"oneMenu\">");
        for (int i = 0; i < dt.Rows.Count; i++)
        {
           
            str1.Append("<div class=\"a" + (i + 1) + "\">");
            if (i == 0)
            {
                str.Append("<a class=\"on\" id=\"a" + (i + 1) + "\" href=\"#\">" + dt.Rows[i]["TITLE"] + "</a>");
                DataTable dt2 = jbv1.getbyNode(int.Parse(dt.Rows[i]["JOBID"].ToString()));
                for (int j = 0; j < dt2.Rows.Count; j++)
                {
                    str1.Append("        <a id=\"a" + (i + 1) + "_" + (j + 1) + "\" href=\"#\">" + dt2.Rows[j]["TITLE"] + "</a>");
                }
            }
            else
            {
                str.Append("<a  id=\"a" + (i + 1) + "\" href=\"#\">" + dt.Rows[i]["TITLE"] + "</a>");
                DataTable dt2 = jbv1.getbyNode(int.Parse(dt.Rows[i]["JOBID"].ToString()));
                for (int j = 0; j < dt2.Rows.Count; j++)
                {
                    str1.Append("        <a id=\"a"+(i+1)+"_"+(j+1)+"\" href=\"#\">"+dt2.Rows[j]["TITLE"]+"</a>");
                }
            
            }
            str1.Append("</div>");
        }
        str.Append(" </div>");


  
    str.Append("<div class=\"threeMenu\">");
    str.Append(str1);

    str.Append("</div>");

    return str.ToString();
    
    }
}