<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="Lib4List.aspx.cs" Inherits="admin_Lib_Lib4List" Theme="Theme1" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
    <br />
    查询条件:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="查询" OnClick="Button1_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" Text="点击添加" OnClick="Button2_Click" />
    <br />
    <asp:GridView ID="GridView1" runat="server" Width="100%">
    </asp:GridView>
    <br />
    <webdiyer:AspNetPager ID="AspNetPager1" runat="server" PrevPageText="上一页" 
        NextPageText="下一页" FirstPageText="首页" LastPageText="尾页"  PageSize="20"
        onpagechanged="AspNetPager1_PageChanged">
    </webdiyer:AspNetPager>
</div>
</asp:Content>

