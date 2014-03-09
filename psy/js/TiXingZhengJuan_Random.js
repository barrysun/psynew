$(document).ready(function () {
    $("#viewHelp").click(function () { gethelp(); $("#MessageBox").OpenDiv(); });
    $("#closeMessage").click(function () { $("#MessageBox").CloseDiv(); });
    $("#viewHelpBottom").click(function () { gethelp(); $("#MessageBox").OpenDiv(); });
    //$("#ExamTool").floatdiv("middlebottom");

    $("#ExamTool").css("position", "absolute");
    $("#ExamTool").css("top", document.documentElement.scrollTop + document.documentElement.clientHeight - 40 + "px");

    $("#checkExam").click(function () { checkExam(); });
    $("#closeMessage250").click(function () { $("#MessageBox250").CloseDiv(); });
    $("#submitExam").click(function () { confirmExam(); return false; });
    //$("#result").click(function(){if(!confirm("是否确定现在提交试卷？")){return false;setInterval("CountDown()",1000);}});

    $("#temp").click(function () { confirmExam(); return false; });
    $("#okconfirm").click(function () { $("#confirm").CloseDiv(); submitExam_Random(); });
    $("#cancelconfirm").click(function () { $("#confirm").CloseDiv(); });
    $("#closeconfirm").click(function () { $("#confirm").CloseDiv(); });
    $("#closewindows").click(function () { window.opener = null; window.open("", "_self");window.close();});

    $("#selectFontSize").click(function () { $("#FontBox").OpenDiv(); });
    $("#closeFontBox").click(function () { $("#FontBox").CloseDiv(); });
    $("#9pt").click(function () { setQuestionFont("9pt") });
    $("#12pt").click(function () { setQuestionFont("12pt") });
    $("#14pt").click(function () { setQuestionFont("14pt") });
    $("#16pt").click(function () { setQuestionFont("16pt") });
    $("#18pt").click(function () { setQuestionFont("18pt") });
    $("#20pt").click(function () { setQuestionFont("20pt") });
    $("#22pt").click(function () { setQuestionFont("22pt") });
    document.onkeyup = function () { if (event.keyCode == 8) { window.event.returnValue = false; } }
});
function gethelp() {
    var help = "";
    help += "<b>以下操作，均为考试过程中相关的操作！</b><br/><br/>";
    help += "每一个题型红色按钮为选中该题型！<br/><br/>";
    help += "单选题/多选题/判断题：将正确答案对应的选项选中！<br/><br/>";
    help += "填空题/简答题：将文字输入到对应的文本框内、线条上！<br/><br/>";
    help += "检测答案：检测该试卷是否填答完全！<br/><br/>";
    help += "提交试卷：做完试卷，提交试卷，离开考场！<br/><br/>";
    Message.innerHTML = help;
    MessageTitle.innerHTML = "考试帮助及注意事项"
}
function confirmExam() {
    confirmcontent.innerHTML = "";
    confirmtitle.innerHTML = "考试提交提示信息？";
     
    $.post(
            "../ashx/checkExam.ashx",
            { Action: "post", ChenJiID: $("#hidKaoShiChengJiID").val(), PaperID: $("#HidPaperID").val(), Papertype: "RandomExam", ExamPattern: "1", type: "confirm" },
            function (data, textStatus) {
                 
                if (data == "")
                    confirmcontent.innerHTML += "试题已全部作答！可以放心交卷！";
                else
                    confirmcontent.innerHTML += "试题未全部作答<BR>";

                confirmcontent.innerHTML += "<font class='toolshow'>"+data+"</font>";

            },
            "html"
        );


    confirmcontent.innerHTML += "<b>你是否确定要结束本次考试？</b><br /><span style='color:red;'>请尽快决定，考试时间还在继续！<br />";
    $("#confirm").OpenDiv();
}
function btnClick(typeid, typename) {
    $(".button_r").each(function () { document.getElementById(this.id).className = "button_b"; });
    $(".button_r_b").each(function () { document.getElementById(this.id).className = "button_b_b"; });
    if (typename.length <= 4) { document.getElementById("btn" + typeid + "").className = "button_r"; document.getElementById("btnbottom" + typeid + "").className = "button_r" }
    else { document.getElementById("btn" + typeid + "").className = "button_r_b"; document.getElementById("btnbottom" + typeid + "").className = "button_r_b" }

    $(".QType").each(function () { document.getElementById(this.id).style.display = "none" });
    $("#QType" + typeid + "").css('display', 'block');
    document.getElementById("submitExam").className = "button_r_b"
    
    $("html,body").animate({ scrollTop: 100 }, 1000);
}

function nextBtnClick(qid, typeid) {
    $("#QType" + typeid + ">.QuestionDiv").each(function () { document.getElementById(this.id).style.display = "none" });
    $("#QuestionDiv" + qid + "").css('display', 'block');
    document.getElementById("submitExam").className = "button_r_b"
}
function showAnswer(qnum) {
    $(".ShowAnswerDiv").each(function () { document.getElementById(this.id).style.display = "none" });
    if ($("#showAnswer" + qnum + "").val() == "隐藏答案") {
        $("#ShowAnswerDiv" + qnum + "").css('display', 'none');
        $("#showAnswer" + qnum + "").val("显示答案");
    }
    else {
        $("#ShowAnswerDiv" + qnum + "").css('display', 'block');
        $("#showAnswer" + qnum + "").val("隐藏答案");
    }

}
function showMark(qnum) {
    $(".ShowMarkDiv").each(function () { document.getElementById(this.id).style.display = "none" });
    if ($("#showMark" + qnum + "").val() == "隐藏解析") {
        $("#ShowMarkDiv" + qnum + "").css('display', 'none');
        $("#showMark" + qnum + "").val("显示解析");
    }
    else {
        $("#ShowMarkDiv" + qnum + "").css('display', 'block');
        $("#showMark" + qnum + "").val("隐藏解析");
    }

}
function setQuestionFont(size) {
    $(".Body").css('font-size', size);
    if (size == "9pt")
        $(".Body").css('line-height', "28px");
    if (size == "12pt")
        $(".Body").css('line-height', "30px");
    if (size == "14pt")
        $(".Body").css('line-height', "36px");
    if (size == "16pt")
        $(".Body").css('line-height', "42px");
    if (size == "18pt")
        $(".Body").css('line-height', "48px");
    if (size == "20pt")
        $(".Body").css('line-height', "54px");
    if (size == "22pt")
        $(".Body").css('line-height', "60px");
    $("#FontBox").CloseDiv();
}




function checkExam() //检查试卷
{
  
    $.post(
            "../ashx/checkExam.ashx",
            { Action: "post", ChenJiID: $("#hidKaoShiChengJiID").val(), PaperID: $("#HidPaperID").val(), Papertype: "RandomExam", ExamPattern: "1", type: "check" },
            function (data, textStatus) {
                var str = "";
                if (data == "")
                    str += "试题已全部作答！可以放心交卷！";
                else
                    str += "试题未全部作答<BR>";


                str += data;
                Message250.innerHTML = "<font class='toolshow'>" + str + "</font>";
                MessageTitle250.innerHTML = "试卷检测提示？"
                if ($("#Message250").text() != "") { $('#MessageBox250').OpenDiv(); return false; }
            },
            "html"
        );
}


function GetGuid() {
    var now = new Date();
    var year = now.getFullYear(); //getFullYear getYear
    var month = now.getMonth();
    var date = now.getDate();
    var day = now.getDay();
    var hour = now.getHours();
    var minu = now.getMinutes();
    var sec = now.getSeconds();
    var mill = now.getMilliseconds();
    month = month + 1;
    if (month < 10) month = "0" + month;
    if (date < 10) date = "0" + date;
    if (hour < 10) hour = "0" + hour;
    if (minu < 10) minu = "0" + minu;
    if (sec < 10) sec = "0" + sec;

    var guid = month + date + hour + minu + sec + mill;

    return guid;
}