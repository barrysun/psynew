function btnClick2(typeid, typename) {
    $(".button_r").each(function () { document.getElementById(this.id).className = "button_b"; });
    $(".button_r_b").each(function () { document.getElementById(this.id).className = "button_b_b"; });
    if (typename.length <= 4) { document.getElementById("btn" + typeid + "").className = "button_r"; document.getElementById("btnbottom" + typeid + "").className = "button_r" }
    else { document.getElementById("btn" + typeid + "").className = "button_r_b"; document.getElementById("btnbottom" + typeid + "").className = "button_r_b" }

    $(".QType").each(function () { document.getElementById(this.id).style.display = "none" });
    $("#QType" + typeid + "").css('display', 'block');
    document.getElementById("submitExam").className = "button_r_b"
}
function btnClick(typeid, typename) {
    $(".button_r").each(function () { document.getElementById(this.id).className = "button_b"; });
    $(".button_r_b").each(function () { document.getElementById(this.id).className = "button_b_b"; });
    if (typename.length <= 4) { document.getElementById("btn" + typeid + "").className = "button_r"; document.getElementById("btnbottom" + typeid + "").className = "button_r" }
    else { document.getElementById("btn" + typeid + "").className = "button_r_b"; document.getElementById("btnbottom" + typeid + "").className = "button_r_b" }

    //    $(".QType").each(function(){document.getElementById(this.id).style.display="none"});
    //    $("#QType"+typeid+"").css('display','block');
    document.getElementById("submitExam").className = "button_r_b"
    document.getElementById("typeaction" + typeid + "").click();
 
}



//第一个为试题id号,  qanswer为正确答案  uanswer用户选择的  单选和判断 多选
function updateXml(qid, qanswer, uanswer, fenshu) {
   // $("#waiting").OpenDiv();
    
    $.post(
            "../ashx/Ajax.ashx",
            { Action: "post", ChenJiID: $("#hidKaoShiChengJiID").val(), qid: qid, qanswer: qanswer, uanswer: uanswer, fenshu: fenshu, func: "updateXml" },
            function (data, textStatus) {
              examState(data); 
             // $("#waiting").CloseDiv(); return false;
            },
            "html"
        );
}


//qnum id号
function updateXmlMchose(qnum, qid, qanswer, fenshu) //多选
{

    var uanswer = "";
    $("input[name=answer" + qnum + "]:checked").each(function () { uanswer += this.value; });
    //uanswer = uanswer.substr(0, uanswer.length - 1);

    //定制最终得分=理解率X（0.6Xn）+准确率X(0.4Xn) （n为每道试题的分数）
    //    var allanswer="";
    //    $("input[name=answer"+qnum+"]").each(function(){allanswer+=this.value+",";});
    //    allanswer=allanswer.substr(0,allanswer.length-1);
    //    updateXml(qid,qanswer,uanswer,allanswer,point)

    updateXml(qid, qanswer, uanswer, fenshu)
}

function updateXmlFill(qnum, qid, qanswer, fenshu) //填空题
{
    //$("#waiting").OpenDiv();
     var uanswer = "";
    $("input[name=answer" + qnum + "]").each(function () { uanswer += this.value + "^"; });
    uanswer = uanswer.substr(0, uanswer.length - 1);
    
    $.post(
            "../ashx/Ajax.ashx",
            { Action: "post", ChenJiID: $("#hidKaoShiChengJiID").val(),  qid: qid, qanswer: qanswer, uanswer: uanswer, fenshu: fenshu, func: "updateXmlFill" },
            function (data, textStatus) {
               examState(data);
                

               // $("#waiting").CloseDiv(); return false;
            },
            "html"
        );
}
function updateXmlAnswer(textid, qid, qanswer, fenshu) //简答
{
    //$("#waiting").OpenDiv();
    var uanswer = $("#" + textid + "").val();
    
    $.post(
            "../ashx/Ajax.ashx",
            { Action: "post", ChenJiID: $("#hidKaoShiChengJiID").val(), qid: qid, qanswer: qanswer, uanswer: uanswer, fenshu: fenshu, func: "updateXmlAnswer" },
            function (data, textStatus) {
              examState(data);
              
               // $("#waiting").CloseDiv(); return false;
            },
            "html"
        );
}

function checkExam_single() {
    $.post(
            "ajax.aspx",
            { Action: "post", planid: $("#planid").val(), examkey: $("#examkey").val(), func: "checkExam_single" },
            function (data, textStatus) {
                var str = "";
                if (data == "")
                    str += "试题已全部作答！可以放心交卷！";
                else
                    str += "试题未全部作答<BR>" + data + "";
                Message250.innerHTML = str;
                MessageTitle250.innerHTML = "试卷检测提示？"
                if ($("#Message250").text() != "") { $('#MessageBox250').OpenDiv(); return false; }
            },
            "html"
        );
}
function checkExamAdmin() {
    $.post(
            "ajax.aspx",
            { Action: "post", planid: $("#planid").val(), examkey: $("#examkey").val(), func: "checkExamAdmin" },
            function (data, textStatus) {
                var str = "";
                if (data == "")
                    str += "试题已全部正确！";
                else
                    str += "试题检测结果：<BR>" + data + "";
                Message250.innerHTML = str;
                MessageTitle250.innerHTML = "试卷检测提示？"
                if ($("#Message250").text() != "") { $('#MessageBox250').OpenDiv(); return false; }
            },
            "html"
        );
}

function checkExamView() {
    $.post(
            "ajax.aspx",
            { Action: "post", planid: $("#planid").val(), examkey: $("#examkey").val(), func: "checkExam" },
            function (data, textStatus) {
                var str = "";
                if (data == "")
                    str += "试题已全部作答！";
                else
                    str += "试题未全部作答<BR>" + data + "";
                Message250.innerHTML = str;
                MessageTitle250.innerHTML = "试卷检测提示？"
                if ($("#Message250").text() != "") { $('#MessageBox250').OpenDiv(); return false; }
            },
            "html"
        );
        }

//强制交
        function submitExam() {
           
    $.post(
            "../ashx/submitExam.ashx",
            { Action: "post", ChenJiID: $("#hidKaoShiChengJiID").val(), PaperID: $("#HidPaperID").val(), Papertype: "FixedExam" },
            function (data, textStatus) {
                if (data == "true") {
                    window.opener = null;
                    window.open("", "_self");
                    window.close();
                }
                else examState(data);
            },
            "html"
        );
        }

        //现在只用这个
        function submitExam_Fixed() {
           

            $.post(
               "../ashx/submitExam.ashx",
                { Action: "post", ChenJiID: $("#hidKaoShiChengJiID").val(), PaperID: $("#HidPaperID").val(), Papertype: "FixedExam" },
                function (data, textStatus) {
                     
                    if (data == "true") {
                        // $("#result").click()
                        window.name = "__self";
                        window.open("ShowResult.aspx?ChenJiID=" + $("#hidKaoShiChengJiID").val() + "&exmid=" + $("#HidExamID").val() + "&showcj=" + $("#HidIsShowChengJi").val() + "&showda=" + $("#IsShowBiaoZhuenDaAn").val() + "&PaperID=" + $("#HidPaperID").val() + "&papertype=Fixed", "__self")
                    }
                    else examState(data);
                },
                "html"
        );
            }




            //随机试题提交
            function submitExam_Random() {

                
                $.post(
               "../ashx/submitExam.ashx",
                { Action: "post", ChenJiID: $("#hidKaoShiChengJiID").val(), PaperID: $("#HidPaperID").val(), Papertype: "RandomExam" },
                function (data, textStatus) {

                    if (data == "true") {
                        // $("#result").click()
                        window.name = "__self";
                        window.open("ShowResult.aspx?ChenJiID=" + $("#hidKaoShiChengJiID").val() + "&exmid=" + $("#HidExamID").val() + "&showcj=" + $("#HidIsShowChengJi").val() + "&showda=" + $("#IsShowBiaoZhuenDaAn").val() + "&PaperID=" + $("#HidPaperID").val() + "&papertype=Random", "__self")
                    }
                    else examState(data);
                },
                "html"
        );
            }



function examState(state) {
    if (state == "强制退出") { alert('你已被管理员强制交卷！并请你离开考场！'); window.opener = null; window.open("", "_self"); window.close(); }
    if (state == "作废") { alert('你已被管理员请出该考场！你的考试结果作废！'); window.opener = null; window.open("", "_self"); window.close(); }
    if (state == "delete") { alert('该试卷已被管理员删除，不能进行操作！'); window.opener = null; window.open("", "_self"); window.close(); }
}



 


function countTime(id) {
    if ($("#Hidden" + id + "").val() == "0") {
        var count = Number($("#span" + id + "").text()) + 1;
        $("#span" + id + "").text(count);
        setTimeout("countTime('" + id + "')", 1000);
    }
    else
        return;
}
function setTimeState(id, qid, point) {
    if ($("#button" + id + "").val() == "停止计时") {
        $("#Hidden" + id + "").val("1");
        $("#button" + id + "").val("开始计时");
        document.getElementById("textarea" + id + "").disabled = true;
        countTime(id);
        updateTypingAnswer(id, qid, point);
    }
    else {
        $("#Hidden" + id + "").val("0");
        $("#button" + id + "").val("停止计时");
        document.getElementById("textarea" + id + "").disabled = false;
        countTime(id);
    }
}
function updateTypingAnswer(id, qid, point) {
    var answer = $("#spantitle" + id + "").text();
    var uanswer = $("#textarea" + id + "").val();

    var ok = 0, error = 0;
    if (answer.length <= uanswer.length) {
        for (i = 0; i < answer.length; i++) {
            if (answer.substring(i, i + 1) != uanswer.substring(i, i + 1))
                error++;
            else
                ok++;
        }
    }
    else {
        for (i = 0; i < uanswer.length; i++) {
            if (answer.substring(i, i + 1) != uanswer.substring(i, i + 1))
                error++;
            else
                ok++;
        }
        error = error + answer.length - uanswer.length;
    }
    var zql = ok / (ok + error) * 100;
    var speed = uanswer.length / $("#span" + id + "").text() * 60;
    var restltTime = "正确：" + ok + "      错误：" + error + "      正确率：" + zql.toFixed(2) + "%      用时：" + $("#span" + id + "").text() + "秒      打字速度：" + speed.toFixed(2) + "字/分";
    $("#spanresulttime" + id + "").text(restltTime)
    uanswer = restltTime + "<br/>" + uanswer;
    point = point * ok / (ok + error);
    $.post(
            "ajax.aspx",
            { Action: "post", planid: $("#planid").val(), qid: qid, uanswer: uanswer, point: point, examkey: $("#examkey").val(), func: "updateTypingAnswer" },
            function (data, textStatus) {
                if (data != "true") examState(data);
                else return false;
            },
            "html"
        );
}
function countChange(id, qid, point) {
    var answer = $("#spantitle" + id + "").text();
    answer = answer.replace("【", "").replace("】", "");
    $("#spantitle" + id + "").text(answer)
    var uanswer = $("#textarea" + id + "").val();
    $("#count" + id + "").text(answer.length - uanswer.length);
    var templeft = answer.substr(0, uanswer.length); //2l
    var tempthis = answer.substr(uanswer.length, 1); //1l
    var tempright = answer.substr(uanswer.length + 1, answer.length - uanswer.length - 1);
    $("#spantitle" + id + "").text(templeft + "【" + tempthis + "】" + tempright);
    updateTypingAnswer(id, qid, point);
}
function updateFile(id, qid, point) {
    var resultValue = window.showModalDialog("../UserControl/FileUpLoad.aspx", "", "dialogWidth=404px;dialogHeight=380px");
    if (resultValue != null) {
        $("#file" + id + "").val(resultValue);
        $.post(
            "ajax.aspx",
            { Action: "post", planid: $("#planid").val(), qid: qid, uanswer: resultValue, examkey: $("#examkey").val(), point: point, func: "updateFile" },
            function (data, textStatus) {
                if (data != "true") examState(data);
                else return false;
            },
            "html"
        );
    }
}

function spliteString(str) {
    var str_arr = new Array();
    for (i = 0; i < str.length; i++) {
        str_arr[i] = str.substring(i, i + 1);
    }
    return str_arr;
}
function anserMark(id) {
    if ($("#anserMark" + id + "").val() == "标记试题") {
        $("#AnswerDiv" + id + "").attr('class', 'AnswerMark');
        $("#anserMark" + id + "").val("取消标记");
        $("#anserMark" + id + "").attr('class', 'button_b');
    }
    else {
        $("#AnswerDiv" + id + "").attr('class', 'Answer');
        $("#anserMark" + id + "").val("标记试题");
        $("#anserMark" + id + "").attr('class', 'button_b');
    }
}
function BodyMark(id) {
    if ($("#BodyMark" + id + "").val() == "标记试题") {
        $("#BodyDiv" + id + "").attr('class', 'BodyMark');
        $("#BodyMark" + id + "").val("取消标记");
        $("#BodyMark" + id + "").attr('class', 'button_b');
    }
    else {
        $("#BodyDiv" + id + "").attr('class', 'Body');
        $("#BodyMark" + id + "").val("标记试题");
        $("#BodyMark" + id + "").attr('class', 'button_b');
    }
}



function updateAdminPoint(id, ChenJiID) {
    var fenshu = $("#Text" + id + "4").val();
    if (isNaN(fenshu) == true) {
        alert("只能输入数字!");
        return false;
    }
    var guid = GetGuid();
    $.post(
             "../ashx/YueJuan.ashx",
            { Action: "post", ChenJiID: ChenJiID, id: id, FenShu: fenshu, func: "updateCjFenShu" },
            function (data, textStatus) {
                $("#div_" + id).html(data);
            },
            "html"
        );
}


//阅卷
function updateAdminAnswer(id, uanswer, FenShu, ChenJiID) {

    $("#Text" + id + "4").val(FenShu);
    var guid = GetGuid();
    $.post(
            "../ashx/YueJuan.ashx",
            { Action: "post", ChenJiID: ChenJiID, id: id, uanswer: uanswer, FenShu: FenShu, func: "updateCjDetail" },
            function (data, textStatus) {

                $("#div_" + id).html(data);

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