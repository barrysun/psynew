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
        $(".twoMenu").children("div").each(function () {
            $(this).addClass("hide");
            $(this).children("a").removeClass("on");
            if ($(this).hasClass(tag)) {
                $(this).removeClass("hide");
                $(this).children("a").eq(0).addClass("on");
            }
        });
        if ($(".twoMenu a").hasClass("on")) {
            var tag1 = $(".twoMenu .on").attr("id");
            $(".threeMenu").children("div").each(function () {
                $(this).addClass("hide");
                if ($(this).hasClass(tag1)) {
                    $(this).removeClass("hide");
                }
            });
        }
        return false;
    });
    $(".twoMenu a").eq(0).addClass("on");
    $(".twoMenu a").click(function () {
        $(".twoMenu a").each(function () {
            $(this).removeClass("on");
        });
        $(this).addClass("on");
        var tag = $(this).attr("id");
        $(".threeMenu").children("div").each(function () {
            $(this).addClass("hide");
            if ($(this).hasClass(tag)) {
                $(this).removeClass("hide");
            }
        });
        return false;
    });
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