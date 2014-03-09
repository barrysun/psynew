<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="myInfo2.aspx.cs" Inherits="myInfo2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!--面包屑-->
<div class="curmbs">
	<span>您现在所在的位置：</span>
  
    <span>&gt;</span>
    <span>完备个人信息</span>
</div>
<div class="content clearfix">
	<div class="leftNav fl">
    	<h3>第一步</h3>
        <div class="lnList">
        	<a href="myInfo.aspx">管理自己的基本信息</a>
        </div>
        <h3>第二步</h3>
        <div class="lnList">
        	<a href="myInfo1.aspx">目前就读学校(学生填写)</a>
        </div>
        <h3>第三步</h3>
        <div class="lnList">
        	<a class="on" href="javascript:;">目前就职情况(在职人员填写)</a>
        </div>
        <h3>第四步</h3>
        <div class="lnList">
        	<a href="myInfo3.aspx">其他信息</a>
        </div>
    </div>  
    <div class="rightMain fr">
    	<ul class="studyTit clearfix">
            <li class="current"><a href="javascript:;">目前就职的企业</a></li>
        </ul>
        <div class="rmCont">
        	<h4 class="step bold14">社会人士填写</h4>
            <table class="resume resumeL" width="100%">
            	<tbody>
                    <tr>
                        <td class="col1">目前就职哪家企业：</td>
                        <td class="col2">
                            <%--<input class="ipt" type="text" />--%>

                            <asp:TextBox ID="TextBox1" CssClass="ipt" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="col1">现在的职位是什么：</td>
                        <td class="col2">
                            <%--<input class="ipt" type="text" />--%>
                            <asp:TextBox ID="TextBox2" CssClass="ipt" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="col1">目前岗位的薪资范围：</td>
                        <td class="col2">
                          <%--  <input class="ipt" type="text" />--%>
                            <asp:TextBox ID="TextBox3" CssClass="ipt" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="col1">做这份工作你出于什么原因：</td>
                        <td class="col2">
                            <%--<input class="ipt" type="text" />--%>
                            <asp:TextBox ID="TextBox4" CssClass="ipt" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="col1">在您内心中期望做何种工作：</td>
                        <td class="col2">
                            <%--<input class="ipt" type="text" />--%>
                            <asp:TextBox ID="TextBox5" CssClass="ipt" runat="server"></asp:TextBox>

                        </td>
                    </tr>
                </tbody>
            </table>
            <div class="btnW">
                <asp:Button ID="Button1" class="loginBtn" runat="server" Text="保存" OnClick="Button1_Click" /> 
            </div>
        </div>
    </div>
</div>
</asp:Content>

