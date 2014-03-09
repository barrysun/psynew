<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>欢迎使用后台管理框架！ </title>
    <link href="css/StyleSheet.css" rel="stylesheet" type="text/css" />
    <link href="ext/resources/css/ext-all.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="ext/adapter/ext/ext-base.js"></script>
    <script type="text/javascript" src="ext/ext-all.js"></script>
    
    <script type="text/javascript">
        Ext.onReady(function () {
            Ext.BLANK_IMAGE_URL = "ext/resources/images/default/s.gif";
            var Tree = Ext.tree;
            var tree = new Tree.TreePanel({
                el: 'west_content',
                useArrows: true,
                autoHeight: true,
                split: true,
                lines: true,
                autoScroll: true,
                animate: true,
                enableDD: true,
                border: false,
                containerScroll: true,
                loader: new Tree.TreeLoader({
                    dataUrl: 'ext_tree_json.aspx' //生成 ext 2.0 所需要的树型格式
                })
            });
            var viewport = new Ext.Viewport({
                layout: 'border',
                items: [{
                    region: 'west',
                    id: 'west',
                    //el:'panelWest',
                    title: '菜单导航',
                    split: true,
                    width: 200,
                    minSize: 200,
                    maxSize: 400,
                    collapsible: true,
                    margins: '60 0 2 2',
                    cmargins: '60 5 2 2',
                    layout: 'fit',
                    layoutConfig: { activeontop: true },
                    defaults: { bodyStyle: 'margin:0;padding:0;' },
                    //iconCls:'nav',
                    items:
                    new Ext.TabPanel({
                        border: false,
                        activeTab: 0,
                        tabPosition: 'bottom',
                        items: [
                        //                              {
                        //                                contentEl:'west_content',
                        //                                title:'数据列表',
                        //                                autoScroll:true,
                        //                                bodyStyle:'padding:5px;'
                        //                                html:'<a href="welcome.aspx" target="main">欢迎！</a>',
                        //                               }
                        //                               ,
                               {
                               layout: 'accordion', layoutConfig: { animate: true },
                               title: '后台管理',
                               autoScroll: true,
                               border: false,
                               //items:[<%=  GetMenuString() %>]
                               items: [{
                                   title: '用户管理',
                                   autoScroll: true,
                                   border: false,
                                   iconCls: 'nav',
                                   html: '<ul class="LeftNav"><li><a target="main" href="admin/AdminUserList.aspx">管理员管理</a></li><li><a target="main" href="admin/UserList.aspx">用户管理</a></li><li><a target="main" href="admin/WilTestQuestionList.aspx">求职者管理</a></li><li><a target="main" href="admin/WilTestQuestionList.aspx">企业管理</a></li></ul>'
                               },{
                                   title: '题库管理',
                                   autoScroll: true,
                                   border: false,
                                   iconCls: 'nav',
                                   html: '<ul class="LeftNav"><li><a target="main" href="admin/EqiQuestionList.aspx">Eqi题目列表</a></li><li><a target="main" href="admin/IpTestQuestionList.aspx">IP题目列表</a></li><li><a target="main" href="admin/WilTestQuestionList.aspx">WIL题目列表</a></li></ul>'
                               }, {
                                   title: '答题管理',
                                   autoScroll: true,
                                   border: false,
                                   iconCls: 'nav',
                                   html: '<ul class="LeftNav"><li><a target="main" href="admin/EqiAnswer.aspx">Eqi答题列表</a></li><li><a target="main" href="admin/IpAnswer.aspx">IP答题列表</a></li></li><li><a target="main" href="admin/WilAnswer.aspx">WIL答题列表</a></li><li><a target="main" href="admin/TestReportList.aspx">测试报告列表</a></li><li><a target="main" href="admin/ForReportList.aspx">预测报告列表</a></li><li><a target="main" href="admin/MatchReportList.aspx">匹配报告列表</a></li></ul>'
                               }, {
                                   title: 'Lib管理',
                                   autoScroll: true,
                                   border: false,
                                   iconCls: 'nav',
                                   html: '<ul class="LeftNav"><li><a target="main" href="admin/Lib2List.aspx">Lib2列表</a></li><li><a target="main" href="admin/Lib3List.aspx">职业大典</a></li></li><li><a target="main" href="admin/Lib4List.aspx">Lib4列表</a></li><li><a target="main" href="admin/Lib5List.aspx">Lib5列表</a></li><li><a target="main" href="admin/TextReportComponentList.aspx">测试报告组件列表</a></li><li><a target="main" href="admin/ForecastReportComponentList.aspx">预测组件列表</a></li><li><a target="main" href="admin/MatchReportComponentList.aspx">匹配组件列表</a></li><li><a target="main" href="admin/IndexlibList.aspx">索引库列表</a></li><li><a target="main" href="admin/Forecastjob1List.aspx">职业匹配子库1列表</a></li><li><a target="main" href="admin/ForecastJob2List.aspx">职业匹配子库2列表</a></li></ul>'
                               }, {
                                   title: '易经管理',
                                   autoScroll: true,
                                   border: false,
                                   iconCls: 'nav',
                                   html: '<ul class="LeftNav"><li><a target="main" href="admin/Ichinglib1List.aspx">易经子库1</a></li><li><a target="main" href="admin/Ichinglib2List.aspx">易经子库2</a></li><li><a target="main" href="admin/Ichinglib3List.aspx">易经子库3</a></li><li><a target="main" href="admin/Ichinglib4List.aspx">易经子库4</a></li><li><a target="main" href="admin/YlList.aspx">月令列表</a></li><li><a target="main" href="admin/IchingResultList.aspx">易经答题详情列表</a></li></ul>'
                               }, {
                                   title: '招聘管理',
                                   autoScroll: true,
                                   border: false,
                                   iconCls: 'nav',
                                   html: '<ul class="LeftNav"><li><a target="main" href="admin/Ichinglib1List.aspx">求职信管理</a></li><li><a target="main" href="admin/Ichinglib2List.aspx">招聘信息管理</a></li><li><a target="main" href="admin/Ichinglib3List.aspx">企业邀请函</a></li><li><a target="main" href="admin/Ichinglib4List.aspx">简历投递情况</a></li><li><a target="main" href="admin/EqiAnswer.aspx">企业查询情况</a></li></ul>'
                               }, {
                                   title: '付费管理',
                                   autoScroll: true,
                                   border: false,
                                   iconCls: 'nav',
                                   html: '<ul class="LeftNav"><li><a target="main" href="admin/PreferentialList.aspx">优惠策略</a></li><li><a target="main" href="admin/ChanPingList.aspx">产品列表</a></li><li><a target="main" href="admin/Shopping.aspx">购买情况</a></li><li><a target="main" href="admin/PowerUser.aspx">用户权限</a></li></ul>'
                               }, {
                                   title: '门户管理',
                                   autoScroll: true,
                                   border: false,
                                   iconCls: 'nav',
                                   html: '<ul class="LeftNav"><li><a target="main" href="admin/ExpertList.aspx?type=2">专家团队</a></li><li><a target="main" href="admin/CommunityList.aspx?type=2">社会职业类->职业介绍</a></li><li><a target="main" href="admin/CommunityList.aspx?type=1">社会职业类->应聘面试</a></li><li><a target="main" href="admin/EntranceList.aspx?type=1">高考类->高考志愿填报</a></li><li><a target="main" href="admin/EntranceList.aspx?type=2">高考类->心理解压</a></li><li><a target="main" href="admin/EntranceList.aspx?type=3">高考类->常用心理学</a></li><li><a target="main" href="admin/ProfessionalDesList.aspx?type=1">高考类->大学专业介绍</a></li><li><a target="main" href="admin/NewsList.aspx">新闻动态</a></li><li><a target="main" href="admin/ServiceDesList.aspx">个性化服务</a></li><li><a target="main" href="admin/DesUpdate.aspx?id=1">职业测评专栏</a></li><li><a target="main" href="admin/DesUpdate.aspx?id=2">职业培训</a></li><li><a target="main" href="admin/DesUpdate.aspx?id=3">人生规划研究中心</a></li><li><a target="main" href="admin/DesUpdate.aspx?id=4">关于我们</a></li><li><a target="main" href="admin/EntranceList.aspx?type=6">会员服务</a></li><li><a target="main" href="admin/DesUpdate.aspx?id=4">友情链接</a></li></ul>'
                               }

                               ]
                           }

                               ]
                    })
                }, {
                    region: 'center',
                    el: 'center',
                    deferredRender: false,
                    margins: '60 0 2 0',
                    html: '<iframe id="center-iframe" width="100%" height=100% name="main"  frameborder="0" scrolling="auto" style="border:0px none; background-color:#BBBBBB; "></iframe>',
                    autoScroll: true
                },
            {
                region: 'south',
                margins: '0 0 0 2',
                border: false,
                html: '<div class="menu south">领航人生后台管理系统 </div>'
            }
            ]
            });

            setTimeout(function () {
                Ext.get('loading').remove();
                Ext.get('loading-mask').fadeOut({ remove: true });
            }, 250)
        });
    </script>
    <base target="_self" />
</head>
<body>
    <form id="form1" runat="server">
     <div id="loading-mask" style=""></div>
      <div id="loading">
        <div class="loading-indicator"><img src="ext/resources/extanim32.gif" width="32" height="32" style="margin-right:8px;" align="absmiddle"/>Loading...</div>
      </div>
  <div id="header"><h1><%= ConfigurationManager.AppSettings["SubTitle"] %></h1></div>
  <div class="menu">
                <span style="float: left">欢迎&nbsp;&nbsp;<b>管理员</b>&nbsp;&nbsp
                    &nbsp;&nbsp;<a href="login.aspx">返回首页</a> </span>
                <span id="aLoginOut" runat="server" style="float: right"><a onclick="if (!window.confirm('您确认要注消当前登录用户吗？')){return false;}"
                    href="Login.aspx">
                    <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click">注销</asp:LinkButton></a></span>
            </div>
  <div id="west">
    
  </div>
  <div id="center">
    
  </div>
  <div id="west_content" style="height:300px; ">

  </div>
    </form>
</body>
</html>
