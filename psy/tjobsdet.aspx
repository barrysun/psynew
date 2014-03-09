<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="tjobsdet.aspx.cs" Inherits="tjobsdet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/base.css" rel="stylesheet" type="text/css" />
<link href="css/global.css" rel="stylesheet" type="text/css" />
<link href="css/tjobsDet.css" rel="stylesheet" type="text/css" />
<link href="css/common.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!--面包屑-->
<div class="curmbs">
	<span>您现在所在的位置：</span>
    <a href="index.html">首页</a>
    <span>&gt;</span>
    <span>求职与招聘平台</span>
</div>
<div class="content clearfix">
    <div class="jobDet">
    	<h3 class="jdTit bold16"><asp:Label ID="Label13" runat="server" Text="Label"></asp:Label></h3>
        <div class="row">
        	<div class="detailsL fl">
            	<dl class="company">
                	<dt class="bold14">
                        <asp:Label ID="Label12" runat="server" Text="Label"></asp:Label></dt>
                    <dd>
                    	<span class="company2">公司性质：</span>
                        <span> <asp:Label ID="Label14" runat="server" Text="Label"></asp:Label></span>
                    </dd>
                    <dd>
                    	<span class="company2">公司行业：</span>
                        <span>
                            <asp:Label ID="Label15" runat="server" Text="Label"></asp:Label></span>
                    </dd>
                    <dd>
                    	<span class="company2">公司规模：</span>
                        <span>
                            <asp:Label ID="Label16" runat="server" Text="Label"></asp:Label></span>
                    </dd>
                </dl>
            </div>
            <div class="detailsR fr">
            	<a class="applyBtn" href="#">申请该职位</a>
            </div>
        </div>
       	<div class="row">
        	<table class="companyTab" width="100%">
            	<tbody>
                	<tr>
                        <td class="col1">职位名称：</td>
                        <td class="col2">
                            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
                        <td class="col1">职位月薪：</td>
                        <td class="col2">
                            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="col1">工作地点：</td>
                        <td class="col2">
                            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></td>
                        <td class="col1">工作经验：</td>
                        <td class="col2">
                            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="col1">最低学历：</td>
                        <td class="col2">
                            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></td>
                        <td class="col1">工作性质：</td>
                        <td class="col2">
                            <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="col1">招聘人数：</td>
                        <td class="col2">
                            <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label></td>
                        <td class="col1">招聘有效期：</td>
                        <td class="col2">
                        	<span><asp:Label ID="Label8" runat="server" Text="Label"></asp:Label></span>到
                            <span><asp:Label ID="Label9" runat="server" Text="Label"></asp:Label></span>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div> 
        <div class="conpanyBox">
        	<h4 class="bold14">职位描述</h4>
            <div class="cbCont">
                
            	<p><asp:Label ID="Label10" runat="server" Text="Label"></asp:Label></p>
               
            </div>
        </div>
        <div class="conpanyBox">
        	<h4 class="bold14">公司介绍</h4>
            <div class="cbCont">
                
            	<p><asp:Label ID="Label11" runat="server" Text="Label"></asp:Label></p>
            </div>
        </div>
        <div class="conBtnw">
        	<a class="applyBtn" href="#">申请该职位</a>
        </div>
    </div>
</div>

</asp:Content>

