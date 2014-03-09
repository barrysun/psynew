<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="Forecastjob1List.aspx.cs" Inherits="admin_Forecastjob1List" Theme="Theme1" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
<br />
<br />
查询条件：&nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button
    ID="Button1" runat="server" Text="查询" OnClick="Button1_Click" />&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button2"
        runat="server" Text="添加" />&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button3" runat="server"
            Text="导出Excel" />
<br />
<br />
    <asp:GridView ID="GridView1" runat="server" Width="100%" AutoGenerateColumns="false">
    <Columns>
    <asp:TemplateField HeaderText="序号">
    <ItemTemplate><%#Eval("RowNum") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="CNMISSMAJOR">
    <ItemTemplate><%#Eval("CNMISSMAJOR") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="职业编号">
    <ItemTemplate><%#Eval("JOBID") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="职业1描述">
    <ItemTemplate><%#Eval("CNMAJOR1") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="职业2描述">
    <ItemTemplate><%#Eval("CNMAJOR2") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="职业3描述">
    <ItemTemplate><%#Eval("CNMAJOR3") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="删除">
      <ItemTemplate>
          <asp:LinkButton ID="LinkButton2" runat="server" CommandName='<%#Eval("FORECASTJOB1ID") %>' oncommand="LinkButton2_Command"><span style=" color:Red; font-size:larger">删除</span></asp:LinkButton>
      </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="修改">
    <ItemTemplate>
        <asp:LinkButton ID="LinkButton1" runat="server" CommandName='<%#Eval("JOBID") %>' oncommand="LinkButton1_Command"><span style=" color:Red; font-size:larger">修改</span></asp:LinkButton>
    </ItemTemplate>
    </asp:TemplateField>
    </Columns>
    </asp:GridView>
    <br />
    <webdiyer:AspNetPager ID="AspNetPager1" runat="server" PrevPageText="上一页" 
        FirstPageText="首页" NextPageText="下一页" LastPageText="尾页" PageSize="20" 
        onpagechanged="AspNetPager1_PageChanged">
    </webdiyer:AspNetPager>
</div>
</asp:Content>

