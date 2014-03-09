<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="YlList.aspx.cs" Inherits="admin_YlList" Theme="Theme1" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="width:100%">
        <asp:GridView ID="GridView1" runat="server" Width="100%" AutoGenerateColumns="false">
            <Columns>
                <asp:TemplateField HeaderText="序号">
                    <ItemTemplate><%#Eval("RowNum") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="ID">
                    <ItemTemplate><%#Eval("ID") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="年" ><ItemTemplate><%#Eval("YYEAR") %></ItemTemplate></asp:TemplateField>
            <asp:TemplateField HeaderText="月">
                <ItemTemplate><%#Eval("YMONTH") %></ItemTemplate>
            </asp:TemplateField>
                <asp:TemplateField HeaderText="天"><ItemTemplate><%#Eval("YDAY") %></ItemTemplate></asp:TemplateField>
           <asp:TemplateField HeaderText="月令"><ItemTemplate><%#Eval("YDES") %></ItemTemplate></asp:TemplateField>
                <asp:TemplateField HeaderText="时间"><ItemTemplate><%#Eval("DTIME") %></ItemTemplate></asp:TemplateField>
                <asp:TemplateField HeaderText="全时间"><ItemTemplate><%#Eval("YMD") %></ItemTemplate></asp:TemplateField>

           
                     </Columns>
        </asp:GridView>
        <webdiyer:AspNetPager ID="AspNetPager1" runat="server" FirstPageText="首页" NextPageText="下一页" PrevPageText="上一页" LastPageText="尾页" PageSize="20" OnPageChanged="AspNetPager1_PageChanged"></webdiyer:AspNetPager>
    </div>

</asp:Content>

