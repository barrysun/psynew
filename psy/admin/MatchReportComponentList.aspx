<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="MatchReportComponentList.aspx.cs" Inherits="admin_Component_MatchReportComponentList" Theme="Theme1" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
    <br />
    查询条件：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="查询条件" OnClick="Button1_Click" />
    <br />
    <asp:GridView ID="GridView1" runat="server" Width="100%" AutoGenerateColumns="false">
        <Columns>
            <asp:TemplateField HeaderText="序号">
                <ItemTemplate><%#Eval("RowNum") %></ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="PPNUM">
                <ItemTemplate><%#Eval("PPNUM") %></ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="VARIABLE">
                <ItemTemplate><%#Eval("VARIABLE") %></ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="VARIABLEVALUE">
                <ItemTemplate><%#Eval("VARIABLEVALUE") %></ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="REPORTCOMPONENT">
                <ItemTemplate><%#Eval("REPORTCOMPONENT") %></ItemTemplate>
                <ItemStyle  Width="50%"/>
            </asp:TemplateField>
             <asp:TemplateField HeaderText="删除">
      <ItemTemplate>
          <asp:LinkButton ID="LinkButton2" runat="server" CommandName='<%#Eval("MATCHREPCOMPID") %>' oncommand="LinkButton2_Command"><span style=" color:Red; font-size:larger">删除</span></asp:LinkButton>
      </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="修改">
    <ItemTemplate>
        <asp:LinkButton ID="LinkButton1" runat="server" CommandName='<%#Eval("MATCHREPCOMPID") %>' oncommand="LinkButton1_Command"><span style=" color:Red; font-size:larger">修改</span></asp:LinkButton>
    </ItemTemplate>
    </asp:TemplateField>
           

        </Columns>
    </asp:GridView>
    <br />
    <webdiyer:AspNetPager ID="AspNetPager1" runat="server" FirstPageText="首页" 
        PageSize="20" LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页" 
        onpagechanged="AspNetPager1_PageChanged">

    </webdiyer:AspNetPager>
</div>
</asp:Content>

