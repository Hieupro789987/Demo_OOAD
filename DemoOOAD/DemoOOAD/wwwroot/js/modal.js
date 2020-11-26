$(document).ready(function () {
    openmodal();
});

function openmodal() {
    $(".detail-view").click(function () {
        var img = $(".ma1").find("img").attr("src");
        var name = $(".ma1").find("h3").html();
        var price = $(".ma1 .price").html();
        var des = $(".ma1 .des").html();
        var modal = $(".modal-body");
        modal.find("img").attr("src", img);
        modal.find("h3").html(name);
        modal.find("h4").html(price);
        modal.find("p").html(des);
    })
}
