<%@ Page Language="C#" AutoEventWireup="true" CodeFile="specialty.aspx.cs" Inherits="specialty" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>领航人生</title>
    <link href="css/base.css" rel="stylesheet" type="text/css" />
<link href="css/global.css" rel="stylesheet" type="text/css" />
<link href="css/specialty.css" rel="stylesheet" type="text/css" />
<link href="css/sidebar.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form runat="server">
   <div class="main">
<div class="head clearfix">
	<div class="logoImg fl">
    	<img src="images/icon_07.png" />
    </div>
    <div class="fr">
    	<div class="before">
            <span>hi~您还没登录哟！</span>
            <span class="gas"></span>
          <a href="login.aspx">个人登录</a>
            <span class="gas"></span>
            <a href="login.aspx">企业登录</a>
            <span class="gas"></span>
            <a href="login.aspx">注册</a>
            <span class="gas"></span>
            <a href="#"  >收藏本页</a>
        </div>
        <div id="Div1" class="login" runat="server">
            <fieldset id="Fieldset1" runat="server">
                <legend>快速登录</legend>
               <%-- <input class="userIpt" type="text" />--%>
                <asp:TextBox ID="TextBox1" CssClass="userIpt" runat="server"></asp:TextBox>
                <span class="gas1"></span>
            <%--    <input class="passIpt" type="text" />--%>
                <asp:TextBox ID="TextBox2" CssClass="passIpt" runat="server" TextMode="Password"></asp:TextBox>
                <span class="gas1"></span>
                <%--<input class="loginBtn" type="button" value="登录" />--%>
                <asp:Button ID="Button1" CssClass="loginBtn" runat="server" Text="登陆" OnClick="Button1_Click" />
            </fieldset>
        </div>
    </div>
</div>
<!--导航-->
<div class="nav">
	<%=bindnav() %>
</div>
<!--面包屑-->
<div class="curmbs">
	<span>您现在所在的位置：</span>
    <a href="index.aspx">首页</a>
    <span>&gt;</span>
    <span>大学专业介绍</span>
</div>
<div class="content">
    <div class="speSearch">
       <%-- <input class="ssIpt" type="text" />
        <input class="ssBtn" type="button" value="搜索" />--%>
        <asp:TextBox ID="TextBox3" CssClass="ssIpt" runat="server"></asp:TextBox>
        <asp:Button ID="Button2" OnClick="Button2_Click" runat="server" CssClass="ssBtn" Text="搜索" />
        <a class="ssMore" href="javascript:;">更多搜索</a>
    </div>

        
    <div class="speListW">
    	<table class="speTab" width="100%">
        	<thead>
            	<tr>
                	<th>专业</th>
                    <th>门类</th>
                    <th>可从事工作</th>
                    <th>推荐院校</th>
                    <th>前景咨询</th>
                </tr>
             </thead>
             <tbody>
                 <asp:Repeater ID="Repeater1" runat="server">
                     <ItemTemplate>
<tr>
                	<td><a class="oprate" href="#"><%#Eval("TITLE1") %></a></td>
                    <td><%#Eval("TITLE2") %></td>
                    <td><%#Eval("TITLE3") %></td>
                    <td><%#Eval("Work") %></td>
                    <td>人工咨询</td>
            	</tr>

                     </ItemTemplate>

                 </asp:Repeater>

               
                
        	</tbody>
    	</table>
        <div class="page">
            <webdiyer:AspNetPager ID="AspNetPager1" PrevPageText="上一页" LastPageText="尾页" NextPageText="下一页" FirstPageText="首页" runat="server" OnPageChanged="AspNetPager1_PageChanged"></webdiyer:AspNetPager>
            </div>
	</div>
</div>
<div class="vGas"></div>
<!--友情链接-->
<div class="links borderC clearfix">
	<div class="fl linkTit">友情链接：</div>
    <div class="fl linkA">
    	<a href="#">心理圈</a>
        <a href="#">心理圈</a>
        <a href="#">心理圈</a>
        <a href="#">心理圈</a>
        <a href="#">心理圈</a>
        <a href="#">心理圈</a>
        <a href="#">心理圈</a>
        <a href="#">心理圈</a>
        <a href="#">心理圈</a>
        <a href="#">心理圈</a>
        <a href="#">心理圈</a>
        <a href="#">心理圈</a>
        <a href="#">心理圈</a>
        <a href="#">心理圈</a>
        <a href="#">心理圈</a>
        <a href="#">心理圈</a>
        <a href="#">心理圈</a>
        <a href="#">心理圈</a>
        <a href="#">心理圈</a>
        <a href="#">心理圈</a>
        <a href="#">心理圈</a>
        <a href="#">心理圈</a>
    </div>
</div>
<div class="vGas"></div>
<!--脚步信息-->
<div class="footer">
	<p><span>联系电话：1234567890</span><span>传真：028-2996754</span><span>电子邮件:9878967839@gmail.com</span></p>
    <p>地址:成都市龙泉驿区十陵镇</p>
    <p>网址:www.jumei.com</p>
</div>	
</div>

<!--弹出框-->
<!--弹出框-->
<div class="speDia" id="speDiaId">
	<input type="hidden" id="hideTxt" />
	
   <%=bindMenu() %>
</div>
        </form>


<script type="text/javascript" src="jquery/jquery-1.9.1.min.js"></script>
<script type="text/javascript" src="js/artDialog.js?skin=blue"></script>
    <script type="text/javascript" src="js/tableJs.js"></script>
<script type="text/javascript">
    $(function () {

        $(".speTab tbody tr:odd").css("background", "#f2f2f2");

       
    });
</script>

<script>window._bd_share_config = { "common": { "bdSnsKey": {}, "bdText": "", "bdMini": "2", "bdMiniList": false, "bdPic": "", "bdStyle": "0", "bdSize": "16" }, "slide": { "type": "slide", "bdImg": "2", "bdPos": "left", "bdTop": "248" } }; with (document) 0[(getElementsByTagName('head')[0] || body).appendChild(createElement('script')).src = 'http://bdimg.share.baidu.com/static/api/js/share.js?v=86835285.js?cdnversion=' + ~(-new Date() / 36e5)];</script>
</body>
</html>
