<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="talentback2.aspx.cs" Inherits="talentback2" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/base.css" rel="stylesheet" type="text/css" />
<link href="css/global.css" rel="stylesheet" type="text/css" />
<link href="css/talent.css" rel="stylesheet" type="text/css" />
<link href="css/common.css" rel="stylesheet" type="text/css" />
       
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!--面包屑-->
<div class="curmbs">
	<span>您现在所在的位置：</span>
    <span>&gt;</span>
    <span>求职与招聘平台</span>
</div>
<div class="content clearfix">
    <div class="tabs1 platform">
    	<ul class="tab_menu studyTit clearfix">
            <li class="current"><a href="javascript:;">找工作</a></li>
        </ul>
        <div class="tab_box">
             
          
            <div class="">
                <div class="filterT">
                     <%=zhaogongzuo() %>
                    <div class="row">
                        <span class="filterSpan">关键字：</span>
                       <%-- <input class="talentIpt" type="text" />
                        <input class="loginBtn" type="button" value="搜索" />--%>
                         <asp:TextBox ID="TextBox4" CssClass="talentIpt" runat="server"></asp:TextBox>
                        <asp:Button ID="Button3" CssClass="loginBtn" OnClick="Button3_Click" runat="server" Text="搜索" />
                    </div>
                </div>
                <div class="detInfo">
                    <table class="tabList" width="100%">
                        <thead>
                            <th class="col1">职位名称</th>
                            <th class="col2">招聘人数</th>
                            <th class="col3">工资范围</th>
                            <th class="col4">企业名称</th>
                            <th class="col5"></th>
                        </thead>
                        <tbody>
                             <asp:Repeater ID="Repeater2" runat="server">
                                <ItemTemplate>
                                 <tr>
                                <td  class="col1">
                                	<a class="unline" href="javascript:window.open('tjobsdet.aspx?id=<%#Eval("Id") %>');"><%#Eval("Zhiwei") %></a>
                                </td>
                                <td  class="col2"><%#Eval("Renshu") %></td>
                                <td  class="col3"><%#Eval("Gzfw") %></td>
                                <td  class="col4"><%#Eval("GongName") %></td>
                                <td  class="col5">
                                	<a class="" href="#">一键申请</a>
                                </td>
                            </tr>

                                </ItemTemplate>
                            </asp:Repeater>
                           
                        </tbody>
                    </table>
                    <div class="page">

                        <webdiyer:AspNetPager ID="AspNetPager1" FirstPageText="首页" NextPageText="下一页" PrevPageText="上一页" LastPageText="尾页" PageSize="20" runat="server" OnPageChanged="AspNetPager1_PageChanged"></webdiyer:AspNetPager>
                        <%--<ul class="clearfix">
                            <li><a href="#">首页</a></li>
                            <li><a href="#">上一页</a></li>
                            <li><span>1</span></li>
                            <li><a href="">2</a></li>
                            <li><a href="">3</a></li>
                            <li><a href="">下一页</a></li>
                            <li><a href="">尾页</a></li>
                        </ul>--%>
                         <!-- 找工作-->
                    <asp:HiddenField ID="HiddenField6" Value="0" runat="server" />
                    <asp:HiddenField ID="HiddenField7" Value="0" runat="server" />
                    <asp:HiddenField ID="HiddenField8" Value="0" runat="server" />

                    </div>
                </div>
            </div>
        </div>
    </div>
   
</div>
</asp:Content>

