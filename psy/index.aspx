<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>领航人生</title>
<link href="css/base.css" rel="stylesheet" type="text/css" />
<link href="css/global.css" rel="stylesheet" type="text/css" />
<link href="css/index.css" rel="stylesheet" type="text/css" />
    <link href="css/common.css" rel="stylesheet" type="text/css" />
</head>
  
<body runat="server">
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
            <a href="#" class="addfav"   >收藏本页</a>
        </div>
        <div class="login" runat="server">
            <fieldset runat="server">
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
<!--宣传栏-->
<!--宣传栏-->
<div class="slide">
	<div class="idx-focus" id="j_idx_focus">
	<div class="idx-foc-tmp">
        <a id="prev1" class="prev1" href="#"></a>
        <ul id="foo1" class="cf">
            <li><a href="javascript:;" title="" target=""><img width="100%" src="images/icon_31.png" /></a></li>
            <li><a href="javascript:;" title="" target=""><img width="100%" src="images/banner.jpg" /></a></li>
            <li><a href="javascript:;" title="" target=""><img width="100%" src="images/login.jpg" /></a></li>
        </ul>
        <a id="next1" class="next1" href="#"></a>
	</div>
</div>
</div>

<%--<div class="twoBox clearfix">
	<div class="tbBox fl borderC">
    	<img src="test/two1.jpg" width="100%" height="200" />
    </div>
    <div class="tbBox fr borderC">
    	<img src="test/two2.jpg" width="100%" height="200" />
    </div>
</div>

<div class="oneBox borderC">
	<img src="test/oneBox.jpg" width="100%" height="200" />
</div>--%>

<!--六个板块-->
<div class="sixTest">
	<%=bindldbk() %>
</div>
<!--新闻动态部分-->
<div class="moving clearfix">
	<div class="dyMain fl">
    	<div class="news borderC">
        	<h3 class="titComm bold14">
            	<span class="tit fl">学术动态</span>
            	<a href="newList.aspx" class="more fr">more</a>    
            </h3>
            <div class="dyCont">
            	<%=bindNews() %>
            </div>
        </div>
        <div class="jobs borderC">
        	<div class="dlW clearfix">
                <dl class="dlBox">
                    <dt class="clearfix">
                        <span class="fl">招聘信息</span>
                        <a class="fr" href="talentList.aspx">more</a>
                    </dt>
                  <%=zpxx() %>
                </dl>
                <dl class="dlBox jobsBox">
                    <dt class="clearfix">
                        <span class="fl">求职信息</span>
                        <a class="fr" href="talentList.aspx">more</a>
                    </dt>
                   <%=qzxx() %>
                </dl>
            </div>
        </div>
    </div>
    <div class="dySide fr">
    	<div class="borderC">
        	<h3 class="titComm bold14">
            	<span class="tit fl">专家团队</span>
            	<a href="exportList.aspx" class="more fr">more</a>    
            </h3>
            <div class="dsCont">
            	<ul class="expert">
                	<%=zjtd() %>
                </ul>
            </div>
        </div>
        <div class="vGas"></div>
        <div class="borderC">
        	<h3 class="titComm bold14">
            	<span class="tit fl">会员服务</span>
            	<a href="newList.aspx?type=6" class="more fr">more</a>    
            </h3>
            <div class="dsCont">
            	<%=hyfw() %>
            </div>
        </div>
    </div>
</div>
<div class="vGas"></div>
<!--求学路上-->
<div class="studying borderC">
	<div class="tabs1 studyW">
        <ul class="tab_menu studyTit clearfix">
            <li class="current"><a href="javascript:;">高考类</a></li>
            <li><a href="javascript:(0);">社会职业类</a></li>
        </ul>
        <div class="tab_box studyCont">
        	<div class="tStudy clearfix">
            	<%=gkl() %>
            </div>
            <div class="hide cStydy">
            	<%=shzyl() %>
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
<script type="text/javascript" src="js/kefu.js"></script>
    <script type="text/javascript" src="js/addFavrite.js"></script>
<script type="text/javascript" src="js/global.js"></script>
<script type="text/javascript">
    $(function () {
        $(".tabs1").Tabs({ event: "click" });

        $("#foo1").carouFredSel({ prev: { button: "#prev1", key: "left" }, next: { button: "#next1", key: "right" }, items: { visible: 1, minimum: 1 }, auto: true });

       
    });
</script>



<script>window._bd_share_config = { "common": { "bdSnsKey": {}, "bdText": "", "bdMini": "1", "bdMiniList": false, "bdPic": "", "bdStyle": "0", "bdSize": "16" }, "slide": { "type": "slide", "bdImg": "6", "bdPos": "left", "bdTop": "241.5" } }; with (document) 0[(getElementsByTagName('head')[0] || body).appendChild(createElement('script')).src = 'http://bdimg.share.baidu.com/static/api/js/share.js?v=89860593.js?cdnversion=' + ~(-new Date() / 36e5)];</script>
</body>
</html>
