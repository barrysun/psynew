<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="firmInfo2.aspx.cs" Inherits="firmInfo2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
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
        <h3>信息管理</h3>
        <div class="lnList">
        	<a href="firmInfo1.aspx">企业信息管理</a>
        </div>
        <div class="lnList">
        	<a class="on" href="javascript:;">营业执照</a>
        </div>
    </div>  
    <div class="rightMain fr">
    	<ul class="studyTit clearfix">
            <li class="current"><a href="javascript:;">营业执照</a></li>
        </ul>
        <div class="rmCont">
        	<h4 class="step bold14">营业执照只作为网站核实贵公司真实性的材料，不在任何页面显示，我们不会以任何形式公布您的执照信息！通过网站核实后营业执照我们将立即删除</h4>
        	<table class="resume">
                <tbody>
                    <tr>
                        <td class="col1">您的营业执照认证状态：</td>
                        <td class="col2"><span class="require">未上传营业执照，请上传！</span></td>
                    </tr>
                    <tr>
                        <td class="col1">营业执照注册号：</td>
                        <td class="col2"><input class="ipt" type="text" /></td>
                    </tr>
                    <tr>
                        <td class="col1">上传营业执照：</td>
                        <td class="col2">
                        	<input class="ipt" type="file" />
                            <span>图片大小不超过1024K，允许格式：jpg/gif/bmp/png。</span>
                        </td>
                    </tr>
                </tbody>
            </table>
            <div class="btnW">
                <a href="#">上传图片</a> 
            </div>
        </div>
    </div>
</div>
</asp:Content>

