<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="IpAnswer.aspx.cs" Inherits="admin_Answer_IpAnswer" Theme="Theme1" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
    <span style=" color: Black; font-size:larger">搜索条件</span>：<asp:DropDownList ID="DropDownList1" runat="server">
    <asp:ListItem Value="0" Text="=查询所有="></asp:ListItem>
    <asp:ListItem Value="1" Text="=用户ID="></asp:ListItem>
    <asp:ListItem Value="2" Text="=用户姓名="></asp:ListItem>
    </asp:DropDownList>&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button
        ID="Button1" runat="server" Text="搜索" onclick="Button1_Click" />&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button
            ID="Button2" runat="server" Text="导出EXCEL" onclick="Button2_Click" />&nbsp;&nbsp;<asp:Button ID="Button3" runat="server" Text="下载IP题目列表Excel" OnClick="Button3_Click" />

        <br />
        <br />
    <asp:GridView ID="GridView1" runat="server" Width="100%"  AutoGenerateColumns="false">
    <Columns>
    <asp:TemplateField HeaderText="序号">
    <ItemTemplate><%#Eval("RowNum") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="用户ID">
    <ItemTemplate><%#Eval("USERID") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="用户姓名">
    <ItemTemplate><%#Eval("NAME") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="IPID">
    <ItemTemplate><%#Eval("IPID") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="IP题目">
    <ItemTemplate><%#Eval("IPTITLE") %></ItemTemplate></asp:TemplateField>
    <asp:TemplateField HeaderText="答案">
    <ItemTemplate><%#Eval("ANSWER") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="得分">
    <ItemTemplate><%#Eval("SCORE") %></ItemTemplate>
    </asp:TemplateField>
    </Columns>
    </asp:GridView>
<br />
    <webdiyer:AspNetPager ID="AspNetPager1" runat="server" FirstPageText="首页" 
        LastPageText="尾页" PrevPageText="上一页" NextPageText="下一页" PageSize="20" 
        onpagechanged="AspNetPager1_PageChanged">
    </webdiyer:AspNetPager>
</div>
</asp:Content>

