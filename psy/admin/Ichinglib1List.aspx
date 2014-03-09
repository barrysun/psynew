<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="Ichinglib1List.aspx.cs" Inherits="admin_Ichinglib1List" Theme="Theme1" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style="width:100%">
<br />
    <asp:GridView ID="GridView1" runat="server" Width="100%" AutoGenerateColumns="false">
    <Columns>
    <asp:TemplateField HeaderText="序号">
    <ItemTemplate><%#Eval("RowNum") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="日期">
    <ItemTemplate><%#Eval("DATE") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="时间">
    <ItemTemplate><%#Eval("TIME") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="年干">
    <ItemTemplate><%#Eval("NG") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="年支">
    <ItemTemplate><%#Eval("NZ") %></ItemTemplate>
    </asp:TemplateField>
           <asp:TemplateField HeaderText="删除">
      <ItemTemplate>
          <asp:LinkButton ID="LinkButton2" runat="server" CommandName='<%#Eval("ID") %>' oncommand="LinkButton2_Command"><span style=" color:Red; font-size:larger">删除</span></asp:LinkButton>
      </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="修改">
    <ItemTemplate>
        <asp:LinkButton ID="LinkButton1" runat="server" CommandName='<%#Eval("ID") %>' oncommand="LinkButton1_Command"><span style=" color:Red; font-size:larger">修改</span></asp:LinkButton>
    </ItemTemplate>
    </asp:TemplateField>
    </Columns>
    </asp:GridView>
<br />
    <webdiyer:AspNetPager ID="AspNetPager1" runat="server" FirstPageText="首页" 
        PrevPageText="上一页" LastPageText="尾页" PageSize="20" NextPageText="下一页" 
        onpagechanged="AspNetPager1_PageChanged">
    </webdiyer:AspNetPager>
</div>
</asp:Content>

