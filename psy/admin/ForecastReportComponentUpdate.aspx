<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="ForecastReportComponentUpdate.aspx.cs" Inherits="admin_ForecastReportComponentUpdate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
<table style="width:100%">
<tr><td>预测组件编号：</td><td>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td><td></td></tr>
<tr><td>预测组件类型：</td><td>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td><td></td></tr>
<tr><td>预测组件值：</td><td>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td><td></td></tr>
<tr><td>组件内容：</td><td>
    <asp:TextBox ID="TextBox4" runat="server" Height="125px" Width="536px" 
        TextMode="MultiLine"></asp:TextBox></td><td></td></tr>
<tr><td></td><td>
    <asp:Button ID="Button1" runat="server" Text="修改" onclick="Button1_Click" /></td><td></td></tr>
</table>
</div>
</asp:Content>

