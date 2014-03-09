<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="myPay2.aspx.cs" Inherits="myPay2" %>

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
        	<a href="myPay.aspx">产品服务列表</a>
        </div>
        <div class="lnList">
        	<a href="myPay1.aspx">我的购物车</a>
        </div>
        <div class="lnList">
        	<a class="on" href="javascript:;">已购买的服务</a>
        </div>
    </div>  
    <div class="rightMain fr">
    	<ul class="studyTit clearfix">
            <li class="current"><a href="javascript:;">已购买的服务</a></li>
        </ul>
        <div class="rmCont">
           
        	<h4 class="bold14 shopTit">您的服务购买记录</h4>
            <table class="myShop myShop2" width="100%">
            	<thead>
                	<tr>
                    	<th class="col1">订单编号</th>
                        <th class="col2">服务名称</th>
                        <th class="col3">服务内容</th>
                        <th class="col4">数量</th>
                        <th class="col5">订单时间</th>
                        <th class="col6">本服务实付款</th>
                        <th class="col7">付款情况</th>
                         <th class="col8">服务使用情况</th>
                    </tr>
                </thead>
                <tbody>
                      <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                    <tr>
                    	<td class="col1">1</td>
                        <td class="col2"><%#Eval("CHANPING") %></td>
                        <td class="col3"><%#Eval("DES") %></td>
                        <td class="col4"><%#Eval("ChangPingCount") %></td>
                        <td class="col5"><%#Eval("ShoppingTime") %></td>
                        <td class="col6"><%#Eval("Money") %>元</td>
                        <td class="col7"><%#Eval("pay") %></td>
                        <td class="col8"><%#Eval("UserPay")%></td>
                        
                    </tr>
                        </ItemTemplate>

                    </asp:Repeater>

                	
                   
                </tbody>
            </table>
        </div>
    </div>
</div>
</asp:Content>

