<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="myReport32.aspx.cs" Inherits="myReport3" %>

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
    <div class="rightMain rightMain1 fr" onselectstart="return false">
    	<ul class="studyTit clearfix">
            <li class="current"><a href="javascript:;">匹配报告</a></li>
        </ul>
          <div class="rmCont" >
        	<h3 class="mtTit bold16">领航人生匹配报告</h3>
            <div class="mtCont">
            	<ul class="proInfo">
                	<li><span class="piLeft">-用 &nbsp;户 &nbsp;名：</span><span><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></span></li>
                    <li><span class="piLeft">-性 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 别：</span><span><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></span></li>
                    <li><span class="piLeft">-出生时间：</span><span><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></span></li>
                    <li><span class="piLeft">-测评时间：</span><span><asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></span></li>
                </ul>
                <div class="detCont">
                 </div>
                <h4 class="detTit bold14">匹配报告导读</h4>
                <div class="detCont detCont1">
                    报告中列出的<span class="bold14">需改进</span>素质点，是指你一旦从事该职业时你的素质短板，需要着力加以改进。报告中罗列的<span class="bold14">优势</span>素质点，是指你已经达到从事该职业的基本素质要求。但如果你想成为该项职业中的佼佼者，仍需自我反省，其中哪些是已经很强的，哪些是还有提升余地的，并相应的着力改进。如果你进行多个职业的匹配，请特别注意比较不同报告中<span class="bold14">素质点</span>的增减变化。这些<span class="bold14">变化点</span>，正是你在选择不同职业时，需要着力改进和提升的素质点，或者改进后容易取得事半功倍效果的素质点。
                </div>
                    <%=ReportView() %>    
               <br />
                 <h4 class="detTit bold14">结束语</h4>
                <div class="detCont detCont1">
                	职业的选择和定位，会在较大程度上影响你的人生轨迹，是人一生中值得慎重考虑的大事。因此值得你在思考中去体验，在体验中进行思考。所以，我们这一次只能为你提供不超过8次匹配机会。欢迎你在一年以后，当你对职业的思考有了进一步心得的时候，再次回来。我们会为你提供新的职业匹配机会，帮助你深化你的职业定位思考。祝你事业/学业一帆风顺！！
                      </div>
             
                
            </div>
        </div>
      
    </div>
</div>
    </asp:Content>
  

