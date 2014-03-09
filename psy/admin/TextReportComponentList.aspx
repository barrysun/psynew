<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master"  AutoEventWireup="true" CodeFile="TextReportComponentList.aspx.cs" Inherits="admin_Component_TextReportComponentList" Theme="Theme1" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
    <br />
    查询条件：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="查询" OnClick="Button1_Click" />
    <br />
    <asp:GridView ID="GridView1" runat="server" Width="100%" AutoGenerateColumns="false">
    <Columns>
    <asp:TemplateField HeaderText="序号">
    <ItemTemplate><%#Eval("RowNum") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="标示号">
    <ItemTemplate><%#Eval("CSNUM") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="类型名">
    <ItemTemplate><%#Eval("VARIABLE") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="值">
    <ItemTemplate><%#Eval("VARIABLEVALUE") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="组件描述">
    <ItemTemplate><%#Eval("REPORTCOMPONENT") %></ItemTemplate>
    <ItemStyle Width="60%" />
    </asp:TemplateField>
     <asp:TemplateField HeaderText="删除">
      <ItemTemplate>
          <asp:LinkButton ID="LinkButton2" oncommand="LinkButton2_Command"  CommandName='<%#Eval("TEXTRECOMID") %>' runat="server"><span style=" color:Red; font-size:larger">删除</span></asp:LinkButton>
      </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="修改">
    <ItemTemplate>
        <asp:LinkButton ID="LinkButton1" runat="server" CommandName='<%#Eval("TEXTRECOMID") %>' oncommand="LinkButton1_Command"><span style=" color:Red; font-size:larger">修改</span></asp:LinkButton>
    </ItemTemplate>
    </asp:TemplateField>
    </Columns>
    </asp:GridView>
    <br />
    <webdiyer:AspNetPager ID="AspNetPager1" runat="server" PrevPageText="上一页" 
        NextPageText="下一页" FirstPageText="首页" LastPageText="尾页" 
        onpagechanged="AspNetPager1_PageChanged">
    </webdiyer:AspNetPager>
</div>
</asp:Content>

