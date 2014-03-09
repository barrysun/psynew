<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="EqiQuestionList.aspx.cs" Inherits="admin_EqiQuestionList" Theme="Theme1" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="width:100%">
        输入关键字：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>&nbsp;&nbsp;<asp:Button ID="Button3" runat="server" Text="查询" OnClick="Button3_Click" />
      &nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Text="添加EQI题目" OnClick="Button1_Click" />  <br />
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" Width="100%" >

<Columns>
<asp:TemplateField HeaderText="编号">
<ItemTemplate><%#Eval("RowNum") %></ItemTemplate>
</asp:TemplateField>
<asp:TemplateField HeaderText="题目">
<ItemTemplate><%#Eval("EQITITLE") %></ItemTemplate>
</asp:TemplateField>
<asp:TemplateField HeaderText="EQI类型">
<ItemTemplate><%#Eval("EQITYPE") %></ItemTemplate>
</asp:TemplateField>
<asp:TemplateField HeaderText="类型">
<ItemTemplate><%#Eval("TEST") %></ItemTemplate>
</asp:TemplateField>
<asp:TemplateField HeaderText="分数">
<ItemTemplate><%#Eval("SCORE") %></ItemTemplate>
</asp:TemplateField>
  <asp:TemplateField HeaderText="删除">
      <ItemTemplate>
          <asp:LinkButton ID="LinkButton2" runat="server" CommandName='<%#Eval("EQIID") %>' oncommand="LinkButton2_Command"><span style=" color:Red; font-size:larger">删除</span></asp:LinkButton>
      </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="修改">
    <ItemTemplate>
        <asp:LinkButton ID="LinkButton1" runat="server" CommandName='<%#Eval("EQIID") %>' oncommand="LinkButton1_Command"><span style=" color:Red; font-size:larger">修改</span></asp:LinkButton>
    </ItemTemplate>
    </asp:TemplateField>
</Columns>
    </asp:GridView>
    <br />
    <webdiyer:AspNetPager ID="AspNetPager1" runat="server" FirstPageText="首页" 
        NextPageText="下一页" PrevPageText="上一页" LastPageText="尾页" PageSize="20" 
        onpagechanged="AspNetPager1_PageChanged">
    </webdiyer:AspNetPager>
    </div>
</asp:Content>

