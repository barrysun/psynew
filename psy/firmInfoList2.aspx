<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="firmInfoList2.aspx.cs" Inherits="firmInfo" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/base.css" rel="stylesheet" type="text/css" />
<link href="css/global.css" rel="stylesheet" type="text/css" />
<link href="css/infoManage.css" rel="stylesheet" type="text/css" />
<link href="css/sidebar.css" rel="stylesheet" type="text/css" />
    <script language="javascript" type="text/javascript" src="My97DatePicker/WdatePicker.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!--面包屑-->
<div class="curmbs">
	<span>您现在所在的位置：</span>
    <a href="index.html">首页</a>
    <span>&gt;</span>
    <span>企业信息管理</span>
</div>
<div class="content clearfix">
	<div class="leftNav fl">
    	<h3>招聘管理</h3>
        <div class="lnList">
        	<a  href="firmInfo.aspx">企业招聘需求发布</a>
        </div>
       
         <div class="lnList">
        	<a   href="firmInfoList.aspx">我发布的招聘信息</a>
        </div>
        <div  class="lnList">
        	<a class="on" href="firmInfoList2.aspx">我收到的简历</a>
        </div>
        <div class="lnList">
        	<a href="firmInfoList3.aspx">我发送的邀请函</a>
        </div>
    </div>  
      <div class="rightMain fr">
    	<ul class="studyTit clearfix">
            <li class="current"><a href="javascript:;">我收到的简历</a></li>
        </ul>
        <div class="rmCont">
        	<table class="resumeList" width="100%">
            	<thead>
                	<tr>
                    	<th>职位名称</th>
                        <th>求职者</th>
                        <th>投递简历时间</th>
                        <th>操作</th>
                    </tr>
                </thead>
                <asp:Repeater ID="Repeater1" runat="server">

                    <ItemTemplate>
                        <tr>
                        <td ><a class="unline" href="#"><%#Eval("Zhiwei") %></a></td>
                    	<td ><a class="unline" href="#"><%#Eval("Zhiwei") %></a></td>
                        <td><%#Eval("StartTime") %></td>
                        <td>
                            <asp:LinkButton CssClass="oprate" CommandName='<%#Eval("Id") %>' OnCommand="LinkButton1_Command" ID="LinkButton1" runat="server">修改</asp:LinkButton>
                            <asp:LinkButton CssClass="oprate" CommandName='<%#Eval("Id") %>' OnCommand="LinkButton2_Command" ID="LinkButton2" runat="server">删除</asp:LinkButton>
                        </td>
                    </tr>

                    </ItemTemplate>
                </asp:Repeater>
                
                   
                
               
            </table>
             <webdiyer:AspNetPager ID="AspNetPager1" FirstPageText="首页" PrevPageText="上一页" NextPageText="下一页" LastPageText="尾页" runat="server" OnPageChanged="AspNetPager1_PageChanged" PageSize="15"></webdiyer:AspNetPager>
        </div>
    </div>
</div>
</asp:Content>

