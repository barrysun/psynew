<%@ Page Language="C#" AutoEventWireup="true" CodeFile="talentList.aspx.cs" Inherits="talentList" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>领航人生</title>
<link href="css/base.css" rel="stylesheet" type="text/css" />
<link href="css/global.css" rel="stylesheet" type="text/css" />
<link href="css/talent.css" rel="stylesheet" type="text/css" />
<link href="css/common.css" rel="stylesheet" type="text/css" />
    <script type="text/ecmascript">
        //xz薪资范围
        function setType(libid, type)
        {
            document.getElementById(libid).value = type;
            for (var i = 0; i < 6; i++)
            {
                if(i.toString()==type)
                    document.getElementById("xz" + i).className = "on";
                else
                    document.getElementById("xz" + i).className = "";
            }
        }
        //工作性质
        function setTypeXZ(libid, type) {
            document.getElementById(libid).value = type;
            for (var i = 0; i < 4; i++) {
                if (i.toString() == type)
                    document.getElementById("xzhi" + i).className = "on";
                else
                    document.getElementById("xzhi" + i).className = "";
            }
        }
        //最高学历
        function setTypeXL(libid, type) {
            document.getElementById(libid).value = type;
            for (var i = 0; i < 7; i++) {
                if (i.toString() == type)
                    document.getElementById("xl" + i).className = "on";
                else
                    document.getElementById("xl" + i).className = "";
            }
        }
        //经验
        function setTypeJY(libid, type) {
            document.getElementById(libid).value = type;
            for (var i = 0; i < 7; i++) {
                if (i.toString() == type)
                    document.getElementById("jy" + i).className = "on";
                else
                    document.getElementById("jy" + i).className = "";
            }
        }
        //目前状态
        function setTypeZT(libid, type) {
            document.getElementById(libid).value = type;
            for (var i = 0; i <5; i++) {
                if (i.toString() == type)
                    document.getElementById("zt" + i).className = "on";
                else
                    document.getElementById("zt" + i).className = "";
            }
        }

        //选择DIV
        function setDiv(libid,type)
        {
            document.getElementById(libid).value = type;
        }
        //找工作 薪资待遇
        function setTypeGXZ(libid, type) {
            document.getElementById(libid).value = type;
            for (var i = 0; i < 6; i++) {
                if (i.toString() == type)
                    document.getElementById("gxz" + i).className = "on";
                else
                    document.getElementById("gxz" + i).className = "";
            }
        }
        //找工作性质
        function setTypeGXZHI(libid, type) {
            document.getElementById(libid).value = type;
            for (var i = 0; i < 4; i++) {
                if (i.toString() == type)
                    document.getElementById("gxzhi" + i).className = "on";
                else
                    document.getElementById("gxzhi" + i).className = "";
            }
        }
        //找工作性质
        function setTypeGXB(libid, type) {
            document.getElementById(libid).value = type;
            for (var i = 0; i < 3; i++) {
                if (i.toString() == type)
                    document.getElementById("gxb" + i).className = "on";
                else
                    document.getElementById("gxb" + i).className = "";
            }
        }

    </script>
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
	<%=bindnav()  %>
</div>
<!--面包屑-->
<div class="curmbs">
	<span>您现在所在的位置：</span>
    <a href="index.aspx">首页</a>
    <span>&gt;</span>
    <span>求职与招聘平台</span>
</div>
<div class="content clearfix">
    <div class="tabs1 platform">
    	<ul class="tab_menu studyTit clearfix">
            <%--<li class="current" onclick="javascript:setDiv('HiddenField9','0');"><a href="javascript:;">找人才</a></li>
            <li onclick="javascript:setDiv('HiddenField9','1');"><a href="javascript:;">找工作</a></li>--%>
           <%=bindHeader() %>
        </ul>
        <div class="tab_box">
        	<div <%=divHide("1")%>>
              <div class="filterT">
                  <%=tiaojian() %>
                    <%--  <div class="row">
                        <span class="filterSpan">薪资范围：</span>
                        <div class="aWrap">
                            <a class="on" href="#">不限</a>
                            <a href="#">1000-1999</a>
                            <a href="#">2000-2999</a>
                            <a href="#">3000-4999</a>
                            <a href="#">5000以上</a>
                            <a href="#">面议</a>
                        </div>
                    </div>
                    <div class="row">
                        <span class="filterSpan">工作性质：</span>
                        <div class="aWrap">
                            <a class="on" href="#">不限</a>
                            <a href="#">全职</a>
                            <a href="#">兼职</a>
                            <a href="#">实习</a>
                        </div>
                    </div>
                    <div class="row">
                        <span class="filterSpan">最高学历：</span>
                        <div class="aWrap">
                        <a class="on" href="#">不限</a>
                        <a href="#">中专</a>
                        <a href="#">职高</a>
                        <a href="#">高中</a>
                        <a href="#">大专</a>
                        <a href="#">本科</a>
                        <a href="#">硕士以上</a>
                        </div>
                    </div>
                    <div class="row">
                        <span class="filterSpan">工作经验：</span>
                        <div class="aWrap">
                        <a class="on" href="#">不限</a>
                        <a href="#">在校学生</a>
                        <a href="#">应届毕业生</a>
                        <a href="#">1-2年</a>
                        <a href="#">3-5年</a>
                        <a href="#">5年以上</a>
                        </div>
                    </div>
                    <div class="row">
                        <span class="filterSpan">目前状态：</span>
                        <div class="aWrap">
                        <a class="on" href="#">不限</a>
                        <a href="#">目前我正在找工作</a>
                        <a href="#">我暂时不想工作</a>
                        <a href="#">在职，暂时不想找工作</a>
                        <a href="#">在职，如果有好工作可以考虑</a>
                        </div>
                    </div>--%>
                    <div class="row">
                        <span class="filterSpan">关键字：</span>
                    <%--    <input class="talentIpt" type="text" />

                        <input class="loginBtn" type="button" value="搜索" />--%>
                        <asp:TextBox ID="TextBox3" CssClass="talentIpt" runat="server"></asp:TextBox>
                        <asp:Button ID="Button2" runat="server" CssClass="loginBtn" Text="搜索" OnClick="Button2_Click" />
                    </div>
                </div>
                <div class="detInfo">
                    <table class="tabList" width="100%">
                        <thead>
                            <th class="col1">求职职位</th>
                            <th class="col2">姓名</th>
                            <th class="col3">性别</th>
                            <th class="col4">求职性质</th>
                            <th class="col5">最高学历</th>
                            <th class="col6">工作经验</th>
                            <th class="col7"></th>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="Repeater1" runat="server">
<ItemTemplate>
    <tr>
                                <td  class="col1"><%#Eval("JianLiName") %></td>
                                <td  class="col2">
                                	<a class="unline" href="#"><%#Eval("RealName") %></a>
                                </td>
                                <td  class="col3"><%#Eval("Xb") %></td>
                                <td  class="col4">全职</td>
                                <td  class="col5">本科</td>
                                <td  class="col6">1年</td>
                                <td  class="col7">
                                	<a href="#">一键邀请</a>
                                </td>
                            </tr>

</ItemTemplate>

                            </asp:Repeater>
                        
                        </tbody>
                    </table>
                    <div class="page">
                        <webdiyer:AspNetPager ID="AspNetPager2" PrevPageText="上一页" NextPageText="下一页" FirstPageText="首页" LastPageText="尾页" runat="server" OnPageChanged="AspNetPager2_PageChanged"></webdiyer:AspNetPager>
                    </div>
                </div>
            </div>
            <div <%=divHide("0")%> >
                <div class="filterT">
                   <%=zhaogongzuo() %>
                    <div class="row">
                        <span class="filterSpan">关键字：</span>
                      <%--  <input class="talentIpt" type="text" />
                        <input class="loginBtn" type="button" value="搜索" />--%>
                        <asp:TextBox ID="TextBox4" CssClass="talentIpt" runat="server"></asp:TextBox>
                        <asp:Button ID="Button3" CssClass="loginBtn" OnClick="Button3_Click" runat="server" Text="搜索" />
                    </div>
                </div>
                <div class="detInfo">
                    <table class="tabList" width="100%">
                        <thead>
                            <th class="col1">职位名称</th>
                            <th class="col2">招聘人数</th>
                            <th class="col3">工资范围</th>
                            <th class="col4">企业名称</th>
                            <th class="col5"></th>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="Repeater2" runat="server">
                                <ItemTemplate>
                                 <tr>
                                <td  class="col1">
                                	<a class="unline" href="#"><%#Eval("Zhiwei") %></a>
                                </td>
                                <td  class="col2"><%#Eval("Renshu") %></td>
                                <td  class="col3"><%#Eval("Gzfw") %></td>
                                <td  class="col4"><%#Eval("GongName") %></td>
                                <td  class="col5">
                                	<a class="" href="#">一键申请</a>
                                </td>
                            </tr>

                                </ItemTemplate>
                            </asp:Repeater>
                          
                         
                        </tbody>
                    </table>
                    <div class="page">
                        <webdiyer:AspNetPager PageSize="20" FirstPageText="首页" NextPageText="下一页" PrevPageText="上一页" LastPageText="尾页" ID="AspNetPager1" runat="server" OnPageChanged="AspNetPager1_PageChanged"></webdiyer:AspNetPager>
                    </div>
                    <!-- 找人才 -->
                    <asp:HiddenField ID="HiddenField1" Value="0" runat="server" />
                    <asp:HiddenField ID="HiddenField2" Value="0" runat="server" />
                    <asp:HiddenField ID="HiddenField3" Value="0" runat="server" />
                    <asp:HiddenField ID="HiddenField4" Value="0" runat="server" />
                    <asp:HiddenField ID="HiddenField5" Value="0" runat="server" />

                     <!-- 找工作-->
                    <asp:HiddenField ID="HiddenField6" Value="0" runat="server" />
                    <asp:HiddenField ID="HiddenField7" Value="0" runat="server" />
                    <asp:HiddenField ID="HiddenField8" Value="0" runat="server" />
                    <!-- 显示-->
                    <asp:HiddenField ID="HiddenField9" Value="0" runat="server" />
                </div>
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
<script type="text/javascript">
    $(function () {
        $(".tabs1").Tabs({ event: "click" });

        $(".tabList tbody tr:even").css("background", "#f2f2f2");

    });
</script>

<script>window._bd_share_config = { "common": { "bdSnsKey": {}, "bdText": "", "bdMini": "2", "bdMiniList": false, "bdPic": "", "bdStyle": "0", "bdSize": "16" }, "slide": { "type": "slide", "bdImg": "2", "bdPos": "left", "bdTop": "248" } }; with (document) 0[(getElementsByTagName('head')[0] || body).appendChild(createElement('script')).src = 'http://bdimg.share.baidu.com/static/api/js/share.js?v=86835285.js?cdnversion=' + ~(-new Date() / 36e5)];</script>
</body>
</html>
