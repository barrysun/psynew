<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="UserList.aspx.cs" Inherits="admin_UserList" Theme="Theme1" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
    <asp:GridView ID="GridView1" runat="server" Width="100%">
    </asp:GridView>
    <br />
    <webdiyer:AspNetPager ID="AspNetPager1" runat="server" FirstPageText="首页" 
        NextPageText="下一页" PrevPageText="上一页" LastPageText="尾页" PageSize="20" 
        onpagechanged="AspNetPager1_PageChanged">
    </webdiyer:AspNetPager>
</div>
</asp:Content>

