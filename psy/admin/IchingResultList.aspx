<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="IchingResultList.aspx.cs" Inherits="admin_Report_IchingResultList" Theme="Theme1" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="width:100%">
        <br />
        <asp:Button ID="Button1" runat="server" Text="导出EXCEL" OnClick="Button1_Click" />
        <br />

        <asp:GridView ID="GridView1" runat="server" Width="100%" AutoGenerateColumns="false">
            <Columns>
                <asp:TemplateField HeaderText="序号">
                    <ItemTemplate><%#Eval("RowNum") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="ID">
                    <ItemTemplate><%#Eval("ID") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="RNUMBER">
                    <ItemTemplate><%#Eval("RNUMBER") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="出生时间">
                    <ItemTemplate><%#Eval("BIRTHDAY") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="NG">
                    <ItemTemplate><%#Eval("NG") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="NZ">
                    <ItemTemplate><%#Eval("NZ") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="YG">
                    <ItemTemplate><%#Eval("YG") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="YZ">
                    <ItemTemplate><%#Eval("YZ") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="RG">
                    <ItemTemplate><%#Eval("RG") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="RZ">
                    <ItemTemplate><%#Eval("RZ") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="SG">
                    <ItemTemplate><%#Eval("SG") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="SWX">
                    <ItemTemplate><%#Eval("SWX") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="SRX">
                    <ItemTemplate><%#Eval("SRX") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="YS_1">
                    <ItemTemplate><%#Eval("YS_1") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="YS_2">
                    <ItemTemplate><%#Eval("YS_2") %></ItemTemplate>
                </asp:TemplateField>
            </Columns>

        </asp:GridView>
        <br />

        <webdiyer:AspNetPager ID="AspNetPager1" runat="server" FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页" PageSize="20" OnPageChanged="AspNetPager1_PageChanged"></webdiyer:AspNetPager>

    </div>
</asp:Content>

