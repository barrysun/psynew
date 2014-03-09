<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="myReport2.aspx.cs" Inherits="myReport2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div class="curmbs">
	<span>您现在所在的位置：</span>
  
    <span>&gt;</span>
    <span>择业测评</span>
</div>
   <div class="content clearfix">
	<div class="leftNav fl">
        <h3>第一步</h3>
        <div class="lnList">
        	<a href="xtxx.aspx">填写先天信息</a>
        </div>
    	<h3>第二步</h3>
        <div class="lnList">
        	<a href="javascript:window.open('Question.aspx');">点击测评</a>
        </div>
        <h3>第三步</h3>
        <div class="lnList">
        	<a href="myInfo.aspx">完备个人信息</a>
        </div>
        <h3>第四步</h3>
        <div class="lnList">
        	<a href="myPay.aspx">报告购买</a>
        </div>

        <h3>第五步</h3>
        <div class="lnList">
        	<a href="myReport1.aspx">测评报告（免费）</a>
        </div>
        <div class="lnList">
        	<a href="myReport2.aspx">预测报告（需购买）</a>
        </div>
        <div class="lnList">
        	<a href="myReport3.aspx">匹配报告（需购买）</a>
        </div>
    </div>   
    <div class="rightMain rightMain1 fr"  onselectstart="return false">
    	<ul class="studyTit clearfix">
            <li class="current"><a href="javascript:;">预测报告</a></li>
        </ul>
        
        	
        <div class="rmCont">
        	<h3 class="mtTit bold16">领航人生预测报告</h3>
            <div class="mtCont">
            	<ul class="proInfo">
                	<li><span class="piLeft">-用 &nbsp;户 &nbsp;名：</span><span><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></span></li>
                    <li><span class="piLeft">-性 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 别：</span><span><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></span></li>
                    <li><span class="piLeft">-出生时间：</span><span><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></span></li>
                    <li><span class="piLeft">-测评时间：</span><span><asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></span></li>
                </ul>
                <div class="detCont">
                         <%=ReportView() %>
                </div>
             
                
            </div>
        </div>
      
    </div>
</div>
</asp:Content>

