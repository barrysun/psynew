<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" Theme="Theme1" CodeFile="ChanPingList.aspx.cs" Inherits="admin_ChanPingList" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    产品List
    <asp:Button ID="Button1" runat="server" Text="添加产品" OnClick="Button1_Click" />
    <br />
    <asp:GridView ID="GridView1" runat="server" Width="100%"></asp:GridView>
    <br />
    <webdiyer:AspNetPager ID="AspNetPager1" runat="server" FirstPageText="首页" LastPageText="尾页" PrevPageText="上一页"  NextPageText="下一页" PageSize="20" OnPageChanged="AspNetPager1_PageChanged"></webdiyer:AspNetPager>
</asp:Content>

