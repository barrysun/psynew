<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="myInfo3.aspx.cs" Inherits="myInfo3" %>

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
        	<a href="myInfo1.aspx">目前就读学校(学生填写)</a>
        </div>
        <h3>第三步</h3>
        <div class="lnList">
        	<a href="myInfo2.aspx">目前就职情况(在职人员填写)</a>
        </div>
        <h3>第四步</h3>
        <div class="lnList">
        	<a class="on" href="javascript:;">其他信息</a>
        </div>
    </div>  
    <div class="rightMain fr">
    	<ul class="studyTit clearfix">
            <li class="current"><a href="javascript:;">其他信息</a></li>
        </ul>
        <div class="rmCont">
        	<h4 class="rmTit bold14">参加过的培训</h4>
            <table class="resume tabTh" width="100%">
            	<thead>
                	<tr>
                    	<th width="30%">科目</th>
                        <th width="30%">培训时间</th>
                        <th width="30%">证书状况或其他</th>
                        <th width="10%"><%--操作--%></th>
                    </tr>
                </thead>
            	<tbody>
                    <tr>
                    	<td class="txtCenter" colspan="4">
                            <asp:TextBox ID="TextBox4" CssClass="ipt" runat="server" Height="64px" TextMode="MultiLine" Width="797px"></asp:TextBox>
                    	</td>
                    </tr>
                  
                </tbody>
            </table>
            <h4 class="rmTit bold14">所获荣誉（或专利）</h4>
            <table class="resume tabTh" width="100%">
            	<thead>
                	<tr>
                    	<th width="30%">荣誉名称</th>
                        <th width="30%">颁发机构</th>
                        <th width="30%">颁发时间</th>
                        <th width="10%"><%--操作--%></th>
                    </tr>
                </thead>
            	<tbody>
                    <tr>
                    	<td class="txtCenter" colspan="4">
                            <asp:TextBox ID="TextBox3" CssClass="ipt" runat="server" Height="64px" TextMode="MultiLine" Width="797px"></asp:TextBox>
                    	</td>
                    </tr>
                   
                </tbody>
            </table>
            <h4 class="rmTit bold14">参加过何种项目</h4>
            <table class="resume tabTh" width="100%">
            	<thead>
                	<tr>
                    	<th width="30%">项目名称</th>
                        <th width="30%">担任职位</th>
                        <th width="30%">所做工作</th>
                        <th width="10%"><%--操作--%></th>
                    </tr>
                </thead>
            	<tbody>
                    <tr>
                    	<td class="txtCenter" colspan="4">
                            <asp:TextBox ID="TextBox2" CssClass="ipt" runat="server" Height="64px" TextMode="MultiLine" Width="797px"></asp:TextBox>
                    	</td>
                    </tr>
                    
                </tbody>
            </table>
            <h4 class="rmTit bold14">发表（出版）文章（含论文）（书籍）情况</h4>
            <table class="resume tabTh" width="100%">
            	<thead>
                	<tr>
                    	<th width="30%">书籍(文章)名称</th>
                        <th width="30%">自己是第几作者</th>
                        <th width="30%">出版刊物名称（出版社名称）</th>
                        <th width="10%"><%--操作--%></th>
                    </tr>
                </thead>
            	<tbody>
                    <tr>
                    	<td class="txtCenter" colspan="4">
                            <asp:TextBox ID="TextBox1" CssClass="ipt" runat="server" Height="64px" TextMode="MultiLine" Width="797px"></asp:TextBox>
                    	</td>
                      
                    </tr>
                  
                </tbody>
            </table>
            <div class="btnW">
               <%-- <a href="#">保存</a> --%>
                <asp:Button ID="Button1" runat="server" CssClass="loginBtn" Text="保存" OnClick="Button1_Click" />
            </div>
        </div>
    </div>
</div>
</asp:Content>

