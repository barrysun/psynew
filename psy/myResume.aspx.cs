using Dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class myResume : System.Web.UI.Page
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
        DataTable dt = new JobsDal().Query(" where UserId="+Session["Id"].ToString());
        Repeater1.DataSource = dt;
        Repeater1.DataBind();


    
    }
}