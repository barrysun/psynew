<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="TestReportList.aspx.cs" Inherits="admin_TestReportList" Theme="Theme1" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server" >
    <div style="width:100%">
        <br />
        <asp:Button ID="Button1" runat="server" Text="导出EXCEL" OnClick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" Text="导出输入EXCEL" OnClick="Button2_Click" />
        <br />
        <asp:GridView ID="GridView1" runat="server" Width="100%" AutoGenerateColumns="false">
            <Columns>
                <asp:TemplateField HeaderText="序号">
                    <ItemTemplate><%#Eval("RowNum") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="REPORTID">
                    <ItemTemplate><%#Eval("REPORTID") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="TestParams">
                    <ItemTemplate><%#Eval("TESTPARAMS") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="TESTREPORTVALUE1">
                    <ItemTemplate><%#Eval("TESTREPORTVALUE1") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="TESTREPORTVALUE2">
                    <ItemTemplate><%#Eval("TESTREPORTVALUE2") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="TESTTIME">
                    <ItemTemplate><%#Eval("TESTTIME") %></ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
        <webdiyer:AspNetPager ID="AspNetPager1" runat="server" FirstPageText="首页" LastPageText="尾页" PrevPageText="上一页" NextPageText="下一页" PageSize="20" OnPageChanged="AspNetPager1_PageChanged"></webdiyer:AspNetPager>

    </div>
</asp:Content>

