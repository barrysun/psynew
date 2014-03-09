<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="WilTestQuestionList.aspx.cs" Inherits="admin_WilTestQuestionList" Theme="Theme1" %>


<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
    <br />
     输入查询条件：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Text="查询" OnClick="Button1_Click" />
    <br />
    <asp:GridView ID="GridView1" runat="server" Width="100%" AutoGenerateColumns="false" >
    <Columns>
    <asp:TemplateField HeaderText="序号">
    <ItemTemplate><%#Eval("RowNum") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="WIL类型">
    <ItemTemplate><%#Eval("WILTYPE") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="标记">
    <ItemTemplate><%#Eval("LETTERMARK") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="WIL题目">
    <ItemTemplate><%#Eval("WILTITLE") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="重要得分">
    <ItemTemplate><%#Eval("IMPORTSCORE")%></ItemTemplate></asp:TemplateField>
    <asp:TemplateField HeaderText="一般重要得分">
    <ItemTemplate><%#Eval("SECONDLYSCORE") %></ItemTemplate></asp:TemplateField>
    <asp:TemplateField HeaderText="不重要得分">
    <ItemTemplate><%#Eval("NOTINPORTSCORE") %></ItemTemplate>
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

