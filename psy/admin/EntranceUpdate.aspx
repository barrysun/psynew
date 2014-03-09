<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="EntranceUpdate.aspx.cs" Inherits="admin_EntranceUpdate" %>

<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 562px;
        }
        .auto-style2 {
            width: 97px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="width:100%">
        <table style="width:100%">
            <tr><td class="auto-style2">名称：</td><td class="auto-style1">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td><td></td></tr>
            <tr><td class="auto-style2">内容：</td><td class="auto-style1">
                <FCKeditorV2:FCKeditor ID="FCKeditor1" runat="server"></FCKeditorV2:FCKeditor>
            </td><td></td></tr>
            <tr><td class="auto-style2">是否首页显示：</td><td class="auto-style1">
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem Value="1" Text="首页显示"></asp:ListItem>
                    <asp:ListItem Value="0" Text="不在首页显示"></asp:ListItem>
                </asp:DropDownList></td><td></td></tr>
            <tr><td class="auto-style2">序号：</td><td class="auto-style1">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td><td></td></tr>
            <tr><td class="auto-style2"></td><td class="auto-style1">
                <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" /></td><td></td></tr>
        </table>

    </div>
</asp:Content>

