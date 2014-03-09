<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="CommunityUpdate.aspx.cs" Inherits="admin_CommunityUpdate" %>

<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 123px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style="width:100%">
    <br />
    <table style="width:100%">
        <tr><td >名称：</td><td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td><td></td></tr>
        <tr><td >内容：</td><td>
            <FCKeditorV2:FCKeditor ID="FCKeditor1" runat="server"></FCKeditorV2:FCKeditor>
        </td><td></td></tr>
        <tr><td >是否首页显示：</td><td>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="1" Text="首页显示"></asp:ListItem>
                <asp:ListItem Value="0" Text="首页不显示"></asp:ListItem>
            </asp:DropDownList>
            </td><td></td></tr>
         <tr><td >序号：</td><td>
             <asp:TextBox ID="TextBox2" runat="server" Text="0"></asp:TextBox></td><td></td></tr>
        <tr><td ></td><td>
            <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" /></td><td></td></tr>
        <tr><td ></td><td></td><td></td></tr>
       
    </table>

</div>
</asp:Content>

