<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="myPay1.aspx.cs" Inherits="myPay1" %>

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
        	<a class="on" href="javascript:;">我的购物车</a>
        </div>
        <div class="lnList">
        	<a href="myPay2.aspx">已购买的服务</a>
        </div>
    </div>  
    <div class="rightMain fr">
    	<ul class="studyTit clearfix">
            <li class="current"><a href="javascript:;">我的购物车</a></li>
        </ul>
        <div class="rmCont">
        	<h4 class="bold14 shopTit">孙某某的购物车</h4>
            <table class="myShop myShop1" width="100%">
            	<thead>
                	<tr>
                    	<th class="col1">服务名称</th>
                        <th class="col2">单价</th>
                        <th class="col3">数量</th>
                        <th class="col4">优惠方式</th>
                        <th class="col5">小计</th>
                      <%--  <th class="col6">服务内容</th>--%>
                        <th class="col6">操作</th>
                    </tr>
                </thead>
                <tbody>

                    <asp:Repeater ID="Repeater1" runat="server" OnDataBinding="Repeater1_DataBinding" OnItemDataBound="Repeater1_ItemDataBound">
                        <ItemTemplate>
                      <tr>
                    	<td class="col1"><%#Eval("CHANPING") %></td>
                        <td class="col2"><%#Eval("Unitprice") %>元</td>
                        <td class="col3">
                            <asp:TextBox ID="TextBox1" AutoPostBack="true" Width="40px" runat="server" OnTextChanged="TextBox1_TextChanged" Text="1"></asp:TextBox></td>
                        <td class="col4">
                            <asp:DropDownList ID="DropDownList1" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true" runat="server"></asp:DropDownList>
                        </td>
                        <td class="col5"><asp:Label ID="Label2" runat="server" Text='<%#Eval("Unitprice") %>'></asp:Label>元</td>
                       <%-- <td class="col6"><span class="fixW"><%#Eval("DES") %></span></td>--%>
                        <td class="col6">
                            <asp:LinkButton ID="LinkButton1" CssClass="oprate" CommandName='<%#Eval("Id") %>' OnCommand="LinkButton1_Command" runat="server">删除</asp:LinkButton>
                        </td>
                    </tr>
                        </ItemTemplate>

                    </asp:Repeater>
                </tbody>
            </table>
            <div class="shopDiv">
            	<span>你的服务实付款合计：</span>
                <span class="money"><asp:Label ID="Label1" runat="server" Text=""></asp:Label>元</span>
            </div>
            <div class="shopDiv">
            	<span>请选择你要使用的付款方式：</span>
                <asp:DropDownList ID="DropDownList2"
                     runat="server">
                    <asp:ListItem Text="支付宝" Value="1"></asp:ListItem>
                     <asp:ListItem Text="其他" Value="2"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="btnW">
                <asp:Button ID="Button2" CssClass="loginBtn" runat="server" Text="提交" OnClick="Button2_Click" />
            </div>
        </div>
    </div>
</div>
</asp:Content>

