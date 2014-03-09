<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="rensheng.aspx.cs" Inherits="myInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!--面包屑-->
<div class="curmbs">
	<span>您现在所在的位置：</span>

    <span>&gt;</span>
    <span>常见问题</span>
</div>
<div class="content clearfix">
<%--	<div class="leftNav fl">
    	<h3>人生路上</h3>
        <div class="lnList">
        	<a class="on" href="javascript:;">人生路上</a>
        </div>
        
    </div> --%> 
    <div class="rightMain" style="width:100%">
    	<ul class="studyTit clearfix">
            <li class="current"><a href="javascript:;">常见问题</a></li>
        </ul>
        <div class="rmCont">
        	
            <table class="resume" width="100%">
            	<tbody>
                	
                    
                </tbody>
            </table>
            <div class="btnW">
               <%-- <asp:Button ID="Button1" class="loginBtn" runat="server" Text="修改密码" OnClick="Button1_Click1"  /> --%>
            </div>
        </div>
    </div>
</div>
</asp:Content>

