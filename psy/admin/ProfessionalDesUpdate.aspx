<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="ProfessionalDesUpdate.aspx.cs" Inherits="admin_ProfessionalDesUpdate" %>

<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    大学专业修改
    <div style="width:100%">
     <table style="width:100%">
         <tr><td>行业名称：</td><td>
             <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td><td></td></tr>
         <tr><td>一级专业：</td><td>
             <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td><td></td></tr>
          <tr><td>二级专业：</td><td>
              <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td><td></td></tr>
           <tr><td>推荐院校：</td><td>
              <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td><td></td></tr>
          <tr><td>专业介绍：</td><td>
              <FCKeditorV2:FCKeditor ID="FCKeditor1" runat="server"></FCKeditorV2:FCKeditor>
              </td><td></td></tr>
          <tr><td></td><td>
              <asp:Button ID="Button1" runat="server" Text="保存" OnClick="Button1_Click" /></td><td></td></tr>

    </table>
    </div>
    
</asp:Content>

