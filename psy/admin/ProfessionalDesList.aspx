<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" Theme="Theme1" CodeFile="ProfessionalDesList.aspx.cs" Inherits="admin_ProfessionalDesList" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    大学专业介绍
    <asp:Button ID="Button1" runat="server" Text="添加大学专业介绍" OnClick="Button1_Click" />
    <br />
    <asp:GridView ID="GridView1" runat="server" Width="100%"></asp:GridView>
    <br />
    <webdiyer:AspNetPager ID="AspNetPager1" runat="server" PrevPageText="上一页"
         LastPageText="尾页" FirstPageText="首页"  NextPageText="下一页" OnPageChanged="AspNetPager1_PageChanged"></webdiyer:AspNetPager>
</asp:Content>

