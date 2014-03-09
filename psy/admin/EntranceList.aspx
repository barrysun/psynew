<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="EntranceList.aspx.cs" Inherits="admin_EntranceList" Theme="Theme1" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="width:100%">
    <br />
        <asp:Button ID="Button1" runat="server" Text="添加" OnClick="Button1_Click" />
    <br />
        <asp:GridView Width="100%" ID="GridView1" runat="server"></asp:GridView>
        <br />
        <webdiyer:AspNetPager ID="AspNetPager1" runat="server" FirstPageText="首页" NextPageText="下一页" LastPageText="尾页" PrevPageText="上一页" PageSize="20" OnPageChanged="AspNetPager1_PageChanged"></webdiyer:AspNetPager>

    </div>
</asp:Content>

