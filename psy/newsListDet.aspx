<%@ Page Language="C#" AutoEventWireup="true" CodeFile="newsListDet.aspx.cs" Inherits="newsListDet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   <title>领航人生</title>
<link href="css/base.css" rel="stylesheet" type="text/css" />
<link href="css/global.css" rel="stylesheet" type="text/css" />
<link href="css/news.css" rel="stylesheet" type="text/css" />
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
    <span>学术动态</span>
</div>
<div class="content clearfix">
	<div class="contLeft fl">
    	<div class="hotNew borderC">
        	<%=redian() %>
        </div>
        <div class="vGas"></div>
        <div class="contact borderC">
        	<h3>联系我们</h3>
            <div class="contactDet">
            	<div class="row">
                	<span>联系电话：</span>
                    <span>028-88888888</span>
                </div>
                <div class="row">
                	<span>传&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;真：</span>
                    <span>163@163.com</span>
                </div>
                <div class="row">
                	<span>联系邮箱：</span>
                    <span>163@163.com</span>
                </div>
            </div>
        </div>
    </div>
    <div class="contRight fr">
    	<div class="newsW borderC">
        	<%= bind() %>
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
<div class="scrollsidebar" id="hhService">
	<div class="side_content">
		<div class="side_list">
			<div class="side_title"><a title="隐藏" class="close_btn"><span>关闭</span></a></div>
			<div class="side_center">            	
				<div class="qqserver">
					<p><a title="点击这里给我发消息" href="http://wpa.qq.com/msgrd?v=3&amp;uin=651471385&amp;site=qq&amp;menu=yes" target="_blank"><img src="http://wpa.qq.com/pa?p=1:651471385:47">欢欢</a></p> 
					<p><a title="点击这里给我发消息" href="http://wpa.qq.com/msgrd?v=3&amp;uin=651471385&amp;site=qq&amp;menu=yes" target="_blank"><img src="http://wpa.qq.com/pa?p=1:651471385:47">欢欢</a></p>
					<p><a title="点击这里给我发消息" href="http://wpa.qq.com/msgrd?v=3&amp;uin=651471385&amp;site=qq&amp;menu=yes" target="_blank"><img src="http://wpa.qq.com/pa?p=1:651471385:47">欢欢</a></p>
					<p><a title="点击这里给我发消息" href="http://wpa.qq.com/msgrd?v=3&amp;uin=651471385&amp;site=qq&amp;menu=yes" target="_blank"><img src="http://wpa.qq.com/pa?p=1:651471385:47">欢欢</a></p>
				</div>
				<div class="msgserver">
				</div>
			</div>
			<div class="side_bottom"></div>
		</div>
	</div>
	<div class="show_btn"><span>在线客服</span></div>
</div><!--scrollsidebar end-->
        </form>

<script type="text/javascript" src="jquery/jquery-1.9.1.min.js"></script>
<script type="text/javascript" src="jquery/tabs.js"></script>
<script type="text/javascript" src="jquery/jquery.hhService.js"></script>
<script type="text/javascript">
    $(function () {
        $(".tabs1").Tabs({ event: "click" });

        //悬浮客服
        $("#hhService").fix({
            float: 'right',	      //默认设置 "left" or "right" 
            minStatue: true,     //默认设置 "false" or "true" 
            skin: 'blue',	    //默认设置 "blue"  "orange"  "green"  "red"  "pink"
            durationTime: 1000
        });
    });
</script>

<script>window._bd_share_config = { "common": { "bdSnsKey": {}, "bdText": "", "bdMini": "2", "bdMiniList": false, "bdPic": "", "bdStyle": "0", "bdSize": "16" }, "slide": { "type": "slide", "bdImg": "2", "bdPos": "left", "bdTop": "248" } }; with (document) 0[(getElementsByTagName('head')[0] || body).appendChild(createElement('script')).src = 'http://bdimg.share.baidu.com/static/api/js/share.js?v=86835285.js?cdnversion=' + ~(-new Date() / 36e5)];</script>
</body>
</html>
