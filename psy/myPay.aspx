<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="myPay.aspx.cs" Inherits="myPay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
      <link href="css/base.css" rel="stylesheet" type="text/css" />
<link href="css/global.css" rel="stylesheet" type="text/css" />
<link href="css/myPay.css" rel="stylesheet" type="text/css" />
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
    	<h3>我的产品服务</h3>
        <div class="lnList">
        	<a class="on" href="javascript:;">产品服务列表</a>
        </div>
        <div class="lnList">
        	<a href="myPay1.aspx">我的购物车</a>
        </div>
        <div class="lnList">
        	<a href="myPay2.aspx">已购买的服务</a>
        </div>
    </div>  
    <div class="rightMain fr">
    	<ul class="studyTit clearfix">
            <li class="current"><a href="javascript:;">产品服务列表</a></li>
        </ul>
        <div class="rmCont">
           
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                <dl class="productList">
            	<dt><%#Eval("CHANPING") %></dt>
                <dd><%#Eval("DES") %></dd>
                <dd class="proBtn">
                    <asp:LinkButton ID="LinkButton1" CssClass="proBtn1" OnCommand="LinkButton1_Command" CommandName='<%#Eval("Id") %>' runat="server">加入购物车</asp:LinkButton>
                </dd>
               </dl>
                </ItemTemplate>
            </asp:Repeater>
        	
        </div>
    </div>
</div>
</asp:Content>

