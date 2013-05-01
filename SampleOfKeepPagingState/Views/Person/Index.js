$(function () {

    var sessionStateKey = "foo.bar";

    var listState = $.extend(
        { pageIndex: 1 },
        JSON.parse(sessionStorage.getItem(sessionStateKey) || "{}"));

    $("#peopleList").load("Person/ListHtml", { pageIndex: listState.pageIndex });

    $(document).on("click", "#pageIndexLinks a", function () {
        var listState = { pageIndex: $(this).text() };
        $("#peopleList").load("Person/ListHtml", listState);
        sessionStorage.setItem(sessionStateKey, JSON.stringify(listState));
        return false;
    });
});