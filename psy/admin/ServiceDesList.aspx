<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="ServiceDesList.aspx.cs" Inherits="admin_ServiceDesList" Theme="Theme1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style="width:100%">
    <asp:GridView ID="GridView1" runat="server" Width="100%" AutoGenerateColumns="false">
        <Columns>
            <asp:TemplateField HeaderText="ID">
                <ItemTemplate><%#Eval("ID") %></ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="标题">
                <ItemTemplate><%#Eval("Title") %>
               </ItemTemplate></asp:TemplateField>
            <asp:TemplateField HeaderText="内容">
                <ItemTemplate><%#Eval("Des") %></ItemTemplate>
            </asp:TemplateField>
              <asp:TemplateField HeaderText="QQ">
                <ItemTemplate><%#Eval("InUrl") %></ItemTemplate>
            </asp:TemplateField>
             <asp:TemplateField HeaderText="排序">
                <ItemTemplate><%#Eval("Order") %></ItemTemplate>
            </asp:TemplateField>
             <asp:TemplateField HeaderText="修改">
    <ItemTemplate>
        <asp:LinkButton ID="LinkButton1" runat="server" CommandName='<%#Eval("ID") %>' oncommand="LinkButton1_Command"><span style=" color:Red; font-size:larger">修改</span></asp:LinkButton>
    </ItemTemplate>
    </asp:TemplateField>
        </Columns>

    </asp:GridView>

</div>
</asp:Content>

