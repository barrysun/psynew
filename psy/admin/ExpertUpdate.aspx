<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="ExpertUpdate.aspx.cs" Inherits="admin_ExpertUpdate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="width:100%">
        <table style="width:100%">
            <tr><td>专家姓名：</td><td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td><td></td></tr>
            <tr><td>专家头像：</td><td>
                <asp:FileUpload ID="FileUpload1" runat="server" /></td><td></td></tr>
            <tr><td>专家类型：</td><td>
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem Text="易经专家" Value="1"></asp:ListItem>
                    <asp:ListItem Text="心理学专家" Value="2"></asp:ListItem>
                </asp:DropDownList></td><td></td></tr>
            <tr><td>专家介绍：</td><td>
                <asp:TextBox ID="TextBox2" runat="server" Height="133px" Width="570px" TextMode="MultiLine"></asp:TextBox></td><td></td></tr>
            <tr><td>排序</td><td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td><td></td></tr>
            <tr><td></td><td>
                <asp:Button ID="Button1" runat="server" Text="添加" OnClick="Button1_Click" /></td><td></td></tr>
        </table>


    </div>
</asp:Content>

