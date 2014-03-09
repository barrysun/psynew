<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="myJobs.aspx.cs" Inherits="myJobs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script language="javascript" type="text/javascript" src="My97DatePicker/WdatePicker.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<!--面包屑-->
<div class="curmbs">
	<span>您现在所在的位置：</span>
   
    <span>&gt;</span>
    <span>个人信息管理</span>
</div>
<div class="content clearfix">
	<div class="leftNav fl">
    	<h3>简历管理</h3>
        <div class="lnList">
        	<a class="on" href="javascript:;">创建新简历</a>
        </div>
        <div class="lnList">
        	<a href="myResume.aspx">简历管理</a>
        </div>
        <h3>求职管理</h3>
       
        <div class="lnList">
        	<a href="#">我申请过的职位</a>
        </div>
    </div>  
    <div class="rightMain fr">
    	<ul class="studyTit clearfix">
            <li class="current"><a href="javascript:;">我的简历</a></li>
        </ul>
        <div class="rmCont">
        <h4 class="step bold14">第一步-创建基本信息（带<span class="require">*</span>的为必填）</h4>
        <table class="resume">
        	<tbody>
                <tr>
                	<td class="col1"><span class="require">*</span>简历名称：</td>
                    <td class="col2">
                       <%-- <input class="ipt" type="text" />--%>
                        <asp:TextBox ID="TextBox1" CssClass="ipt" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                	<td class="col1"><span class="require">*</span>真实姓名：</td>
                    <td class="col2">
                       <%-- <input class="ipt" type="text" />--%>
                         <asp:TextBox ID="TextBox2" CssClass="ipt" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                	<td class="col1"><span class="require">*</span>性别：</td>
                    <td class="col2">
                    	 <asp:DropDownList ID="DropDownList4" runat="server">
                                 <asp:ListItem Value="男" Text="男"></asp:ListItem>
                                <asp:ListItem Value="女" Text="女"></asp:ListItem>
                            </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                	<td class="col1"><span class="require">*</span>出生年月：</td>
                    <td class="col2">
                       <%-- <input class="ipt" type="text" />--%>
                         <asp:TextBox ID="TextBox3" onClick="WdatePicker()"  CssClass="ipt" runat="server"></asp:TextBox>
                        
                        <span>如1985-10-03</span></td>
                </tr>
                <tr>
                	<td class="col1">身高：</td>
                    <td class="col2">
                     <%--   <input class="ipt" type="text" />--%>
                         <asp:TextBox ID="TextBox4" CssClass="ipt" runat="server"></asp:TextBox>
                        <span>cm</span></td>
                </tr>
                <tr>
                	<td class="col1"><span class="require">*</span>婚姻状态：</td>
                    <td class="col2">
                        <asp:DropDownList ID="DropDownList3" runat="server">
                            <asp:ListItem Value="未婚" Text="未婚"></asp:ListItem>
                             <asp:ListItem Value="已婚" Text="已婚"></asp:ListItem>
                             <asp:ListItem Value="保密" Text="保密"></asp:ListItem>
                        </asp:DropDownList>
                    	<%--<label  class="labelOne"><input type="radio" />未婚</label>
                    	<label class="labelOne"><input type="radio" />已婚</label>
                        <label class="labelOne"><input type="radio" />保密</label>--%>
                    </td>
                </tr>
                <tr>
                	<td class="col1"><span class="require">*</span>工作经验：</td>
                    <td class="col2">
                    	<asp:DropDownList ID="DropDownList2" runat="server">
                             
                                 <asp:ListItem Value="应届毕业生" Text="应届毕业生"></asp:ListItem>
                                <asp:ListItem Value="1年以下" Text="1年以下"></asp:ListItem>
                                <asp:ListItem Value="1-3年" Text="1-3年"></asp:ListItem>
                                <asp:ListItem Value="3-5年" Text="3-5年"></asp:ListItem>
                                <asp:ListItem Value="5-10年" Text="5-10年"></asp:ListItem>
                                <asp:ListItem Value="10年以上" Text="10年以上"></asp:ListItem>
                            </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                	<td class="col1"><span class="require">*</span>最高学历：</td>
                    <td class="col2">
                      <asp:DropDownList ID="DropDownList1" runat="server">
                               
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
                    </td>
                </tr>
                <tr>
                	<td class="col1">特长标签：</td>
                    <td class="col2">
                    	<div class="tagsW">
                   
                            <asp:TextBox class="ipt specialty" ID="TextBox11" runat="server"></asp:TextBox>
                            <div class="tagsCont">
                            	<h4 class="bold14">精准的选择标签可有效提高求职效果，可多选，最多可以选择5项</h4>
                                <ul class="tagsDet clearfix">
                                	<li><label><input type="checkbox" />形象气质佳</label></li>
                                    <li><label><input type="checkbox" />学习力强</label></li>
                                    <li><label><input type="checkbox" />IT技术流</label></li>
                                    <li><label><input type="checkbox" />诚信正直</label></li>
                                    <li><label><input type="checkbox" />技术精悍</label></li>
                                    <li><label><input type="checkbox" />责任心强</label></li>
                                    <li><label><input type="checkbox" />吃苦耐劳</label></li>
                                    <li><label><input type="checkbox" />抗压力强</label></li>
                                    <li><label><input type="checkbox" />沉稳内敛</label></li>
                                    <li><label><input type="checkbox" />开朗活泼</label></li>
                                    <li><label><input type="checkbox" />经验丰富</label></li>
                                    <li><label><input type="checkbox" />有亲和力</label></li>
                                    <li><label><input type="checkbox" />媒体资源</label></li>
                                    <li><label><input type="checkbox" />善于创新</label></li>
                                    <li><label><input type="checkbox" />客户资源丰富</label></li>
                                    <li><label><input type="checkbox" />项目经验</label></li>
                                    <li><label><input type="checkbox" />有创业经历</label></li>
                                    <li><label><input type="checkbox" />有上进心</label></li>
                                    <li><label><input type="checkbox" />会开车</label></li>
                                    <li><label><input type="checkbox" />海归</label></li>
                                    <li><label><input type="checkbox" />口才好</label></li>
                                    <li><label><input type="checkbox" />会应酬</label></li>
                                    <li><label><input type="checkbox" />适应加班</label></li>
                                    <li><label><input type="checkbox" />外语好</label></li>
                                </ul>
                                <div class="tagBtn">
                                	<a class="loginBtn tagSure" href="javascript:;">确定</a>
                                </div>
                            </div>
                        </div>
                    </td>
                </tr>
                <tr>
                	<td class="col1"><span class="require">*</span>户口所在地：</td>
                    <td class="col2"><%--<input class="ipt" type="text" />--%>
                        <asp:TextBox ID="TextBox5" CssClass="ipt" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                	<td class="col1"><span class="require">*</span>联系电话：</td>
                    <td class="col2"><%--<input class="ipt" type="text" />--%>
                        <asp:TextBox ID="TextBox6" CssClass="ipt" runat="server"></asp:TextBox>
                        <span class="require">非常重要，招聘方会通过此电话与您联系！</span></td>
                </tr>
                <tr>
                	<td class="col1"><span class="require">*</span>电子邮箱：</td>
                    <td class="col2"><%--<input class="ipt" type="text" />--%>
                        <asp:TextBox ID="TextBox7" CssClass="ipt" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                	<td class="col1"><span class="require">*</span>联系QQ：</td>
                    <td class="col2"><%--<input class="ipt" type="text" />--%>
                        <asp:TextBox ID="TextBox8" CssClass="ipt" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                	<td class="col1">通讯地址：</td>
                    <td class="col2"><%--<input class="ipt" type="text" />--%>
                        <asp:TextBox ID="TextBox9" CssClass="ipt" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                	<td class="col1">个人主页/博客：</td>
                    <td class="col2"><%--<input class="ipt" type="text" />--%>
                        <asp:TextBox ID="TextBox10" CssClass="ipt" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </tbody>
        </table>
        <div class="btnW">
        	<%--<a href="#">保存并跳到下一步</a> --%>
            <asp:Button ID="Button1" runat="server" CssClass="loginBtn" Text="下一步" Width="78px" OnClick="Button1_Click" />
        </div>
        </div>
    </div>
</div>
    <script type="text/javascript" src="jquery/jquery-1.9.1.min.js"></script>
<script type="text/javascript" src="js/resume.js"></script>
</asp:Content>

