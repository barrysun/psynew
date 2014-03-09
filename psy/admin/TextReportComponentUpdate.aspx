<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="TextReportComponentUpdate.aspx.cs" Inherits="admin_TextReportComponentUpdate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
<table>
<tr><td>组件编号：</td><td>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td><td></td></tr>
<tr><td>组件类型:</td><td>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td><td></td></tr>
<tr><td>组件值：</td><td>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td><td></td></tr>
<tr><td>组件描述：</td><td>
    <asp:TextBox ID="TextBox4" runat="server" Height="258px" TextMode="MultiLine" 
        Width="573px"></asp:TextBox></td><td></td></tr>
        <tr><td></td><td>
            <asp:Button ID="Button1" runat="server" Text="修改" onclick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="保存" OnClick="Button2_Click" />
                     </td><td></td></tr>
</table>
</div>
</asp:Content>

