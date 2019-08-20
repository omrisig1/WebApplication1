
function loadNow(href,id) {
    btn = $('#' + id);
    //prior-to-load
    btn.prop("onclick", "");
    btn.html('Loading...');
    btn.prop("disabled", true);

    loadData(href,
        function onSuccess() {
            btn.html('All Loaded!');
        },
        function onFailure() {
            btn.prop("disabled", false);
            btn.html('Try Again');
        }
    );
}
function loadData(herf, onSucc, onFail) {
    $.ajax({
        type: "GET",
        url: herf,
        success: function (result) {
            defaultLogger.log(result, 'loadButtons.js');
            mainGraph(result);
            if (onSucc) onSucc();
        },
        error: function (response) {
            alert("Error: loading data failed.\n" + response + "\nTry again...");
            if (onFail) onFail();
        }
    })
}
