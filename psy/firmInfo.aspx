<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="firmInfo.aspx.cs" Inherits="firmInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/base.css" rel="stylesheet" type="text/css" />
<link href="css/global.css" rel="stylesheet" type="text/css" />
<link href="css/infoManage.css" rel="stylesheet" type="text/css" />
<link href="css/sidebar.css" rel="stylesheet" type="text/css" />
    <script language="javascript" type="text/javascript" src="My97DatePicker/WdatePicker.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!--面包屑-->
<div class="curmbs">
	<span>您现在所在的位置：</span>
    <a href="index.html">首页</a>
    <span>&gt;</span>
    <span>企业信息管理</span>
</div>
<div class="content clearfix">
	<div class="leftNav fl">
    	<h3>招聘管理</h3>
        <div class="lnList">
        	<a class="on" href="javascript:;">企业招聘需求发布</a>
        </div>
       
         <div class="lnList">
        	<a href="firmInfoList.aspx">我发布的招聘信息</a>
        </div>
        <div class="lnList">
        	<a href="firmInfoList2.aspx">我收到的简历</a>
        </div>
        <div class="lnList">
        	<a href="firmInfoList3.aspx">我发送的邀请函</a>
        </div>
        
    </div>  
    <div class="rightMain fr">
    	<ul class="studyTit clearfix">
            <li class="current"><a href="javascript:;">发布职位</a></li>
        </ul>
        <div class="rmCont">
        	<h4 class="step bold14">带<span class="require">*</span>的为必填项</h4>
        	<table class="resume">
                <tbody>
                    <tr>
                        <td class="col1"><span class="require">*</span>职位名称：</td>
                        <td class="col2"><%--<input class="ipt" type="text" />--%>
                            <asp:TextBox ID="TextBox1"  CssClass="ipt" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="col1"><span class="require">*</span>性别要求：</td>
                        <td class="col2">
                            <asp:DropDownList ID="DropDownList4" runat="server">
                                <asp:ListItem Value="不限" Text="不限"></asp:ListItem>
                                 <asp:ListItem Value="男" Text="男"></asp:ListItem>
                                <asp:ListItem Value="女" Text="女"></asp:ListItem>
                            </asp:DropDownList>
                        	<%--<select>
                            	<option>不限</option>
                                <option>男</option>
                                <option>女</option>
                            </select>--%>
                        </td>
                    </tr>
                    <tr>
                        <td class="col1"><span class="require">*</span>工作性质：</td>
                        <td class="col2">
                            <asp:DropDownList ID="DropDownList5" runat="server">
                                <asp:ListItem Value="全职" Text="全职"></asp:ListItem>
                                <asp:ListItem Value="兼职" Text="兼职"></asp:ListItem>
                                <asp:ListItem Value="实习" Text="实习"></asp:ListItem>
                                <asp:ListItem Value="应届生" Text="应届生"></asp:ListItem>
                            </asp:DropDownList>
                        	<%--<select>
                            	<option>全职</option>
                                <option>兼职</option>
                                <option>实习</option>
                                <option>应届生</option>
                            </select>--%>
                        </td>
                    </tr>
                    <tr>
                        <td class="col1"><span class="require">*</span>招聘人数：</td>
                        <td class="col2">
                            <%--<input class="ipt" type="text" value="1"/>--%>
                            <asp:TextBox ID="TextBox2" CssClass="ipt" runat="server" Text="1"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="col1"><span class="require">*</span>招聘有效期：</td>
                        <td class="col2">
                        	<%--<input class="ipt" type="text"/>--%>
                            <asp:TextBox ID="TextBox3" onClick="WdatePicker()" CssClass="ipt" runat="server"></asp:TextBox>
                            <span>到</span>
                           <%-- <input class="ipt" type="text"/>--%>
                            <asp:TextBox ID="TextBox4" onClick="WdatePicker()" CssClass="ipt" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="col1"><span class="require">*</span>工作地点：</td>
                        <td class="col2">
                            <%--<input class="ipt" type="text" />--%>
                            <asp:TextBox ID="TextBox5" CssClass="ipt" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="col1"><span class="require">*</span>学历要求：</td>
                        <td class="col2">
                            <asp:DropDownList ID="DropDownList1" runat="server">
                                <asp:ListItem Value="不限制" Text="不限制"></asp:ListItem>
                                <asp:ListItem Value="初中" Text="初中"></asp:ListItem>
                                <asp:ListItem Value="高中" Text="高中"></asp:ListItem>
                                <asp:ListItem Value="中技" Text="中技"></asp:ListItem>
                                <asp:ListItem Value="中专" Text="中专"></asp:ListItem>
                                 <asp:ListItem Value="大专" Text="大专"></asp:ListItem>
                                <asp:ListItem Value="本科" Text="本科"></asp:ListItem>
                                <asp:ListItem Value="硕士" Text="硕士"></asp:ListItem>
                                <asp:ListItem Value="博士" Text="博士"></asp:ListItem>
                                <asp:ListItem Value="博士后" Text="博士后"></asp:ListItem>
                            </asp:DropDownList>
                        	<%--<select>
                            	<option>不限制</option>
                                <option>初中</option>
                                <option>高中</option>
                                <option>中技</option>
                                <option>中专</option>
                                <option>大专</option>
                                <option>本科</option>
                                <option>硕士</option>
                                <option>博士</option>
                                <option>博士后</option>
                            </select>--%>
                        </td>
                    </tr>
                    <tr>
                        <td class="col1"><span class="require">*</span>工作经验：</td>
                        <td class="col2">
                            <asp:DropDownList ID="DropDownList2" runat="server">
                                <asp:ListItem Value="不限制" Text="不限制"></asp:ListItem>
                                 <asp:ListItem Value="应届毕业生" Text="应届毕业生"></asp:ListItem>
                                <asp:ListItem Value="1年以下" Text="1年以下"></asp:ListItem>
                                <asp:ListItem Value="1-3年" Text="1-3年"></asp:ListItem>
                                <asp:ListItem Value="3-5年" Text="3-5年"></asp:ListItem>
                                <asp:ListItem Value="5-10年" Text="5-10年"></asp:ListItem>
                                <asp:ListItem Value="10年以上" Text="10年以上"></asp:ListItem>
                            </asp:DropDownList>
                        <%--	<select>
                            	<option>不限制</option>
                                <option>应届毕业生</option>
                                <option>1年以下</option>
                                <option>1-3年</option>
                                <option>3-5年</option>
                                <option>5-10年</option>
                                <option>10年以上</option>
                            </select>--%>
                        </td>
                    </tr>
                    <tr>
                        <td class="col1"><span class="require">*</span>工资范围：</td>
                        <td class="col2">
                            <asp:DropDownList ID="DropDownList3" runat="server">
                                <asp:ListItem Text="面议" Value="面议"></asp:ListItem>
                                <asp:ListItem Text="1000以下元/月" Value="1000以下元/月"></asp:ListItem>
                                <asp:ListItem Text="1000~2000元/月" Value="1000~2000元/月"></asp:ListItem>
                                <asp:ListItem Text="2000~3000元/月" Value="2000~3000元/月"></asp:ListItem>
                                <asp:ListItem Text="3000~5000元/月" Value="3000~5000元/月"></asp:ListItem>
                                <asp:ListItem Text="5000~10000元/月" Value="5000~10000元/月"></asp:ListItem>
                                <asp:ListItem Text="10000以上元/月" Value="10000以上元/月"></asp:ListItem>
                            </asp:DropDownList>
                        	<%--<select>
                            	<option>面议</option>
                                <option>1000以下元/月</option>
                                <option>1000~2000元/月</option>
                                <option>2000~3000元/月</option>
                                <option>3000~5000元/月</option>
                                <option>5000~10000元/月</option>
                                <option>10000以上元/月</option>
                            </select>--%>
                        </td>
                    </tr>
                    <tr>
                        <td class="col1 colTop"><span class="require">*</span>职位描述/要求：</td>
                        <td class="col2">
                            <asp:TextBox ID="TextBox6" runat="server" Height="103px" TextMode="MultiLine" Width="500px"></asp:TextBox>
                        	<%--<textarea></textarea>--%>
                        </td>
                    </tr>
                </tbody>
            </table>
            <div class="btnW">
               <%-- <a href="#">确认发布</a> --%>
                <asp:Button ID="Button1"  CssClass="loginBtn" runat="server" Text="发布" OnClick="Button1_Click" />
            </div>
        </div>
    </div>
</div>
</asp:Content>

