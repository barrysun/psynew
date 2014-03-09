<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="myJobs1.aspx.cs" Inherits="myJobs1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!--面包屑-->
<div class="curmbs">
	<span>您现在所在的位置：</span>
 
    <span>&gt;</span>
    <span>个人信息管理</span>
</div>
<div class="content clearfix">
	<div class="leftNav fl">
    	<h3>简历管理</h3>
        <div class="lnList">
        	<a class="on" href="javascript:;">创建新简历</a>
        </div>
        <div class="lnList">
        	<a href="myResume.aspx">简历管理</a>
        </div>
        <h3>求职管理</h3>
       
        <div class="lnList">
        	<a href="#">我申请过的职位</a>
        </div>
    </div>  
    <div class="rightMain fr">
    	<ul class="studyTit clearfix">
            <li class="current"><a href="javascript:;">我的简历</a></li>
        </ul>
        <div class="rmCont">
        <h4 class="step bold14">第二步 - 求职意向（带<span class="require">*</span>的为必填）</h4>
        <table class="resume">
        	<tbody>
                <tr>
                	<td class="col1"><span class="require">*</span>期望工作地区：</td>
                    <td class="col2"><%--<input class="ipt" type="text" />--%>
                        <asp:TextBox ID="TextBox1" CssClass="ipt" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                	<td class="col1"><span class="require">*</span>期望月薪：</td>
                    <td class="col2">
                    	  <asp:DropDownList ID="DropDownList3" runat="server">
                                <asp:ListItem Text="面议" Value="面议"></asp:ListItem>
                                <asp:ListItem Text="1000以下元/月" Value="1000以下元/月"></asp:ListItem>
                                <asp:ListItem Text="1000~2000元/月" Value="1000~2000元/月"></asp:ListItem>
                                <asp:ListItem Text="2000~3000元/月" Value="2000~3000元/月"></asp:ListItem>
                                <asp:ListItem Text="3000~5000元/月" Value="3000~5000元/月"></asp:ListItem>
                                <asp:ListItem Text="5000~10000元/月" Value="5000~10000元/月"></asp:ListItem>
                                <asp:ListItem Text="10000以上元/月" Value="10000以上元/月"></asp:ListItem>
                            </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                	<td class="col1"><span class="require">*</span>期望岗位性质：</td>
                    <td class="col2">
                    	<asp:DropDownList ID="DropDownList5" runat="server">
                                <asp:ListItem Value="全职" Text="全职"></asp:ListItem>
                                <asp:ListItem Value="兼职" Text="兼职"></asp:ListItem>
                                <asp:ListItem Value="实习" Text="实习"></asp:ListItem>
                                <asp:ListItem Value="应届生" Text="应届生"></asp:ListItem>
                            </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                	<td class="col1"><span class="require">*</span>期望从事的岗位：</td>
                    <td class="col2"><%--<input class="ipt" type="text" />--%>
                         <asp:TextBox ID="TextBox2" CssClass="ipt" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                	<td class="col1">最近工作过的职位：：</td>
                    <td class="col2"> <asp:TextBox ID="TextBox3" CssClass="ipt" runat="server"></asp:TextBox><span>无工作经验者可不填写</span></td>
                </tr>
                <tr>
                	<td class="col1"><span class="require">*</span>目前求职状态：</td>
                    <td class="col2">
                        <p>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                            <asp:ListItem Value="我目前处于离职状态,可立即上岗" Text="我目前处于离职状态,可立即上岗"></asp:ListItem>
                            <asp:ListItem Value="我目前在职,正考虑换个新环境" Text="我目前在职,正考虑换个新环境"></asp:ListItem>
                            <asp:ListItem Value="目前暂无跳槽打算" Text="目前暂无跳槽打算"></asp:ListItem>
                            <asp:ListItem Value="我对现有工作还算满意,如有更好的工作" Text="我对现有工作还算满意,如有更好的工作"></asp:ListItem>
                            <asp:ListItem Value="应届毕业生" Text="应届毕业生"></asp:ListItem>
                        </asp:RadioButtonList>
                    	</p>
                        
                    </td>
                </tr>
            </tbody>
        </table>
        <div class="btnW">
        	<%--<a href="#">保存并跳到下一步</a> 

            <a href="#">返回上一步</a>--%>
            <asp:Button ID="Button1" CssClass="loginBtn" runat="server" Text="下一步" OnClick="Button1_Click"></asp:Button>
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" CssClass="loginBtn"  runat="server" Text="上一步" OnClick="Button2_Click" />
        </div>
        </div>
    </div>
</div>
</asp:Content>

