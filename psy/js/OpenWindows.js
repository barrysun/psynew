jQuery.fn.extend(
{
    OpenDiv: function()
    {

        var sWidth, sHeight;
        sWidth = window.screen.availWidth;
        if (window.screen.availHeight > document.body.scrollHeight)
        {
            sHeight = window.screen.availHeight;

        } else
        {
            sHeight = document.body.scrollHeight + 20;

        }
        var maskObj = document.createElement("div");
        maskObj.setAttribute('id', 'BigDiv');
        maskObj.style.position = "absolute";
        maskObj.style.top = "0";
        maskObj.style.left = "0";
        maskObj.style.background = "#848484";
        maskObj.style.filter = "Alpha(opacity=0);";
        maskObj.style.opacity = "0";
        maskObj.style.width = sWidth + "px";
        maskObj.style.height = sHeight + "px";
        maskObj.style.zIndex = "10000";
     $("body").attr("scroll", "auto");
        document.body.appendChild(maskObj);
        $("#BigDiv").data("divbox_selectlist", $("select:visible"));
        $("select:visible").hide();
        $("#BigDiv").attr("divbox_scrolltop", $.ScrollPosition().Top);
        $("#BigDiv").attr("divbox_scrollleft", $.ScrollPosition().Left);
        $("#BigDiv").attr("htmloverflow", $("html").css("overflow"));
        //$("html").css("overflow", "hidden");
        window.scrollTo($("#BigDiv").attr("divbox_scrollleft"), $("#BigDiv").attr("divbox_scrolltop"));
        var MyDiv_w = this.width();
        var MyDiv_h = this.height();
        MyDiv_w = parseInt(MyDiv_w);
        MyDiv_h = parseInt(MyDiv_h);
        var width = $.PageSize().Width;
        var height = $.PageSize().Height;
        var left = $.ScrollPosition().Left;
        var top = $.ScrollPosition().Top;
        var Div_topposition = top + (height / 2) - (MyDiv_h / 2);
        var Div_leftposition = left + (width / 2) - (MyDiv_w / 2);
        this.css("position", "absolute");
        this.css("z-index", "10001");
        this.css("background", "#fff");
        this.css("left", Div_leftposition + "px");
        this.css("top", Div_topposition + "px");
        if ($.browser.mozilla)
        {
            this.show();
            return;
        }
        this.fadeIn("fast");

    }
    , CloseDiv: function()
    {

        if ($.browser.mozilla)
        {
            this.hide();

        } else
        {
            this.fadeOut("fast");

        } //$("html").css("overflow", $("#BigDiv").attr("htmloverflow"));
         window.scrollTo($("#BigDiv").attr("divbox_scrollleft"), $("#BigDiv").attr("divbox_scrolltop"));
        //$("html").css("overflow-x", "hidden");
        $("#BigDiv").data("divbox_selectlist").show();
        $("#BigDiv").remove();

    }

   






});
$.extend(
{
    PageSize:function ()
    {
        var width=0;
        var height=0;
        width=window.innerWidth!=null?window.innerWidth:document.documentElement&&document.documentElement.clientWidth?document.documentElement.clientWidth:document.body!=null?document.body.clientWidth:null;
        height=window.innerHeight!=null?window.innerHeight:document.documentElement&&document.documentElement.clientHeight?document.documentElement.clientHeight:document.body!=null?document.body.clientHeight:null;
        return {Width:width,Height:height};
    }
    ,ScrollPosition:function ()
    {
        var top=0,left=0;
        if($.browser.mozilla)
        {
            top=window.pageYOffset;
            left=window.pageXOffset;
            
        }
        else if($.browser.msie)
        {
            top=document.documentElement.scrollTop;
            left=document.documentElement.scrollLeft;

        }
        else if(document.body)
        {
            top=document.body.scrollTop;
            left=document.body.scrollLeft;
        }
        return {Top:top,Left:left};
        
    }
});
/*任意位置浮动固定层
*/
jQuery.fn.floatdiv=function(location){
        //判断浏览器版本
    var isIE6=false;
    var Sys = {};
    var ua = navigator.userAgent.toLowerCase();
    var s;
    (s = ua.match(/msie ([\d.]+)/)) ? Sys.ie = s[1] : 0;
    if(Sys.ie && Sys.ie=="6.0"){
        isIE6=true;
    }
    var windowWidth,windowHeight;//窗口的高和宽
    //取得窗口的高和宽
    if (self.innerHeight) {
        windowWidth=self.innerWidth;
        windowHeight=self.innerHeight;
    }else if (document.documentElement&&document.documentElement.clientHeight) {
        windowWidth=document.documentElement.clientWidth;
        windowHeight=document.documentElement.clientHeight;
    } else if (document.body) {
        windowWidth=document.body.clientWidth;
        windowHeight=document.body.clientHeight;
    }
    return this.each(function(){
        var loc;//层的绝对定位位置
        if(location==undefined || location.constructor == String){
            switch(location){
                case("rightbottom")://右下角
                    loc={right:"0px",bottom:"0px"};
                    break;
                case("leftbottom")://左下角
                    loc={left:"0px",bottom:"0px"};
                    break;    
                case("lefttop")://左上角
                    loc={left:"0px",top:"0px"};
                    break;
                case("righttop")://右上角
                    loc={right:"0px",top:"0px"};
                    break;
                case("middletop")://居中置顶
                    loc={left:windowWidth/2-$(this).width()/2+"px",top:"0px"};
                    break;
                case("middlebottom")://居中置低
                    loc={left:windowWidth/2-$(this).width()/2+"px",bottom:"0px"};
                    break;
                case("leftmiddle")://左边居中
                    loc={left:"0px",top:windowHeight/2-$(this).height()/2+"px"};
                    break;
                case("rightmiddle")://右边居中
                    loc={right:"0px",top:windowHeight/2-$(this).height()/2+"px"};
                    break;
                case("middle")://居中
                    var l=0;//居左
                    var t=0;//居上
                    l=windowWidth/2-$(this).width()/2;
                    t=windowHeight/2-$(this).height()/2;
                    loc={left:l+"px",top:t+"px"};
                    break;
                default://默认为右下角
                    location="rightbottom";
                    loc={right:"0px",bottom:"0px"};
                    break;
            }
        }else{
            loc=location;
        }
        var wrap=$("<div></div>");
        if(isIE6){wrap=$("<div style=\"top:expression(documentElement.scrollTop+documentElement.clientHeight-this.offsetHeight);\"></div>");}
        $("body").append(wrap);
        wrap.css(loc).css({position:"fixed",
            z_index:"1"});
        if (isIE6)
        {
            wrap.css("position","absolute");
            $("body").css("background-attachment","fixed").css("background-image","url(n1othing.txt)");
        }
        $(this).appendTo(wrap);
    });
};
function ifconfirm(str)
{
    if(!confirm(str))
        {return false;}
}
