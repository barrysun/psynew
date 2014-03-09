<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="mima.aspx.cs" Inherits="myInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!--面包屑-->
<div class="curmbs">
	<span>您现在所在的位置：</span>

    <span>&gt;</span>
    <span>账户管理</span>
</div>
<div class="content clearfix">
	<div class="leftNav fl">
    	<h3>登陆账户管理</h3>
        <div class="lnList">
        	<a class="on" href="javascript:;">密码管理</a>
        </div>
        
    </div>  
    <div class="rightMain fr">
    	<ul class="studyTit clearfix">
            <li class="current"><a href="javascript:;">密码管理</a></li>
        </ul>
        <div class="rmCont">
        	
            <table class="resume" width="100%">
            	<tbody>
                	<tr>
                    	<td class="col1"><span class="require">*</span>输入新密码：</td><td><asp:TextBox ID="TextBox1" CssClass="ipt" runat="server"></asp:TextBox></td>
                      
                    </tr>
                    <tr>
                    	<td class="col1"><span class="require">*</span>确认密码：</td><td><asp:TextBox ID="TextBox2" CssClass="ipt" runat="server"></asp:TextBox></td>
                        
                        
                    </tr>
                    
                </tbody>
            </table>
            <div class="btnW">
                <asp:Button ID="Button1" class="loginBtn" runat="server" Text="修改密码" OnClick="Button1_Click1"  /> 
            </div>
        </div>
    </div>
</div>
</asp:Content>

