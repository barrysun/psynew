<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="Lib2Update.aspx.cs" Inherits="admin_Lib2Update" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
<table style="width:100%">
<tr><td>职业编号：</td><td>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td><td></td></tr>
<tr><td>职业名称：</td><td>
    <asp:TextBox ID="TextBox2" runat="server" Width="322px"></asp:TextBox></td><td></td></tr>
<tr><td>职业介绍：</td><td>
    <asp:TextBox ID="TextBox3" runat="server" Height="339px" TextMode="MultiLine" 
        Width="633px"></asp:TextBox></td><td></td></tr>
<tr><td></td><td>
    <asp:Button ID="Button1" runat="server" Text="修改" onclick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" Text="提交" OnClick="Button2_Click" />
    </td><td></td></tr>
</table>
</div>
</asp:Content>

