<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="myJobs5.aspx.cs" Inherits="myJobs5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
  
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
    	<h3>简历管理</h3>
        <div class="lnList">
        	<a class="on" href="javascript:;">创建新简历</a>
        </div>
        <div class="lnList">
        	<a href="myResume.aspx">简历管理</a>
        </div>
        <h3>求职管理</h3>
       
        <div class="lnList">
        	<a href="#">我申请过的职位</a>
        </div>
    </div>  
    <div class="rightMain fr">
    	<ul class="studyTit clearfix">
            <li class="current"><a href="javascript:;">我的简历</a></li>
        </ul>
        <div class="rmCont">
        <h4 class="step bold14">第六步-上传形象照（带<span class="require">*</span>的为必填）</h4>
        <table class="resume">
        	<tbody>
                <tr>
                	<td class="col1">请上传您的照片：</td>
                    <td class="col2">
                    	<input class="valid" name="photo" id="photo" onkeydown="alert('请点击右侧“浏览”选择您电脑上的照片！');return false" style="width:260px; height:22px; border:1px #7797A8 solid; font-size:12px;" type="file" />
                        <p>(允许上传的照片格式为:jpg,gif,png,bmp,大小不能超过500KB)</p>
                    </td>
                </tr>
            </tbody>
        </table>
        <div class="btnW">
        	<a href="#">上传照片</a>
        	<a class="chart_btn1" href="javascript:;">我不想上传照片</a> 
            <a href="#">返回上一步</a>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
        </div>
    </div>
</div>
</asp:Content>

