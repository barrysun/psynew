<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="Ichinglib1Update.aspx.cs" Inherits="admin_Ichinglib1Update" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div><table width="100%">
             
        <tr><td>DATE：</td><td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td><td></td></tr>
        <tr><td>TIME：</td><td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td><td></td></tr>
        <tr><td>NG：</td><td>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td><td></td></tr>
        <tr><td>NZ：</td><td>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td><td></td></tr>
        <tr><td></td><td>
            <asp:Button ID="Button1" runat="server" Text="修改" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="保存" OnClick="Button2_Click" />
                     </td><td></td></tr>
         </table></div>
</asp:Content>

