<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="EqiQuestionUpdate.aspx.cs" Inherits="admin_EqiQuestionUpdate" Theme="Theme1" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
<table style="width:100%">
<tr><td>原始题号：</td><td>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td><td></td></tr>
<tr><td>测试类型：</td><td>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td><td></td></tr>
<tr><td>测试编号：</td><td>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td><td></td></tr>
    <tr><td>测试：</td><td>
        <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox></td><td></td></tr>
<tr><td>分数：</td><td>
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td><td></td></tr>
<tr><td class="style1">类型</td><td class="style1">
    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td><td class="style1"></td></tr>
<tr><td>是否使用：</td><td>
    <asp:TextBox ID="TextBox5" runat="server" ></asp:TextBox></td><td></td></tr>
<tr><td>题目：</td><td>
    <asp:TextBox ID="TextBox7" runat="server" Height="61px" TextMode="MultiLine" 
        Width="698px"></asp:TextBox></td><td></td></tr>
<tr><td>排序：</td><td>
    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox></td><td></td></tr>
<tr><td>非常喜欢得分</td><td>
    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox></td><td></td></tr>
<tr><td>基本得分</td><td>
    <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox></td><td></td></tr>
<tr><td>有事得分</td><td>
    <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox></td><td></td></tr>
<tr><td>有点不得分</td><td>
    <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox></td><td></td></tr>
<tr><td>不得分</td><td>
    <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox></td><td></td></tr>
<tr><td></td><td>
    <asp:Button ID="Button1" runat="server" Text="修改" OnClick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" Text="提交" OnClick="Button2_Click" />
    </td><td></td></tr></table>
 
</div>
</asp:Content>

