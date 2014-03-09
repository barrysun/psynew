<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="Lib3Update.aspx.cs" Inherits="admin_Lib3Update" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
<table style="width:100%">
<tr><td>职业编号：</td><td>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td><td></td></tr>
<tr><td>职业名称：</td><td>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td><td></td></tr>
<tr><td>职业描述：</td><td>
    <asp:TextBox ID="TextBox3" runat="server" Height="19px" Width="249px"></asp:TextBox></td><td></td></tr>
<tr><td>职业工作描述：</td><td>
    <asp:TextBox ID="TextBox4" runat="server" Height="193px" TextMode="MultiLine" 
        Width="500px"></asp:TextBox></td><td></td></tr>
<tr><td></td><td>
    <asp:Button ID="Button1" runat="server" Text="修改" onclick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" Text="保存" OnClick="Button2_Click" />
             </td><td></td></tr>
</table>
</div>
</asp:Content>

