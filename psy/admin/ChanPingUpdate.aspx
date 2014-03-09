<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="ChanPingUpdate.aspx.cs" Inherits="admin_ChanPingUpdate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style="width:100%">
    <table style="width:100%">
        <tr><td>产品名称：</td><td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td><td></td></tr>
        <tr><td>描述</td><td>
            <asp:TextBox ID="TextBox2" runat="server" Height="104px" TextMode="MultiLine" Width="566px"></asp:TextBox></td><td></td></tr>
        <tr><td>单价：</td><td>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td><td></td></tr>
        <tr><td>用户公司选择：</td><td>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Text="公司产品" Value="1"></asp:ListItem>
                 <asp:ListItem Text="用户" Value="2"></asp:ListItem>
            </asp:DropDownList></td><td></td></tr>
        <tr><td></td><td>
            <asp:Button ID="Button1" runat="server" Text="保存" OnClick="Button1_Click" /></td><td></td></tr>
    </table>

</div>
</asp:Content>

