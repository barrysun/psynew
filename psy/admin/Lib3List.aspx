<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="Lib3List.aspx.cs" Inherits="admin_Lib3List" Theme="Theme1" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="width:100%">
    <br />
    查询条件：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="查询" OnClick="Button1_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" Text="添加新职业" OnClick="Button2_Click" />
    <br />
    <asp:GridView ID="GridView1" runat="server" Width="100%" AutoGenerateColumns="false">
    <Columns>
    <asp:TemplateField HeaderText="序号">
    <ItemTemplate><%#Eval("RowNum") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="职业编号">
    <ItemTemplate><%#Eval("CNNUMBER") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="职业名称">
    <ItemTemplate><%#Eval("CNNAME") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="职业描述">
    <ItemTemplate><%#Eval("CNDES") %></ItemTemplate>

    </asp:TemplateField>
    <asp:TemplateField HeaderText="职业工作描述">
    <ItemTemplate><%#Eval("CNWORK") %></ItemTemplate>
    <ItemStyle Width="50%" />
    </asp:TemplateField>
      <asp:TemplateField HeaderText="删除">
      <ItemTemplate>
          <asp:LinkButton ID="LinkButton2" oncommand="LinkButton2_Command"  CommandName='<%#Eval("CNNUMBER") %>' runat="server"><span style=" color:Red; font-size:larger">删除</span></asp:LinkButton>
      </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="修改">
    <ItemTemplate>
        <asp:LinkButton ID="LinkButton1" runat="server" CommandName='<%#Eval("CNNUMBER") %>' oncommand="LinkButton1_Command"><span style=" color:Red; font-size:larger">修改</span></asp:LinkButton>
    </ItemTemplate>
    </asp:TemplateField>
    </Columns>
    </asp:GridView>
<br />
    <webdiyer:AspNetPager ID="AspNetPager1" FirstPageText="首页" LastPageText="尾页" 
        PrevPageText="上一页" NextPageText="下一页" runat="server"  PageSize="10"
        onpagechanged="AspNetPager1_PageChanged">
    </webdiyer:AspNetPager>
</div>
</asp:Content>

