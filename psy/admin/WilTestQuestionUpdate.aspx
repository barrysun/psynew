<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="WilTestQuestionUpdate.aspx.cs" Inherits="admin_WilTestQuestionUpdate" Theme="Theme1" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
   <table width="100%">
       <tr><td>WIL题型：</td><td>
           <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td><td></td></tr>
        <tr><td>标记：</td><td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td><td></td></tr>
        <tr><td>WIL题目：</td><td>
            <asp:TextBox ID="TextBox3" runat="server" Height="94px" TextMode="MultiLine" Width="518px"></asp:TextBox></td><td></td></tr>
        <tr><td>非常重要得分：</td><td>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td><td></td></tr>
        <tr><td>IMPORTSCORE:</td><td>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td><td></td></tr>
        <tr><td>SECONDLYSCORE:</td><td>
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td><td></td></tr>
       <tr><td>GENERALSCORE:</td><td>
           <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox></td><td></td></tr>
        <tr><td>SOMEIMPORTSCORE:</td><td>
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox></td><td></td></tr>
       <tr><td>NOTINPORTSCORE:</td><td>
           <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox></td><td></td></tr>
        <tr><td>WILORDER:</td><td>
            <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox></td><td></td></tr>
       <tr><td></td>
           <td><asp:Button ID="Button1" runat="server" Text="修改" OnClick="Button1_Click" /><asp:Button ID="Button2" runat="server" Text="提交" OnClick="Button2_Click" /></td><td></td></tr>
        <tr><td></td><td></td><td></td></tr>

   </table>
</div>
</asp:Content>

