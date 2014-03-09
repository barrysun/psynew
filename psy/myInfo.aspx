<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="myInfo.aspx.cs" Inherits="myInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 <script language="javascript" type="text/javascript" src="My97DatePicker/WdatePicker.js"></script>

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
        	<a class="on" href="javascript:;">管理自己的基本信息</a>
        </div>
        <h3>第二步</h3>
        <div class="lnList">
        	<a href="myInfo1.aspx">目前就读学校(学生填写)</a>
        </div>
        <h3>第三步</h3>
        <div class="lnList">
        	<a href="myInfo2.aspx">目前就职情况(在职人员填写)</a>
        </div>
        <h3>第四步</h3>
        <div class="lnList">
        	<a href="myInfo3.aspx">其他信息</a>
        </div>
    </div>  
    <div class="rightMain fr">
    	<ul class="studyTit clearfix">
            <li class="current"><a href="javascript:;">基本信息</a></li>
        </ul>
        <div class="rmCont">
        	<h4 class="step bold14"><span class="require">*</span>号为用户不可以修改，只有管理员才能修改。</h4>
            <table class="resume" width="100%">
            	<tbody>
                	<tr>
                    	<td class="col1"><span class="require">*</span>真实姓名：</td>
                        <td class="col2">
                            <%--<input class="ipt" type="text" />--%>
                            <asp:TextBox ID="TextBox1" CssClass="ipt" runat="server"></asp:TextBox>

                        </td>
                        <td class="col1"><span class="require">*</span>性别：</td>
                        <td class="col2">
                           <%-- <input class="ipt" type="text" />--%>
                            <asp:DropDownList ID="DropDownList3" runat="server">
                                <asp:ListItem Text="男" Value="1"></asp:ListItem>
                                 <asp:ListItem Text="女" Value="-1"></asp:ListItem>
                            </asp:DropDownList>
                         <%--   <asp:TextBox ID="TextBox2" CssClass="ipt" runat="server"></asp:TextBox>--%>
                        </td>
                    </tr>
                    <tr>
                    	<td class="col1"><span class="require">*</span>出生年月日：</td>
                        <td class="col2">
                          <%--  <input class="ipt" type="text" />--%>
                            <asp:TextBox ID="TextBox3"  onClick="WdatePicker()"  CssClass="ipt"  runat="server"></asp:TextBox>

                        </td>
                    	<td class="col1"><span class="require">*</span>出生时分：</td>
                        <td class="col2">
                            <%--<input class="ipt" type="text" />--%>
                            <asp:DropDownList ID="DropDownList1" Width="50px" runat="server">
                                <asp:ListItem Text="00" Value="00"></asp:ListItem>
                                <asp:ListItem Text="01" Value="01"></asp:ListItem>
                                <asp:ListItem Text="02" Value="02"></asp:ListItem>
                                <asp:ListItem Text="03" Value="03"></asp:ListItem>
                                <asp:ListItem Text="04" Value="04"></asp:ListItem>
                                <asp:ListItem Text="05" Value="05"></asp:ListItem>
                                <asp:ListItem Text="06" Value="06"></asp:ListItem>
                                 <asp:ListItem Text="07" Value="07"></asp:ListItem>
                                 <asp:ListItem Text="08" Value="08"></asp:ListItem>
                                 <asp:ListItem Text="09" Value="09"></asp:ListItem>
                               <asp:ListItem Text="10" Value="10"></asp:ListItem>
                                <asp:ListItem Text="11" Value="11"></asp:ListItem>
                                <asp:ListItem Text="12" Value="12"></asp:ListItem>
                                <asp:ListItem Text="13" Value="13"></asp:ListItem>
                                <asp:ListItem Text="14" Value="14"></asp:ListItem>
                                <asp:ListItem Text="15" Value="15"></asp:ListItem>
                                <asp:ListItem Text="16" Value="16"></asp:ListItem>
                                 <asp:ListItem Text="17" Value="17"></asp:ListItem>
                                 <asp:ListItem Text="18" Value="18"></asp:ListItem>
                                 <asp:ListItem Text="19" Value="19"></asp:ListItem>
                                  <asp:ListItem Text="20" Value="20"></asp:ListItem>
                                <asp:ListItem Text="21" Value="21"></asp:ListItem>
                                <asp:ListItem Text="22" Value="22"></asp:ListItem>
                                <asp:ListItem Text="23" Value="23"></asp:ListItem>

                            </asp:DropDownList>时
                            :<asp:DropDownList ID="DropDownList2"  Width="50px"  runat="server">
                                <asp:ListItem Text="00" Value="00"></asp:ListItem>
                                <asp:ListItem Text="01" Value="01"></asp:ListItem>
                                <asp:ListItem Text="02" Value="02"></asp:ListItem>
                                <asp:ListItem Text="03" Value="03"></asp:ListItem>
                                <asp:ListItem Text="04" Value="04"></asp:ListItem>
                                <asp:ListItem Text="05" Value="05"></asp:ListItem>
                                <asp:ListItem Text="06" Value="06"></asp:ListItem>
                                 <asp:ListItem Text="07" Value="07"></asp:ListItem>
                                 <asp:ListItem Text="08" Value="08"></asp:ListItem>
                                 <asp:ListItem Text="09" Value="09"></asp:ListItem>
                               <asp:ListItem Text="10" Value="10"></asp:ListItem>
                                <asp:ListItem Text="11" Value="11"></asp:ListItem>
                                <asp:ListItem Text="12" Value="12"></asp:ListItem>
                                <asp:ListItem Text="13" Value="13"></asp:ListItem>
                                <asp:ListItem Text="14" Value="14"></asp:ListItem>
                                <asp:ListItem Text="15" Value="15"></asp:ListItem>
                                <asp:ListItem Text="16" Value="16"></asp:ListItem>
                                 <asp:ListItem Text="17" Value="17"></asp:ListItem>
                                 <asp:ListItem Text="18" Value="18"></asp:ListItem>
                                 <asp:ListItem Text="19" Value="19"></asp:ListItem>
                                  <asp:ListItem Text="20" Value="20"></asp:ListItem>
                                <asp:ListItem Text="21" Value="21"></asp:ListItem>
                                <asp:ListItem Text="22" Value="22"></asp:ListItem>
                                <asp:ListItem Text="23" Value="23"></asp:ListItem>
                                 <asp:ListItem Text="24" Value="24"></asp:ListItem>
                                <asp:ListItem Text="25" Value="25"></asp:ListItem>
                                <asp:ListItem Text="26" Value="26"></asp:ListItem>
                                 <asp:ListItem Text="27" Value="27"></asp:ListItem>
                                 <asp:ListItem Text="28" Value="28"></asp:ListItem>
                                 <asp:ListItem Text="29" Value="29"></asp:ListItem>
                                  <asp:ListItem Text="30" Value="30"></asp:ListItem>
                                   <asp:ListItem Text="31" Value="01"></asp:ListItem>
                                <asp:ListItem Text="32" Value="02"></asp:ListItem>
                                <asp:ListItem Text="33" Value="03"></asp:ListItem>
                                <asp:ListItem Text="34" Value="04"></asp:ListItem>
                                <asp:ListItem Text="35" Value="05"></asp:ListItem>
                                <asp:ListItem Text="36" Value="06"></asp:ListItem>
                                 <asp:ListItem Text="37" Value="07"></asp:ListItem>
                                 <asp:ListItem Text="38" Value="08"></asp:ListItem>
                                 <asp:ListItem Text="39" Value="09"></asp:ListItem>
                               <asp:ListItem Text="40" Value="10"></asp:ListItem>
                               
                                <asp:ListItem Text="41" Value="11"></asp:ListItem>
                                <asp:ListItem Text="42" Value="12"></asp:ListItem>
                                <asp:ListItem Text="43" Value="13"></asp:ListItem>
                                <asp:ListItem Text="44" Value="14"></asp:ListItem>
                                <asp:ListItem Text="45" Value="15"></asp:ListItem>
                                <asp:ListItem Text="46" Value="16"></asp:ListItem>
                                 <asp:ListItem Text="47" Value="17"></asp:ListItem>
                                 <asp:ListItem Text="48" Value="18"></asp:ListItem>
                                 <asp:ListItem Text="49" Value="19"></asp:ListItem>
                                  <asp:ListItem Text="50" Value="20"></asp:ListItem>
                                <asp:ListItem Text="51" Value="21"></asp:ListItem>
                                <asp:ListItem Text="52" Value="22"></asp:ListItem>
                                <asp:ListItem Text="53" Value="23"></asp:ListItem>
                                 <asp:ListItem Text="54" Value="24"></asp:ListItem>
                                <asp:ListItem Text="55" Value="25"></asp:ListItem>
                                <asp:ListItem Text="56" Value="26"></asp:ListItem>
                                 <asp:ListItem Text="57" Value="27"></asp:ListItem>
                                 <asp:ListItem Text="58" Value="28"></asp:ListItem>
                                 <asp:ListItem Text="59" Value="29"></asp:ListItem>
                                 
                             </asp:DropDownList>分
                           <%-- <asp:TextBox ID="TextBox4" CssClass="ipt" runat="server"></asp:TextBox>--%>
                        </td>
                    </tr>
                    <tr>
                    	<td class="col1">通讯地址：</td>
                        <td class="col2">
                            <%--<input class="ipt" type="text" />--%>
                            <asp:TextBox ID="TextBox5" CssClass="ipt" runat="server"></asp:TextBox>
                        </td>
                    	<td class="col1">户籍所在地：</td>
                        <td class="col2">
                            <%--<input class="ipt" type="text" />--%>
                            <asp:TextBox ID="TextBox6" CssClass="ipt" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                    	<td class="col1">婚姻状况：</td>
                        <td class="col2">
                            <%--<input class="ipt" type="text" />--%>
                            <asp:TextBox ID="TextBox7" CssClass="ipt" runat="server"></asp:TextBox>
                        </td>
                    	<td class="col1">身高：</td>
                        <td class="col2">
                            <%--<input class="ipt" type="text" />--%>
                            <asp:TextBox ID="TextBox8" CssClass="ipt" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                    	<td class="col1"><%--<span class="require">*</span>--%>家长姓名：</td>
                        <td class="col2">
                           <%-- <input class="ipt" type="text" />--%>
                            <asp:TextBox ID="TextBox9" CssClass="ipt" runat="server"></asp:TextBox>
                        </td>
                    	<td class="col1">家长联系电话：</td>
                        <td class="col2">
                            <%--<input class="ipt" type="text" />--%>
                            <asp:TextBox ID="TextBox10" CssClass="ipt" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                    	<td class="col1"><span class="require">*</span>联系电话：</td>
                        <td class="col2">
                            <%--<input class="ipt" type="text" />--%>
                            <asp:TextBox ID="TextBox11" CssClass="ipt" runat="server"></asp:TextBox>
                        </td>
                    	<td class="col1"><span class="require">*</span>常用邮箱：</td>
                        <td class="col2">
                            <%--<input class="ipt" type="text" />--%>
                            <asp:TextBox ID="TextBox12" CssClass="ipt" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                    	<td class="col1"><span class="require">*</span>QQ：</td>
                        <td class="col2">
                            <%--<input class="ipt" type="text" />--%>
                            <asp:TextBox ID="TextBox13" CssClass="ipt" runat="server"></asp:TextBox>
                        </td>
                    	<td class="col1">个人主页/微博：</td>
                        <td class="col2">
                          <%--  <input class="ipt" type="text" />--%>
                            <asp:TextBox ID="TextBox14" CssClass="ipt" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                    	<td class="col1"><span class="require">*</span>身份证号：</td>
                        <td class="col2">
                           <%-- <input class="ipt" type="text" />--%>
                            <asp:TextBox ID="TextBox15" CssClass="ipt" runat="server"></asp:TextBox>

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

