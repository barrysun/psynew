<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="ForecastJob2List.aspx.cs" Inherits="admin_Component_ForecastJob2List" Theme="Theme1" %>

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
    <asp:TemplateField HeaderText="职业编号">
    <ItemTemplate><%#Eval("JOBID") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="介绍1">
    <ItemTemplate><%#Eval("CNOUTLOOK1") %></ItemTemplate></asp:TemplateField>
    <asp:TemplateField HeaderText="介绍2">
    <ItemTemplate><%#Eval("CNOUTLOOK2") %></ItemTemplate>
    </asp:TemplateField>
     <asp:TemplateField HeaderText="删除">
      <ItemTemplate>
          <asp:LinkButton ID="LinkButton2" runat="server" CommandName='<%#Eval("FORECASTJOB2ID") %>' oncommand="LinkButton2_Command"><span style=" color:Red; font-size:larger">删除</span></asp:LinkButton>
      </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="修改">
    <ItemTemplate>
        <asp:LinkButton ID="LinkButton1" runat="server" CommandName='<%#Eval("FORECASTJOB2ID") %>' oncommand="LinkButton1_Command"><span style=" color:Red; font-size:larger">修改</span></asp:LinkButton>
    </ItemTemplate>
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

