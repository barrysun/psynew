<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="ForecastJob2Update.aspx.cs" Inherits="admin_ForecastJob2Update" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="width:100%">
        <table style="width:100%">
            <tr><td>职业编号：</td><td>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td><td></td></tr>
            <tr><td>介绍1：</td><td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td><td></td></tr>
            <tr><td>介绍2：</td><td>
                <asp:TextBox ID="TextBox2" runat="server" Height="73px" TextMode="MultiLine" Width="507px"></asp:TextBox></td><td></td></tr>
            <tr><td>
                <asp:Button ID="Button1" runat="server" Text="修改" OnClick="Button1_Click" /></td><td>
                    <asp:Button ID="Button2" runat="server" Text="返回" OnClick="Button2_Click" /></td><td></td></tr>
            <tr><td></td><td></td><td></td></tr>
            <tr><td></td><td></td><td></td></tr>
        </table>

    </div>
</asp:Content>

