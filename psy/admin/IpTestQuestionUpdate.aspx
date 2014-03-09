<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="IpTestQuestionUpdate.aspx.cs" Inherits="admin_IpTestQuestionUpdate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
<table style="width:100%">
<tr><td>试题类型：</td><td>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td><td></td></tr>
<tr><td>试题题目：</td><td>
    <asp:TextBox ID="TextBox2" runat="server" Height="72px" TextMode="MultiLine" Width="408px"></asp:TextBox></td><td></td></tr>
<tr><td>选择喜欢得分：</td><td>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td><td></td></tr>
<tr><td>选择不喜欢得分：</td><td>
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td><td></td></tr>
<tr><td>选择不确定得分：</td><td>
    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td><td></td></tr>
<tr><td>IP试题排序字段：</td><td>
    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td><td></td></tr>
<tr><td></td><td>

    <asp:Button ID="Button1" runat="server" Text="修改" OnClick="Button1_Click" />
             <asp:Button ID="Button2" runat="server" Text="提交" OnClick="Button2_Click" />
             </td><td></td></tr>
</table>
</div>
</asp:Content>

