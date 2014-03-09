<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="myInfo1.aspx.cs" Inherits="myInfo1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!--面包屑-->
<div class="curmbs">
	<span>您现在所在的位置：</span>

    <span>&gt;</span>
    <span>完备个人信息</span>
</div>
<div class="content clearfix">
	<div class="leftNav fl">
    	<h3>第一步</h3>
        <div class="lnList">
        	<a href="myInfo.aspx">管理自己的基本信息</a>
        </div>
        <h3>第二步</h3>
        <div class="lnList">
        	<a class="on" href="javascript:;">目前就读学校(学生填写)</a>
        </div>
        <h3>第三步</h3>
        <div class="lnList">
        	<a href="myInfo2.aspx">目前就职情况(在职人员填写)</a>
        </div>
        <h3>第四步</h3>
        <div class="lnList">
        	<a href="myInfo3.aspx">其他信息</a>
        </div>
    </div>  
    <div class="rightMain fr">
    	<ul class="studyTit clearfix">
            <li class="current"><a href="javascript:;">目前就读的学校</a></li>
        </ul>
        <div class="rmCont">
        	<h4 class="step bold14">在校学生填写</h4>
            <table class="resume" width="100%">
            	<tbody>
                    <tr>
                    	<td class="col1">目前就读的学校：</td>
                        <td class="col2">
                        	<%--<input class="ipt" type="text" />--%>
                            <asp:TextBox ID="TextBox1" CssClass="ipt" runat="server"></asp:TextBox>
                        	<span class="gas"></span>
                            <asp:DropDownList ID="DropDownList3" runat="server">
                                <asp:ListItem Value="非重点" Text="非重点"></asp:ListItem>
                                <asp:ListItem Value="重点" Text="重点"></asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                    	<td class="col1">所在年级：</td>
                        <td class="col2">
                            <asp:DropDownList ID="DropDownList1" runat="server">
                                <asp:ListItem Text="初一" Value="初一"></asp:ListItem>
                                 <asp:ListItem Text="初二" Value="初二"></asp:ListItem>
                                  <asp:ListItem Text="初三" Value="初三"></asp:ListItem>
                                  <asp:ListItem Text="高一" Value="高一"></asp:ListItem>
                                  <asp:ListItem Text="高二" Value="高二"></asp:ListItem>
                                  <asp:ListItem Text="高三" Value="高三"></asp:ListItem>
                                  <asp:ListItem Text="大一" Value="大一"></asp:ListItem>
                                  <asp:ListItem Text="大二" Value="大二"></asp:ListItem>
                                  <asp:ListItem Text="大三" Value="大三"></asp:ListItem>
                                  <asp:ListItem Text="大四" Value="大四"></asp:ListItem>
                            </asp:DropDownList>
                        	<%--<select>
                            	<option>初一</option>
                                <option>初二</option>
                                <option>初三</option>
                                <option>高一</option>
                                <option>高二</option>
                                <option>高三</option>
                                <option>大一</option>
                                <option>大二</option>
                                <option>大三</option>
                                <option>大四</option>
                            </select>--%>
                        </td>
                    </tr>
                    <tr>
                        <td class="col1">班级：</td>
                        <td class="col2">
                            <div class="tagsW">
                                <asp:TextBox ID="TextBox2" CssClass="ipt specialty"   runat="server"></asp:TextBox>
                                <div class="tagsCont">
                                    <h4 class="bold14"></h4>
                                    <ul class="tagsDet clearfix">
                                        <li><label><input type="radio" name="grade" />1班</label></li>
                                        <li><label><input type="radio" name="grade" />2班</label></li>
                                        <li><label><input type="radio" name="grade" />3班</label></li>
                                        <li><label><input type="radio" name="grade" />4班</label></li>
                                        <li><label><input type="radio" name="grade" />5班</label></li>
                                        <li><label><input type="radio" name="grade" />6班</label></li>
                                        <li><label><input type="radio" name="grade" />7班</label></li>
                                        <li><label><input type="radio" name="grade" />8班</label></li>
                                        <li><label><input type="radio" name="grade" />9班</label></li>
                                        <li><label><input type="radio" name="grade" />10班</label></li>
                                        <li><label><input type="radio" name="grade" />11班</label></li>
                                        <li><label><input type="radio" name="grade" />12班</label></li>
                                        <li><label><input type="radio" name="grade" />13班</label></li>
                                        <li><label><input type="radio" name="grade" />14班</label></li>
                                        <li><label><input type="radio" name="grade" />15班</label></li>
                                        <li><label><input type="radio" name="grade" />16班</label></li>
                                        <li><label><input type="radio" name="grade" />17班</label></li>
                                        <li><label><input type="radio" name="grade" />18班</label></li>
                                        <li><label><input type="radio" name="grade" />19班</label></li>
                                        <li><label><input type="radio" name="grade" />20班</label></li>
                                        <li><label><input type="radio" name="grade" />21班</label></li>
                                        <li><label><input type="radio" name="grade" />22班</label></li>
                                        <li><label><input type="radio" name="grade" />23班</label></li>
                                        <li><label><input type="radio" name="grade" />24班</label></li>
                                        <li><label><input type="radio" name="grade" />25班</label></li>
                                    </ul>
                                    <div class="tagBtn">
                                        <a class="loginBtn tagSure" href="javascript:;">确定</a>
                                    </div>
                                </div>
                            </div>
                        </td>
                    </tr>
                    <tr>
                    	<td class="col1">自我预测高中毕业后会(上)：</td>
                        <td class="col2">
                            <asp:DropDownList ID="DropDownList2" runat="server">
                                <asp:ListItem Value="出国" Text="出国"></asp:ListItem>
                                <asp:ListItem Value="国内重点大学" Text="国内重点大学"></asp:ListItem>
                                 <asp:ListItem Value="国内非重点大学" Text="国内非重点大学"></asp:ListItem>
                                 <asp:ListItem Value="大专" Text="大专"></asp:ListItem>
                                <asp:ListItem Value="高职" Text="高职"></asp:ListItem>
                                <asp:ListItem Value="中专" Text="中专"></asp:ListItem>
                                <asp:ListItem Value="就业" Text="就业"></asp:ListItem>
                            </asp:DropDownList>
                        	<%--<select>
                            	<option>出国</option>
                                <option>国内重点大学</option>
                                <option>国内非重点大学</option>
                                <option>大专</option>
                                <option>高职</option>
                                <option>中专</option>
                                <option>就业</option>
                            </select>--%>
                        </td>
                    </tr>
                    <tr>
                    	<td class="col1">你的年级排名是：</td>
                        <td class="col2">
                            <%--<input class="ipt" type="text" />--%>
                            <%--<asp:TextBox ID="TextBox3" CssClass="ipt" runat="server"></asp:TextBox>--%>
                            <asp:DropDownList ID="DropDownList4" runat="server">
                                <asp:ListItem Text="前20%" Value="前20%"></asp:ListItem>
                                <asp:ListItem Text="前50%" Value="前50%"></asp:ListItem>
                                <asp:ListItem Text="中下水平" Value="中下水平"></asp:ListItem>
                                <asp:ListItem Text="比较靠后" Value="比较靠后"></asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                    	<td class="col1">最后一次重要考试的年级排名：</td>
                        <td class="col2">
                           <%-- <input class="ipt" type="text" />--%>
                            <asp:TextBox ID="TextBox4"  CssClass="ipt" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                    	<td class="col1">参加过奥数：</td>
                        <td class="col2">
                           <%-- <input class="ipt" type="text" />--%>
                            <asp:RadioButton ID="RadioButton1" GroupName="ao" Text="是" runat="server" />&nbsp;&nbsp;<asp:RadioButton ID="RadioButton2" GroupName="ao" Text="否" runat="server" />
                        <%--    <asp:TextBox ID="TextBox5"  CssClass="ipt" runat="server"></asp:TextBox>--%>
                        </td>
                    </tr>
                    <tr>
                    	<td class="col1">艺术特长：</td>
                        <td class="col2">
                          <%--  <input class="ipt" type="text" />--%>
                            <asp:TextBox ID="TextBox6"  CssClass="ipt" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                    	<td class="col1">体育特长：</td>
                        <td class="col2">
                           <%-- <input class="ipt" type="text" />--%>
                            <asp:TextBox ID="TextBox7"  CssClass="ipt" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                    	<td class="col1">其他特长：</td>
                        <td class="col2">
                           <%-- <input class="ipt" type="text" />--%>
                            <asp:TextBox ID="TextBox8"  CssClass="ipt" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                </tbody>
            </table>
            <div class="btnW">
                <asp:Button ID="Button1" CssClass="loginBtn" runat="server" Text="保存" OnClick="Button1_Click" />
            </div>
        </div>
    </div>
</div>
     <script type="text/javascript" src="jquery/jquery-1.9.1.min.js"></script>
<script type="text/javascript" src="js/resume.js"></script>
</asp:Content>

