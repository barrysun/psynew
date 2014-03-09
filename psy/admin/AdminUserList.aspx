<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="AdminUserList.aspx.cs" Inherits="admin_AdminUserList" Theme="Theme1" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
    <asp:GridView ID="GridView1" runat="server" Width="100%" AutoGenerateColumns="false">
    <Columns>
    <asp:TemplateField HeaderText="序号">
    <ItemTemplate>
    <%#Eval("RowNum") %>
    </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="账号">
    <ItemTemplate><%#Eval("NAME") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="电话号码">
    <ItemTemplate><%#Eval("PHONE") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="Email">
    <ItemTemplate><%#Eval("EMAIL") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="地址">
    <ItemTemplate><%#Eval("ADRESS") %></ItemTemplate>
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
    <webdiyer:AspNetPager ID="AspNetPager1" runat="server" PrevPageText="上一页" 
        NextPageText="下一页" LastPageText="尾页" FirstPageText="首页" PageSize="20" 
        onpagechanged="AspNetPager1_PageChanged">
    </webdiyer:AspNetPager>
</div>
</asp:Content>

