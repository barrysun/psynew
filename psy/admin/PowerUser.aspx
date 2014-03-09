<%@ Page Title="" Language="C#" MasterPageFile="~/admin/index.master" AutoEventWireup="true" Theme="Theme1" CodeFile="PowerUser.aspx.cs" Inherits="admin_PowerUser" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    PowerUser

    <div>
        <br />
        <table>
            <tr><td>用户名：</td><td>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td><td></td></tr>
            <tr><td>匹配次数：</td><td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td><td></td></tr>
            <tr><td>
                <asp:Label ID="Label2" runat="server" Visible="false" Text=""></asp:Label></td><td>
                <asp:Button ID="Button5" runat="server" Text="设置" OnClick="Button5_Click" /></td><td></td></tr>
        </table>
        <br />
        查询条件：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox> &nbsp;&nbsp;<asp:DropDownList ID="DropDownList1" runat="server">

                                                                                  </asp:DropDownList>&nbsp;&nbsp;<asp:Button ID="Button6" runat="server" Text="查询" OnClick="Button6_Click" />
        <br />
        <asp:GridView ID="GridView1" AutoGenerateColumns="false" runat="server" OnRowDataBound="GridView1_RowDataBound">
            <Columns>
                <asp:TemplateField HeaderText="编号">
                    <ItemTemplate><%#Eval("RowNum") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="用户编号">
                    <ItemTemplate><%#Eval("Id") %></ItemTemplate>
                </asp:TemplateField>
                    <asp:TemplateField HeaderText="用户姓名">
                    <ItemTemplate><%#Eval("RealName") %></ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="登陆名">
                    <ItemTemplate><%#Eval("LoginName") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="IP测试题答题情况">
                    <ItemTemplate><%#Eval("IPORDER") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="WIL测试题答题情况">
                    <ItemTemplate><%#Eval("WILORDER") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="EQI测试题答题情况">
                    <ItemTemplate><%#Eval("EQIORDER") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="易经计算">
                    <ItemTemplate>

                        <asp:Button ID="Button3"  CommandName='<%#Eval("Id") %>' CommandArgument='<%#Eval("Isiching") %>' runat="server" OnCommand="Button3_Command" Text="易经计算" /></ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="测评报告权限">
                    <ItemTemplate><asp:Button ID="Button1"  CommandName='<%#Eval("Id") %>' CommandArgument='<%#Eval("IsTest") %>' runat="server" OnCommand="Button1_Command" Text="生成测评报告" /> </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="预测报告权限">
                    <ItemTemplate><asp:Button ID="Button2"  CommandName='<%#Eval("Id") %>' CommandArgument='<%#Eval("IsFor") %>' runat="server" OnCommand="Button1_Command1" Text="生成预测报告" /> </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="匹配次数权限">
                    <ItemTemplate>
                          <%#Eval("McCount") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="添加次数">
                    <ItemTemplate>
                        <asp:Button ID="Button4" OnCommand="Button4_Command"  CommandName='<%#Eval("Id") %>' runat="server" Text="设置匹配次数" />
                    </ItemTemplate>          
                </asp:TemplateField>
            </Columns>
        </asp:GridView><br />
        <webdiyer:AspNetPager ID="AspNetPager1" PrevPageText="上一页" NextPageText="下一页" FirstPageText="首页" LastPageText="尾页" runat="server" PageSize="15" OnPageChanged="AspNetPager1_PageChanged"></webdiyer:AspNetPager>


    </div>
</asp:Content>

