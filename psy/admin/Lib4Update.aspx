<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="Lib4Update.aspx.cs" Inherits="admin_Lib4Update" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <table width="100%">
            <tr><td>父节点:</td><td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td><td></td></tr>
            <tr><td>CNUMBER:</td><td>
                <asp:TextBox ID="TextBox2" runat="server" Width="343px"></asp:TextBox></td><td></td></tr>
            <tr><td>职业名称：</td><td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td><td></td></tr>
            <tr><td>工资：</td><td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td><td></td></tr>
            <tr><td>IsNode:</td><td>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td><td></td></tr>
            <tr><td></td><td>
                <asp:Button ID="Button1" runat="server" Text="修改" OnClick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" Text="保存" OnClick="Button2_Click" />
                         </td><td></td></tr>
            <tr><td></td><td></td><td></td></tr>

        </table>
    </div>
</asp:Content>

