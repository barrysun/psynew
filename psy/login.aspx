<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   <title>领航人生</title>
<link href="css/base.css" rel="stylesheet" type="text/css" />
<link href="css/global.css" rel="stylesheet" type="text/css" />
<link href="css/login.css" rel="stylesheet" type="text/css" />
<link href="css/sidebar.css" rel="stylesheet" type="text/css" />
    <link href="css/common.css" rel="stylesheet" type="text/css" />
</head>
    <body>
        <form name="form" runat="server">
<div class="main">
<div class="head clearfix">
	<div class="logoImg fl">
    	<img src="images/icon_07.png"  height="70" />
    </div>
    <div class="fr">
    	<div class="before">
            <span>hi~亲，欢迎您来到领航人生！</span>
            <span class="gas"></span>
            <span class="gas"></span>
            <a href="#">收藏本页</a>
        </div>
        <div class="hotTel">
        	<span class="telRed">咨询热线：</span>
            <span class="telBlue">400-820-8820</span>
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
    <span>登录/注册</span>
</div>
<div class="content clearfix">
    <div class="loginBox borderC tabs1">
    	<ul class="tab_menu studyTit clearfix">
            <li class="current"><a href="javascript:;">登录</a></li>
            <li class=""><a href="javascript:;">注册</a></li>
        </ul>
        <div class="tab_box">
            <div class="lbCont clearfix" runat="server" id="login_div">
                <div class="lbLeft fl">
                    <div class="row">
                        <span>用户名：</span>
                       <%-- <input class="ipt" type="text" />--%>
                        <asp:TextBox ID="TextBox2" CssClass="ipt" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*"   ControlToValidate="TextBox2" ValidationGroup="log" ForeColor="Red"></asp:RequiredFieldValidator>
                 
                    </div>
                    <div class="row">
                        <span>密&nbsp;&nbsp;&nbsp;&nbsp;码：</span>
                       <%-- <input class="ipt" type="password" />--%>
                        <asp:TextBox ID="TextBox1"  TextMode="Password" CssClass="ipt" runat="server"></asp:TextBox>
                    </div>
                    <div class="row">
                        <span>角&nbsp;&nbsp;&nbsp;&nbsp;色：</span>
                        <label>
                          <%--  <input type="radio" name="" />--%>
                            <asp:RadioButton ID="RadioButton1"  GroupName="1" runat="server" />
                            个人</label>
                        <label>
                           <%-- <input type="radio" name="" />--%>
                              <asp:RadioButton ID="RadioButton2" GroupName="1" runat="server" />
                            企业</label>
                    </div>
                    <div class="row btnW">
                        <%--<input class="loginBtn" type="submit" value="登录" />--%>
                        <asp:Button ID="Button2" CssClass="loginBtn" runat="server" Text="登陆" OnClick="Button2_Click" />
                        <span>没有注册，<a href="#">免费注册</a></span>
                    </div>
                </div>
                <div class="lbRight fl">
                	<div class="tips">
                        <h4 class="lbrTit">温馨提示：</h4>
                        <div class="lbrCont">这是温馨提示，这是温馨提示，这是温馨提示，这是温馨提示，这是温馨提示，这是温馨提示，这是温馨提示，这是温馨提示，这是温馨提示。</div>
                       <img src="images/login1.jpg" width="380px" />
                    </div>
                </div>
            </div>
            <div class="lbCont hide clearfix" runat="server" id="register_div">
                <div class="lbLeft fl">
                    <div class="row">
                        <span>用户名：</span>
                      <%--  <input class="ipt" type="text" />--%>
                        <asp:TextBox ID="TextBox3" CssClass="ipt" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"   ControlToValidate="TextBox3"  ForeColor="Red" ValidationGroup="register"></asp:RequiredFieldValidator>
                    </div>
                    <div class="row">
                        <span>邮&nbsp;&nbsp;&nbsp;&nbsp;箱：</span>
                        <%--<input class="ipt" type="text" />--%>
                        <asp:TextBox ID="TextBox4" CssClass="ipt" runat="server"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*"   ControlToValidate="TextBox4"  ForeColor="Red" ValidationGroup="register"></asp:RequiredFieldValidator>
                    </div>
                    <div class="row">
                        <span>密&nbsp;&nbsp;&nbsp;&nbsp;码：</span>
                       <%-- <input class="ipt" type="password" />--%>
                        <asp:TextBox ID="TextBox5" TextMode="Password" runat="server" CssClass="ipt"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*"   ControlToValidate="TextBox5"  ForeColor="Red" ValidationGroup="register"></asp:RequiredFieldValidator>
                    </div>
                    <div class="row">
                        <span>确认密码：</span>
                        <%--<input class="ipt" type="password" />--%>
                        <asp:TextBox ID="TextBox6" TextMode="Password" runat="server" CssClass="ipt"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*"   ControlToValidate="TextBox6"  ForeColor="Red" ValidationGroup="register"></asp:RequiredFieldValidator>
                    </div>
                    <div class="row">
                        <span>角&nbsp;&nbsp;&nbsp;&nbsp;色：</span>
                        <label>
                          <%--  <input type="radio" name="" />--%>
                            <asp:RadioButton ID="RadioButton3"  GroupName="1" runat="server" />
                            企业</label>
                        <label>
                           <%-- <input type="radio" name="" />--%>
                              <asp:RadioButton ID="RadioButton4" GroupName="1" runat="server" />
                            个人</label>
                    </div>
                    <div class="row">
                    	<input type="checkbox" />
                        <span>我已阅读并同意《注册协议》</span>
                    </div>
                    <div class="row btnW">
                        <%--<input class="loginBtn" type="submit" value="注册" />--%>
                        <asp:Button ID="Button1" CssClass="loginBtn" ValidationGroup="register" runat="server" Text="注册"  OnClick="Button1_Click" />
                        <span>已经注册，<a href="#">马上登录</a></span>
                    </div>
                </div>
                <div class="lbRight fl">
                    <div class="tips">
                        <h4 class="lbrTit">温馨提示：</h4>
                        <div class="lbrCont">这是温馨提示，这是温馨提示，这是温馨提示，这是温馨提示，这是温馨提示，这是温馨提示，这是温馨提示，这是温馨提示，这是温馨提示。</div>
                       <img src="images/login1.jpg" width="380px" />
                    </div>
                </div>
            </div>
        </div>
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
