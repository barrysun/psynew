// JavaScript Document

$(function () {
   
    var count;
    $(".specialty").click(function () {
        $(this).next(".tagsCont").show();
    });
    $(".tagSure").click(function () {
        $(this).parents(".tagsCont").hide();
    });

    $(".tagsDet li label").click(function () {
        count = $(".tagsDet li input:checked").length;
        if (count > 5) {
            alert("你喊");
            //alert("选项不能超出5个！");
            return false;
        }
    });

    $(".tagSure").click(function () {
        var txt = "";
        $(".tagsDet li label").each(function () {
            var chTag = $(this).children().get(0);
            if (chTag.checked) {
                txt = txt + $(this).text() + ",";
            };
        });
        $(".specialty").val(txt);
    });
});