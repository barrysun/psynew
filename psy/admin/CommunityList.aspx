<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" CodeFile="CommunityList.aspx.cs" Inherits="admin_CommunityList" Theme="Theme1" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="width:100%">
        <br />
        <asp:Button ID="Button1" runat="server" Text="社会职业" OnClick="Button1_Click" />
        <br />
        <asp:GridView ID="GridView1" runat="server" Width="100%" AutoGenerateColumns="false">
            <Columns>
                <asp:TemplateField HeaderText="序号">
                    <ItemTemplate><%#Eval("RowNum") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="标题">
                    <ItemTemplate><%#Eval("TITLE") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="内容">
                    <ItemTemplate><%#Eval("CONTENT") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="时间">
                    <ItemTemplate><%#Eval("EDITTIME") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="是否首页显示（1表示首页显示）">
                    <ItemTemplate><%#Eval("ISHOME") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="排序字段">
                    <ItemTemplate><%#Eval("ORDER") %></ItemTemplate>
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
        <webdiyer:AspNetPager ID="AspNetPager1" FirstPageText="首页" NextPageText="下一页" PrevPageText="上一页" LastPageText="尾页" PageSize="20" runat="server" OnPageChanged="AspNetPager1_PageChanged"></webdiyer:AspNetPager>

    </div>
</asp:Content>

