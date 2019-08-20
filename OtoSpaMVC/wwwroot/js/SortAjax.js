var CurrentFilter;
var searchCategory;
var TextSortOrder;
function onevent(herf) {
    $.ajax({
        type: "GET",
        url: herf,
        success: function (result) {
            var container = $("#idMultiProductTable");
            container.replaceWith("<div id='idMultiProductTable'>" + result + "</div>");
        },
        error: function (response) {
        }
    });

}

function clicksortbutton(text) {
    TextSortOrder = text;
    setAttribute();
}

function getAdditionHref(ss, sc, tso) {
    herfaddition = "";
    herfaddition = herfaddition.concat("searchString=" + ss + "&");
    herfaddition = herfaddition.concat("searchCategory=" + sc + "&");
    herfaddition = herfaddition.concat("sortOrder=" + tso);
    return herfaddition;
}

function setAttribute() {
    var herf = "/Products/Index?";
    var herf2 = "/Products/Index?";
    var herfaddition = getAdditionHref(CurrentFilter, searchCategory, TextSortOrder);
    herf = herf.concat(herfaddition);
    herf2 = herf2.concat(herfaddition);
    document.getElementById("sortorder").innerHTML = TextSortOrder;
    var btn_sort_up = document.getElementById("btn_sort_up");
    var btn_sort_down = document.getElementById("btn_sort_down");
    btn_sort_up.onclick = function () {
        onevent(herf2);
    };
    btn_sort_down.onclick = function () {
        onevent(herf2 + "_desc");
    };
}

function startsortorder(cf, cc, tso) {
    CurrentFilter = cf;
    searchCategory = cc;
    TextSortOrder = tso;
    setAttribute();
}
