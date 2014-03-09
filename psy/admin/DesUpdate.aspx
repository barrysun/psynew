<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="DesUpdate.aspx.cs" Inherits="admin_DesUpdate" %>

<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="width:109%">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></div>
        <div style="width:80%">
            <FCKeditorV2:FCKeditor ID="FCKeditor1" runat="server"></FCKeditorV2:FCKeditor>
            <br />
            <asp:Button ID="Button1" runat="server" Text="保存" Height="19px" OnClick="Button1_Click" />
        </div>

    </div>
</asp:Content>

