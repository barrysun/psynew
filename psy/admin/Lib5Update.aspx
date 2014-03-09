<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="Lib5Update.aspx.cs" Inherits="admin_Lib5Update" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <div>
        <table width="100%">
            <tr><td>子库类型ID：</td><td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td><td></td></tr>
            <tr><td>标记：</td><td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td><td></td></tr>
            <tr><td>名称：</td><td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td><td></td></tr>
            <tr><td>内容：</td><td>
                <asp:TextBox ID="TextBox4" runat="server" Height="83px" TextMode="MultiLine" Width="419px"></asp:TextBox></td><td></td></tr>
            <tr><td></td><td>
                <asp:Button ID="Button1" runat="server" Text="修改" OnClick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" Text="保存" OnClick="Button2_Click" />
                </td><td></td></tr>
            <tr><td></td><td></td><td></td></tr>

        </table>
    </div>
    

</asp:Content>

