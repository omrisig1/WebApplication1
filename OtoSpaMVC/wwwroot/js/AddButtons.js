function showAllCategories(currentFilter,currentCategory,sortby) {
    var herf = "/Products/Index?";
    if (currentFilter) {
        herf = herf.concat("searchString="+currentFilter + "&");
    }
    if (sortby) {
        herf = herf.concat("sortOrder=" + sortby + "&");
    }
    herf = herf.concat("searchCategory=");

    $(document).ready(function () {
        $.ajax({
            type: "GET",
            url: "/Products/_ShowAllCategories",
            success: function (result) {
                defaultLogger.log(result, 'AddButtons.js');
                div = document.getElementById("txtHint");
                tmp = "";
                for (var i = 0; i < result.length; i++) {
                    var disabled = (result[i] == currentCategory) ? " disabled" : "";
                    defaultLogger.log(result[i], 'AddButtons.js');
                    defaultLogger.log(disabled, 'AddButtons.js');
                    var tmp = $("<a></a>", {
                        text: result[i],
                        "id": result[i],
                        "class": "dropdown-item " + disabled,
                        "role": "button",
                        "href": herf + result[i],
                    }
                    ).appendTo(div);
                    defaultLogger.log(tmp, 'AddButtons.js');
                }
            },
            error: function (response) {
                //debugger;
                alert('eror');
            }
        });
    });

}
