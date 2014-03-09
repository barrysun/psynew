<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="ForecastJob1Update.aspx.cs" Inherits="admin_ForecastJob1Update" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <table>
             <tr><td>编号ID：</td><td>
                 <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td><td></td></tr>
            <tr><td>职业编号：</td><td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td><td></td></tr>
             <tr><td>职业1描述：</td><td>
                 <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td><td></td></tr>
             <tr><td>职业2描述:</td><td>
                 <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td><td></td></tr>
             <tr><td>职业3描述：</td><td>
                 <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td><td></td></tr>
             <tr><td>
                 <asp:Button ID="Button1" runat="server" Text="修改" OnClick="Button1_Click" /></td><td></td><td></td></tr>
        </table>

    </div>
</asp:Content>

