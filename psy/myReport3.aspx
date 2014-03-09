<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="myReport3.aspx.cs" Inherits="myReport3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div class="curmbs">
	<span>您现在所在的位置：</span>
   
    <span>&gt;</span>
    <span>择业测评</span>
</div>
   <div class="content clearfix">
<div class="leftNav fl">
        <h3>第一步</h3>
        <div class="lnList">
        	<a href="xtxx.aspx">填写先天信息</a>
        </div>
    	<h3>第二步</h3>
        <div class="lnList">
        	<a href="javascript:window.open('Question.aspx');">点击测评</a>
        </div>
        <h3>第三步</h3>
        <div class="lnList">
        	<a href="myInfo.aspx">完备个人信息</a>
        </div>
        <h3>第四步</h3>
        <div class="lnList">
        	<a href="myPay.aspx">报告购买</a>
        </div>

        <h3>第五步</h3>
        <div class="lnList">
        	<a href="myReport1.aspx">测评报告（免费）</a>
        </div>
        <div class="lnList">
        	<a href="myReport2.aspx">预测报告（需购买）</a>
        </div>
        <div class="lnList">
        	<a href="myReport3.aspx">匹配报告（需购买）</a>
        </div>
    </div>   
    <div class="rightMain fr">
    	<ul class="studyTit clearfix">
            <li class="current"><a href="javascript:;">匹配报告</a></li>
        </ul>

        <div class="rmCont">
             <fieldset class="speSearch">
                	<legend class="bold14">选择您需要匹配的职业</legend>
                    <%--<input class="ssIpt" type="text" />
                    <input class="ssBtn" type="button" value="匹配" />--%>
                 <asp:TextBox ID="TextBox1" CssClass="ssIpt" runat="server"></asp:TextBox>
                 <asp:Button ID="Button1" CssClass="ssBtn" runat="server" Text="匹配" OnClick="Button1_Click" />
                    <a class="ssMore" href="javascript:;">更多职业</a>
                </fieldset>

        	<table class="resumeList" width="100%">
            	<thead>
                	<tr>
                    	<th>匹配职业名称</th>
                        <th>匹配时间</th>
                        <th>操作</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                      <tr>
                    	<td><%#Eval("TITLE") %></td>
                        <td><%#Eval("MATCHTIME") %></td>
                        <td>
                        	<a class="oprate" href='myReport32.aspx?Id=<%#Eval("ID") %>'>查看</a>
                        </td>
                    </tr>

                        </ItemTemplate>

                    </asp:Repeater>
                	
                </tbody>
            </table>
        </div>
    </div>
</div>
    <!--弹出框-->
<div class="speDia" id="speDiaId">
	<input type="hidden" id="hideTxt" />
	<%--<div class="oneMenu">
    	<a class="on" id="a1" href="#">文科</a>
        <a id="a2" href="">理科</a>
    </div>
    <div class="threeMenu">
    	<div class="a1">
            <a id="al_1" href="#">网络工程1</a>
            <a id="al_2" href="#">美术11</a>
            <a id="al_3" href="#">计算机科学1</a>
        </div>
        <div class="a2 hide">
            <a id="a2_1" href="#">网络工程2</a>
            <a id="a2_2" href="#">美术2</a>
            <a id="a2_3" href="#">计算机科学2</a>
        </div>
       
    </div>--%>
    <%=jobview() %>
</div>
    <script type="text/javascript" src="jquery/jquery-1.9.1.min.js"></script>
<script type="text/javascript" src="js/artDialog.js?skin=blue"></script>
<script type="text/javascript" src="js/artDialog.js?skin=blue"></script>
<script type="text/javascript">
    $(function () {
        //弹出框	
        $(".ssMore").click(function () {
            var mydislog = art.dialog({
                title: '大学专业介绍',
                content: document.getElementById("speDiaId"),
                ok: function () {
                    var txt = $("#hideTxt").val();
                    if (txt == "") {
                        art.dialog({
                            title: "提示",
                            time: 2,
                            content: "您没有选择大学专业"
                        });
                        return false;
                    } else {
                        $(".ssIpt").val(txt);
                    }
                },
                cancelValue: '取消',
                cancel: true,
                lock: true
            });

        });

        $(".oneMenu a").click(function () {
            $(".oneMenu a").each(function () {
                $(this).removeClass("on");
            });
            $(this).addClass("on");
            var tag = $(this).attr("id");
            $(".threeMenu").children("div").each(function () {
                $(this).addClass("hide");
                $(this).children("a").removeClass("on");
                if ($(this).hasClass(tag)) {
                    $(this).removeClass("hide");
                    $(this).children("a").eq(0).addClass("on");
                }
            });
            //if ($(".threeMenu a").hasClass("on")) {
            //    var tag1 = $(".threeMenu .on").attr("id");
            //    //$(".threeMenu").children("div").each(function () {
            //    //    $(this).addClass("hide");
            //    //    if ($(this).hasClass(tag1)) {
            //    //        $(this).removeClass("hide");
            //    //    }
            //    //});
            //}
            return false;
        });
        $(".threeMenu a").eq(0).addClass("on");
        //$(".threeMenu a").click(function () {
        //    $(".twoMenu a").each(function () {
        //        $(this).removeClass("on");
        //    });
        //    $(this).addClass("on");
        //    var tag = $(this).attr("id");
        //    $(".threeMenu").children("div").each(function () {
        //        $(this).addClass("hide");
        //        if ($(this).hasClass(tag)) {
        //            $(this).removeClass("hide");
        //        }
        //    });
        //    return false;
        //});
        $(".threeMenu a").click(function () {
            $(".threeMenu a").each(function () {
                $(this).removeClass("on");
            });
            $(this).addClass("on");
            var txt = $(this).text();
            $("#hideTxt").val(txt);
            return false;
        });
    });
</script>
</asp:Content>

