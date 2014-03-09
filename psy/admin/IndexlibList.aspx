<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="IndexlibList.aspx.cs" Inherits="admin_Lib_IndexlibList" Theme="Theme1" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
    <br />
    查询条件：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> <asp:Button ID="Button1" runat="server" Text="查询" OnClick="Button1_Click" />
    <br />
    <asp:GridView ID="GridView1" runat="server" Width="100%" AutoGenerateColumns="false">
        <Columns>
            <asp:TemplateField HeaderText="序号">
                <ItemTemplate><%#Eval("RowNum") %></ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="CNNUMBER">
                <ItemTemplate><%#Eval("CNNUMBER") %></ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="CNNAME">
                <ItemTemplate><%#Eval("CNNAME") %></ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="LIB2">
                <ItemTemplate><%#Eval("LIB2") %></ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="LIB3">
                <ItemTemplate><%#Eval("LIB3") %></ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="CN_duty1">
                <ItemTemplate><%#Eval("CN_duty1") %></ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="CN_duty2">
                <ItemTemplate><%#Eval("CN_duty2") %></ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="CN_duty3">
                <ItemTemplate><%#Eval("CN_duty3") %></ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="CN_salary1">
                <ItemTemplate><%#Eval("CN_salary1") %></ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="CN_salary2">
                <ItemTemplate><%#Eval("CN_salary2") %></ItemTemplate>
            </asp:TemplateField>
               <asp:TemplateField HeaderText="删除">
      <ItemTemplate>
          <asp:LinkButton ID="LinkButton2" runat="server" CommandName='<%#Eval("CNNUMBER") %>' oncommand="LinkButton2_Command"><span style=" color:Red; font-size:larger">删除</span></asp:LinkButton>
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
    <webdiyer:AspNetPager ID="AspNetPager1" runat="server" PrevPageText="上一页" 
        NextPageText="下一页" LastPageText="尾页" FirstPageText="首页" PageSize="20" 
        onpagechanged="AspNetPager1_PageChanged">
    </webdiyer:AspNetPager>
</div>
</asp:Content>

