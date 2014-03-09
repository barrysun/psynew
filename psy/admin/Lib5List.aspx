<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="Lib5List.aspx.cs" Inherits="admin_Lib_Lib5List" Theme="Theme1" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
    <br />
    查询条件：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="查询" OnClick="Button1_Click" />
    &nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" Text="点击添加" OnClick="Button2_Click" />
    <br />
    <asp:GridView ID="GridView1" runat="server" Width="100%" AutoGenerateColumns="false">
    <Columns>
    <asp:TemplateField HeaderText="序号">
    <ItemTemplate><%#Eval("RowNum") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField  HeaderText="所属子库">
    <ItemTemplate><%#Eval("LIBTYPE") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="类型">
    <ItemTemplate><%#Eval("MARK") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="名称">
    <ItemTemplate><%#Eval("LIBNAME") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="描述" >
    <ItemTemplate><%#Eval("DESCRIPTION") %></ItemTemplate>
    <ItemStyle Width="50%" />
    </asp:TemplateField>
      <asp:TemplateField HeaderText="删除">
      <ItemTemplate>
          <asp:LinkButton ID="LinkButton2" onclick="LinkButton2_Click" runat="server"><span style=" color:Red; font-size:larger">删除</span></asp:LinkButton>
      </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="修改">
    <ItemTemplate>
        <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click"><span style=" color:Red; font-size:larger">修改</span></asp:LinkButton>
    </ItemTemplate>
    </asp:TemplateField>
    </Columns>
    </asp:GridView>
    <br />
    <webdiyer:AspNetPager ID="AspNetPager1" runat="server" FirstPageText="首页" 
        NextPageText="下一页" PageSize="20" PrevPageText="上一页" LastPageText="尾页" 
        onpagechanged="AspNetPager1_PageChanged">
    </webdiyer:AspNetPager>
</div>
</asp:Content>

