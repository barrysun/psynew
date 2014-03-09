<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="myJobs4.aspx.cs" Inherits="myJobs4" %>

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
        <h4 class="step bold14">第五步-个人能力（带<span class="require">*</span>的为必填）</h4>
        <table class="resume">
        	<tbody>
                <tr>
                	<td class="col1 colTop"><span class="require">*</span>个人能力：</td>
                    <td class="col2">
                    	<%--<textarea></textarea>--%>
                        <asp:TextBox ID="TextBox1" runat="server" Height="124px" TextMode="MultiLine" Width="554px"></asp:TextBox>
                        <p>范例：</p>
                    </td>
                </tr>
            </tbody>
        </table>
        <div class="btnW">
        	<%--<a href="#">保存并跳到下一步</a> 
            <a href="#">返回上一步</a>--%>
                <asp:Button ID="Button1" CssClass="loginBtn" runat="server" Text="下一步" OnClick="Button1_Click" />&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" CssClass="loginBtn" runat="server" Text="上一步" OnClick="Button2_Click" />
       
        </div>
        </div>
    </div>
</div>
</asp:Content>

