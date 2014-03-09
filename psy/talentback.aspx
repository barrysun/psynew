<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="talentback.aspx.cs" Inherits="talentback" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/base.css" rel="stylesheet" type="text/css" />
<link href="css/global.css" rel="stylesheet" type="text/css" />
<link href="css/talent.css" rel="stylesheet" type="text/css" />
<link href="css/common.css" rel="stylesheet" type="text/css" />
     <script type="text/ecmascript">
         //xz薪资范围
         function setType(libid, type) {
             document.getElementById("ctl00_ContentPlaceHolder1_HiddenField1").value = type;
             for (var i = 0; i < 6; i++) {
                 if (i.toString() == type)
                     document.getElementById("xz" + i).className = "on";
                 else
                     document.getElementById("xz" + i).className = "";
             }
         }
         //工作性质
         function setTypeXZ(libid, type) {
             document.getElementById("ctl00_ContentPlaceHolder1_HiddenField2").value = type;
             for (var i = 0; i < 4; i++) {
                 if (i.toString() == type)
                     document.getElementById("xzhi" + i).className = "on";
                 else
                     document.getElementById("xzhi" + i).className = "";
             }
         }
         //最高学历
         function setTypeXL(libid, type) {
             document.getElementById("ctl00_ContentPlaceHolder1_HiddenField3").value = type;
             for (var i = 0; i < 7; i++) {
                 if (i.toString() == type)
                     document.getElementById("xl" + i).className = "on";
                 else
                     document.getElementById("xl" + i).className = "";
             }
         }
         //经验
         function setTypeJY(libid, type) {
             document.getElementById("ctl00_ContentPlaceHolder1_HiddenField4").value = type;
             for (var i = 0; i < 7; i++) {
                 if (i.toString() == type)
                     document.getElementById("jy" + i).className = "on";
                 else
                     document.getElementById("jy" + i).className = "";
             }
         }
         //目前状态
         function setTypeZT(libid, type) {
             document.getElementById("ctl00_ContentPlaceHolder1_HiddenField5").value = type;
             for (var i = 0; i < 5; i++) {
                 if (i.toString() == type)
                     document.getElementById("zt" + i).className = "on";
                 else
                     document.getElementById("zt" + i).className = "";
             }
         }

         //选择DIV
         function setDiv(libid, type) {
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

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!--面包屑-->
<div class="curmbs">
	<span>您现在所在的位置：</span>
    <span>&gt;</span>
    <span>求职与招聘平台</span>
</div>
<div class="content clearfix">
    <div class="tabs1 platform">
    	<ul class="tab_menu studyTit clearfix">
            <li class="current"><a href="javascript:;">找人才</a></li>
           
        </ul>
        <div class="tab_box">
        	<div class="">
                <div class="filterT">
                     <%=tiaojian() %>
                    <div class="row">
                        <span class="filterSpan">关键字：</span>
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
                                <td  class="col1"><a href="tjobsdet.aspx"><%#Eval("JianLiName") %></a></td>
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
                         <!-- 找人才 -->
                    <asp:HiddenField ID="HiddenField1" Value="0" runat="server" />
                    <asp:HiddenField ID="HiddenField2" Value="0" runat="server" />
                    <asp:HiddenField ID="HiddenField3" Value="0" runat="server" />
                    <asp:HiddenField ID="HiddenField4" Value="0" runat="server" />
                    <asp:HiddenField ID="HiddenField5" Value="0" runat="server" />
                    </div>
                </div>
            </div>
       
        </div>
    </div>
</div>
</asp:Content>

