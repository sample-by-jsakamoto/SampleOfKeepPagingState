$(function () {

    var key = "foo.bar";

    var pageIndex = sessionStorage.getItem(key) || "1";

    $("#peopleList").load("Person/ListHtml", { "pageIndex": pageIndex });

    $(document).on("click", "#pageIndexLinks a", function () {
        var pageIndex = $(this).text();
        $("#peopleList").load("Person/ListHtml", { "pageIndex": pageIndex });
        sessionStorage.setItem(key, pageIndex);
        return false;
    });
});