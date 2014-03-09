<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="NewsUpdate.aspx.cs" Inherits="admin_NewsUpdate" %>

<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="width:100%">
        <table style="width:100%">
            <tr><td>新闻标题：</td><td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td><td></td></tr>
            <tr><td>新闻类型：</td><td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td><td></td></tr>
            <tr><td>新闻图片：</td><td>
                <asp:FileUpload ID="FileUpload1" runat="server" /> </td><td></td></tr>
            <tr><td>是否在首页显示：</td><td>
                <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList></td><td></td></tr>
            <tr><td>新闻内容：</td><td>
                <FCKeditorV2:FCKeditor ID="FCKeditor1" runat="server"></FCKeditorV2:FCKeditor>
            </td><td></td></tr>
            <tr><td></td><td>
                <asp:Button ID="Button1" runat="server" Text="添加" OnClick="Button1_Click" /></td><td></td></tr>

        </table>


    </div>
</asp:Content>

