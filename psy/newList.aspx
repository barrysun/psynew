<%@ Page Language="C#" AutoEventWireup="true" CodeFile="newList.aspx.cs" Inherits="newList" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>领航人生</title>
<link href="css/base.css" rel="stylesheet" type="text/css" />
<link href="css/global.css" rel="stylesheet" type="text/css" />
<link href="css/news.css" rel="stylesheet" type="text/css" />
<link href="css/sidebar.css" rel="stylesheet" type="text/css" />
    <link href="css/common.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form name="form" runat="server">
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
    	<div class="searchBox">
        	<%--<input class="sbIpt" type="text" />--%>
            <asp:TextBox ID="TextBox3" CssClass="sbIpt" runat="server"></asp:TextBox>
            <asp:Button ID="Button2" CssClass="sbBtn" runat="server" Text="搜索" OnClick="Button2_Click" />
           <%-- <input class="sbBtn" type="submit" value="搜索" />--%>
        </div>
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
        	<div class="newTit">
            	<h4 class="bold14">
                    <asp:Label ID="Label1" runat="server" Text="学术动态"></asp:Label></h4>
            </div>
            <div class="newsCont">
                <ul class="newsList">
                    <asp:DataList ID="DataList1" runat="server" Width="100%">
                        <ItemTemplate>
                        <li>
                        <a class="fl" href="newsListDet.aspx?type=<%#Eval("typetype") %>&id=<%#Eval("Id") %>"><%#Eval("NewTitle") %></a>
                        <span class="fr"><%#Eval("EditTime") %></span>
                    </li>
                        </ItemTemplate>
                    </asp:DataList>
                </ul>
            </div>
            <div class="page">
                <webdiyer:AspNetPager ID="AspNetPager1" runat="server" FirstPageText="首页" NextPageText="下一页" LastPageText="尾页" PrevPageText="上一页" OnPageChanged="AspNetPager1_PageChanged" PageSize="14"></webdiyer:AspNetPager>
            	<%--<ul class="clearfix">
                	<li><a href="#">首页</a></li>
                    <li><a href="#">上一页</a></li>
                    <li><span>1</span></li>
                    <li><a href="">2</a></li>
                    <li><a href="">3</a></li>
                    <li><a href="">下一页</a></li>
                    <li><a href="">尾页</a></li>
                </ul>--%>
            </div>
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


<div id='floatTools' class='float0831'>
<div class='floatL'>
	<a  id='aFloatTools_Show' class='btnOpen' title='查看在线客服' onclick="javascript:$('#divFloatToolsView').animate({width: 'show', opacity: 'show'}, 'normal',function(){ $('#divFloatToolsView').show();kf_setCookie('RightFloatShown', 0, '', '/', 'www.lanrensc.com'); });$('#aFloatTools_Show').attr('style','display:none');$('#aFloatTools_Hide').attr('style','display:block');" href="javascript:void(0);">展开</a>
	<a style="DISPLAY: none" id='aFloatTools_Hide' class='btnCtn' title='关闭在线客服' onclick="javascript:$('#divFloatToolsView').animate({width: 'hide', opacity: 'hide'}, 'normal',function(){ $('#divFloatToolsView').hide();kf_setCookie('RightFloatShown', 1, '', '/', 'www.lanrensc.com'); });$('#aFloatTools_Show').attr('style','display:block');$('#aFloatTools_Hide').attr('style','display:none');" href="javascript:void(0);">收缩</a>
</div>
<div id='divFloatToolsView' class='floatR'>
	<div class='tp'></div>
	<div class='cn'>
	<ul>
		<li class='top'><H3 class='titZx'>QQ咨询</H3></li>
		<li><a class='icoTc' target="_blank" href="http://wpa.qq.com/msgrd?v=3&uin=1096490965&site=qq&menu=yes" title="大学专业填报咨询">大学专业填报咨询</a></li>
		<li><a class='icoTc' target="_blank" href="http://wpa.qq.com/msgrd?v=3&uin=1096490965&site=qq&menu=yes" title="职业咨询">职业咨询</a></li>
        	<li><a class='icoTc' target="_blank" href="http://wpa.qq.com/msgrd?v=3&uin=1096490965&site=qq&menu=yes" title="职业规划咨询">职业规划咨询</a></li>
		<li><a class='icoTc' target="_blank" href="http://wpa.qq.com/msgrd?v=3&uin=1096490965&site=qq&menu=yes" title="心理减压咨询">心理减压咨询</a></li>
         	<li><a class='icoTc' target="_blank" href="http://wpa.qq.com/msgrd?v=3&uin=1096490965&site=qq&menu=yes" title="心理专家预约服务">心理专家预约服务</a></li>
		<li><a class='icoTc' target="_blank" href="http://wpa.qq.com/msgrd?v=3&uin=1096490965&site=qq&menu=yes" title="易经专家预约服务">易经专家预约服务</a></li>
	</ul>
      <ul>
        <li>
          <h3 class='titDh'>电话咨询</h3>
        </li>
        <li><span class='icoTl'>400-000-0000</span> </li>
      </ul>
	</div>
</div>
</div>
        </form>

<script type="text/javascript" src="jquery/jquery-1.9.1.min.js"></script>
<script type="text/javascript" src="jquery/tabs.js"></script>
<script type="text/javascript" src="jquery/jquery.hhService.js"></script>
    <script type="text/javascript" src="js/kefu.js"></script>
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
