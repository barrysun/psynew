<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="PreferentialUpdate.aspx.cs" Inherits="admin_PreferentialUpdate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    优惠修改
    <div>
        <table>
            <tr><td>优惠名称：</td><td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td><td></td></tr>
            <tr><td>优惠折扣：</td><td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td><td></td></tr>
            <tr><td></td><td>
                <asp:Button ID="Button1" runat="server" Text="保存" OnClick="Button1_Click" /></td><td></td></tr>
         
        </table>

    </div>
</asp:Content>

