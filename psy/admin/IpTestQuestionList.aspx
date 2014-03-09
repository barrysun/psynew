<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="IpTestQuestionList.aspx.cs" Inherits="admin_IpTestQuestionList" Theme="Theme1" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
<br />
 查询条件：&nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;<asp:Button
     ID="Button1" runat="server" Text="查询" onclick="Button1_Click" />&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button
         ID="Button2" runat="server" Text="添加IP试题" onclick="Button2_Click" />
     <br />
<br />
    <asp:GridView ID="GridView1" runat="server" Width="100%" AutoGenerateColumns="false">
    <Columns>
    <asp:TemplateField HeaderText="序号">
    <ItemTemplate><%#Eval("RowNum") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="IP试题类型">
    <ItemTemplate><%#Eval("IPTYPE") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="IP题目">
    
    <ItemTemplate><%#Eval("IPTITLE") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="喜欢得分">
    <ItemTemplate><%#Eval("LIKESCORE") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="不喜欢得分">
    <ItemTemplate><%#Eval("NOTLIKESCORE") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="不确定得分">
    <ItemTemplate><%#Eval("UNCERTAINSCORE") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="删除">
      <ItemTemplate>
          <asp:LinkButton ID="LinkButton2" runat="server" CommandName='<%#Eval("IPID") %>' oncommand="LinkButton2_Command"><span style=" color:Red; font-size:larger">删除</span></asp:LinkButton>
      </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="修改">
    <ItemTemplate>
        <asp:LinkButton ID="LinkButton1" runat="server" CommandName='<%#Eval("IPID") %>' oncommand="LinkButton1_Command"><span style=" color:Red; font-size:larger">修改</span></asp:LinkButton>
    </ItemTemplate>
    </asp:TemplateField>
    </Columns>
    </asp:GridView>
    <br />
    <webdiyer:AspNetPager ID="AspNetPager1" runat="server" FirstPageText="首页" 
        LastPageText="尾页" PrevPageText="上一页" NextPageText="下一页"  PageSize="20"
        onpagechanged="AspNetPager1_PageChanged">
    </webdiyer:AspNetPager>
</div>
</asp:Content>

