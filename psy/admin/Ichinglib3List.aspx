﻿<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="Ichinglib3List.aspx.cs" Inherits="admin_Iching_Ichinglib3List" Theme="Theme1" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
    <asp:GridView ID="GridView1" runat="server" Width="100%" AutoGenerateColumns="false">
        <Columns>
           <asp:TemplateField HeaderText="序号">
               <ItemTemplate><%#Eval("RowNum") %></ItemTemplate>
           </asp:TemplateField>
            <asp:TemplateField HeaderText="ID">
                <ItemTemplate><%#Eval("ID") %></ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="年">
                <ItemTemplate><%#Eval("YEAR") %></ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="月">
                <ItemTemplate><%#Eval("MONTH") %></ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="FDG">
                <ItemTemplate><%#Eval("FDG") %></ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="FDZ">
                <ItemTemplate><%#Eval("FDZ") %></ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="删除">
      <ItemTemplate>
          <asp:LinkButton ID="LinkButton2" runat="server" CommandName='<%#Eval("ID") %>' oncommand="LinkButton2_Command"><span style=" color:Red; font-size:larger">删除</span></asp:LinkButton>
      </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="修改">
    <ItemTemplate>
        <asp:LinkButton ID="LinkButton1" runat="server" CommandName='<%#Eval("ID") %>' oncommand="LinkButton1_Command"><span style=" color:Red; font-size:larger">修改</span></asp:LinkButton>
    </ItemTemplate>
    </asp:TemplateField>
            
        </Columns>
    </asp:GridView>
    <br />
    <webdiyer:AspNetPager ID="AspNetPager1" runat="server" PrevPageText="上一页" 
        NextPageText="下一页" LastPageText="尾页" FirstPageText="首页"  PageSize="20"
        onpagechanged="AspNetPager1_PageChanged">
    </webdiyer:AspNetPager>
</div>
</asp:Content>

