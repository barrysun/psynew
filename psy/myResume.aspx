<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="myResume.aspx.cs" Inherits="myResume" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!--面包屑-->
<div class="curmbs">
	<span>您现在所在的位置：</span>
    <a href="index.html">首页</a>
    <span>&gt;</span>
    <span>个人信息管理</span>
</div>
<div class="content clearfix">
	<div class="leftNav fl">
    	<h3>简历管理</h3>
        <div class="lnList">
        	<a href="myJobs.aspx">创建新简历</a>
        </div>
        <div class="lnList">
        	<a class="on" href="javascript:;">简历管理</a>
        </div>
        <h3>求职管理</h3>
        
        <div class="lnList">
        	<a href="#">我申请过的职位</a>
        </div>
    </div>  
    <div class="rightMain fr">
    	<ul class="studyTit clearfix">
            <li class="current"><a href="javascript:;">我的简历列表</a></li>
        </ul>
        <div class="rmCont">
        	<table class="resumeList" width="100%">
            	<thead>
                	<tr>
                    	<th>简历名称</th>
                        <th>创建时间</th>
                        <th>操作</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <tr>
                    	<td><%#Eval("JianLiName") %></td>
                        <td><%#Eval("InsertTime") %></td>
                        <td>
                        	<a class="oprate" href='myJobs.aspx?Id=<%#Eval("Id") %>'>修改</a>
                            <a class="oprate" href="#">删除</a>
                            <a class="oprate" href="#">发布简历</a>
                        </td>
                    </tr>

                        </ItemTemplate>

                    </asp:Repeater>
                	
                </tbody>
            </table>
        </div>
    </div>
</div>
</asp:Content>

