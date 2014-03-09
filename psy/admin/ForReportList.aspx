<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="ForReportList.aspx.cs" Inherits="admin_ForReportList" Theme="Theme1" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="width:100%">
        <br />
        <asp:Button ID="Button1" runat="server" Text="导出EXCEL" OnClick="Button1_Click" />&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <asp:GridView ID="GridView1" runat="server" Width="100%" AutoGenerateColumns="false">
            <Columns>
                <asp:TemplateField HeaderText="序号">
                    <ItemTemplate><%#Eval("RowNum") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="REPORTID">
                    <ItemTemplate><%#Eval("REPORTID") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="USERID">
                    <ItemTemplate><%#Eval("USERID") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="FORECASTREPORTPARAM">
                    <ItemTemplate><%#Eval("FORECASTREPORTPARAM") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="FORECASTREPORTVALUE1">
                    <ItemTemplate><%#Eval("FORECASTREPORTVALUE1") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="FORECASTREPORTVALUE2">
                    <ItemTemplate><span style="word-break:break-all;
word-wrap:break-word;"><%#Eval("FORECASTREPORTVALUE2") %></span></ItemTemplate>
                    <ItemStyle Width="50%" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="FORECASTTIME">
                    <ItemTemplate><%#Eval("FORECASTTIME") %></ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
        <webdiyer:AspNetPager ID="AspNetPager1" runat="server" FirstPageText="首页" NextPageText="下一页" LastPageText="尾页" PrevPageText="上一页" PageSize="20" OnPageChanged="AspNetPager1_PageChanged"></webdiyer:AspNetPager>

    </div>
</asp:Content>

