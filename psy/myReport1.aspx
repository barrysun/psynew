<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="myReport1.aspx.cs" Inherits="myReport1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/base.css" rel="stylesheet" type="text/css" />
<link href="css/global.css" rel="stylesheet" type="text/css" />
<link href="css/infoManage.css" rel="stylesheet" type="text/css" />
<link href="css/sidebar.css" rel="stylesheet" type="text/css" />
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
    <div class="rightMain rightMain1 fr" onselectstart="return false">
    	<ul class="studyTit clearfix">
            <li class="current"><a href="javascript:;">测评报告</a></li>
        </ul>
        <div class="rmCont">
        	<h3 class="mtTit bold16">领航人生测评报告</h3>
            <div class="mtCont">
            	<ul class="proInfo">
                	<li><span class="piLeft">-用 &nbsp;户 &nbsp;名：</span><span><asp:Label ID="Label1" runat="server" Text=""></asp:Label></span></li>
                    <li><span class="piLeft">-性 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 别：</span><span><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></span></li>
                    <li><span class="piLeft">-出生时间：</span><span><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></span></li>
                    <li><span class="piLeft">-测评时间：</span><span><asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></span></li>
                </ul>
                <h4 class="detTit bold14">前言</h4>
                <div class="detCont detCont1">
                	我们已经完成了对您的测试。这是一篇对您非常重要的报告。它详尽地描述了你的个性特质，你是什么样的一个人，你的兴趣点在哪里，以及你的价值观取向等等。这些特质将长久地、深远地影响你的人生。了解这些，对规划好你的人生，弥足珍贵，请认真阅读并理解它们。
                </div>
                 <%=reportView() %>
                <br />
                <h4 class="detTit bold14">结束语</h4>
                <div class="detCont detCont1">
                	以上是我们为你撰写的测评报告的全部内容。你的上述特质，将在相对较长的时间里，以相对稳定的状态影响你的学习、生活和职业选择。
                       当你在以后的学习生活中遇到难题时，不妨回来读一读它，或许会开卷有益。如果你希望进一步了解，你的个人特质最适合什么职业，请在完成付费程序后，读取你的职业预测报告。<a class="bold14" href="myReport2.aspx">点击查看预测报告</a>
                </div>
            </div>
        </div>
    </div>
</div>
</asp:Content>

