<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="firmInfo1.aspx.cs" Inherits="firmInfo1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
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
    	
        <h3>信息管理</h3>
        <div class="lnList">
        	<a class="on" href="javascript:;">企业信息管理</a>
        </div>
        <div class="lnList">
        	<a href="firmInfo2.aspx">营业执照</a>
        </div>
    </div>  
    <div class="rightMain fr">
    	<ul class="studyTit clearfix">
            <li class="current"><a href="javascript:;">企业基本信息</a></li>
        </ul>
        <div class="rmCont">
        	<h4 class="step bold14">完善了基本信息后，才可以发布招聘职位（带<span class="require">*</span>的为必填项）</h4>
        	<table class="resume">
                <tbody>
                    <tr>
                        <td class="col1"><span class="require">*</span>公司名称：</td>
                        <td class="col2">
                           <%-- <input class="ipt" type="text" />--%>
                            <asp:TextBox ID="TextBox1" CssClass="ipt" runat="server"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td class="col1"><span class="require">*</span>企业性质：</td>
                        <td class="col2">
                            <asp:DropDownList ID="DropDownList1" runat="server">
                                <asp:ListItem Value="国企" Text="国企"></asp:ListItem>
                                <asp:ListItem Value="民营" Text="民营"></asp:ListItem>
                                <asp:ListItem Value="合资" Text="合资"></asp:ListItem>
                                <asp:ListItem Value="外商独资" Text="外商独资"></asp:ListItem>
                                <asp:ListItem Value="股份制企业" Text="股份制企业"></asp:ListItem>
                                <asp:ListItem Value="上市公司" Text="上市公司"></asp:ListItem>
                                 <asp:ListItem Value="国家机关" Text="国家机关"></asp:ListItem>
                                 <asp:ListItem Value="事业单位" Text="事业单位"></asp:ListItem>
                                <asp:ListItem Value="其他" Text="其他"></asp:ListItem>
                            </asp:DropDownList>
                        	<%--<select>
                            	<option>国企</option>
                                <option>民营</option>
                                <option>合资</option>
                                <option>外商独资</option>
                                <option>股份制企业</option>
                                <option>上市公司</option>
                                <option>国家机关</option>
                                <option>事业单位</option>
                                <option>其他</option>
                            </select>--%>
                        </td>
                    </tr>
                    <tr>
                        <td class="col1"><span class="require">*</span>所属行业：</td>
                        <td class="col2">
                        	<div class="tagsW">
                                <input class="ipt specialty" readonly />
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
                        <td class="col1"><span class="require">*</span>通讯地址：</td>
                        <td class="col2">
                           <%-- <input class="ipt" type="text" value="1"/>--%>
                            <asp:TextBox ID="TextBox2" CssClass="ipt" runat="server"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td class="col1"><span class="require">*</span>公司规模：</td>
                        <td class="col2">
                            <asp:DropDownList ID="DropDownList2" runat="server">
                                <asp:ListItem Value="20人以下" Text="20人以下"></asp:ListItem>
                                 <asp:ListItem Value="20-99人" Text="20-99人"></asp:ListItem>
                                <asp:ListItem Value="500-999人" Text="500-999人"></asp:ListItem>
                                <asp:ListItem Value="1000-9999人" Text="1000-9999人"></asp:ListItem>
                                <asp:ListItem Value="10000人以上" Text="10000人以上"></asp:ListItem>
                            </asp:DropDownList>
                        	<%--<select>
                            	<option>20人以下</option>
                                <option>20-99人</option>
                                <option>100-499人</option>
                                <option>500-999人</option>
                                <option>1000-9999人</option>
                                <option>10000人以上</option>
                            </select>--%>
                        </td>
                    </tr>
                    <tr>
                        <td class="col1"><span class="require">*</span>注册资金：</td>
                        <td class="col2">
                        	<%--<input class="ipt" type="text" />--%>
                            <asp:TextBox ID="TextBox3" CssClass="ipt" runat="server"></asp:TextBox>
                            <label class="labelOne"><input type="radio" name="" />人民币</label>
                            <label class="labelOne"><input type="radio" name="" />美元</label>
                        </td>
                    </tr>
                    <tr>
                        <td class="col1"><span class="require">*</span>联系人：</td>
                        <td class="col2">
                            <%--<input class="ipt" type="text" />--%>
                            <asp:TextBox ID="TextBox4" CssClass="ipt" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="col1"><span class="require">*</span>联系人QQ：</td>
                        <td class="col2">
                            <%--<input class="ipt" type="text" />--%>
                            <asp:TextBox ID="TextBox5" CssClass="ipt" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="col1"><span class="require">*</span>联系电话：</td>
                        <td class="col2">
                            <%--<input class="ipt" type="text" />--%>
                            <asp:TextBox ID="TextBox6" CssClass="ipt" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="col1"><span class="require">*</span>联系邮箱：</td>
                        <td class="col2">
                           <%-- <input class="ipt" type="text" />--%>
                            <asp:TextBox ID="TextBox7" CssClass="ipt" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="col1">公司网址：</td>
                        <td class="col2">
                            <%--<input class="ipt" type="text" />--%>
                            <asp:TextBox ID="TextBox8" CssClass="ipt" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="col1 colTop">公司介绍：</td>
                        <td class="col2">
                        	<%--<textarea></textarea>--%>
                            <asp:TextBox ID="TextBox9" runat="server" Height="127px" TextMode="MultiLine" Width="553px"></asp:TextBox>
                        </td>
                    </tr>
                </tbody>
            </table>
            <div class="btnW">
               <%-- <a href="#">确认发布</a> --%>
                <asp:Button ID="Button1" CssClass="loginBtn" runat="server" Text="确认" OnClick="Button1_Click" />
            </div>
        </div>
    </div>
</div>
</asp:Content>

